using CreateProject.Util;
using Newtonsoft.Json.Linq;
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
    public partial class BuilderCheckCodeForm : Form
    {
        public BuilderCheckCodeForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tempDT = new DataTable();
                InitCheckBuilderForm initCheckBuilderForm = new InitCheckBuilderForm();
                DialogResult result = initCheckBuilderForm.ShowDialog();
                if (result.Equals(DialogResult.Yes))
                {
                    tempDT = initCheckBuilderForm.TempDT;
                    dgMain.DataSource = tempDT;
                }
            }
            catch (Exception ex)
            {

                lbState.Text = ex.Message;
            }
        }





        private void BuilderCheckCodeForm_Load(object sender, EventArgs e)
        {
            try
            {
                dgMain.AutoGenerateColumns = false;
                lbState.Text = "";

                DataTable dataTypeDT = XMLUtil.getDataTypeDT();
                this.Tag = dataTypeDT;

                DataTable tempDT = new DataTable();
                tempDT.Columns.Add("NO", typeof(Int32));
                tempDT.Columns.Add("Field", typeof(String));
                tempDT.Columns.Add("FieldTemp", typeof(String));
                tempDT.Columns.Add("SqlDataType", typeof(String));
                tempDT.Columns.Add("CodeDataType", typeof(String));
                tempDT.Columns.Add("CheckEmpty", typeof(String));
                tempDT.Columns.Add("CheckNull", typeof(String));
                tempDT.Columns.Add("CheckRange", typeof(String));
                tempDT.Columns.Add("Range", typeof(String));
                dgMain.DataSource = tempDT;

                this.Focus();
                btnStart_Click(sender, e);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnAddField_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tempDT = dgMain.DataSource as DataTable;
                CreateFieldForm createFieldForm = new CreateFieldForm(tempDT, null);
                DialogResult result = createFieldForm.ShowDialog();
                if (result.Equals(DialogResult.OK))
                {
                    if (createFieldForm.SelectedRow != null)
                    {
                        DataRow[] selectedRows = tempDT.Select("Field = '" + createFieldForm.SelectedRow["Field"] + "'");
                        if (selectedRows.Length > 0)
                        {
                            selectedRows[0].ItemArray = createFieldForm.SelectedRow.ItemArray;
                        }

                    }
                    else
                    {
                        tempDT = createFieldForm.TempDT;
                    }

                    //dgMain.Rows.Clear();
                    dgMain.DataSource = tempDT;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddPageNumber_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tempDT = dgMain.DataSource as DataTable;
                DataRow newRow = tempDT.NewRow();
                newRow["NO"] = tempDT.Rows.Count + 1;
                newRow["Field"] = "pageNumber";
                newRow["FieldTemp"] = "pageNumber".ToLower();
                newRow["SqlDataType"] = "int";
                newRow["CodeDataType"] = "Integer";
                newRow["CheckEmpty"] = true;
                newRow["CheckNull"] = false;
                newRow["CheckRange"] = false;
                newRow["Range"] = "";
                tempDT.Rows.Add(newRow);
                dgMain.DataSource = tempDT;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddPageSize_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tempDT = dgMain.DataSource as DataTable;
                DataRow newRow = tempDT.NewRow();
                newRow["NO"] = tempDT.Rows.Count + 1;
                newRow["Field"] = "pageSize";
                newRow["FieldTemp"] = "pageSize".ToLower();
                newRow["SqlDataType"] = "int";
                newRow["CodeDataType"] = "Integer";
                newRow["CheckEmpty"] = true;
                newRow["CheckNull"] = false;
                newRow["CheckRange"] = false;
                newRow["Range"] = "";
                tempDT.Rows.Add(newRow);
                dgMain.DataSource = tempDT;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddSearchContent_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tempDT = dgMain.DataSource as DataTable;
                DataRow newRow = tempDT.NewRow();
                newRow["NO"] = tempDT.Rows.Count + 1;
                newRow["Field"] = "searchContent";
                newRow["FieldTemp"] = "searchContent".ToLower();
                newRow["SqlDataType"] = "varchar";
                newRow["CodeDataType"] = "String";
                newRow["CheckEmpty"] = false;
                newRow["CheckNull"] = true;
                newRow["CheckRange"] = false;
                newRow["Range"] = "";
                tempDT.Rows.Add(newRow);
                dgMain.DataSource = tempDT;
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
                String entity = txtEntityName.Text.Trim();
                if (entity.Length == 0)
                {
                    MessageBox.Show("请输入实体名称!");
                    return;
                }
                DataTable tempDT = dgMain.DataSource as DataTable;
                StringBuilder paraBuilder = new StringBuilder();
                StringBuilder checkBuilder = new StringBuilder();


                Dictionary<String, String> fieldList = new Dictionary<string, string>();

                for (int i = 0; i < tempDT.Rows.Count; i++)
                {
                    DataRow row = tempDT.Rows[i];
                    String fieldName = CreateProject.Util.Util.ConvertObjToString(row["Field"]).Trim();
                    //String sqlDataType = CreateProject.Util.Util.ConvertObjToString(row["SqlDataType"]).Trim();
                    String codeDataType = CreateProject.Util.Util.ConvertObjToString(row["CodeDataType"]).Trim();
                    Boolean checkNotEmpty = ConvertObjToString(row["CheckEmpty"]).ToLower().Equals("true");
                    Boolean checkNotNull = ConvertObjToString(row["CheckNull"]).ToLower().Equals("true");
                    Boolean checkRange = ConvertObjToString(row["CheckRange"]).ToLower().Equals("true");
                    String range = ConvertObjToString(row["Range"]);

                    String formatField = fieldName.Substring(0, 1).ToUpper() + fieldName.Substring(1);

                    if (!fieldList.Keys.Contains(formatField))
                    {
                        paraBuilder.Append(codeDataType).Append(" ")
                       .Append(fieldName).Append(" = ").Append(entity).Append(".get")
                       .Append(formatField).AppendLine("();");
                        fieldList.Add(formatField, codeDataType);
                    }


                    String start = "if ";

                    if (i != 0)
                    {
                        start = "else if ";
                    }

                    String checkMethod = "ObjectUtils.isEmpty(" + fieldName + ")";
                    String returnMethod = "	jsonObject = this.getNotEmptyJson(\"" + fieldName + "\");";
                    if (checkNotNull)
                    {
                        checkMethod = "" + fieldName + " == null";
                        returnMethod = "	jsonObject = this.getNotNullJson(\"" + fieldName + "\");";
                    }
                    else if (checkRange)
                    {
                        checkMethod = "checkedParaNotInRange(" + fieldName + ", ";
                        returnMethod = "	jsonObject = this.getValueErrorJson(\"" + fieldName + "\", ";//"all", "agent", "platform", "personal");";
                        String[] rangeArr = range.Split(new char[] { '^' }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (var item in rangeArr)
                        {
                            checkMethod += "\"" + item + "\", ";
                            returnMethod += "\"" + item + "\", ";
                        }
                        checkMethod = checkMethod.TrimEnd().Substring(0, checkMethod.Length - 2) + ")";
                        returnMethod = returnMethod.TrimEnd().Substring(0, returnMethod.Length - 2) + ");";
                    }

                    checkBuilder.Append(start).Append("(").Append(checkMethod).AppendLine(")");
                    checkBuilder.AppendLine("{");
                    checkBuilder.AppendLine(returnMethod);
                    checkBuilder.AppendLine("}");
                }

                paraBuilder.AppendLine();
                paraBuilder.AppendLine();
                paraBuilder.Append(checkBuilder.ToString());
                paraBuilder.AppendLine("else");
                paraBuilder.AppendLine("{");
                paraBuilder.AppendLine("	jsonObject = this.getSuccessJson(jsonObject);");
                paraBuilder.AppendLine("}");
                txtResult.Text = paraBuilder.ToString();

                JObject parameters = new JObject();
                //生成调用Json
                foreach (var fieldName in fieldList.Keys)
                {
                    var field = fieldName.Substring(0, 1).ToLower() + fieldName.Substring(1);
                    if (field.ToLower().Equals("pagesize"))
                    {
                        parameters.Add(field, 10);
                    }
                    else if (field.ToLower().Equals("pagenumber"))
                    {
                        parameters.Add(field, 1);
                    }
                    else if (field.ToLower().Equals("begintime"))
                    {
                        parameters.Add(field, DateTime.Now.AddDays(-2).ToString("yyyy-MM-dd HH:mm:ss"));
                    }
                    else if (field.ToLower().Equals("endtime"))
                    {
                        parameters.Add(field, DateTime.Now.AddDays(1).ToString("yyyy-MM-dd HH:mm:ss"));
                    }
                    else if (fieldList[fieldName].ToLower().Equals("date") || fieldList[fieldName].ToLower().Equals("timestamp"))
                    {
                        parameters.Add(field, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    }
                    else
                    {
                        parameters.Add(field, "");
                    }
                }

                txtJson.Text = parameters.ToString(Newtonsoft.Json.Formatting.Indented);

                lbState.Text = "生成成功";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgMain_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DataGridViewSelectedRowCollection rows = dgMain.SelectedRows;
                if (rows.Count > 0)
                {
                    DataTable tempDT = dgMain.DataSource as DataTable;
                    DataRow selectedRow = tempDT.NewRow();
                    DataGridViewRow dgRow = rows[0];
                    Object NO = dgRow.Cells["NO"].Value;

                    DataRow[] selectedRows = tempDT.Select("NO = " + NO + "");

                    if (selectedRows.Length > 0)
                    {
                        CreateFieldForm createFieldForm = new CreateFieldForm(tempDT, selectedRows[0]);
                        DialogResult result = createFieldForm.ShowDialog();
                        if (result.Equals(DialogResult.OK))
                        {
                            DataRow[] tempRows = tempDT.Select("Field = '" + createFieldForm.SelectedRow["Field"] + "'");
                            if (tempRows.Length > 0)
                            {
                                tempRows[0].ItemArray = createFieldForm.SelectedRow.ItemArray;
                            }
                            dgMain.DataSource = tempDT;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
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

        private void btnDeleteField_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewSelectedRowCollection rows = dgMain.SelectedRows;
                if (rows.Count > 0)
                {
                    DataTable tempDT = dgMain.DataSource as DataTable;
                    DataRow selectedRow = tempDT.NewRow();
                    DataGridViewRow dgRow = rows[0];
                    Object field = dgRow.Cells["Field"].Value;
                    DataTable tempDT1 = tempDT.Clone();
                    for (int i = 0; i < tempDT.Rows.Count; i++)
                    {
                        DataRow row = tempDT.Rows[i];
                        Object fieldTemp = row["Field"];
                        if (fieldTemp.Equals(field))
                        {
                            continue;
                        }
                        DataRow newRow = tempDT1.NewRow();
                        newRow.ItemArray = row.ItemArray;
                        newRow["NO"] = tempDT1.Rows.Count + 1;
                        tempDT1.Rows.Add(newRow);
                    }
                    dgMain.DataSource = tempDT1;
                }
                else
                {
                    lbState.Text = "请选择要删除的字段!";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                int colIndex = e.ColumnIndex;

                DataGridViewColumn column = dgMain.Columns[colIndex];
                if (column.Name.Equals("CheckRange"))
                {
                    String field = ConvertObjToString(dgMain.Rows[rowIndex].Cells[1].Value);
                    Boolean checkRange = !ConvertObjToString(dgMain.Rows[rowIndex].Cells[colIndex].Value).ToLower().Equals("true");
                    if (checkRange)
                    {
                        InputRangeForm inputRangeForm = new InputRangeForm(field);
                        DialogResult result = inputRangeForm.ShowDialog();
                        if (result.Equals(DialogResult.Yes))
                        {
                            DataTable tempDT = dgMain.DataSource as DataTable;
                            DataRow[] rows = tempDT.Select("Field = '" + field + "'");
                            if (rows.Length > 0)
                            {
                                rows[0]["CheckRange"] = checkRange;
                                rows[0]["CheckNull"] = false;
                                rows[0]["CheckEmpty"] = false;
                                rows[0]["Range"] = inputRangeForm.Range;
                                dgMain.DataSource = tempDT;
                            }
                        }
                    }
                }
                else if (column.Name.Equals("CheckNull") || column.Name.Equals("CheckEmpty"))
                {
                    String field = ConvertObjToString(dgMain.Rows[rowIndex].Cells[1].Value);
                    Boolean check = !ConvertObjToString(dgMain.Rows[rowIndex].Cells[column.Name].Value).ToLower().Equals("true");
                    DataTable tempDT = dgMain.DataSource as DataTable;
                    DataRow[] rows = tempDT.Select("Field = '" + field + "'");
                    if (rows.Length > 0)
                    {
                        String otherColName = column.Name.Equals("CheckNull") ? "CheckEmpty" : "CheckNull";
                        rows[0][column.Name] = check;
                        rows[0][otherColName] = !check;
                        rows[0]["CheckRange"] = false;
                        dgMain.DataSource = tempDT;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void BuilderCheckCodeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.builderCheckCodeForm = null;
        }

        private void txtResult_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Control && e.KeyCode == Keys.A)
                {
                    txtResult.SelectAll();
                }
                else if (e.Control && e.KeyCode == Keys.C)
                {
                    String selectedText = txtResult.SelectedText.Trim();
                    if (selectedText.Length == 0)
                    {
                        selectedText = txtResult.Text.Trim();
                    }
                    if (selectedText.Length != 0)
                    {
                        Clipboard.SetDataObject(selectedText);
                        lbState.Text = "复制验证代码成功！";
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
                        txtResult.Clear();
                        txtResult.Text = pasteStr;
                        lbState.Text = "粘贴验证代码成功！";
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

        private void btnCopy_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedTabIndex = tabControl1.SelectedIndex;
                String content = selectedTabIndex == 0 ? txtResult.Text.Trim() : txtJson.Text.Trim();
                String type = selectedTabIndex == 0 ? "验证代码" : "Json";

                if (txtResult.Text.Trim().Length != 0)
                {
                    Clipboard.SetDataObject(content);
                    lbState.Text = "复制" + type + "成功！";
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

        private void btnAddRangeCheck_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewSelectedRowCollection selectedRows = dgMain.SelectedRows;
                if (selectedRows.Count == 0)
                {
                    MessageBox.Show("请选择要添加范围验证的行!");
                }
                else
                {
                    String field = ConvertObjToString(selectedRows[0].Cells[1].Value);
                    Boolean checkRange = ConvertObjToString(selectedRows[0].Cells[6].Value).ToLower().Equals("true");
                    if (checkRange)
                    {
                        MessageBox.Show("当前选中行验证类型为[验证范围]，不能再添加，请选择其他行!");
                        return;
                    }

                    Int32 index = Int32.Parse(selectedRows[0].Cells[0].Value.ToString());
                    DataRow[] selectedDTRow = (dgMain.DataSource as DataTable).Select("NO = " + index);
                    if (selectedDTRow.Length == 0)
                    {
                        MessageBox.Show("");
                    }
                    InputRangeForm inputRangeForm = new InputRangeForm(field);
                    DialogResult result = inputRangeForm.ShowDialog();
                    if (result.Equals(DialogResult.Yes))
                    {

                        DataTable tempDT = dgMain.DataSource as DataTable;
                        DataRow newRow = tempDT.NewRow();
                        newRow.ItemArray = selectedDTRow[0].ItemArray;
                        newRow["CheckRange"] = true;
                        newRow["CheckNull"] = false;
                        newRow["CheckEmpty"] = false;
                        newRow["Range"] = inputRangeForm.Range;
                        newRow["NO"] = index;

                        tempDT.Rows.Add(newRow);

                        DataView dataView = tempDT.DefaultView;
                        dataView.Sort = "NO asc";
                        tempDT = dataView.ToTable();
                        for (int i = 0; i < tempDT.Rows.Count; i++)
                        {
                            DataRow tempRow = tempDT.Rows[i];
                            tempRow["NO"] = i + 1;
                        }
                        dgMain.DataSource = tempDT;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtJson_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Control && e.KeyCode == Keys.A)
                {
                    txtJson.SelectAll();
                }
                else if (e.Control && e.KeyCode == Keys.C)
                {
                    String selectedText = txtJson.SelectedText;
                    if (selectedText.Trim().Length == 0)
                    {
                        selectedText = txtJson.Text.Trim();
                    }
                    if (selectedText.Length != 0)
                    {
                        Clipboard.SetDataObject(selectedText);
                        lbState.Text = "复制Json成功！";
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
                        txtJson.Clear();
                        txtJson.Text = pasteStr;
                        lbState.Text = "粘贴Json成功！";
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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = tabControl1.SelectedIndex;
            if(index == 0)
            {
                btnCopy.Text = "复制验证代码(&C)";
            }
            else
            {
                btnCopy.Text = "复制调用Json(&C)";
            }
        }
    }
}
