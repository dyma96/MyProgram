using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1calculator
{
    public class Controller
    {
        public Controller()
        {
            calculator = new Calculator();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
       
        }
        static public Calculator calculator;            
    }
}
