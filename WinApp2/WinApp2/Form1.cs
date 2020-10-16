using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp2
{
    public partial class Form1 : Form
    {
        [DllImport("kernel32.dll")]
        private static extern int GetPrivateProfileString(string Section, string key, string def, StringBuilder sb, int size, string path);
        [DllImport("kernel32.dll")]
        private static extern int WritePrivateProfileString(string Section, string key, string val, string path);

        public string GetToken(int n, string str, string sep = ",") // ","
        {
            int i, j, k;  // local index
            int n1 = 0, n2 = 0, n3 = 0;  // temp int 변수
            string sRet;

            for (i = 0, n1 = 0; i < n; i++)  // 0  1  2  3  4  5 ...
            {   // IndexOf : 문자가 없을 경우 -1
                n1 = str.IndexOf(sep, n1) + 1;  // i 번째 구분자   
                if (n1 == 0) return "";
            }   // n1 : n 번째 필드 시작

            n2 = str.IndexOf(sep, n1);  // n+1 번째 구분자
            if (n2 == -1) n2 = str.Length;
            n3 = n2 - n1;  // 문자열 길이 계산

            sRet = str.Substring(n1, n3);
            return sRet;
        }

        string sPath = @".\WinApp1.ini";
        public int GetInI_Int(string sec, string key, int def = 0)
        {
            StringBuilder sb = new StringBuilder();
            GetPrivateProfileString(sec, key, $"{def}", sb, 500, sPath);
            int nVal = int.Parse(sb.ToString());

            return nVal;
        }

        public string GetInI_String(string sec, string key, string def)
        {
            StringBuilder sb = new StringBuilder();
            GetPrivateProfileString(sec, key, $"{def}", sb, 500, sPath);
            string sVal = sb.ToString();

            return sVal;
        }

        public Form1()  // 생성자 호출시 처리
        {
            InitializeComponent();
 //           tbTest22.Location = new Point(tbTest22.Location.X, tbTest21.Location.Y);

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

        private void Form1_Resize(object sender, EventArgs e)
        {   // tbTest21, tbTest22 영역 재설정
            int w = this.Size.Width;
            int h = this.Size.Height;

            int sx1 = w / 2 - 30;

            //if(sx1 > 50)
            {
                tbTest21.Width = sx1;   // tbTest21 의 가로 크기 변경
                tbTest22.Location = new Point(sx1+20, tbTest21.Location.Y);
                tbTest22.Width = sx1;   // tbTest21 의 가로 크기 변경
            }
        }

        int cn1, cn2, cn3, cn4, cn5;  // Form2 의 콤보박스의 선택값 보관용

        private void btnFileOpen_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fPath = openFileDialog1.FileName; // full path

                FileStream fs = new FileStream(fPath, FileMode.Open); // 기존에 존재하는 파일 읽기
                int fSize = (int)fs.Length; 
                fs.Close();

                char[] buf = new char[fSize];
                StreamReader sr = new StreamReader(fPath);
                sr.Read(buf, 0, fSize);
                tbTest21.Text = new string(buf);
                sr.Close();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            WritePrivateProfileString("Form2 ComboBox Set", "cn1", $"{cn1}", sPath);
            WritePrivateProfileString("Form2 ComboBox Set", "cn2", $"{cn2}", sPath);
            WritePrivateProfileString("Form2 ComboBox Set", "cn3", $"{cn3}", sPath);
            WritePrivateProfileString("Form2 ComboBox Set", "cn4", $"{cn4}", sPath);
            WritePrivateProfileString("Form2 ComboBox Set", "cn5", $"{cn5}", sPath);
            WritePrivateProfileString("Window Conig", "tabPage", $"{tabControl1.SelectedIndex}", sPath);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form1_Resize(sender, e);
            cn1 = GetInI_Int("Form2 ComboBox Set", "cn1");
            cn2 = GetInI_Int("Form2 ComboBox Set", "cn2");
            cn3 = GetInI_Int("Form2 ComboBox Set", "cn3");
            cn4 = GetInI_Int("Form2 ComboBox Set", "cn4");
            cn5 = GetInI_Int("Form2 ComboBox Set", "cn5");

            tabControl1.SelectedIndex = GetInI_Int("Window Conig", "tabPage");
        }

        private void btnForm2Test_Click(object sender, EventArgs e)
        {
            Form2 dlg = new Form2();

            dlg.comboBox1.SelectedIndex = cn1;
            dlg.comboBox2.SelectedIndex = cn2;
            dlg.comboBox3.SelectedIndex = cn3;
            dlg.comboBox4.SelectedIndex = cn4;
            dlg.comboBox5.SelectedIndex = cn5;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                tbTest21.Text = dlg.sRet;
                cn1 = dlg.comboBox1.SelectedIndex;
                cn2 = dlg.comboBox2.SelectedIndex;
                cn3 = dlg.comboBox3.SelectedIndex;
                cn4 = dlg.comboBox4.SelectedIndex;
                cn5 = dlg.comboBox5.SelectedIndex;
            }
        }
    }
}
