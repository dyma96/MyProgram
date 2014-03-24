using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OnButtonClick(char ch)
        {
            if (this.textBox1.Text.Length >= 2)
                if (this.textBox1.Text[this.textBox1.Text.Length - 1] >= '9'
                    || this.textBox1.Text[this.textBox1.Text.Length - 1] <= '0')
                    this.textBox1.Text = null;
            this.textBox1.Text += ch;
        }

        private void OnButtonSignClick(char ch)
        {
            this.calculator.Add(Convert.ToInt32(this.textBox1.Text));
            this.calculator.Add(ch);
            this.textBox1.Text = this.calculator.Print();
        }
    }
}
