using CreateProject.Util;
using DataBaseApp.Util;
using MySql.Data.MySqlClient;
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
    public partial class DataBaseCopyForm : Form
    {
        public DataBaseCopyForm()
        {
            InitializeComponent();
        }

        private void DataBaseCopyForm_Load(object sender, EventArgs e)
        {
            try
            {
                CheckForIllegalCrossThreadCalls = false;
                backgroundWorker.WorkerReportsProgress = true;
                lbSeletedInfo.Text = "";
                DataTable dataSourceDT = new DataTable();
                dataSourceDT.Columns.Add("type", typeof(String));
                dataSourceDT.Columns.Add("port", typeof(UInt32));
                DataRow newRow = dataSourceDT.NewRow();
                newRow["type"] = "MySql";
                newRow["port"] = 3306;
                dataSourceDT.Rows.Add(newRow);

                foreach (DataRow row in dataSourceDT.Rows)
                {
                    cboDataBaseType.Items.Add(row["type"]);
                }

                //bindCbo(cboDataBaseType.ComboBox, dataSourceDT, "type", "port");
                //cboDataBaseType.ComboBox.DisplayMember = "type";
                //cboDataBaseType.ComboBox.ValueMember = "port";
                //cboDataBaseType.ComboBox.DataSource = dataSourceDT;

                cboDataBaseType.Tag = dataSourceDT;

                if (cboDataBaseType.Items.Count > 0)
                {
                    cboDataBaseType.SelectedIndex = 0;
                }

                pbMain.Dock = DockStyle.Fill;
                lbState.Dock = DockStyle.Right;

                String sourceIP = XMLUtil.getValue("sourceIP");
                String sourcePort = XMLUtil.getValue("sourcePort");
                String sourceUserName = XMLUtil.getValue("sourceUserName");
                String sourcePassWord = XMLUtil.getValue("sourcePassWord");
                String targetIP = XMLUtil.getValue("targetIP");
                String targetPort = XMLUtil.getValue("targetPort");
                String targetUserName = XMLUtil.getValue("targetUserName");
                String targetPassWord = XMLUtil.getValue("targetPassWord");

                if (sourceIP.Length != 0)
                {
                    txtSourceIP.Text = sourceIP;
                }
                if (sourcePort.Length != 0)
                {
                    txtSourcePort.Text = sourcePort;
                }
                if (sourceUserName.Length != 0)
                {
                    txtSourceUserName.Text = sourceUserName;
                }
                if (sourcePassWord.Length != 0)
                {
                    txtSourcePassWord.Text = sourcePassWord;
                }
                if (targetIP.Length != 0)
                {
                    txtTargetIP.Text = targetIP;
                }
                if (targetPort.Length != 0)
                {
                    txtTargetPort.Text = targetPort;
                }
                if (targetUserName.Length != 0)
                {
                    txtTargetUserName.Text = targetUserName;
                }
                if (targetPassWord.Length != 0)
                {
                    txtTargetPassWord.Text = targetPassWord;
                }

                String tableCreateType = XMLUtil.getValue("tableCreateType");
                if (tableCreateType.Equals("clearAndAdd"))
                {
                    radClearAndAdd.Checked = true;
                }
                else if (tableCreateType.Equals("add"))
                {
                    radAdd.Checked = true;
                }
                else
                {
                    radUpdateAndAdd.Checked = true;
                }

                String copyType = XMLUtil.getValue("copyType");
                if (copyType.Equals("create"))
                {
                    radCreate.Checked = true;
                }
                else
                {
                    radSkip.Checked = true;
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnConnSource_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnConnSource.Text == "连接(&A)")
                {
                    String host = txtSourceIP.Text.Trim();
                    String portStr = txtSourcePort.Text.Trim();
                    String userName = txtSourceUserName.Text.Trim();
                    String passWord = txtSourcePassWord.Text.Trim();

                    if (host.Length == 0)
                    {
                        MessageBox.Show("源数据库IP地址不能为空!");
                        txtSourceIP.Focus();
                        return;
                    }
                    if (portStr.Length == 0)
                    {
                        MessageBox.Show("源数据库端口不能为空!");
                        txtSourcePort.Focus();
                        return;
                    }
                    int port = 0;
                    if (!Int32.TryParse(portStr, out port))
                    {
                        MessageBox.Show("源数据库端口必须为数字!");
                        txtSourcePort.Focus();
                        return;
                    }
                    if (userName.Length == 0)
                    {
                        MessageBox.Show("源数据库用户名不能为空!");
                        txtSourceUserName.Focus();
                        return;
                    }
                    if (passWord.Length == 0)
                    {
                        MessageBox.Show("源数据库密码不能为空!");
                        txtSourcePassWord.Focus();
                        return;
                    }
                    if (testConnection(host, portStr, userName, passWord))
                    {
                        btnConnSource.Text = "修改(&A)";
                        lbSourceState.Text = "源数据库已连接";

                        txtSourceIP.ReadOnly = true;
                        txtSourcePort.ReadOnly = true;
                        txtSourceUserName.ReadOnly = true;
                        txtSourcePassWord.ReadOnly = true;

                        lbSourceState.ForeColor = Color.Green;
                        lbSourceState.Tag = true;
                        XMLUtil.setValue("sourceIP", host);
                        XMLUtil.setValue("sourcePort", portStr);
                        XMLUtil.setValue("sourceUserName", userName);
                        XMLUtil.setValue("sourcePassWord", passWord);

                        String connStr = MySqlUtil.getConnectionStr(host, portStr, userName, passWord);

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
                        DataTable columns = MySqlUtil.getSchema(connStr, "Columns");
                        rows = columns.Select("TABLE_SCHEMA in ('performance_schema','information_schema','mysql')");
                        foreach (DataRow row in rows)
                        {
                            columns.Rows.Remove(row);
                        }

                        Dictionary<String, DataTable> source = new Dictionary<string, DataTable>();
                        source.Add("dataBases", dataBases);
                        source.Add("tables", tables);
                        source.Add("columns", columns);
                        btnConnSource.Tag = source;

                        bindCbo(cboSourceDataBase, dataBases, "database_name");
                        cboSourceDataBase.Tag = dataBases;

                        String selectedSourceDataBase = XMLUtil.getValue("selectedSourceDataBase");
                        if (selectedSourceDataBase.Length != 0 && dataBases.Rows.Count > 0)
                        {
                            int index = getRowIndex(dataBases, "database_name", selectedSourceDataBase);
                            cboSourceDataBase.SelectedIndex = index;
                        }
                    }
                    else
                    {
                        lbSourceState.Text = "源数据库未连接";
                        lbSourceState.ForeColor = Color.Red;
                        lbSourceState.Tag = null;
                        MessageBox.Show("源数据库链接失败");
                    }
                }
                else
                {
                    txtSourceIP.ReadOnly = false;
                    txtSourcePort.ReadOnly = false;
                    txtSourceUserName.ReadOnly = false;
                    txtSourcePassWord.ReadOnly = false;
                    btnConnSource.Text = "连接(&A)";
                    lbSourceState.Text = "源数据库未连接";
                    lbSourceState.ForeColor = Color.Red;
                    lbSourceState.Tag = null;
                    cboSourceDataBase.Items.Clear();
                    cboSourceDataBase.Text = "";
                    clbTableInfo.Items.Clear();
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnConnTarget_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnConnTarget.Text == "连接(&B)")
                {
                    String host = txtTargetIP.Text.Trim();
                    String portStr = txtTargetPort.Text.Trim();
                    String userName = txtTargetUserName.Text.Trim();
                    String passWord = txtTargetPassWord.Text.Trim();

                    if (host.Length == 0)
                    {
                        MessageBox.Show("目标数据库IP地址不能为空!");
                        txtTargetIP.Focus();
                        return;
                    }
                    if (portStr.Length == 0)
                    {
                        MessageBox.Show("目标数据库端口不能为空!");
                        txtTargetPort.Focus();
                        return;
                    }
                    int port = 0;
                    if (!Int32.TryParse(portStr, out port))
                    {
                        MessageBox.Show("目标数据库端口必须为数字!");
                        txtTargetPort.Focus();
                        return;
                    }
                    if (userName.Length == 0)
                    {
                        MessageBox.Show("目标数据库用户名不能为空!");
                        txtTargetUserName.Focus();
                        return;
                    }
                    if (passWord.Length == 0)
                    {
                        MessageBox.Show("目标数据库密码不能为空!");
                        txtTargetPassWord.Focus();
                        return;
                    }
                    if (testConnection(host, portStr, userName, passWord))
                    {
                        btnConnTarget.Text = "修改(&B)";
                        lbTargetState.Text = "目标数据库已连接";

                        txtTargetIP.ReadOnly = true;
                        txtTargetPort.ReadOnly = true;
                        txtTargetUserName.ReadOnly = true;
                        txtTargetPassWord.ReadOnly = true;

                        lbTargetState.ForeColor = Color.Green;
                        lbTargetState.Tag = true;
                        XMLUtil.setValue("targetIP", host);
                        XMLUtil.setValue("targetPort", portStr);
                        XMLUtil.setValue("targetUserName", userName);
                        XMLUtil.setValue("targetPassWord", passWord);

                        String connStr = MySqlUtil.getConnectionStr(host, portStr, userName, passWord);


                        DataTable dataBases = MySqlUtil.getSchema(connStr, "Databases");

                        String selectedSorceDataBase = cboSourceDataBase.Text;

                        DataRow[] rows = dataBases.Select("database_name in ('performance_schema','information_schema','mysql') AND database_name<>'" + selectedSorceDataBase + "'");
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
                        DataTable columns = MySqlUtil.getSchema(connStr, "Columns");
                        rows = columns.Select("TABLE_SCHEMA in ('performance_schema','information_schema','mysql')");
                        foreach (DataRow row in rows)
                        {
                            columns.Rows.Remove(row);
                        }

                        Dictionary<String, DataTable> target = new Dictionary<string, DataTable>();
                        target.Add("dataBases", dataBases);
                        target.Add("tables", tables);
                        target.Add("columns", columns);
                        btnConnTarget.Tag = target;


                        bindCbo(cboTargetDataBase, dataBases, "database_name");
                        cboTargetDataBase.Tag = dataBases;

                        String selectedTargetDataBase = XMLUtil.getValue("selectedTargetDataBase");
                        if (selectedTargetDataBase.Length != 0 && dataBases.Rows.Count > 0)
                        {
                            int index = getRowIndex(dataBases, "database_name", selectedTargetDataBase);
                            cboTargetDataBase.SelectedIndex = index;
                        }
                    }
                    else
                    {
                        lbTargetState.Text = "目标数据库未连接";
                        lbTargetState.ForeColor = Color.Red;
                        lbTargetState.Tag = null;
                        MessageBox.Show("目标数据库链接失败");
                    }
                }
                else
                {
                    txtTargetIP.ReadOnly = false;
                    txtTargetPort.ReadOnly = false;
                    txtTargetUserName.ReadOnly = false;
                    txtTargetPassWord.ReadOnly = false;
                    lbTargetState.ForeColor = Color.Red;
                    lbTargetState.Tag = null;
                    btnConnTarget.Text = "连接(&B)";
                    lbTargetState.Text = "目标数据库未连接";
                    cboTargetDataBase.Items.Clear();
                    cboTargetDataBase.Text = "";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void initTableInfo(String selectedSchema)
        {
            try
            {

                Dictionary<String, DataTable> source = btnConnSource.Tag as Dictionary<String, DataTable>;
                DataTable tableInfo = source["tables"];
                DataRow[] rows = tableInfo.Select("TABLE_SCHEMA = '" + selectedSchema + "'");
                var rows1 = tableInfo.Select("TABLE_SCHEMA = '" + selectedSchema + "'").OrderByDescending(row => row["TABLE_NAME"].ToString().Length);
                int length = rows1.Count() == 0 ? 0 : rows1.ElementAt(0)["TABLE_NAME"].ToString().Length;
                length = length * 360 / 58;
                clbTableInfo.ColumnWidth = length;
                clbTableInfo.Items.Clear();
                foreach (DataRow row in rows)
                {
                    String tableName = row["TABLE_NAME"].ToString();
                    clbTableInfo.Items.Add(tableName);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }



        private bool testConnection(String host, String portStr, String userName, String passWord)
        {
            String sql = "SELECT 1";
            String connStr = this.getConnStr(host, portStr, userName, passWord);
            DataTable tempDT = MySqlUtil.getDateTable(connStr, sql);
            if (tempDT.Rows.Count > 0)
            {
                //this.connStr = connStr;
                return true;
            }
            else
            {
                return false;
            }
        }

        private String getConnStr(String host, String portStr, String userName, String passWord)
        {

            String connStr = MySqlUtil.getConnectionStr(host, portStr, userName, passWord);
            return connStr;
        }


        private void cboDataBaseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dataSourceDT = cboDataBaseType.Tag as DataTable;
                DataRow[] rows = dataSourceDT.Select("type = '" + cboDataBaseType.Text + "'");
                if (rows.Length > 0)
                {
                    txtSourcePort.Text = rows[0]["port"].ToString();
                    txtTargetPort.Text = rows[0]["port"].ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }



        private void combox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cboSourceDataBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String selectedSchema = cboSourceDataBase.Text;
                initTableInfo(selectedSchema);
                String sourceIP = txtSourceIP.Text.Trim().ToLower();
                String sourcePort = txtSourcePort.Text.Trim().ToLower();
                String sourceUserName = txtSourceUserName.Text.Trim().ToLower();
                String sourcePassWord = txtSourcePassWord.Text.Trim().ToLower();
                String targetIP = txtTargetIP.Text.Trim().ToLower();
                String targetPort = txtTargetPort.Text.Trim().ToLower();
                String targetUserName = txtTargetUserName.Text.Trim().ToLower();
                String targetPassWord = txtTargetPassWord.Text.Trim().ToLower();

                if (sourceIP.Equals(targetIP) && sourcePort.Equals(targetPort) && sourceUserName.Equals(targetUserName) && sourcePassWord.Equals(targetPassWord) && btnConnTarget.Tag != null)
                {
                    Dictionary<String, DataTable> target = btnConnTarget.Tag as Dictionary<String, DataTable>;
                    DataTable targetData = target["dataBases"];

                    DataTable temp = targetData.Copy();

                    DataRow[] rows = temp.Select("database_name='" + selectedSchema + "'");
                    if (rows.Length > 0)
                    {
                        temp.Rows.Remove(rows[0]);
                    }

                    bindCbo(cboTargetDataBase, temp, "database_name");

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnCopySourceToTarget_Click(object sender, EventArgs e)
        {
            try
            {
                txtTargetIP.Text = txtSourceIP.Text.Trim();
                txtTargetPort.Text = txtSourcePort.Text.Trim();
                txtTargetUserName.Text = txtSourceUserName.Text.Trim();
                txtTargetPassWord.Text = txtSourcePassWord.Text.Trim();

                txtTargetIP.ReadOnly = false;
                txtTargetPort.ReadOnly = false;
                txtTargetUserName.ReadOnly = false;
                txtTargetPassWord.ReadOnly = false;

                DialogResult result = MessageBox.Show("复制成功,是否立即目标数据库?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                btnConnTarget.Text = "连接(&A)";
                lbTargetState.Text = "目标数据库未连接";
                cboTargetDataBase.Items.Clear();
                if (result.Equals(DialogResult.Yes))
                {
                    btnConnTarget_Click(sender, e);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnCopyTargetToSource_Click(object sender, EventArgs e)
        {
            try
            {
                txtSourceIP.Text = txtTargetIP.Text.Trim();
                txtSourcePort.Text = txtTargetPort.Text.Trim();
                txtSourceUserName.Text = txtTargetUserName.Text.Trim();
                txtSourcePassWord.Text = txtTargetPassWord.Text.Trim();

                txtSourceIP.ReadOnly = false;
                txtSourcePort.ReadOnly = false;
                txtSourceUserName.ReadOnly = false;
                txtSourcePassWord.ReadOnly = false;

                DialogResult result = MessageBox.Show("复制成功,是否立即源数据库?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                btnConnSource.Text = "连接(&A)";
                lbSourceState.Text = "源数据库未连接";
                cboSourceDataBase.Items.Clear();
                if (result.Equals(DialogResult.Yes))
                {
                    btnConnSource_Click(sender, e);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void cboTargetDataBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void bindCbo(ComboBox combox, DataTable dataTable, String displayMember, int selectedIndex = 0)
        {
            combox.Items.Clear();

            foreach (DataRow row in dataTable.Rows)
            {
                combox.Items.Add(row[displayMember]);
            }
            //combox.DataSource = dataTable;
            //combox.ValueMember = valueMember;
            //combox.DisplayMember = displayMember;
            if (dataTable.Rows.Count > selectedIndex)
            {
                combox.SelectedIndex = selectedIndex;
            }
            //combox.Tag = dataTable;
        }

        private int getRowIndex(DataTable dataTable, String key, String value)
        {
            DataRow[] rows = dataTable.Select(key + " = '" + value + "'");
            return rows.Length == 0 ? 0 : dataTable.Rows.IndexOf(rows[0]);
        }

        private void txtSearchContent_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode.Equals(Keys.Enter) && btnConnSource.Tag != null)
                {
                    e.Handled = true;
                }
                else
                {
                    CheckedListBox.CheckedItemCollection selected = clbTableInfo.CheckedItems;
                    String[] selectedArr = new String[selected.Count];
                    selected.CopyTo(selectedArr, 0);
                    clbTableInfo.Items.Clear();
                    Dictionary<String, DataTable> source = btnConnSource.Tag as Dictionary<String, DataTable>;
                    DataTable temp = source["tables"].Copy();
                    StringBuilder strBuilder = new StringBuilder("'1'");

                    foreach (var item in selectedArr)
                    {
                        strBuilder = strBuilder.Append(",'").Append(item).Append("'");
                        clbTableInfo.Items.Add(item, true);
                    }
                    String notInFilter = strBuilder.ToString();
                    DataRow[] rows = temp.Select("TABLE_NAME not in (" + notInFilter + ") AND TABLE_NAME LIKE '%" + txtSearchContent.Text.Trim() + "%'");
                    foreach (DataRow item in rows)
                    {
                        clbTableInfo.Items.Add(item["TABLE_NAME"]);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void clbTableInfo_SelectedValueChanged(object sender, EventArgs e)
        {
            lbSeletedInfo.Text = "选中了[" + clbTableInfo.CheckedItems.Count + "]个表";
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            int count = clbTableInfo.Items.Count;
            for (int i = 0; i < count; i++)
            {
                clbTableInfo.SetItemChecked(i, true);
            }

        }

        private void btnClearSelected_Click(object sender, EventArgs e)
        {
            int count = clbTableInfo.Items.Count;
            for (int i = 0; i < count; i++)
            {
                clbTableInfo.SetItemChecked(i, false);
            }
        }

        MySqlConnection connection = null;

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnStart.Tag == null)
                {
                    CheckedListBox.CheckedItemCollection selectedTables = clbTableInfo.CheckedItems;
                    if (lbSourceState.Tag == null)
                    {
                        MessageBox.Show("源数据库未链接，请链接源数据库!");
                        return;
                    }
                    else if (lbTargetState.Tag == null)
                    {
                        MessageBox.Show("目标数据库未链接，请链接源数据库!");
                        return;
                    }
                    else if (selectedTables.Count == 0)
                    {
                        MessageBox.Show("请选择待拷贝的表!");
                        return;
                    }
                    work();
                    //backgroundWorker.RunWorkerAsync();
                    btnStart.Text = "取消拷贝(&P)";
                    btnStart.Tag = "start";

                }
                else
                {
                    btnStart.Text = "开始拷贝(&P)";
                    btnStart.Tag = null;
                }

                //获得源数据
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void work()
        {
            //获取源数据
            String host = txtSourceIP.Text.Trim();
            String portStr = txtSourcePort.Text.Trim();
            String userName = txtSourceUserName.Text.Trim();
            String passWord = txtSourcePassWord.Text.Trim();
            String dataBase = cboSourceDataBase.Text;
            String connectionString = MySqlUtil.getConnectionStr(host, portStr, userName, passWord, dataBase);
            connection = MySqlUtil.getConn(connectionString);
            Dictionary<String, DataTable> source = new Dictionary<string, DataTable>();
            Dictionary<String, DataTable> sourceSetting = btnConnSource.Tag as Dictionary<String, DataTable>;
            Dictionary<String, DataTable> targetSetting = btnConnSource.Tag as Dictionary<String, DataTable>;
            DataTable sourceColumns = sourceSetting["columns"] as DataTable;
            DataTable targetColumns = targetSetting["columns"] as DataTable;

            lbState.Text = "开始获取源数据";
            List<Dictionary<String, Dictionary<String, Object>>> sqlList = new List<Dictionary<String, Dictionary<String, Object>>>();
            foreach (String tableName in clbTableInfo.CheckedItems)
            {
                bool createTable = radCreate.Checked && !radSkip.Checked;

                bool tableIsExist = checkTableExist(tableName, sourceColumns);

                if (createTable && tableIsExist)
                {
                    String insertSql = getCreateSql(sourceColumns, tableName);
                }

                String sql = "select * from " + tableName;
                DataTable tempDT = MySqlUtil.getDateTable(connection, sql);

                DataTable tableInfo = sourceSetting[tableName];

                StringBuilder fields = new StringBuilder();

                var rows = sourceColumns.Select("TABLE_NAME = '" + tableName + "' and COLUMN_KEY <> 'PRI'").Distinct(row => row["COLUMN_NAME"]);



                foreach (var row in rows)
                {
                    String colName = row["COLUMN_NAME"].ToString();
                    fields.Append(colName).Append(",");
                }

            }
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        private bool checkTableExist(String tableName, DataTable dataTable)
        {
            DataRow[] rows = dataTable.Select("TABLE_NAME = '" + tableName + "'");
            return rows.Length > 0;
        }

        private String getCreateSql(DataTable columns, String tableName)
        {
            try
            {
                StringBuilder sql = new StringBuilder("CREATE TABLE ").Append(tableName);
                var rows = columns.Select("TABLE_NAME = '" + tableName + "'").Distinct(row => row["COLUMN_NAME"]);
                foreach (var row in rows)
                {
                    String colName = row["COLUMN_NAME"].ToString();

                }
                return "";
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
