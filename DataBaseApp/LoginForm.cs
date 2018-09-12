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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            String userName = txtUserName.Text.Trim();
            if (userName.Length == 0)
            {
                MessageBox.Show("请输入用户名");
                txtUserName.Focus();
                return;
            }
            if (!radJava.Checked && !radNet.Checked)
            {
                MessageBox.Show("请选择类型");
                return;
            }
            XMLUtil.setValue("UserName",txtUserName.Text.Trim());
            if (radNet.Checked)
            {
                XMLUtil.setValue("WorkType", "Net");
            }
            else
            {
                XMLUtil.setValue("WorkType", "Java");
            }
            this.DialogResult = DialogResult.Yes;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            String userName = XMLUtil.getValue("UserName");
            String workType = XMLUtil.getValue("WorkType");
            txtUserName.Text = userName;
            if (workType.Equals("Net"))
            {
                radNet.Checked = true;
            }
            else if (workType.Equals("Java"))
            {
                radJava.Checked = true;
            }
        }
    }
}
