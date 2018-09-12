using CreateProject.Util;
using DataBaseApp;
using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace CreateProject
{
    public partial class DESTestForm : Form
    {
        public DESTestForm()
        {
            InitializeComponent();
        }

        private void btnCtreateKey_Click(object sender, EventArgs e)
        {
            txtKey.Text = GenerateCheckCode(32);
        }

        private void btnCreateIV_Click(object sender, EventArgs e)
        {
            txtIV.Text = GenerateCheckCode(8);
            DESCryptoServiceProvider _desCryptProvider = new DESCryptoServiceProvider();
        }

        /// 
        /// 生成随机字母字符串(数字字母混和)
        /// 
        /// 待生成的位数
        /// 生成的字母字符串
        private string GenerateCheckCode(int codeCount)
        {
            string str = string.Empty;
            long num2 = DateTime.Now.Ticks;
            Random random = new Random((int)(((ulong)num2) & 0xffffffffL));
            for (int i = 0; i < codeCount; i++)
            {
                char ch;
                int num = random.Next();
                if ((num % 2) == 0)
                {
                    ch = (char)(0x30 + ((ushort)(num % 10)));
                }
                else
                {
                    ch = (char)(0x41 + ((ushort)(num % 0x1a)));
                }
                str = str + ch.ToString();
            }
            return str;
        }


        private void btnJiaMi_Click(object sender, EventArgs e)
        {
            try
            {
                label6.Text = txtStr.Text.Length.ToString();
                try
                {
                    String type = "encrypt";
                    String str = DesOperation(txtStr.Text, type);
                    if (str.StartsWith(type + " Failed:"))
                    {
                        MessageBox.Show(str + "\r\n请检查key、iv是否正确!");
                    }
                    else
                    {
                        txtJMStr.Text = str;
                        label8.Text = txtJMStr.Text.Length.ToString();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                label7.Text = txtJMStr.Text.Length.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void btnJieMi_Click(object sender, EventArgs e)
        {
            try
            {
                String type = "decrypt";
                String str = DesOperation(txtJMStr.Text, type);
                if (str.StartsWith(type + " Failed:"))
                {
                    MessageBox.Show(str + "\r\n请检查key、iv和加密后字符串是否正确!");
                }
                else
                {
                    txtJieMStr.Text = str;
                    label8.Text = txtJieMStr.Text.Length.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            int a = 0;
            byte[] keyByteArr = Encoding.Default.GetBytes(txtKey.Text);
            foreach (byte b in keyByteArr)
            {
                a = a + b;
            }

            int c = 0;
            byte[] ivByteArr = Encoding.Default.GetBytes(txtIV.Text);
            foreach (byte b in ivByteArr)
            {
                c = c + b;
            }
            if (txtStr.Text.Equals(txtJieMStr.Text))
            {
                MessageBox.Show("same");
            }
            else
            {
                MessageBox.Show("different");
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (txtJMStr.Text != "")
            {
                Clipboard.SetDataObject(txtJMStr.Text);
                label7.Text = "复制成功";
            }
        }

        private void DESTestForm_Load(object sender, EventArgs e)
        {
            try
            {
                label6.Text = "";
                label7.Text = "";
                label8.Text = "";
                //if (!CheckJreInstalled())
                //{
                //    MessageBox.Show("本功能需要安装Jre环境");
                //    this.DialogResult = DialogResult.No;
                //}
                String key = XMLUtil.getValue("Key");
                String iv = XMLUtil.getValue("Iv");
                txtKey.Text = key;
                txtIV.Text = iv;
            }
            catch (Exception ex)
            {
                String startPath = Application.StartupPath;
                MessageBox.Show(ex.Message);
                this.DialogResult = DialogResult.No;


            }

        }

        private String DesOperation(String str, String operationType)
        {
            try
            {
                String keyTemp = "2PJH020ZL8L00PHNX8Z4PZB4468FL880";
                String ivTemp = "8BRZ8R64";
                String key = txtKey.Text.Trim();
                String iv = txtIV.Text.Trim();
                if (key.Length != keyTemp.Length)
                {
                    throw new Exception("key 不正确");
                }
                if (iv.Length != ivTemp.Length)
                {
                    throw new Exception("iv 不正确");
                }


                var jarPath = Application.StartupPath + "\\jar\\DesUtil.jar";
                String result = "";
                if (File.Exists(jarPath))
                {
                    StringBuilder command = new StringBuilder();
                    command.Append("java -jar ");
                    command.Append(jarPath).Append(" ");
                    command.Append(str).Append(" ").Append(key).Append(" ").Append(iv).Append(" ").Append(operationType);
                    //Process p = new Process();
                    //p.startInfo.FileName = "cmd.exe";
                    //p.StartInfo.FileName = path.ToString();
                    //p.Start();
                    //String result = p.StandardOutput.ReadToEnd();
                    textBox1.Text = command.ToString();
                    result = Execute(command.ToString(), 0).Trim();
                }
                else
                {
                    throw new Exception("路径[" + jarPath + "]不存在!");
                }

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private string Execute(string command, int seconds)
        {
            string output = ""; //输出字符串  
            if (command != null && !command.Equals(""))
            {
                Process process = new Process();//创建进程对象  
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "cmd.exe";//设定需要执行的命令  
                startInfo.Arguments = "/C " + command;//“/C”表示执行完命令后马上退出  
                startInfo.UseShellExecute = false;//不使用系统外壳程序启动  
                startInfo.RedirectStandardInput = false;//不重定向输入  
                startInfo.RedirectStandardOutput = true; //重定向输出  
                startInfo.CreateNoWindow = true;//不创建窗口  
                process.StartInfo = startInfo;
                try
                {
                    if (process.Start())//开始进程  
                    {
                        if (seconds == 0)
                        {
                            process.WaitForExit();//这里无限等待进程结束  
                        }
                        else
                        {
                            process.WaitForExit(seconds); //等待进程结束，等待时间为指定的毫秒  
                        }
                        output = process.StandardOutput.ReadToEnd();//读取进程的输出  
                    }
                }
                catch
                {
                }
                finally
                {
                    if (process != null)
                        process.Close();
                }
            }
            return output.Trim();
        }

        public static bool CheckJreInstalled()
        {
            try
            {
                Process p = new Process();
                String startPath = Application.StartupPath;
                p.StartInfo.FileName = "java";
                p.StartInfo.Arguments = "-version";
                p.StartInfo.RedirectStandardError = true;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.CreateNoWindow = true;
                p.Start();
                string result = p.StandardError.ReadToEnd();
                //具体逻辑你可以进一步完善，比如正则表达式
                return result.Contains("java version");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
                throw new Exception("本功能需要安装Jre环境");
            }

        }

        private void txtKey_TextChanged(object sender, EventArgs e)
        {
            String key = txtKey.Text.Trim();
            XMLUtil.setValue("Key", key);
        }

        private void txtIV_TextChanged(object sender, EventArgs e)
        {
            String iv = txtIV.Text.Trim();
            XMLUtil.setValue("Iv", iv);
        }

        private void DESTestForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.desTestForm = null;
        }
    }
}
