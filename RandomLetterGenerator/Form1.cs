using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomLetterGenerator
{
    
    public partial class Form1 : Form
    {
        static Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rollResult = rand.Next(1, 27);
            textBox1.Text = ""  + rollResult + ((char)(rollResult + 64));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
