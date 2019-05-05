using CreateProject.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseApp
{
    public partial class BuildQuartzConfig : Form
    {
        public BuildQuartzConfig()
        {
            InitializeComponent();
        }

        private void BuildQuartzConfig_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.buildQuartzConfig = null;
        }

        private void BuildQuartzConfig_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable quartzTypeDT = new DataTable();
                quartzTypeDT.Columns.Add("key");
                quartzTypeDT.Columns.Add("value");
                DataRow newRow = quartzTypeDT.NewRow();
                newRow["key"] = "SimpleTrigger";
                newRow["value"] = "间隔时间";
                quartzTypeDT.Rows.Add(newRow);
                newRow = quartzTypeDT.NewRow();
                newRow["key"] = "CronTrigger";
                newRow["value"] = "Cron表达式";
                quartzTypeDT.Rows.Add(newRow);

                QuartzType.DataSource = quartzTypeDT;
                QuartzType.DisplayMember = "value";
                QuartzType.ValueMember = "key";



                String packageName = XMLUtil.getValue("JobPackageName");
                txtPackageName.Text = packageName.Trim();
                //dgvMain.Rows[0].Cells["QuartzType"].Value = "SimpleTrigger";


                DataTable tempDT = new DataTable();
                tempDT.Columns.Add("ID", typeof(Int32));
                tempDT.Columns.Add("JobClass");
                tempDT.Columns.Add("QuartzType");
                tempDT.Columns.Add("ExcuteParameter");
                tempDT.Columns.Add("Description");

                dgvMain.DataSource = tempDT;
                lbState.Text = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {

                String packageName = txtPackageName.Text.Trim();
                if (packageName.Length == 0)
                {
                    txtPackageName.Focus();
                    throw new Exception("包名不能为空!");
                }
                XMLUtil.setValue("JobPackageName", packageName);
                dgvMain.EndEdit();
                String springConfigTemplet = readTemplet("QuartzSpringConfigTemplet.temp");
                String simpleTriggerTemplet = readTemplet("QuartzBeanSimpleTriggerTemplet.temp");
                String cronTriggerTemplet = readTemplet("QuartzBeanCronTriggerTemplet.temp");

                DataGridViewRowCollection rows = dgvMain.Rows;
                List<String> triggerList = new List<String>();
                StringBuilder jobConfig = new StringBuilder();
                foreach (DataGridViewRow row in rows)
                {
                    if (row.Cells["JobClass"].Value == null || row.Cells["QuartzType"].Value == null || row.Cells["ExcuteParameter"].Value == null)
                    {
                        continue;
                    }
                    String jobClass = row.Cells["JobClass"].Value.ToString().Trim();
                    String quartzType = row.Cells["QuartzType"].Value.ToString().Trim();
                    String excuteParameter = row.Cells["ExcuteParameter"].Value.ToString().Trim();
                    String description = row.Cells["Description"].Value.ToString().Trim();
                    description = description.Length == 0 ? jobClass : description;
                    Int32 repeatInterval = 0;
                    bool isNumber = Int32.TryParse(excuteParameter, out repeatInterval);
                    if (!isNumber && quartzType.Equals("SimpleTrigger"))
                    {
                        throw new Exception("[" + jobClass + "] 的执行方式为间隔时间,他的执行参数应为数字!");
                    }
                    else if (isNumber && quartzType.Equals("CronTrigger"))
                    {
                        throw new Exception("[" + jobClass + "] 的执行方式为Cron表达式,他的执行参数应为字符串!");
                    }
                    String className = jobClass;
                    if (jobClass.ToLower().EndsWith("job"))
                    {
                        jobClass = jobClass.Substring(0, jobClass.ToLower().LastIndexOf("job"));
                        jobClass = jobClass.Substring(0, 1).ToLower() + jobClass.Substring(1);
                    }

                    String jobName = jobClass + "Job";
                    String classFullName = packageName.EndsWith(".") ? packageName + className : packageName + "." + className;
                    String jobDetailName = jobClass + "JobDetail";
                    String jobTriggerName = jobClass + "JobTrigger";

                    String triggerTemplet = cronTriggerTemplet;
                    if (quartzType.Equals("SimpleTrigger"))
                    {
                        triggerTemplet = simpleTriggerTemplet;
                        excuteParameter = (repeatInterval * 1000).ToString();
                    }
                    String triggerConfig = triggerTemplet.Replace("$[jobName]", jobName).Replace("$[classFullName]", classFullName).Replace("$[jobDetailName]", jobDetailName).Replace("$[jobTriggerName]", jobTriggerName).Replace("$[ExcuteParameter]", excuteParameter).Replace("$[Description]", description);
                    jobConfig.AppendLine(triggerConfig);
                    triggerList.Add(jobTriggerName);
                }
                StringBuilder refTriggerConfig = new StringBuilder();
                String blank = "				      ";
                foreach (String triggerName in triggerList)
                {
                    refTriggerConfig.Append(blank).AppendLine("<ref bean=\"" + triggerName + "\"/>");
                }
                String springConfig = springConfigTemplet.Replace("$[triggers]", refTriggerConfig.ToString()).Replace("$[beans]", jobConfig.ToString());
                txtConfig.Text = springConfig.Trim();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private String readTemplet(String fileName)
        {
            try
            {
                String path = Application.StartupPath + "/templet/" + fileName;
                if (!File.Exists(path))
                {
                    throw new Exception("模板文件不存在,[" + path + "]");
                }
                return File.ReadAllText(path);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tempDT = dgvMain.DataSource as DataTable;
                AddTriggerForm addTriggerForm = new AddTriggerForm(tempDT);
                DialogResult result = addTriggerForm.ShowDialog();

                if (result.Equals(DialogResult.OK))
                {
                    DataRow newRow = addTriggerForm.getInfo;
                    tempDT.Rows.Add(newRow);
                    dgvMain.DataSource = tempDT;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewSelectedRowCollection selectedDGRows = dgvMain.SelectedRows;
                if (selectedDGRows.Count == 0)
                {
                    dgvMain.Focus();
                    throw new Exception("请选择要编辑的行!");
                }
                DataTable tempDT = dgvMain.DataSource as DataTable;

                Int32 id = Int32.Parse( selectedDGRows[0].Cells["ID"].Value.ToString());
                DataRow[] selectedRows = tempDT.Select("ID = '" + id + "'");
                if (selectedRows.Length == 0)
                {
                    throw new Exception("系统错误");
                }
                AddTriggerForm addTriggerForm = new AddTriggerForm(tempDT, selectedRows[0]);
                DialogResult result = addTriggerForm.ShowDialog();

                if (result.Equals(DialogResult.OK))
                {
                    DataRow newRow = addTriggerForm.getInfo;
                   
                    dgvMain.DataSource = tempDT;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewSelectedRowCollection selectedDGRows = dgvMain.SelectedRows;
                if (selectedDGRows.Count == 0)
                {
                    dgvMain.Focus();
                    throw new Exception("请选择要删除的行!");
                }
                DataTable tempDT = dgvMain.DataSource as DataTable;

                Int32 id = Int32.Parse(selectedDGRows[0].Cells["ID"].Value.ToString());
                DataRow[] selectedRows = tempDT.Select("ID = '" + id + "'");
                if (selectedRows.Length == 0)
                {
                    throw new Exception("系统错误");
                }

                DialogResult result = MessageBox.Show("是否确定删除?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result.Equals(DialogResult.OK))
                {
                    tempDT.Rows.Remove(selectedRows[0]);
                    for (int i = 0; i < tempDT.Rows.Count; i++)
                    {
                        DataRow row = tempDT.Rows[i];
                        row["ID"] = i + 1;
                    }
                    dgvMain.DataSource = tempDT;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tempDT = dgvMain.DataSource as DataTable;
                tempDT.Clear();
                txtConfig.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtConfig.Text.Trim().Length != 0)
                {
                    Clipboard.SetDataObject(txtConfig.Text);
                    lbState.Text = "复制成功！";
                }
                else
                {
                    lbState.Text = "待处理文本为空！";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtConfig_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Control && e.KeyCode == Keys.A)
                {
                    txtConfig.SelectAll();
                }
                else if (e.Control && e.KeyCode == Keys.C)
                {
                    String selectedText = txtConfig.SelectedText.Trim();
                    if (selectedText.Length == 0)
                    {
                        selectedText = txtConfig.Text.Trim();
                    }
                    if (selectedText.Length != 0)
                    {
                        Clipboard.SetDataObject(selectedText);
                        lbState.Text = "复制成功！";
                    }
                    else
                    {
                        lbState.Text = "待处理文本为空！";
                    }
                }
                else if (e.Control && e.KeyCode == Keys.V)
                {
                    String pasteStr = Clipboard.GetText();
                    if (pasteStr.Trim().Length != 0)
                    {
                        txtConfig.Clear();
                        txtConfig.Text = pasteStr;
                        lbState.Text = "粘贴成功！";
                    }
                    else
                    {
                        lbState.Text = "粘贴板中数据为空！";
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
