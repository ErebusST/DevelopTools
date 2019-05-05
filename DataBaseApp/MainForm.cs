using CreateProject;
using CreateProject.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        Point startPoint = new Point(116, 23);

        public static DataBaseForm dataBaseForm;

        public static FormatSqlForm formatSqlForm;
        public static DESTestForm desTestForm;
        public static BosTestForm bosTestForm;
        public static CreateBeanForm createBeanForm;
        public static BuilderCheckCodeForm builderCheckCodeForm;
        public static BuildQuartzConfig buildQuartzConfig;
        public static CreateExcelFunction createExcelFunction;
        public static CreateCodeAndView createCodeAndView;
        private void miDataBase_Click(object sender, EventArgs e)
        {
            InitForm(ref dataBaseForm);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            String workType = XMLUtil.getValue("WorkType");
            this.lbWorkType.Text = workType.Equals("Net") ? "For .Net" : "For Java";
        }

        private void InitForm<T>(ref T form) where T : Form, new()
        {
            if (form == null)
            {
                form = new T();
                form.MdiParent = this;

                form.StartPosition = FormStartPosition.CenterParent;
            }
            form.Show();
            form.WindowState = FormWindowState.Normal;
            form.Location = startPoint;
        }

        private void lbWorkType_Click(object sender, EventArgs e)
        {
            if (lbWorkType.Text.Equals("For .Net"))
            {
                lbWorkType.Text = "For Java";
            }
            else
            {
                lbWorkType.Text = "For .Net";
            }
            XMLUtil.setValue("WorkType", lbWorkType.Text.Equals("For .Net") ? "Net" : "Java");
        }

        private void miSqlFormat_Click(object sender, EventArgs e)
        {
            InitForm(ref formatSqlForm);
        }

        private void miDesTools_Click(object sender, EventArgs e)
        {
            try
            {
                if (DESTestForm.CheckJreInstalled())
                {
                    InitForm(ref desTestForm);
                }
            }
            catch (Exception ex)
            {
                DialogResult result = MessageBox.Show(ex.Message + "\r\n    是否现在安装？", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (result.Equals(DialogResult.Yes))
                {
                    String jre = System.Configuration.ConfigurationManager.AppSettings["jre"].Trim();
                    if (jre.Length == 0)
                    {
                        MessageBox.Show("请在程序配置文件中配置根目录中的Jre文件名");
                    }
                    jre = Application.StartupPath + "\\" + jre;
                    if (!File.Exists(jre))
                    {
                        MessageBox.Show("路径[" + jre + "]不存在！");
                    }
                    else
                    {
                        try
                        {
                            Process.Start(jre).WaitForExit();
                            MessageBox.Show("Jre安装完成，请重启程序");
                            this.Dispose();
                        }
                        catch (Exception ee)
                        {

                            MessageBox.Show(ee.Message);
                        }
                        
                    }

                    //miDesTools_Click(sender, e);
                }
            }


        }

        private void miBosTools_Click(object sender, EventArgs e)
        {
            String accessKey = XMLUtil.getValue("AccessKey");
            String secretKey = XMLUtil.getValue("SecretKey");
            String endPoint = XMLUtil.getValue("EndPoint");
            if (accessKey.Length == 0 || secretKey.Length == 0 || endPoint.Length == 0)
            {
                BosSettingForm bosSettingForm = new BosSettingForm();
                DialogResult result = bosSettingForm.ShowDialog();
                if (result.Equals(DialogResult.OK))
                {
                    InitForm(ref bosTestForm);
                }
            }
            else
            {
                InitForm(ref bosTestForm);
            }

        }

        public static CopyRightForm copyRightForm;
        private void 版权所有ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitForm(ref copyRightForm);
        }

        private void miCreateBean_Click(object sender, EventArgs e)
        {
            //createBeanForm
            InitForm(ref createBeanForm);
        }

        private void btnBuilderCheckCode_Click(object sender, EventArgs e)
        {
            InitForm(ref builderCheckCodeForm);
        }

        private void miBuildQuartzConfig_Click(object sender, EventArgs e)
        {
            //buildQuartzConfig
            InitForm(ref buildQuartzConfig);
        }

        private void miExcelFunctionInsert_Click(object sender, EventArgs e)
        {
            //createExcelFunction
            InitForm(ref createExcelFunction);
        }

        private void 生成前端和后端代码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitForm(ref createCodeAndView);
        }

        private void 生成前后端架构ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitForm(ref )
        }
    }
}
