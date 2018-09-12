using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseApp
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new test());
            //Application.Run(new DataBaseCopyForm());
            //return;
            
            LoginForm form1 = new LoginForm();
            DialogResult result = form1.ShowDialog();
            if (result.Equals(DialogResult.Yes))
            {
                Application.Run(new MainForm());
            }
           

        }
    }
}
