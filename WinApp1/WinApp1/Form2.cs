using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp1
{
    public partial class Form2 : Form
    {
        public string as1, as2, as3, as4, as5;   // public : class 외부에서 참조 가능
                                            // private : class 외부에서 참조 불가
        public Form2()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            as1 = comboBox1.Text;
            as2 = comboBox2.Text;
            as3 = comboBox3.Text;
            as4 = comboBox4.Text;
            as5 = comboBox5.Text;
            int a = int.Parse(as5); // 문자 "5" 와 숫자 5는 다름
            double a1 = double.Parse(as5);
        }
    }
}
