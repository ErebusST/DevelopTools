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

namespace CreateProject
{
    public partial class ReadForm : Form
    {
        public ReadForm()
        {
            InitializeComponent();
        }

        private String _key = "";
        private String _SelectedBucket = "";

        public String Key
        {
            set
            {
                _key = value;
            }
        }

        public String SelectedBucket
        {
            set { _SelectedBucket = value; }
        }
        

        private void ReadForm_Load(object sender, EventArgs e)
        {
            BosUtil bosUtil = new BosUtil();
            String str = bosUtil.readTxtFile(_SelectedBucket, _key);
            txtContent.Text = str;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
