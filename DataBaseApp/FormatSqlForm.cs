using CreateProject.Util;
using DataBaseApp;
using Newtonsoft.Json.Linq;
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

namespace CreateProject
{
    public partial class FormatSqlForm : Form
    {
        public FormatSqlForm()
        {
            InitializeComponent();
        }


        private void FormatSqllForm_Load(object sender, EventArgs e)
        {
            String formatType = XMLUtil.getValue("WorkType");//NET,JAVA
            if (XMLUtil.getValue("FormatSqlHeight").Length == 0)
            {
                XMLUtil.setValue("FormatSqlHeight", "220");
            }

            lbState.Text = "";
            txtSql.Text = XMLUtil.getInnerText("LastEditSql").Replace("\n", "\r\n");

            raHibernate.Checked = XMLUtil.getValue("isHibernate").Equals("true");
            raMyBatis.Checked = !XMLUtil.getValue("isHibernate").Equals("true");
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtSql.Clear();
        }



        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (txtSql.Text.Trim().Length != 0)
            {
                Clipboard.SetDataObject(txtSql.Text);
                lbState.Text = "复制成功！";
            }
            else
            {
                lbState.Text = "待处理文本为空！";
            }

        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            String pasteStr = Clipboard.GetText();
            if (pasteStr.Trim().Length != 0)
            {
                txtSql.Clear();
                txtSql.Text = pasteStr;
                lbState.Text = "粘贴成功！";

            }
            else
            {
                lbState.Text = "粘贴板中数据为空！";
            }
        }
        String formatType = XMLUtil.getValue("WorkType");
        private String getRegex()
        {
            String regex = ":[a-zA-Z]+\\w*";

            if (formatType.Equals("Net"))
            {
                regex = "@[a-zA-Z]+\\w*";
            }
            return regex;
        }

        /// <summary>
        /// 适配MyBatis
        /// </summary>
        /// <param name="parameterName"></param>
        /// <returns></returns>
        private String fomartParameterForMyBatis(String parameterName)
        {
            parameterName = parameterName.Substring(1);
            return "#{" + parameterName + "}";
        }

        /// <summary>
        /// 从MyBatis的参数格式还原成对应的数据库格式
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        private String restoreParameterForMyBatis(String parameter)
        {
            parameter = parameter.Replace("#", "").Replace("{", "").Replace("}", "").Trim();
            if (!formatType.Equals("Net"))
            {
                return ":" + parameter;
            }
            else
            {
                return "@" + parameter;
            }
        }


