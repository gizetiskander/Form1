using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var graphics = panel1.CreateGraphics();
            Pen pn = new Pen(Color.Black, 5);
            graphics.DrawLine(pn, 50, 50, 50, 50);
            graphics.DrawEllipse(pn, 50, 50, 50, 50);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
