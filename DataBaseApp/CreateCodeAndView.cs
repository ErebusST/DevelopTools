using CreateProject.Util;
using DataBaseApp.busi;
using DataBaseApp.busi.entity;
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
    public partial class CreateCodeAndView : Form
    {
        public CreateCodeAndView()
        {
            selectedDataBase = XMLUtil.getValue("SelectedDataBase");
            InitializeComponent();
            tbx_baoGuDingBuFen.Text = XMLUtil.getValue("baoGuDingBuFen");
            tbx_gongNengMiaoShu.Text = XMLUtil.getValue("gongNengMiaoShu");
            tbx_boxName.Text = XMLUtil.getValue("boxName");
            tbx_creater.Text = XMLUtil.getValue("creater");
            tbx_leiMingCheng.Text = XMLUtil.getValue("leiMingCheng");          
            tbx_CodePath.Text = XMLUtil.getValue("CodePath");
            tbx_tableName.Text = XMLUtil.getValue("tableName");
            tbx_templateUrl.Text = XMLUtil.getValue("tbx_templateUrl");
        }

        private String connStr = "";
        private String dataBaseType = "";
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

        private void CreateBeanForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.createCodeAndView = null;
        }



        private void btnOpenSelectPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            DialogResult result = path.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                this.tbx_CodePath.Text = path.SelectedPath;
            }
        }
        private void btnExportAll_Click(object sender, EventArgs e)
        {
            try
            {
                XMLUtil.setValue("SelectedDataBase", selectedDataBase);
                XMLUtil.setValue("baoGuDingBuFen", tbx_baoGuDingBuFen.Text);
                XMLUtil.setValue("boxName", tbx_boxName.Text);
                XMLUtil.setValue("creater", tbx_creater.Text);
                XMLUtil.setValue("leiMingCheng", tbx_leiMingCheng.Text);
                XMLUtil.setValue("CodePath", tbx_CodePath.Text);
                XMLUtil.setValue("gongNengMiaoShu", tbx_gongNengMiaoShu.Text);
                XMLUtil.setValue("tableName", tbx_tableName.Text);
                XMLUtil.setValue("tbx_templateUrl", tbx_templateUrl.Text);

                if (tbx_baoGuDingBuFen.Text.Length == 0)
                {
                    MessageBox.Show("请输入包固定部分");
                    return;
                }
                if (tbx_boxName.Text.Length == 0)
                {
                    MessageBox.Show("请输入包名称");
                    return;
                }
                if (tbx_creater.Text.Length == 0)
                {
                    MessageBox.Show("请输入创建人");
                    return;
                }
                if (tbx_leiMingCheng.Text.Length == 0)
                {
                    MessageBox.Show("请输入类名称");
                    return;
                }               
                if (tbx_CodePath.Text.Length == 0)
                {
                    MessageBox.Show("请选择路径");
                    return;
                }
                if (tbx_gongNengMiaoShu.Text.Length == 0)
                {
                    MessageBox.Show("请输入功能描述");
                    return;
                }
                if (tbx_tableName.Text.Length == 0)
                {
                    MessageBox.Show("请输入表名称");
                    return;
                }
                if (tbx_templateUrl.Text.Length == 0)
                {
                    MessageBox.Show("请输入前台文件夹名");
                    return;
                }

                string ziDuan = tbx_ziDuan.Text;
                if (String.IsNullOrEmpty(ziDuan))
                {
                    MessageBox.Show("字段必填");
                    return;
                }
                string keyName = "";
                List<ZiDuanEntity> zbZDDuanList = new List<ZiDuanEntity>();
                string[] ziDuans = ziDuan.Split(new Char[] { '\t' });
                try
                {
                    for (int i = 8; i < ziDuans.Length; i = i + 7)
                    {
                        zbZDDuanList.Add(new ZiDuanEntity(ziDuans[i], ziDuans[i + 1], ziDuans[i - 1].Split(new Char[] { '\n' })[1]));
                        if (i == 8)
                        {
                            keyName = ziDuans[i];
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("主表字段类型有问题或格式不正确，请检查");
                }

                CodeAndViewFactory.CreateBackgroundCode(zbZDDuanList, tbx_CodePath.Text.Trim(), tbx_gongNengMiaoShu.Text.Trim(), tbx_creater.Text.Trim(), tbx_boxName.Text.Trim()
                     , tbx_tableName.Text.Trim(), tbx_baoGuDingBuFen.Text.Trim(), tbx_leiMingCheng.Text.Trim(), keyName, tbx_templateUrl.Text.Trim(),"");
                MessageBox.Show("生成成功");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbx_ziDuan.Text = "请把model全部粘贴到这里";
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            try
            {
                String exportPath = tbx_CodePath.Text.Trim();
                if (exportPath.Length != 0)
                {
                    System.Diagnostics.Process.Start("Explorer.exe", exportPath);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
