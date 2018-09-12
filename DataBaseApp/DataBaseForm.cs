using CreateProject.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using SessionUtil;
using DataBaseApp.Util;

namespace DataBaseApp
{
    public partial class DataBaseForm : Form
    {
        public DataBaseForm()
        {
            selectedDataBase = XMLUtil.getValue("SelectedDataBase");
            InitializeComponent();
        }

        private String connStr = "";
        private String selectedDataBase = "";
        private Boolean isConnected = false;

        bool isHibernate = XMLUtil.getValue("isHibernate").Equals("true");
        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                lbConnStr.Text = "";
                lbState.Text = "";
                
                String host = XMLUtil.getValue("Host");
                String port = XMLUtil.getValue("Port");
                String userName = XMLUtil.getValue("DBUserName");
                String passWord = XMLUtil.getValue("PassWord");
                if ( host.Length != 0 && port.Length != 0 && userName.Length != 0 && passWord.Length != 0)
                {

                    String connStr = MySqlUtil.getConnectionStr(host, port, userName, passWord);
                    this.connStr = connStr;
                    DataTable dataBases = MySqlUtil.getSchema(connStr, "Databases");
                    DataRow[] rows = dataBases.Select("database_name in ('performance_schema','information_schema','mysql')");
                    foreach (DataRow row in rows)
                    {
                        dataBases.Rows.Remove(row);
                    }
                    DataTable tables = MySqlUtil.getSchema(connStr, "Tables");
                    rows = tables.Select("TABLE_SCHEMA in ('performance_schema','information_schema','mysql')");
                    foreach (DataRow row in rows)
                    {
                        tables.Rows.Remove(row);
                    }
                    DataTable columns1 = new DataTable();
                    columns1.Columns.Add("database_name");
                    columns1.Columns.Add("TABLE_SCHEMA");
                    columns1.Columns.Add("column");

                    StringBuilder sqlBuilder = new StringBuilder();
                    foreach (DataRow table in tables.Rows)
                    {
                        String databaseName = table["TABLE_SCHEMA"].ToString();
                        String tableName = table["TABLE_NAME"].ToString();
                        String sql = "select * from " + databaseName + "." + tableName + " limit 1;";
                        sqlBuilder.Append(sql);
                    }

                    DataTable c = MySqlUtil.getDateTable(connStr, sqlBuilder.ToString());

                    DataTable columns = MySqlUtil.getSchema(connStr, "Columns");
                    rows = columns.Select("TABLE_SCHEMA in ('performance_schema','information_schema','mysql')");
                    foreach (DataRow row in rows)
                    {
                        columns.Rows.Remove(row);
                    }
                    Session.put("dataBases", dataBases);

                    Session.put("tables", tables);
                    Session.put("columns", columns);
                    isConnected = true;
                }
                if (Session.check("dataBases"))
                {
                    DataTable dataBases = Session.get("dataBases") as DataTable;
                    cboDataBase.ComboBox.DataSource = dataBases;
                    cboDataBase.ComboBox.DisplayMember = "database_name";
                    cboDataBase.ComboBox.ValueMember = "database_name";

                    lbConnStr.Text = connStr.Substring(0, connStr.LastIndexOf("password"));


                    DataRow[] rows = dataBases.Select("database_name = '" + selectedDataBase + "'");
                    if (rows.Length > 0)
                    {
                        int index = dataBases.Rows.IndexOf(rows[0]);
                        cboDataBase.SelectedIndex = index;
                    }
                    else if (dataBases.Rows.Count > 0)
                    {
                        cboDataBase.SelectedIndex = 0;
                    }
                    String schemaName = cboDataBase.Text;
                    InitTree(schemaName, "");
                }

                String SelectTable = XMLUtil.getValue("SelectTable");
                lbDbConnState.Text = isConnected ? "已连接" : "未连接";
                lbDbConnState.ForeColor = isConnected ? Color.Green : Color.Red;

