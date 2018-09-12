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
    public partial class SetExcludedFiledForm : Form
    {
        public SetExcludedFiledForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String[] insert = txtExcludedFiledForInsert.Lines;

            string result = "";
            foreach (var item in insert)
            {
                if(item.Trim().Length == 0)
                {
                    continue;
                }
                result += "," + item;
            }
            XMLUtil.setValue("ExcludedInsert", result);
            XMLUtil.setValue("InsertSetting",txtExcludedFiledForInsert.Text.Trim());

            String[] update = txtExcludedFiledForUpdate.Lines;
            result = "";
            foreach (var item in update)
            {
                if (item.Trim().Length == 0)
                {
                    continue;
                }
                result += "," + item;
            }
            XMLUtil.setValue("ExcludedUpdate", result);
            XMLUtil.setValue("UpdateSetting", txtExcludedFiledForUpdate.Text.Trim());
            this.DialogResult = DialogResult.OK;
        }

        private void SetExcludedFiledForm_Load(object sender, EventArgs e)
        {
            try
            {
                txtExcludedFiledForInsert.Text = XMLUtil.getValue("InsertSetting");
                txtExcludedFiledForUpdate.Text = XMLUtil.getValue("UpdateSetting");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
