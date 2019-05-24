using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CreateProject.Util;

namespace DataBaseApp
{
    public partial class AddTriggerForm : Form
    {
        public AddTriggerForm(DataTable tempDT)
        {
            InitializeComponent();
            this.tempDT = tempDT;
        }

        private DataTable tempDT = null;
        private DataRow row = null;

        public DataRow getInfo
        {
            get { return row; }
        }

        public AddTriggerForm(DataTable tempDT, DataRow row)
        {
            InitializeComponent();
            this.row = row;
            this.tempDT = tempDT;
        }

        private void btnCannel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void AddTriggerForm_Load(object sender, EventArgs e)
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

                cboTriggerType.DataSource = quartzTypeDT;
                cboTriggerType.DisplayMember = "value";
                cboTriggerType.ValueMember = "key";

                cboTriggerType.SelectedValue = "SimpleTrigger";

                if (row != null)
                {
                    String jobClass = CreateProject.Util.Util.ConvertObjToString(row["JobClass"]);
                    String quartzType = CreateProject.Util.Util.ConvertObjToString(row["QuartzType"]);
                    String excuteParameter = CreateProject.Util.Util.ConvertObjToString(row["ExcuteParameter"]);
                    String description = CreateProject.Util.Util.ConvertObjToString(row["Description"]);
                    txtJobClass.Text = jobClass;
                    cboTriggerType.SelectedValue = quartzType;
                    txtExcuteParameter.Text = excuteParameter;
                    txtDiscription.Text = description;
                    //if (quartzType.Equals("SimpleTrigger"))
                    //{
                    //    lbExcuteParameter.Text = "间隔时间";
                    //}
                    //else
                    //{
                    //    lbExcuteParameter.Text = "Cron表达式";
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboTriggerType_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cboTriggerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String quartzType = cboTriggerType.SelectedValue.ToString().Equals("System.Data.DataRowView") ? (cboTriggerType.SelectedValue as DataRowView)["key"].ToString() : cboTriggerType.SelectedValue.ToString();
                //ListItem li = cboTriggerType.SelectedItem as ListItem;

                if (quartzType.Equals("SimpleTrigger"))
                {
                    lbExcuteParameter.Text = "间隔时间";
                }
                else
                {
                    lbExcuteParameter.Text = "Cron表达式";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 id = row == null ? -1 : Int32.Parse(row["ID"].ToString());
                String jobClass = txtJobClass.Text.Trim();
                String quartzType = cboTriggerType.SelectedValue.ToString().Equals("System.Data.DataRowView") ? (cboTriggerType.SelectedValue as DataRowView)["key"].ToString() : cboTriggerType.SelectedValue.ToString();
                String excuteParameter = txtExcuteParameter.Text.Trim();
                String description = txtDiscription.Text.Trim();

                if (jobClass.Length == 0)
                {
                    txtJobClass.Focus();
                    throw new Exception("任务类名称不能为空!");
                }

                DataRow[] tempRows = tempDT.Select("JobClass = '" + jobClass + "' and ID <> " + id + "");

                if (tempRows.Length > 0)
                {
                    txtJobClass.Focus();
                    throw new Exception("任务类名称不能重复!");
                }

                if (excuteParameter.Length == 0)
                {
                    txtExcuteParameter.Focus();
                    throw new Exception(lbExcuteParameter.Text + "任务类名称不能为空!");
                }

                bool isNum = Int32.TryParse(excuteParameter, out id);

                if (!isNum && quartzType.Equals("SimpleTrigger"))
                {
                    cboTriggerType.Focus();
                    throw new Exception("触发器类型为[" + cboTriggerType.SelectedText + "]时,执行参数必须为数字!");
                }
                else if (isNum && quartzType.Equals("CronTrigger"))
                {
                    throw new Exception("触发器类型为[" + cboTriggerType.SelectedText + "]时,执行参数必须为字符串!");
                }

                if (row == null)
                {
                    row = tempDT.NewRow();
                    row["ID"] = tempDT.Rows.Count + 1;
                }
                row["JobClass"] = jobClass;
                row["QuartzType"] = quartzType;
                row["ExcuteParameter"] = excuteParameter;
                row["Description"] = description;
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
