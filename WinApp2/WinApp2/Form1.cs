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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest11_Click(object sender, EventArgs e)
        {   // 문자열 변환 테스트
            if (rbTest11.Checked == true)
            {
                label1.Text = tbTest11.Text.ToLower();
            }
            if (rbTest12.Checked == true)
            {
                label1.Text = tbTest11.Text.ToUpper();
            }
        }

        private void btnTest12_Click(object sender, EventArgs e)
        {   // 텍스트 창에 입력된 문자열을 콤보박스에 추가
            string str = tbTest12.Text;
            int nVal = int.Parse(str);

            cbTest11.Text = str;
            cbTest11.Items.Add(nVal);
        }

        private void cbTest11_SelectedIndexChanged(object sender, EventArgs e)
        {   // 콤보박스에 입력된 object  추출 및 변환 테스트
            string as1 = cbTest11.Text;
            int nSel = cbTest11.SelectedIndex;
            object oVal = cbTest11.Items[nSel];

            int nVal = (int)oVal;
            tbTest13.Text = string.Format("{0} selected.", nVal);
        }
    }
}
