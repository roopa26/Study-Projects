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
            string unicodeText = this.textBox1.Text;
            byte[] byteData = Encoding.UTF8.GetBytes(unicodeText);

            for (int i = 0; i < byteData.Length; i++)
            {
                this.textBox2.Text += byteData[i].ToString();
            }
        }
    }
}
