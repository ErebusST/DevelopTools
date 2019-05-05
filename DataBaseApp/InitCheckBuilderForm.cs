using CreateProject.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseApp
{
    public partial class InitCheckBuilderForm : Form
    {
        public InitCheckBuilderForm()
        {
            InitializeComponent();
        }

        private void InitCheckBuilderForm_Load(object sender, EventArgs e)
        {
            try
            {
                String builderFrom = XMLUtil.getValue("BuilderFrom").Trim();
                String builderText = XMLUtil.getValue("BuilderText").Trim();
                txtInput.Text = builderText;
                raBuilderFromJavaBean.Checked = builderFrom.Length == 0 || builderFrom.ToLower().Equals("javabean");
                raBuilderFromSql.Checked = !raBuilderFromJavaBean.Checked;
                tempDT = new DataTable();
                tempDT.Columns.Add("NO", typeof(Int32));
                tempDT.Columns.Add("Field", typeof(String));
                tempDT.Columns.Add("FieldTemp", typeof(String));
                tempDT.Columns.Add("SqlDataType", typeof(String));
                tempDT.Columns.Add("CodeDataType", typeof(String));
                tempDT.Columns.Add("CheckEmpty", typeof(String));
                tempDT.Columns.Add("CheckNull", typeof(String));
                tempDT.Columns.Add("CheckRange", typeof(String));
                tempDT.Columns.Add("Range", typeof(String));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private DataTable tempDT;

        public DataTable TempDT
        {
            get { return tempDT; }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtInput.Text.Trim().Length == 0)
                {
                    MessageBox.Show("请输入待生成的字段信息");
                    this.DialogResult = DialogResult.None;
                    return;
                }
                DataTable dataTypeDT = XMLUtil.getDataTypeDT();
                this.Tag = dataTypeDT;
                String[] lines = txtInput.Lines.Where(str=>str.Trim().Length!=0).ToArray();
                bool isContinue = false;
                for (int i = 0; i < lines.Length; i++)
                {
                    String line = lines[i].Trim();

                    if (line.StartsWith("CREATE TABLE") || line.StartsWith("(")
                            || line.StartsWith(");") || line.StartsWith("CREATE INDEX") || line.Contains("FOREIGN KEY"))
                    {
                        continue;
                    }
                    else
                    {
                        line = line.Replace("private", "").Replace("static", "");
                        String[] colArr = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                        String str1 = colArr[0].Trim();
                        String str2 = colArr[1].Trim();

                        String field = "";
                        String sqlDataType = "";
                        String codeDataType = "Object";

                        DataRow row = Select(str2);
                        if (!isContinue && row != null && raBuilderFromJavaBean.Checked)//
                        {
                            DialogResult result = MessageBox.Show("输入的待生成字段信息似乎不是JavaBean,是否确定继续生成?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                            if (result.Equals(DialogResult.No))
                            {
                                this.DialogResult = DialogResult.None;
                                return;
                            }
                            else
                            {
                                isContinue = true;
                            }
                        }
                        else if (!isContinue && row == null && raBuilderFromSql.Checked)
                        {
                            DialogResult result = MessageBox.Show("输入的待生成字段信息似乎不是sql语句,是否确定继续生成?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                            if (result.Equals(DialogResult.No))
                            {
                                this.DialogResult = DialogResult.None;
                                return;
                            }
                            else
                            {
                                isContinue = true;
                            }
                        }

                        if (raBuilderFromJavaBean.Checked)
                        {
                            field = str2;
                            if (field.EndsWith(";"))
                            {
                                field = field.Substring(0, field.Length - 1);
                            }
                            codeDataType = str1;
                        }
                        else
                        {
                            field = str1;
                            sqlDataType = str2;
                            if (sqlDataType.EndsWith(",") || sqlDataType.EndsWith(";"))
                            {
                                sqlDataType = sqlDataType.Substring(0, sqlDataType.Length - 1);
                            }
                            row = Select(sqlDataType);
                            if (row != null)
                            {
                                codeDataType = CreateProject.Util.Util.ConvertObjToString(row["CodeDataType"]);
                            }
                        }

                        DataRow newRow = tempDT.NewRow();
                        newRow["NO"] = tempDT.Rows.Count + 1;
                        newRow["Field"] = field;
                        newRow["FieldTemp"] = field.ToLower();
                        newRow["SqlDataType"] = sqlDataType;
                        newRow["CodeDataType"] = codeDataType;
                        newRow["CheckEmpty"] = true;
                        newRow["CheckNull"] = false;
                        newRow["CheckRange"] = false;
                        tempDT.Rows.Add(newRow);
                    }
                }
                this.DialogResult = DialogResult.Yes;
                XMLUtil.setValue("BuilderFrom", raBuilderFromJavaBean.Checked ? "JavaBean" : "Sql");
                XMLUtil.setValue("BuilderText",txtInput.Text.Trim());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private DataRow Select(String filter)
        {
            try
            {
                DataTable dataTypeDT = this.Tag as DataTable;
                foreach (DataRow item in dataTypeDT.Rows)
                {
                    String sqlDataType = ConvertObjToString(item["SqlDataType"]);
                    if (filter.Trim().ToLower().StartsWith(sqlDataType.Trim().ToLower()))
                    {
                        return item;
                    }
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static String ConvertObjToString(Object obj)
        {
            if (obj == null)
            {
                return "";
            }
            else
            {
                return obj.ToString();
            }
        }

        private void txtInput_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Control && e.KeyCode == Keys.A)
                {
                    txtInput.SelectAll();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
        }
    }
}
