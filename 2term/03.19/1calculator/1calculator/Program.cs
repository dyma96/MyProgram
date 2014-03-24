using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1calculator
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Controller cont = new Controller();
           // Application.EnableVisualStyles();
           // Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new Form1());
        }
    }
}
