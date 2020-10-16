using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp1
{
    public partial class FormTest1 : Form
    {
        [DllImport("kernel32.dll")] // D L L Import
        private static extern int GetPrivateProfileString(string Section, string key, string def, StringBuilder sb, int size, string path);
        [DllImport("kernel32.dll")]
        private static extern int WritePrivateProfileString(string Section, string key, string val, string path);

        public FormTest1()  // 생성자
        {
            InitializeComponent();

            rbOption1.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //label1.Text  = "안녕하세요.....반갑습니다...슷ㅂ";
            //            label1.Text = textBox1.Text;

            string str = textBox1.Text.Replace("hulklee", "길동");

            //            if (checkBox1.Checked) // 소문자로 바꾸어서 label1에 출력
            if (rbOption1.Checked) // 소문자로 바꾸어서 label1에 출력
            {
                str = textBox1.Text.ToLower();
                //               str = textBox1.Text.Replace("hulklee", "길동");
                label1.Text = str;
            }
            //            if (checkBox2.Checked) // 대문자로 바꾸어서 label2에 출력
            if (rbOption2.Checked) // 대문자로 바꾸어서 label2에 출력
            {
                textBox1.Text.ToUpper();
                label2.Text = str;
            }

        }

        private void btnCombo_Click(object sender, EventArgs e)
        {   //tbCombo.Text : 
            // ComboBox 에 아이템 추가
            string str = tbCombo.Text;
            if (tbCombo.Text != "")
            {
                comboBox1.Items.Add(str);
                tbCombo.Text = "";
            }
        }
        private void tbCombo_TextChanged(object sender, EventArgs e)
        {

        }
        string sStr;
        //  함수명  : GetToken : 인수로 주어진 문자열에 대하여 
        //            주어진 구분자로 구분되는 필드의 n번째 데이터를
        //            추출하여 되돌려 주는 일반 함수
        //   인수(Argument)  (string str, string seperator, int field_index)
        //              str : 대상 문자열
        //              seperator : 구분자
        //              field_index : 구분자로 구분되는 필드 번호
        //    return : string sRet
        //              sRet : 추출된 문자 데이터
        //             해당하는 데이터가 없을 경우 "" (빈 문자열)을 반환
        //    error  : 발생 가능한 에러는 ??
        public string GetToken(string str, string sep, int n)
        {
            // 함수호출시  string ss = GetToken(sStr,"|",10000);
            // for loof를 사용하여 n번째 구분자를 탐색
            //  str = "0kim,1lee,2han,3seo,4cho,5cha",  sep=","  n = 5 (zero base)
            //  ret = "3seo"
            // n번째 구분자 이후 n+1번째 구분자 탐색
            //  문자열 길이 계산
            //  문자열 추출 : Substring 메쏘드 이용
            int i, j, k;  // local index
            int n1=0, n2=0, n3=0;  // temp int 변수
            string sRet;

            for (i=0,n1=0;i<n;i++)  // 0  1  2  3  4  5 ...
            // (초기값;수행조건;증감연산)
            // for loof 의 경계값 :  시작 i = 0,   종료 i = n;
            {   // IndexOf : 문자가 없을 경우 -1
                n1 = str.IndexOf(sep, n1) + 1;  // i 번째 구분자   
                if (n1 == 0) return "";
            }   // n1 : n 번째 필드 시작

            n2 = str.IndexOf(sep, n1);  // n+1 번째 구분자
            if (n2 == -1) n2 = str.Length;
                                        // n = 5 라면 ????
            n3 = n2 - n1;  // 문자열 길이 계산

            sRet = str.Substring(n1, n3);

            return sRet;
            //int n1 = sStr.IndexOf(","); // 첫번째 구분자
            //int n2 = sStr.IndexOf(",", n1 + 1);  // 두번째 구분자
            //int k = n2 - n1 - 1;  // 문자열 길이 계산
            //string ss = sStr.Substring(n1 + 1, k);
        }

        int cn1, cn2, cn3, cn4, cn5;    // Form2의 콤보박스 설정값 보관용
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 dlg = new Form2();

            dlg.cn1 = cn1;
            dlg.cn2 = cn2;
            dlg.cn3 = cn3;
            dlg.cn4 = cn4;
            dlg.cn5 = cn5;

            DialogResult dr = dlg.ShowDialog();
            if(dr == DialogResult.OK)
            {
                cn1 = dlg.cn1;
                cn2 = dlg.cn2;
                cn3 = dlg.cn3;
                cn4 = dlg.cn4;
                cn5 = dlg.cn5;

                sStr = string.Format("{0},{1},{2},{3},{4}", dlg.as1, dlg.as2, dlg.as3, dlg.as4, dlg.as5);
                MessageBox.Show(sStr);
                tbTest.Text = sStr;
                btnNoop.Text = "Ready";
            }
        }
        string sPath = @".\WinApp1.ini";
        public int GetInI_Int(string sec, string key, int def = 0)
        {
            StringBuilder sb = new StringBuilder();
            GetPrivateProfileString(sec, key, $"{def}", sb, 500, sPath); 
            int nVal = int.Parse(sb.ToString());

            return nVal;
        }

        // 함수의 일반화 #3 - GetInI_String(string  section, string key, string def);
        //               인수 (Arg) section : InI 파일의 Section 이름
        //                          key : Key 이름
        //                          def : default string
        //              return :  sValue : Ini 파일에서 추출한 string 값

        public string GetInI_String(string sec, string key, string def)
        {
            StringBuilder sb = new StringBuilder();
            GetPrivateProfileString(sec, key, $"{def}", sb, 500, sPath);
            string sVal = sb.ToString();

            return sVal;
        }


        private void FormTest1_Load(object sender, EventArgs e)
        {
            //StringBuilder sb = new StringBuilder();
            //GetPrivateProfileString("Form2 Combo Set", "cn1", "0", sb, 500, sPath); cn1 = int.Parse(sb.ToString());
            cn1 = GetInI_Int("Form2 Combo Set", "cn1");
            cn2 = GetInI_Int("Form2 Combo Set", "cn2");
            cn3 = GetInI_Int("Form2 Combo Set", "cn3");
            cn4 = GetInI_Int("Form2 Combo Set", "cn4");
            cn4 = GetInI_Int("Form2 Combo Set", "cn5");

            this.Width  = GetInI_Int("Window Configuration", "Width", 1000);
            this.Height = GetInI_Int("Window Configuration", "Height", 700);
            this.Text   = GetInI_String("Window Configuration", "Title", "...");
        }

        private void FormTest1_FormClosed(object sender, FormClosedEventArgs e)
        {                               // string.Format("stringFormatText", arg1,arg2... );
            WritePrivateProfileString("Form2 Combo Set", "cn1", $"{cn1}", sPath);  // string.Format("{0}",cn1)==> $"{cn1}" : 보간문자열 처리
            WritePrivateProfileString("Form2 Combo Set", "cn2", $"{cn2}", sPath);  // string.Format("{0}",cn1)==> $"{cn1}" : 보간문자열 처리
            WritePrivateProfileString("Form2 Combo Set", "cn3", $"{cn3}", sPath);  // string.Format("{0}",cn1)==> $"{cn1}" : 보간문자열 처리
            WritePrivateProfileString("Form2 Combo Set", "cn4", $"{cn4}", sPath);  // string.Format("{0}",cn1)==> $"{cn1}" : 보간문자열 처리
            WritePrivateProfileString("Form2 Combo Set", "cn5", $"{cn5}", sPath);  // string.Format("{0}",cn1)==> $"{cn1}" : 보간문자열 처리

            WritePrivateProfileString("Window Configuration", "Width", $"{this.Width}", sPath);
            WritePrivateProfileString("Window Configuration", "Height", $"{this.Height}", sPath);
            WritePrivateProfileString("Window Configuration", "Title", $"{this.Text}", sPath);
        }

        private void btnNoop_Click(object sender, EventArgs e)
        {
            if(btnNoop.Text == "Ready")
            {
                // 이름만 추출하세요. 첫번째와 두번째 ',' 사이에 있음
                // string.IndexOf(),  .SubString() 메쏘드 이용.
                // string 에서 제공하는 메쏘드 중에서 적절한 기능 찾기  XXX
                // 알고리즘 구상 : 
                // - 구분자(",") 가 위치한 첫번째 인덱스 찾기  ===> n1
                // -           "           두번째     "        ===> n2
                // 구분할 문자열 길이는 n2 - n1 - 1  ===> k
                //////int n1 = sStr.IndexOf(",");
                //////int n2 = sStr.IndexOf(",", n1 + 1);
                //////int k = n2 - n1 - 1;  // 문자열 길이 계산
                //////string ss = sStr.Substring(n1 + 1, k);
                //////tbTest.Text = ss;
                tbTest.Text = GetToken(sStr, ",", 2);

                // 입력한 숫자가 "5"   "7"  ==> 출력시에는 문제 X
                //                   +*-/  >>  숫자로 변환해야 함.                

                //  함수의 일반화  : GetToken : 인수로 주어진 문자열에 대하여 
                //              주어진 구분자로 구분되는 필드의 n번째 데이터를
                //              추출하여 되돌려 주는 일반 함수
                //   인수(Argument)  (string str, string seperator, int field index)
                //              str : 대상 문자열
                //              seperator : 구분자
                //              field_index : 구분자로 구분되는 필드 번호


            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int n = int.Parse(comboBox2.Text); // comboBox 창에 표시된 문자열
            int m = int.Parse(comboBox2.Items[comboBox2.SelectedIndex].ToString());
            tbTest.Text = GetToken(sStr, ",", n);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            string s1 = GetToken(sStr, ",", 4);
            int n = int.Parse(s1); // comboBox 5번 창에 표시된 문자열
            tbTest.Text = string.Format("{0,10}",n);
            // string Format {변수인덱스,자리수:변환문자}
        }

        private void tbTest_TextChanged(object sender, EventArgs e)
        {
            string str = tbTest.Text;
            int len = str.Length;
            int cNum = int.Parse(textBox3.Text);
            int i, j, k;

            StringBuilder sb = new StringBuilder();

            textBox2.Text = "";
            for(i = 0; i<len;i++)
            {
                char a = str[i];  // 문자열 str의 첫번째 문자
                byte c = (byte)a;  // byte : 1 byte int
                //textBox2.Text += string.Format(" {0:X2}", c);
                sb.Append($" {c:X2}");
                if ((i+1)%cNum == 0) sb.Append("\r\n");
            }
            textBox2.Text = sb.ToString();
        }
    }
}
