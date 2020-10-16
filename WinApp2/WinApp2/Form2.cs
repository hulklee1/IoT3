using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp2
{
    public partial class Form2 : Form
    {
 //      int cn1...
        public Form2()
        {
            InitializeComponent();
        }
        public string sRet;
        private void button1_Click(object sender, EventArgs e)
        {   // int cn1, cn2,c3 ...
            sRet =  comboBox1.Text + " " +
                    comboBox2.Text + " " +
                    comboBox3.Text + " " +
                    comboBox4.Text + " " +
                    comboBox5.Text;
        }
    }
}
