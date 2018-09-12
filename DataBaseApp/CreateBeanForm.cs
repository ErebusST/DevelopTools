using CreateProject.Util;
using DataBaseApp.Util;
using SessionUtil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseApp
{
    public partial class CreateBeanForm : Form
    {
        public CreateBeanForm()
        {
            selectedDataBase = XMLUtil.getValue("SelectedDataBase");
            InitializeComponent();
        }

        private String connStr = "";
        private String selectedDataBase = "";
        private Boolean isConnected = false;
        private static String fieldSetting = Application.StartupPath + @"/fieldSetting.xml";

        private void reloadSettingDT()
        {
            try
            {
                DataTable typeDT = new DataTable();
                typeDT.Columns.Add("DataBaseType");
                typeDT.Columns.Add("DataType");
                typeDT.TableName = "fieldSetting";
                typeDT.ReadXml(fieldSetting);
                this.Tag = typeDT;
            }
            catch (Exception)
            {

                throw;
            }
        }
        bool isHibernate = XMLUtil.getValue("isHibernate").Equals("true");
        private void CreateBeanForm_Load(object sender, EventArgs e)
        {
            String exportPath = XMLUtil.getValue("BeanPath");
            txtPath.Text = exportPath.Trim();

            try
            {
                raHibernate.Checked = isHibernate;
                raMybatis.Checked = !isHibernate;
                
                reloadSettingDT();
                lbConnStr.Text = "";
                lbState.Text = "";
                
                String host = XMLUtil.getValue("Host");
                String port = XMLUtil.getValue("Port");
                String userName = XMLUtil.getValue("DBUserName");
                String passWord = XMLUtil.getValue("PassWord");
                if (host.Length != 0 && port.Length != 0 && userName.Length != 0 && passWord.Length != 0)
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

                lbDbConnState.Text = isConnected ? "已连接" : "未连接";
                lbDbConnState.ForeColor = isConnected ? Color.Green : Color.Red;
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



        private void tvMain_AfterCheck(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = e.Node;
            bool isChecked = selectedNode.Checked;
            TreeNodeCollection childNodes = selectedNode.Nodes;
            if (childNodes.Count > 0)
            {
                foreach (TreeNode childnode in childNodes)
                {
                    childnode.Checked = isChecked;
                }
            }
        }

        private void btnConnectionDB_Click(object sender, EventArgs e)
        {
            DBLoginForm loginForm = new DBLoginForm();
            DialogResult result = loginForm.ShowDialog();
            if (result.Equals(DialogResult.Yes))
            {
                this.connStr = loginForm.ConnStr;
                this.isConnected = true;
                this.CreateBeanForm_Load(sender, e);
            }
        }

        private void cboDataBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedDataBase = cboDataBase.Text;
            if (selectedDataBase.Equals("System.Data.DataRowView"))
            {
                return;
            }
            
            String filter = txtSelect.Text;
            InitTree(selectedDataBase, filter);
        }

        private void cboDataBase_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtSelect_TextChanged(object sender, EventArgs e)
        {
            String filter = txtSelect.Text;
            selectedDataBase = cboDataBase.Text;
            InitTree(selectedDataBase, filter);
        }

        private void btnOpenSelectPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            DialogResult result = path.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                this.txtPath.Text = path.SelectedPath;
            }
        }

        private void btnExportAll_Click(object sender, EventArgs e)
        {
            try
            {
                XMLUtil.setValue("SelectedDataBase", selectedDataBase);
                String savePath = txtPath.Text.Trim();
                if (savePath.Length == 0)
                {
                    MessageBox.Show("请选择保存路径");
                    return;
                }
                XMLUtil.setValue("BeanPath", savePath);
                TreeNode rootNode = tvMain.Nodes[0];
                TreeNodeCollection childNode = rootNode.Nodes;
                List<String> exportTables = new List<string>();
                foreach (TreeNode node in childNode)
                {
                    if (node.Checked)
                    {
                        exportTables.Add(node.Text);
                    }
                }
                if (exportTables.Count == 0)
                {
                    MessageBox.Show("请选择要生成的数据库表");
                    return;
                }
                pbMain.Maximum = exportTables.Count;
                pbMain.Value = 0;
                String templet;

                if (isHibernate)
                {
                    templet = readTemplet("javebean.temp");
                }
                else
                {
                    templet = readTemplet("javebeanForMybatis.temp");
                }

                foreach (String tableName in exportTables)
                {
                    export(tableName, templet);
                }
                string s = "";
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

        private void export(String tableName, String templet)
        {
            try
            {

                message("开始导出表【" + tableName + "】");
                String prefix = txtPrefix.Text.Trim();
                prefix = upperFirst(prefix);
                String suffix = txtSuffix.Text.Trim();
                suffix = upperFirst(suffix);

                String className = fixString(tableName);
                className = upperFirst(className);

                String beanClassName = prefix + className + suffix;

                message("类名 【" + beanClassName + "】");

                DataTable columns = Session.get("columns") as DataTable;
                DataRow[] rows = columns.Select("TABLE_SCHEMA = '" + selectedDataBase + "' AND TABLE_NAME = '" + tableName + "'");
                message("共" + rows.Length + "列");

                DataTable typeDT = this.Tag as DataTable;
                StringBuilder fieldList = new StringBuilder();
                StringBuilder importList = new StringBuilder();
                StringBuilder bean = new StringBuilder();
                foreach (DataRow row in rows)
                {
                    String COLUMN_NAME = toString(row["COLUMN_NAME"]);
                    String COLUMN_COMMENT = toString(row["COLUMN_COMMENT"]);
                    String DATA_TYPE = toString(row["DATA_TYPE"]);
                    String CHARACTER_MAXIMUM_LENGTH = toString(row["CHARACTER_MAXIMUM_LENGTH"]);
                    String NUMERIC_PRECISION = toString(row["NUMERIC_PRECISION"]);
                    String NUMBERIC_SCALE = toString(row["NUMERIC_SCALE"]);
                    String IS_NULLABLE = toString(row["IS_NULLABLE"]);
                    String EXTRA = toString(row["EXTRA"]);
                    String COLUMN_KEY = toString(row["COLUMN_KEY"]);

                    //获取类型
                    DataRow[] type = typeDT.Select("DataBaseType = '" + DATA_TYPE + "'");
                    if (type.Length == 0)
                    {
                        throw new Exception("数据库类型【" + DATA_TYPE + "】未配置对应Java类型");
                    }
                    String typeInJava = toString(type[0]["DataType"]);

                    String precision = "";
                    String length = "";
                    //判断字段类型，如果是Timestamp或者BigDecimal则需要引入新类
                    if (typeInJava.Equals("Timestamp"))
                    {
                        if (isHibernate)
                        {
                            if (!importList.ToString().Contains("import java.sql.Timestamp;"))
                            {
                                importList.AppendLine("import java.sql.Timestamp;");
                            }
                        }
                        else 
                        {
                            if (!importList.ToString().Contains("import java.util.Date;"))
                            {
                                importList.AppendLine("import java.util.Date;");
                                
                            }
                            typeInJava = "Date";
                        }
                       

                    }
                    else if (typeInJava.Equals("BigDecimal"))
                    {
                        if (!importList.ToString().Contains("import java.math.BigDecimal;"))
                        {
                            importList.AppendLine("import java.math.BigDecimal;");
                        }
                        precision = ", precision = " + NUMBERIC_SCALE;
                    }
                    else if (typeInJava.Equals("Float"))
                    {
                        precision = ", precision = " + NUMBERIC_SCALE;
                    }
                    else if (!DATA_TYPE.ToLower().Contains("text") && typeInJava.Equals("String"))
                    {
                        length = ", length = " + CHARACTER_MAXIMUM_LENGTH;
                    }
                    if(COLUMN_COMMENT.Length != 0)
                    {
                        //生成Field的注释
                        fieldList.AppendLine("    /**");
                        fieldList.Append("     * ");
                        fieldList.AppendLine(COLUMN_COMMENT);
                        fieldList.AppendLine("    **/");
                    }
   
                    fieldList.AppendLine("    private " + typeInJava + " " + COLUMN_NAME + ";");



                    //生成声明
                    /*
                            @Id
                            @Basic
                            @Column(name = "aiId", nullable = false)
                    */
                    StringBuilder annoStr = new StringBuilder();
                    if (isHibernate)
                    {
                        
                        //生成注释
                        if (COLUMN_COMMENT.Length != 0)
                        {
                            fieldList.AppendLine("    /**");
                            fieldList.Append("     * ");
                            fieldList.AppendLine(COLUMN_COMMENT);
                            fieldList.AppendLine("    **/");
                        }
                        message("生成声明");
                        if (COLUMN_KEY.Equals("PRI"))
                        {
                            annoStr.AppendLine("    @Id");
                            if (EXTRA.Equals("auto_increment"))
                            {
                                annoStr.AppendLine("    @GeneratedValue(strategy = GenerationType.AUTO)");
                            }
                        }
                        else
                        {
                            annoStr.AppendLine("    @Basic");
                        }
                        String nullable = EXTRA.Equals("YES") ? "true" : "false";
                        //@Column(name = "unitConvert", nullable = true, precision = 6, length = 20)
                        //
                        annoStr.Append("    @Column(name = \"" + COLUMN_NAME + "\", nullable = " + nullable + length + precision + ")");

                        //生成getSet方法
                        message("生成getSet方法");
                        String getMethodName = this.getGetMethodName(COLUMN_NAME);
                        String setMethodName = this.getSetMethodName(COLUMN_NAME);

                        bean.AppendLine(annoStr.ToString());
                        bean.AppendLine("    public " + typeInJava + " " + getMethodName + "()");
                        bean.AppendLine("    {");
                        bean.AppendLine("        return " + COLUMN_NAME + ";");
                        bean.AppendLine("    }");
                        bean.AppendLine("    ");
                        bean.AppendLine("    public void " + setMethodName + "(" + typeInJava + " " + COLUMN_NAME + ")");
                        bean.AppendLine("    {");
                        bean.AppendLine("        this." + COLUMN_NAME + " = " + COLUMN_NAME + ";");
                        bean.AppendLine("    }");
                        bean.AppendLine("    ");
                    }
                    
                }
                message("【" + tableName + "】生成完成");

                templet = templet.Replace("${import}", importList.ToString());
                templet = templet.Replace("${description}", tableName + "  Bean");
                templet = templet.Replace("${date}", DateTime.Now.ToString());
                templet = templet.Replace("${table_name}", tableName.ToString());
                templet = templet.Replace("${bean_class_name}", beanClassName.ToString());
                if (fieldList.ToString().Length == 0)
                {
                    throw new Exception("生成错误");
                }
                templet = templet.Replace("${fieldList}", fieldList.ToString());
                templet = templet.Replace("${bean}", bean.ToString());
                String exportPath = txtPath.Text.Trim();
                if (!exportPath.EndsWith("\\"))
                {
                    exportPath += "\\";
                }
                exportPath = exportPath + beanClassName + ".java";
                writeToFile(exportPath, templet.ToString());
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                pbMain.Value++;
            }
        }

       

        private void writeToFile(String path, String content)
        {
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
            else
            {
                File.Delete(path);
            }
            Thread.Sleep(100);
            var utf8WithoutBom = new System.Text.UTF8Encoding(false);
            using (StreamWriter sw = new StreamWriter(path, false, utf8WithoutBom))
            {
                sw.WriteLine(content);
                sw.Flush();
                sw.Close();
            }
        }

        private void message(String message)
        {
            DateTime now = DateTime.Now;
            StringBuilder builder = new StringBuilder();
            builder.Append(now);
            builder.Append(" ");
            builder.AppendLine(message);
            txtLog.AppendText(builder.ToString());
        }

        private String fixString(String str)
        {
            String[] arr = str.Split(new String[] { "_" }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < arr.Length; i++)
            {
                String s = arr[i];
                if (i == 0)
                {
                    result.Append(s);
                }
                else
                {
                    result.Append(upperFirst(s));
                }
            }
            return result.ToString();
        }

        private String getGetMethodName(String field)
        {
            String str = fixString(field);
            return "get" + upperFirst(str);
        }

        private String getSetMethodName(String field)
        {
            String str = fixString(field);
            return "set" + upperFirst(str);
        }

        private String upperFirst(String str)
        {
            String regex = "[a-z]*";
            String first = Regex.Match(str, regex).Value;
            if (first.Length == 1)
            {
                return str;
            }
            else if (str.Length == 1)
            {
                return str.ToUpper();
            }
            else if (str.Length == 0)
            {
                return str;
            }
            else
            {
                return str.Substring(0, 1).ToUpper() + str.Substring(1);
            }
        }

        private String toString(Object value)
        {
            if (value != null)
            {
                return value.ToString();
            }
            else
            {
                return "";
            }
        }

        private void CreateBeanForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.createBeanForm = null;
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            try
            {
                String exportPath = txtPath.Text.Trim();
                if (exportPath.Length != 0)
                {
                    System.Diagnostics.Process.Start("Explorer.exe", exportPath);
                    //System.Diagnostics.Process.Start("Explorer.exe", "C:\\window");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }


        }

        private void btnOpenFieldSetting_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("notepad.exe", fieldSetting);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            try
            {
                reloadSettingDT();
                MessageBox.Show("加载成功");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void raMybatis_CheckedChanged(object sender, EventArgs e)
        {
            isHibernate = !raMybatis.Checked;
            XMLUtil.setValue("isHibernate", isHibernate.ToString());
        }

        private void raHibernate_CheckedChanged(object sender, EventArgs e)
        {
            isHibernate = raHibernate.Checked;
            XMLUtil.setValue("isHibernate", isHibernate.ToString());
        }
    }
}
