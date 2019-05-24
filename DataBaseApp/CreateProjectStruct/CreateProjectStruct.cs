using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DataBaseApp
{
    public partial class CreateProjectStruct : Form
    {
        public CreateProjectStruct()
        {
            InitializeComponent();
            txtPath.Text = @"Y:\Works\Workspaces\平乡县数据平台\03_docuemnts\功能树及权限设置_final.xlsx";
        }

        private void CreateProjectStruct_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.createProjectStruct = null;
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            DialogResult result = fileDialog.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                txtPath.Text = fileDialog.FileName;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                String filePath = txtPath.Text.Trim();
                var webPath = txtWebPath.Text.Trim();
                var apiPath = txtApiPath.Text.Trim();
                var savePath = txtSavePath.Text.Trim();
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("请选择模板文件!");
                    return;
                }
                if (chkWeb.Checked && webPath.Length == 0)
                {

                    MessageBox.Show("将构建前端文件，请填写前端路径!");
                    return;
                }

                if (chkApi.Checked && apiPath.Length == 0)
                {

                    MessageBox.Show("将构建后端文件，请填写后端路径!");
                    return;
                }
                DataTable config = readConfig();
                createFiles(config);

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void createFiles(DataTable config)
        {
            var savePath = txtSavePath.Text.Trim();
            if (Directory.Exists(savePath))
            {
                Directory.Delete(savePath);
            }
            Directory.CreateDirectory(savePath);
            if (chkWeb.Checked)
            {
                createWebFiles(config);
            }
        }

        private DataTable readConfig()
        {
            try
            {
                var path = txtPath.Text.Trim();
                Aspose.Cells.Workbook excel = new Aspose.Cells.Workbook();
                excel.Open(path, Aspose.Cells.FileFormatType.Excel2007Xlsx);
                Aspose.Cells.Worksheet sheet = excel.Worksheets[0];
                int startRow = 1;//起始行
                int endRow = sheet.Cells.MaxDataRow; //结束行, 
                DataTable data = new DataTable();
                data.Columns.Add("nodeNumber");
                data.Columns.Add("nodeName");
                data.Columns.Add("url");
                data.Columns.Add("parentPath");
                data.Columns.Add("fileName");
                data.Columns.Add("permissionCode");

                for (int i = startRow; i <= endRow; i++)
                {
                    var father = ConvertObjectToString(sheet.Cells[i, 1].Value);
                    if (father.Equals("-1"))
                    {
                        continue;
                    }
                    DataRow row = data.NewRow();
                    row["nodeNumber"] = ConvertObjectToString(sheet.Cells[i, 0].Value);
                    row["nodeName"] = ConvertObjectToString(sheet.Cells[i, 2].Value);
                    var url = ConvertObjectToString(sheet.Cells[i, 6].Value);
                    row["url"] = url;
                    var parentPath = url.Substring(0, url.LastIndexOf("/"));
                    row["parentPath"] = parentPath;
                    var fileName = url.Substring(url.LastIndexOf("/") + 1);
                    row["fileName"] = fileName;
                    row["permissionCode"] = ConvertObjectToString(sheet.Cells[i, 9].Value);
                    data.Rows.Add(row);
                }
                return data;
            }
            catch (Exception)
            {

                throw;
            }
        }


        private void createWebFiles(DataTable config)
        {
            var savePath = txtSavePath.Text.Trim();

            savePath = savePath + "/web/";

            Directory.CreateDirectory(savePath);
            DataRowCollection rows = config.Rows;

            String html = readTemplet(angularHtml);
            String controller = readTemplet(angularController);

            foreach (DataRow row in rows)
            {
                String nodeNumber = ConvertObjectToString(row["nodeNumber"]);
                String nodeName = ConvertObjectToString(row["nodeName"]);
                String parentPath = ConvertObjectToString(row["parentPath"]);
                String fileName = ConvertObjectToString(row["fileName"]);
                String url = ConvertObjectToString(row["url"]);
                DateTime now = DateTime.Now;

                if (!Directory.Exists(savePath + parentPath))
                {
                    Directory.CreateDirectory(savePath + parentPath);
                }
                //创建List 页面 以及Controller
                String listPageName = fileName + "List";
                var content = html.Replace("${Date}", now.ToShortDateString()).Replace("${Description}", nodeName + " 浏览页");
                writeToFile(savePath + parentPath + @"\" + listPageName, content);

                String listControllerName = fileName + "Controller";
                content = controller.Replace("${Date}", now.ToShortDateString()).Replace("${Description}", nodeName + " 浏览页")
                   .Replace("${Url}", url).Replace("${fileName}", fileName).Replace("${parentPath}", parentPath)
                   .Replace("${Controller}", listControllerName);
                //创建Add 页面 以及 Controller
            }

        }

        String angularHtml = Application.StartupPath + @"\CreateProjectStruct\template\angular.html";
        String angularController = Application.StartupPath + @"\CreateProjectStruct\template\angular.temp";
        String javaController = Application.StartupPath + @"\CreateProjectStruct\template\angular.html";
        String javaService = Application.StartupPath + @"\CreateProjectStruct\template\angular.html";
        String javaServiceDao = Application.StartupPath + @"\CreateProjectStruct\template\angular.html";

        private String readTemplet(String path)
        {
            try
            {
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


        private string ConvertObjectToString(object value)
        {
            try
            {
                if (value != null)
                {
                    return value.ToString().Trim();
                }
            }
            catch { }
            return "";
        }
    }
}