                getExcludedFiledSetting();
                radHibernate.Checked = XMLUtil.getValue("isHibernate").Equals("true");
                radMybatis.Checked = !XMLUtil.getValue("isHibernate").Equals("true");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void InitTree(String schemaName, String filter)
        {
            try
            {
                if (schemaName.Trim().Length == 0)
                {
                    return;
                }
                DataTable tables = SessionUtil.Session.get("tables") as DataTable;
                DataRow[] rows = tables.Select("TABLE_SCHEMA = '" + schemaName + "' and TABLE_NAME like '%" + filter + "%'");
                TreeNode rootNode = new TreeNode(schemaName);
                foreach (DataRow row in rows)
                {
                    String tableName = row["TABLE_NAME"].ToString();
                    TreeNode treeNode = new TreeNode(tableName);
                    treeNode.Tag = tableName;
                    rootNode.Nodes.Add(treeNode);
                }
                tvMain.Nodes.Clear();
                tvMain.Nodes.Add(rootNode);
                tvMain.ExpandAll();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void tvMain_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = e.Node;
            TreeNodeCollection nodeColl = tvMain.Nodes;
            //tvMain.Refresh();
            foreach (TreeNode treenode in nodeColl)
            {
                treenode.BackColor = Color.FromArgb(0, 255, 255, 255);
                TreeNodeCollection childnodes = treenode.Nodes;
                foreach (TreeNode childnode in childnodes)
                {
                    childnode.BackColor = Color.FromArgb(0, 255, 255, 255);
                }
            }
            selectedNode.BackColor = Color.FromArgb(0, 51, 153, 255);
            String tableName = selectedNode.Text;
            InitInsertSql(tableName);
            InitUpdateSql(tableName);
            InitJson(tableName);
        }

        private void InitInsertSql(String tableName)
        {
            String workType = XMLUtil.getValue("WorkType");
            DataTable columns = SessionUtil.Session.get("columns") as DataTable;



            var rows = columns.Select("TABLE_SCHEMA = '" + cboDataBase.Text + "' AND TABLE_NAME = '" + tableName + "' ").Distinct(row => row["COLUMN_NAME"]);
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("StringBuilder sbSql = new StringBuilder();");
            sql.AppendLine("sbSql.append(\" INSERT INTO \");");
            sql.AppendLine("sbSql.append(\"   " + tableName + " \");");
            sql.AppendLine("sbSql.append(\"   ( \");");
            StringBuilder para = new StringBuilder();
            StringBuilder paraMap = new StringBuilder();

            List<String> columnsList = new List<string>();
            String paraChar = ":";
            if (workType.Equals("Net"))
            {
                paraChar = "@";
            }

            var count = rows.Count();
            for (int i = 0; i < rows.Count(); i++)
            {
                var row = rows.ElementAt(i);
                String colName = row["COLUMN_NAME"].ToString();
                String COLUMN_DEFAULT = row["COLUMN_DEFAULT"].ToString();
                if (columnsList.Contains(colName))
                {
                    continue;
                }
                else if (COLUMN_DEFAULT.Equals("CURRENT_TIMESTAMP"))
                {
                    count--;
                    continue;
                }

                bool isExist = insertField.Exists(str => str.ToLower().Equals(colName.ToLower()));
                if (isExist)
                {
                    count--;
                    continue;
                }

                columnsList.Add(colName);
                if (row["COLUMN_KEY"].ToString().ToLower().Equals("pri") && row["EXTRA"].ToString().ToLower().Equals("auto_increment"))
                {
                    continue;
                }

                var paraName = colName;
                if (isHibernate && !workType.Equals("Net"))
                {
                    paraName = ":" + paraName;
                }
                else if (!isHibernate && !workType.Equals("Net"))
                {
                    paraName = fomartParameterForMyBatis(paraName);
                }

                if (i == count - 1)
                {
                    sql.AppendLine("sbSql.append(\"      " + colName + " \");");
                    para.AppendLine("sbSql.append(\"      " + paraName + " \");");
                }
                else
                {
                    sql.AppendLine("sbSql.append(\"      " + colName + ", \");");
                    para.AppendLine("sbSql.append(\"      " + paraName + ", \");");
                }

                String colTemp = formatPara(colName);
                if (workType.Equals("Net"))
                {
                    paraMap.AppendLine("parametersList.Add(new SqlParameter(\"@" + colName + "\", entity." + colTemp + "));");
                }
                else
                {
                    paraMap.AppendLine("parameters.put(\"" + colName + "\", entity.get" + colTemp + "());");
                }

            }
            sql.AppendLine("sbSql.append(\"   ) \");");
            sql.AppendLine("sbSql.append(\" VALUES \");");
            sql.AppendLine("sbSql.append(\"   ( \");");
            sql.AppendLine(para.ToString().Trim());
            sql.AppendLine("sbSql.append(\"   ) \");");
            if (workType.Equals("Net"))
            {
                sql.Replace("sbSql.append", "sbSql.Append");
            }
            sql.AppendLine();

            if (workType.Equals("Net") && isHibernate)
            {
                sql.AppendLine("List<SqlParameter> parametersList = new List<SqlParameter>();");
            }
            else if (isHibernate)
            {
                sql.AppendLine("Map<String, Object> parameters = new HashMap();");
            }
            if (isHibernate)
            {
                sql.AppendLine(paraMap.ToString().Trim());
            }

            if (workType.Equals("Net"))
            {
                sql.AppendLine("SqlParameter[] parameters = parametersList.ToArray();");
            }
            txtInsert.Text = sql.ToString();
        }
        private String fomartParameterForMyBatis(String parameterName)
        {
            return "#{" + parameterName + "}";
        }
        private void InitUpdateSql(String tableName)
        {
            String workType = XMLUtil.getValue("WorkType");
            DataTable columns = SessionUtil.Session.get("columns") as DataTable;
            //DataRow[] rows = columns.Select("TABLE_NAME = '" + tableName + "' and COLUMN_KEY <> 'PRI'");

            var rows = columns.Select("TABLE_NAME = '" + tableName + "' and COLUMN_KEY <> 'PRI'").Distinct(row => row["COLUMN_NAME"]);

            StringBuilder sql = new StringBuilder();
            sql.AppendLine("StringBuilder sbSql = new StringBuilder();");
            sql.AppendLine("sbSql.append(\" UPDATE \");");
            sql.AppendLine("sbSql.append(\"   " + tableName + " \");");
            sql.AppendLine("sbSql.append(\" SET \");");
            StringBuilder paraMap = new StringBuilder();

            String paraChar = ":";
            if (workType.Equals("Net"))
            {
                paraChar = "@";
            }

            var count = rows.Count();
            List<String> columnsList = new List<string>();

            for (int i = 0; i < rows.Count(); i++)
            {
                var row = rows.ElementAt(i);
                String colName = row["COLUMN_NAME"].ToString();
                String COLUMN_DEFAULT = row["COLUMN_DEFAULT"].ToString();
                if (columnsList.Contains(colName))
                {
                    continue;
                }
                else if (COLUMN_DEFAULT.Equals("CURRENT_TIMESTAMP"))
                {
                    count--;
                    continue;
                }

                bool isExist = updateField.Exists(str => str.ToLower().Equals(colName.ToLower()));
                if (isExist)
                {
                    count--;
                    continue;
                }
                columnsList.Add(colName);
                var para = paraChar + colName;
                if (!isHibernate)
                {
                    para = fomartParameterForMyBatis(colName);
                }
                if (i == count - 1)
                {
                    sql.AppendLine("sbSql.append(\"   " + colName + " = " + para + " \");");
                }
                else
                {
                    sql.AppendLine("sbSql.append(\"   " + colName + " = " + para + ", \");");
                }
                if (isHibernate)
                {
                    String colTemp = formatPara(colName);
                    if (workType.Equals("Net"))
                    {
                        paraMap.AppendLine("parametersList.Add(new SqlParameter(\"@" + colName + "\", entity." + colTemp + "));");
                    }
                    else
                    {
                        paraMap.AppendLine("parameters.put(\"" + colName + "\", entity.get" + colTemp + "());");
                    }
                }

            }
            sql.AppendLine("sbSql.append(\" WHERE \");");
            rows = columns.Select("TABLE_NAME = '" + tableName + "' and COLUMN_KEY = 'PRI'");
            if (rows.Count() > 0)
            {
                String priName = rows.First()["COLUMN_NAME"].ToString();
                var para = priName;
                if (isHibernate && !workType.Equals("Net"))
                {
                    para = ":" + para;
                }
                else if (!isHibernate && !workType.Equals("Net"))
                {
                    para = fomartParameterForMyBatis(para);
                }
                sql.AppendLine("sbSql.append(\"   " + priName + " = " + para + " \");");
                String colTemp = formatPara(priName);
                paraMap.AppendLine("parameters.put(\"" + priName + "\", entity.get" + colTemp + "());");
            }
            if (workType.Equals("Net"))
            {
                sql.Replace("sbSql.append", "sbSql.Append");
            }
            sql.AppendLine();
            if (workType.Equals("Net"))
            {
                sql.AppendLine("List<SqlParameter> parametersList = new List<SqlParameter>();");
            }
            else if (isHibernate)
            {
                sql.AppendLine("Map<String, Object> parameters = new HashMap();");
            }
            if (isHibernate)
                sql.AppendLine(paraMap.ToString().Trim());
            if (workType.Equals("Net"))
            {
                sql.AppendLine("SqlParameter[] parameters = parametersList.ToArray();");
            }
            txtUpdate.Text = sql.ToString();
        }

        private void InitJson(String tableName)
        {
            DataTable columns = SessionUtil.Session.get("columns") as DataTable;
            //DataRow[] rows = columns.Select("TABLE_NAME = '" + tableName + "' and COLUMN_KEY <> 'PRI'");

            var rows = columns.Select("TABLE_NAME = '" + tableName + "' and COLUMN_KEY <> 'PRI'").Distinct(row => row["COLUMN_NAME"]);
            int count = rows.Count();
            StringBuilder jsonStr = new StringBuilder();
            jsonStr.AppendLine("{");
            for (var i = 0; i < count; i++)
            {
                DataRow row = rows.ElementAt(i);
                String colName = row["COLUMN_NAME"].ToString();
                jsonStr.Append("    \"")
                    .Append(colName)
                     .Append("\"")
                    .Append(" : \"")
                    .Append(colName)
                    .Append("\"");
                if (i != count - 1)
                {
                    jsonStr.AppendLine(",");
                }
                else
                {
                    jsonStr.AppendLine("");
                }
            }

            jsonStr.AppendLine("}");
            txtJson.Text = jsonStr.ToString();
        }
        public static String formatPara(String para)
        {
            MatchCollection split = Regex.Matches(para, "[^A-Za-z0-9]");
            List<char> splitList = new List<char>();
            foreach (Match match in split)
            {
                splitList.AddRange(match.Value.ToArray());
            }
            String[] paraArr = para.Split(splitList.ToArray(), StringSplitOptions.RemoveEmptyEntries);
            StringBuilder result = new StringBuilder();
            foreach (String paraStr in paraArr)
            {
                result.Append(paraStr.Substring(0, 1).ToUpper());
                if (paraStr.Length > 1)
                {
                    result.Append(paraStr.Substring(1));
                }
            }
            return result.ToString();
        }

        private void cboDataBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selectedSchema = cboDataBase.Text;
            XMLUtil.setValue("SelectedDataBase", selectedSchema);
            String filter = txtSelect.Text;
            InitTree(selectedSchema, filter);
        }

