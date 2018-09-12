using BaiduBce.Services.Bos;
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
    public partial class BosSettingForm : Form
    {
        public BosSettingForm()
        {
            InitializeComponent();
        }

        private void BosSettingForm_Load(object sender, EventArgs e)
        {
            String accessKey = XMLUtil.getValue("AccessKey");
            String secretKey = XMLUtil.getValue("SecretKey");
            String endPoint = XMLUtil.getValue("EndPoint");
            txtAccessKey.Text = accessKey;
            txtSecretKey.Text = secretKey;
            txtEndPoint.Text = endPoint;
        }

        private void btnCannel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                String accessKey = txtAccessKey.Text.Trim();
                String secretKey = txtSecretKey.Text.Trim();
                String endPoint = txtEndPoint.Text.Trim();
                BosUtil bosUtil = new BosUtil();
                bosUtil.AccessKey = accessKey;
                bosUtil.SecretKey = secretKey;
                bosUtil.EndPoint = endPoint;
                BosClient bosClient = bosUtil.GenerateBosClient();
                bosClient.ListBuckets();
                XMLUtil.setValue("AccessKey", accessKey);
                XMLUtil.setValue("SecretKey", secretKey);
                XMLUtil.setValue("EndPoint", endPoint);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
