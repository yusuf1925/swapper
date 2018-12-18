using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                int a;
                int b;
                a = Convert.ToInt16(textBox1.Text);
                b = Convert.ToInt16(textBox2.Text);

                a = a + b;
                b = a - b;
                a = a - b;
                label1.Text = a.ToString();
                label2.Text = b.ToString();
                textBox1.Text = a.ToString();
                textBox2.Text = b.ToString();
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