        private void txtSelect_TextChanged(object sender, EventArgs e)
        {
            String filter = txtSelect.Text;
            String selectedSchema = cboDataBase.Text;
            InitTree(selectedSchema, filter);

        }

        private void cboDataBase_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {

            if (tabMain.SelectedIndex == 1 && txtUpdate.Text.Trim().Length != 0)
            {
                Clipboard.SetDataObject(txtUpdate.Text);
                lbState.Text = "Update复制成功！";
            }
            else if (tabMain.SelectedIndex == 0 && txtInsert.Text.Trim().Length != 0)
            {
                Clipboard.SetDataObject(txtInsert.Text);
                lbState.Text = "Insert复制成功！";
            }
            else if (tabMain.SelectedIndex == 2 && txtJson.Text.Trim().Length != 0)
            {

                Clipboard.SetDataObject(txtJson.Text);
                lbState.Text = "Json复制成功！";
            }
            else
            {
                return;
            }
        }

        private void txtUpdate_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                txtUpdate.SelectAll();
            }
            else if (e.Control && e.KeyCode == Keys.C)
            {
                String seletcedText = txtUpdate.SelectedText.Trim();
                if (seletcedText.Length == 0)
                {
                    seletcedText = txtUpdate.Text.Trim();
                }
                if (seletcedText.Length != 0)
                {
                    Clipboard.SetDataObject(seletcedText);
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
                    txtUpdate.Clear();
                    txtUpdate.Text = pasteStr;
                    lbState.Text = "粘贴成功！";
                }
                else
                {
                    lbState.Text = "粘贴板中数据为空！";
                }
            }
        }

        private void txtInsert_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                txtInsert.SelectAll();
            }
            else if (e.Control && e.KeyCode == Keys.C)
            {
                String selectedText = txtInsert.SelectedText.Trim();
                if (selectedText.Length == 0)
                {
                    selectedText = txtInsert.Text.Trim();
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
                    txtInsert.Clear();
                    txtInsert.Text = pasteStr;
                    lbState.Text = "粘贴成功！";
                }
                else
                {
                    lbState.Text = "粘贴板中数据为空！";
                }
            }
        }

        private void miConnectionDB_Click(object sender, EventArgs e)
        {
            DBLoginForm loginForm = new DBLoginForm();
            DialogResult result = loginForm.ShowDialog();
            if (result.Equals(DialogResult.Yes))
            {
                this.connStr = loginForm.ConnStr;
                this.isConnected = true;
                this.MainForm_Load(sender, e);
            }
        }

        private void DataBaseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.dataBaseForm = null;
        }

        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = tabMain.SelectedIndex;
            if (selectedIndex == 0)
            {
                btnCopy.Text = "复制全部Insert语句(&C)";
            }
            else if (selectedIndex == 1)
            {
                btnCopy.Text = "复制全部Update语句(&C)";
            }
            else
            {
                btnCopy.Text = "复制全部Json对象(&C)";
            }
        }

        List<String> insertField = new List<string>();
        List<String> updateField = new List<string>();

        private void btnExcludedField_Click(object sender, EventArgs e)
        {
            SetExcludedFiledForm form = new SetExcludedFiledForm();
            DialogResult result = form.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                getExcludedFiledSetting();
            }
        }

        private void getExcludedFiledSetting()
        {
            string insert = XMLUtil.getValue("ExcludedInsert");
            string update = XMLUtil.getValue("ExcludedUpdate");
            insertField = insert.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList<string>();
            updateField = update.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList<string>();
        }

        private void radHibernate_CheckedChanged(object sender, EventArgs e)
        {
            isHibernate = radHibernate.Checked;
            XMLUtil.setValue("isHibernate", radHibernate.Checked ? "true" : "false");
        }

        private void radMybatis_CheckedChanged(object sender, EventArgs e)
        {
            isHibernate = !radMybatis.Checked;
            XMLUtil.setValue("isHibernate", !radMybatis.Checked ? "true" : "false");
        }
    }
}
