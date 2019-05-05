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
    public partial class UploadForm : Form
    {
        public UploadForm()
        {
            InitializeComponent();
        }

        private String _BucketName;
        private String _SelectedPath;
        public String BucketName
        {
            set { _BucketName = value; }
        }

        public String SelectedPath
        {
            set { _SelectedPath = value; }
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else e.Effect = DragDropEffects.None;
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            string path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            label1.Text = path;

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            String filePath = label1.Text;

            ReadForm readForm = new ReadForm();
            BosUtil bosUtil = new BosUtil();
            //Boolean isOk = bosUtil.uploadFile(filePath, _BucketName, _SelectedPath);

            Boolean isOk = bosUtil.uploadFile(filePath, _BucketName, _SelectedPath, toolStripProgressBar1);
            if (isOk)
            {
                MessageBox.Show("OK！");
            }
        }
    }
}
