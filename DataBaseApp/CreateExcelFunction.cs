using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseApp
{
    public partial class CreateExcelFunction : Form
    {
        public CreateExcelFunction()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtContent.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void CreateExcelFunction_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.createExcelFunction = null;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                String regex = "^[A-Z]+$";
                String startIndex = txtStartIndex.Text.Trim().ToUpper();
                String endIndex = txtEndIndex.Text.Trim().ToUpper();

                if (startIndex.Length == 0)
                {
                    MessageBox.Show("请输入开始列");
                    txtStartIndex.Focus();
                    return;
                }
                if (endIndex.Length == 0)
                {
                    MessageBox.Show("请输入结束列");
                    txtEndIndex.Focus();
                    return;
                }

                if (!Regex.IsMatch(startIndex, regex))
                {
                    MessageBox.Show("开始列只能包含字母");
                    txtStartIndex.Focus();
                    return;
                }

                if (!Regex.IsMatch(endIndex, regex))
                {
                    MessageBox.Show("结束列只能包含字母");
                    txtEndIndex.Focus();
                    return;
                }


                int startCount = countValue(startIndex);
                int endCount = countValue(endIndex);

                if (startCount >= endCount)
                {
                    MessageBox.Show("结束列必须在开始列之后");
                    txtStartIndex.Focus();
                    return;
                }

                String temp = "";
                int index = indexList.IndexOf(startIndex);

                while (temp != endIndex)
                {
                    temp += indexList[index];
                    index++;
                    if (index == indexList.Count)
                    {
                        index = 0;
                        temp = indexList[0];
                    }
                }
                String s = "";
            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message);
            }
        }

        private int countValue(String str)
        {
            char[] chars = str.ToCharArray();
            int count = 0;
            foreach (var item in chars)
            {
                String temp = item.ToString();
                int index = indexList.IndexOf(temp);
                count += index;
            }
            return count;
        }

        List<String> indexList = new List<string>();
        private void CreateExcelFunction_Load(object sender, EventArgs e)
        {
            indexList.Add("A");
            indexList.Add("B");
            indexList.Add("C");
            indexList.Add("D");
            indexList.Add("E");
            indexList.Add("F");
            indexList.Add("G");
            indexList.Add("H");
            indexList.Add("I");
            indexList.Add("J");
            indexList.Add("K");
            indexList.Add("L");
            indexList.Add("M");
            indexList.Add("N");
            indexList.Add("O");
            indexList.Add("P");
            indexList.Add("Q");
            indexList.Add("R");
            indexList.Add("S");
            indexList.Add("T");
            indexList.Add("U");
            indexList.Add("V");
            indexList.Add("W");
            indexList.Add("X");
            indexList.Add("Y");
            indexList.Add("Z");
        }
    }
}
