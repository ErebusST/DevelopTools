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
    public partial class InputRangeForm : Form
    {
        public InputRangeForm()
        {
            InitializeComponent();
        }

        public InputRangeForm(String fieldName)
        {
            InitializeComponent();
            this.fieldName = fieldName;
        }

        String fieldName;
        String range;

        public String Range
        {
            get { return range; }
        }
        private void InputRangeForm_Load(object sender, EventArgs e)
        {
            txtField.Enabled = true;
            txtField.Text = fieldName;
        }

        private void btnCannel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                String rangeStr = txtRange.Text.Replace("\r\n", "^").Trim();
                if (rangeStr.Length == 0)
                {
                    MessageBox.Show("请输入验证范围!");
                    return;
                }
                String[] rangeStrArr = rangeStr.Split(new char[] { '^' }, StringSplitOptions.RemoveEmptyEntries);
                List<String> rangeList = new List<string>();
                rangeStr = "";
                foreach (var item in rangeStrArr)
                {
                    if (!rangeList.Contains(item.Trim()))
                    {
                        rangeList.Add(item.Trim());
                        rangeStr += item.Trim() + "^";
                    }
                }
                this.range = rangeStr;
                this.DialogResult = DialogResult.Yes;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
