using CreateProject.Util;
using DataBaseApp.Util;
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
    public partial class DBLoginForm : Form
    {
        public DBLoginForm()
        {
            InitializeComponent();
        }



        private String connStr = "";

        public String ConnStr
        {
            get { return connStr; }
        }





        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable setting = SqliteHelper.findList("select * from tb_database");
            cboSetting.DataSource = setting;
            cboSetting.DisplayMember = "settingName";
            cboSetting.ValueMember = "id";
            cboSetting.Tag = setting;
            String SelectedDbSetting = XMLUtil.getValue("SelectedDbSetting");

            DataRow[] rows = setting.Select("settingName = '" + SelectedDbSetting + "'");
            if (rows.Length > 0)
            {
                int index = setting.Rows.IndexOf(rows[0]);
                cboSetting.SelectedIndex = index;
                txtIP.Text = rows[0]["ip"].ToString();
                txtPort.Text = rows[0]["port"].ToString();
                txtUserName.Text = rows[0]["userName"].ToString();
                txtPassWord.Text = rows[0]["password"].ToString();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (testForm() && testConnection())
                {
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
                    SessionUtil.Session.put("dataBases", dataBases);

                    SessionUtil.Session.put("tables", tables);
                    SessionUtil.Session.put("columns", columns);

                    string passsword = txtPassWord.Text.Trim();
                    string ip = txtIP.Text.Trim();
                    String userName = txtUserName.Text.Trim();
                    string port = txtPort.Text.Trim();
                    String settingName =  "@" + ip + ":" + port;
                    DataTable setting = cboSetting.Tag as DataTable;
                    DataRow[] result = setting.Select("password = '" + passsword + "'" +
                           " AND userName = '" + userName + "'"
                           + " AND port = '" + port + "'" +
                           " AND ip = '" + ip + "'");
                    if (result.Length == 0)
                    {
                        StringBuilder sbSql = new StringBuilder();
                        sbSql.Append(" INSERT INTO tb_database (dbName, password, ip, userName, port, settingName) VALUES ( ");
                        sbSql.Append("   :dbName, :password, :ip, :userName, :port, :settingName ");
                        sbSql.Append(" ) ");


                        Dictionary<String, Object> parameters = new Dictionary<string, object>();
                        parameters.Add("dbName", "");
                        parameters.Add("password", txtPassWord.Text.Trim());
                        parameters.Add("ip", txtIP.Text.Trim());
                        parameters.Add("userName", txtUserName.Text.Trim());
                        parameters.Add("port", txtPort.Text.Trim());
                        parameters.Add("settingName", settingName);
                        SqliteHelper.excuteNoQuery(sbSql.ToString(), parameters);
                    }
                  
                    XMLUtil.setValue("Host", ip);
                    XMLUtil.setValue("Port", port);
                    XMLUtil.setValue("DBUserName", userName);
                    XMLUtil.setValue("PassWord", passsword);
                    XMLUtil.setValue("SelectedDbSetting", settingName);

                    this.DialogResult = DialogResult.Yes;
                }
                else
                {
                    this.DialogResult = DialogResult.No;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }



        private void btnTest_Click(object sender, EventArgs e)
        {
            try
            {
                if (testForm() && testConnection())
                {
                    MessageBox.Show("测试成功");
                }
                else
                {
                    MessageBox.Show("测试失败");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private bool testConnection()
        {
            String sql = "SELECT 1";
            String connStr = this.getConnStr();
            DataTable tempDT = MySqlUtil.getDateTable(connStr, sql);
            if (tempDT.Rows.Count > 0)
            {
                this.connStr = connStr;

                return true;
            }
            else
            {
                return false;
            }
        }

        private String getConnStr()
        {
            String host = txtIP.Text;
            String portStr = txtPort.Text;
            String userName = txtUserName.Text;
            String passWord = txtPassWord.Text;
            String connStr = MySqlUtil.getConnectionStr(host, portStr, userName, passWord);
            return connStr;
        }

        private bool testForm()
        {
            String host = txtIP.Text;
            String portStr = txtPort.Text;
            String userName = txtUserName.Text;
            String passWord = txtPassWord.Text;

            if (host.Length == 0)
            {
                MessageBox.Show("请输入host地址");
                return false;
            }
            uint port = 0;
            if (portStr.Length == 0 && !UInt32.TryParse(portStr, out port))
            {
                MessageBox.Show("请输入正确的端口信息");
                return false;
            }

            if (userName.Length == 0)
            {
                MessageBox.Show("请输入用户名");
                return false;
            }
            if (passWord.Length == 0)
            {
                MessageBox.Show("请输入密码");
                return false;
            }
            return true;
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }


        private void lbDisplay_Click(object sender, EventArgs e)
        {
            if (lbDisplay.Text.Equals("显示密码"))
            {
                txtPassWord.PasswordChar = new char();
                lbDisplay.Text = "隐藏密码";
            }
            else
            {
                txtPassWord.PasswordChar = '*';
                lbDisplay.Text = "显示密码";
            }
        }

        private void cboSetting_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cboSetting.SelectedIndex;
            DataTable setting = cboSetting.Tag as DataTable;
            if (setting != null)
            {
                DataRow row = setting.Rows[selectedIndex];
                txtIP.Text = row["ip"].ToString();
                txtPort.Text = row["port"].ToString();
                txtUserName.Text = row["userName"].ToString();
                txtPassWord.Text = row["password"].ToString();
            }

        }
        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Int32 id = toInt(cboSetting.SelectedValue);
            if (id == 0)
            {
                return;
            }

            string sql = "delete from tb_database where id = :id";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("id", id);
            SqliteHelper.excuteNoQuery(sql, parameters);
            MessageBox.Show("删除成功!");
            DataTable setting = SqliteHelper.findList("select * from tb_database");
            cboSetting.DataSource = setting;
            cboSetting.DisplayMember = "settingName";
            cboSetting.ValueMember = "id";
            cboSetting.Tag = setting;
        }



        private int toInt(Object value)
        {
            int i = 0;
            Int32.TryParse(value == null ? "" : value.ToString(), out i);
            return i;
        }
    }
}
