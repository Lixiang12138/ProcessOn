using System;
using System.Windows.Forms;
namespace ProcessOn
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// test
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new VirtualProcessController());
        }
    }
}
