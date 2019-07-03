using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ProcessOn
{
    public static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// test
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new VirtualProcessController());
        }
    }
}
