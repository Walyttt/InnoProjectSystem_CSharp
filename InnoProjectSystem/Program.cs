using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using InnoProjectSystem.src.view;

namespace InnoProjectSystem
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

            LoginForm loginForm = new LoginForm();
            DialogResult dialogResult = loginForm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                Application.Run(new MainForm());
            }
        }
    }
}
