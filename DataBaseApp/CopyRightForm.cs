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
    public partial class CopyRightForm : Form
    {
        public CopyRightForm()
        {
            InitializeComponent();
        }

        private void CopyRightForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.copyRightForm = null;
        }
    }
}
