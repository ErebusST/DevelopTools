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
    public partial class CreateFieldForm : Form
    {
        public CreateFieldForm()
        {
            InitializeComponent();
        }

        DataTable tempDT;

        public DataTable TempDT
        {
            get { return tempDT; }
        }

        DataRow selectedRow;

        public DataRow SelectedRow
        {
            get { return selectedRow; }
        }

        String oldFieldName;

        public CreateFieldForm(DataTable tempDT, DataRow selectedRow)
        {
            InitializeComponent();
            this.tempDT = tempDT;
            this.selectedRow = selectedRow;
        }

        private void CreateFieldForm_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTypeDT = XMLUtil.getDataTypeDT();
                cboCodeDataType.DataSource = dataTypeDT;
                cboCodeDataType.DisplayMember = "CodeDataType";
                cboCodeDataType.ValueMember = "CodeDataType";



                this.Tag = dataTypeDT;

                if (dataTypeDT.Rows.Count > 0)
                {
                    cboCodeDataType.SelectedIndex = 0;
                }

                if (selectedRow != null)
                {
                    this.Text = "修改验证字段";
                    txtFieldName.Text = ConvertObjToString(selectedRow["Field"]);
                    raCheckNotEmpty.Checked = ConvertObjToString(selectedRow["CheckEmpty"]).ToLower().Equals("true");
                    raCheckNotNull.Checked = ConvertObjToString(selectedRow["CheckNull"]).ToLower().Equals("true");
                    raCheckRange.Checked = ConvertObjToString(selectedRow["CheckRange"]).ToLower().Equals("true");
                    if (raCheckRange.Checked)
                    {
                        txtRange.Text = ConvertObjToString(selectedRow["Range"]).Replace("^", "\r\n");
                        txtRange.Enabled = true;
                    }
                    oldFieldName = ConvertObjToString(selectedRow["Field"]);

                    DataRow[] rows = dataTypeDT.Select("CodeDataType = '" + selectedRow["CodeDataType"] + "'");
                    cboCodeDataType.SelectedValue = rows.Length == 0 ? "Object" : CreateProject.Util.Util.ConvertObjToString(rows[0]["CodeDataType"]);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void cboSqlDataType_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cboSqlDataType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                return;
                String selectedText = "";// CreateProject.Util.Util.ConvertObjToString(cboSqlDataType.SelectedValue);
                if (selectedText.Length == 0 || cboCodeDataType.DataSource == null)
                {
                    return;
                }

                DataTable dataTypeDT = cboCodeDataType.DataSource as DataTable;

                DataRow[] rows = dataTypeDT.Select("SqlDataType = '" + selectedText + "'");
                cboCodeDataType.SelectedValue = rows.Length == 0 ? "Object" : CreateProject.Util.Util.ConvertObjToString(rows[0]["CodeDataType"]);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                String fieldName = txtFieldName.Text.Trim();
                String codeDataType = CreateProject.Util.Util.ConvertObjToString(cboCodeDataType.SelectedValue);
                Boolean checkNotEmpty = raCheckNotEmpty.Checked;
                Boolean checkNotNull = raCheckNotNull.Checked;
                Boolean checkRange = raCheckRange.Checked;

                if (fieldName.Length == 0)
                {
                    MessageBox.Show("请填写字段名!");
                    txtFieldName.Focus();
                    return;
                }

                else if (codeDataType.Length == 0)
                {
                    MessageBox.Show("选择代码数据类型!");
                    cboCodeDataType.Focus();
                    return;
                }
                else
                {
                    DataRow[] rows = tempDT.Select("FieldTemp = '" + fieldName.ToLower() + "' AND FieldTemp <> '" + oldFieldName + "'");
                    if (rows.Length > 0)
                    {
                        MessageBox.Show("该字段[" + fieldName + "]已存在!");
                        return;
                    }
                    String rangeStr = txtRange.Text.Replace("\r\n", "^").Trim();
                    if (checkRange)
                    {
                        if (rangeStr.Length == 0)
                        {
                            MessageBox.Show("请输入验证范围!");
                            return;
                        }
                        String[] rangeStrArr = rangeStr.Split(new char[] { '^' }, StringSplitOptions.RemoveEmptyEntries);
                        List<String> rangeList = new List<string>();
                        rangeStr = "";
                        foreach (var item in rangeStrArr)
                        {
                            if (!rangeList.Contains(item.Trim()))
                            {
                                rangeList.Add(item.Trim());
                                rangeStr += item.Trim() + "^";
                            }
                        }
                    }

                    if (selectedRow != null)
                    {
                        selectedRow["Field"] = fieldName;
                        selectedRow["FieldTemp"] = fieldName.ToLower();
                        selectedRow["CodeDataType"] = codeDataType;
                        selectedRow["CheckEmpty"] = checkNotEmpty;
                        selectedRow["CheckNull"] = checkNotNull;
                        selectedRow["CheckRange"] = checkRange;
                        selectedRow["Range"] = rangeStr;

                    }
                    else
                    {
                        DataRow newRow = this.tempDT.NewRow();
                        newRow["NO"] = tempDT.Rows.Count + 1;
                        newRow["Field"] = fieldName;
                        newRow["FieldTemp"] = fieldName.ToLower();
                        newRow["CodeDataType"] = codeDataType;
                        newRow["CheckEmpty"] = checkNotEmpty;
                        newRow["CheckNull"] = checkNotNull;
                        newRow["CheckRange"] = checkRange;
                        newRow["Range"] = rangeStr;
                        this.tempDT.Rows.Add(newRow);
                    }

                    this.DialogResult = DialogResult.OK;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCannel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void raCheckRange_CheckedChanged(object sender, EventArgs e)
        {
            txtRange.Enabled = raCheckRange.Checked;
            if (!raCheckRange.Checked)
            {
                txtRange.Clear();
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
    }
}
