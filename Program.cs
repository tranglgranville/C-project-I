using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trang_Granville
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //public static BindingList<Product> OLBL = new BindingList<Product>();
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