        private void btnConvert_Click(object sender, EventArgs e)
        {
            String regex = getRegex();
            if (txtSql.Text.Trim().Length == 0)
            {
                lbState.Text = "待处理文本为空！";
                return;
            }

            String top = "StringBuilder sbSql = new StringBuilder();";
            String start = "sbSql.Append(\" ";
            String end = " \"); ";

            String bottom = "";// "return sbSql.toString();";
            StringBuilder builder = new StringBuilder();
            if (!formatType.Equals("Net"))
            {
                top = "StringBuilder sbSql = new StringBuilder();";
                start = "sbSql.append(\" ";
            }
            String[] lines = txtSql.Lines;
            String str = txtSql.Text;
            if (formatType.Equals("Net"))
            {
                str = str.Replace(":", "@");
            }
            else
            {
                str = str.Replace("@", ":");
            }

            
            builder.AppendLine(top);
            MatchCollection matches = Regex.Matches(str, regex);

            foreach (String line in lines)
            {
                if (line.Trim().Length == 0)
                {
                    continue;
                }
                String lineTemp = line.TrimEnd();
                if (formatType.Equals("Net"))
                {
                    lineTemp = lineTemp.Replace(":", "@");
                }
                else
                {
                    lineTemp = lineTemp.Replace("@", ":");
                }

                builder.AppendLine(start + lineTemp + end);
            }
            builder.AppendLine(bottom);

            if (raMyBatis.Checked)
            {

                if (matches.Count > 0)
                {
                    foreach (Match match in matches)
                    {
                        String para = match.Value.Trim();
                        String paraForMyBatis = fomartParameterForMyBatis(para);
                        builder.Replace(para, paraForMyBatis);

                    }
                }
                builder.AppendLine("return sbSql.toString();");
               
            }
            else
            {

                StringBuilder paraBuilder = new StringBuilder();
                if (matches.Count > 0)
                {
                    if (formatType.Equals("Net"))
                    {
                        paraBuilder.AppendLine("List<SqlParameter> parametersList = new List<SqlParameter>();");
                    }
                    else
                    {
                        paraBuilder.AppendLine("Map<String, Object> parameters = new HashMap();");
                    }

                    List<String> paras = new List<string>();

                    foreach (Match match in matches)
                    {
                        String para = match.Value.Trim();

                        if (para.Length > 1)
                        {
                            para = para.Substring(1);
                        }
                        if (paras.Contains(para))
                        {
                            continue;
                        }



                        String paraTemp = DataBaseForm.formatPara(para);
                        if (formatType.Equals("Net"))
                        {
                            paraBuilder.AppendLine("parametersList.Add(new SqlParameter(\"@" + para + "\", entity." + paraTemp + "));");
                        }
                        else
                        {
                            paraBuilder.AppendLine("parameters.put(\"" + para + "\", entity.get" + paraTemp + "());");
                        }
                        paras.Add(para);
                    }
                    if (formatType.Equals("Net"))
                    {
                        paraBuilder.AppendLine("SqlParameter[] parameters = parametersList.ToArray();");
                    }
                }
                builder.AppendLine();
                builder.AppendLine(paraBuilder.ToString().Trim());
            }



            //paraBuilder.ToString().Split("")


            txtSql.Text = builder.ToString();

            lbState.Text = "封装成功！";
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            String str = txtSql.Text;
            if (str.Length == 0)
            {
                lbState.Text = "待处理文本为空！";
                return;
            }
            String top = "StringBuilder sbSql = new StringBuilder();";
            String startNet = "sbSql.Append(\"";
            String startJava = "sbSql.append(\"";
            String end = " \"); ";
            //String bottom = "";// "return sbSql.toString();";
            StringBuilder builder = new StringBuilder();

            str = str.Replace(top.Trim(), "").Replace(startNet.Trim(), "").Replace(startJava.Trim(), "").Replace(end.Trim(), "");
            txtSql.Text = str.Trim();
            foreach (String line in txtSql.Lines)
            {
                if (line.Trim().Length == 0)
                {
                    continue;
                }
                if (line.Trim().StartsWith("Map<String, Object> parameters = new HashMap();") || line.Trim().StartsWith("List<SqlParameter> parametersList = new List<SqlParameter>();"))
                {
                    break;
                }
                builder.AppendLine(line);
            }

            if (raMyBatis.Checked)
            {
                String regex = "#{.+}\\w*";
                MatchCollection matches = Regex.Matches(str, regex);
                foreach (Match match in matches)
                {
                    String paraInMyBatis = match.Value.Trim();
                    String parameter = restoreParameterForMyBatis(paraInMyBatis);
                    builder.Replace(paraInMyBatis, parameter);
                }
                String result = Regex.Replace(builder.ToString(), "return.+$", "");
                builder = new StringBuilder(result);
            }
            txtSql.Text = builder.ToString().Trim();
            lbState.Text = "解封成功！";
        }

        private void txtSql_KeyDown(object sender, KeyEventArgs e)
        {

            // Console.WriteLine(e.Control + e.KeyCode + "");

        }

        private void txtSql_TextChanged(object sender, EventArgs e)
        {
            String txt = txtSql.Text;
            XMLUtil.innerText("LastEditSql", txt);
        }

        private void txtSql_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                txtSql.SelectAll();
            }
            else if (e.Control && e.KeyCode == Keys.C)
            {
                String selectedText = txtSql.SelectedText.Trim();
                if (selectedText.Length == 0)
                {
                    selectedText = txtSql.Text.Trim();
                }
                if (selectedText.Length != 0)
                {
                    Clipboard.SetDataObject(selectedText);
                    lbState.Text = "复制成功！";
                }
                else
                {
                    lbState.Text = "待处理文本为空！";
                }
            }
            else if (e.Control && e.KeyCode == Keys.V)
            {
                String pasteStr = Clipboard.GetText();
                if (pasteStr.Trim().Length != 0)
                {
                    txtSql.Clear();
                    txtSql.Text = pasteStr;
                    lbState.Text = "粘贴成功！";
                }
                else
                {
                    lbState.Text = "粘贴板中数据为空！";
                }
            }
        }

        private void FormatSqlForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.formatSqlForm = null;
        }

        private void btnPinJie_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder builder = new StringBuilder();
                String[] lines = txtSql.Lines;
                for (int i = 0; i < lines.Length; i++)
                {
                    String line = lines[i].Trim();
                    builder.Append(line);
                    if (i != lines.Length - 1)
                    {
                        builder.Append(",").AppendLine();
                    }
                }
                txtSql.Text = builder.ToString().Trim();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void raHibernate_CheckedChanged(object sender, EventArgs e)
        {
            XMLUtil.setValue("isHibernate", raHibernate.Checked ? "true" : "false");
        }

    }
}
