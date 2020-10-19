﻿using System;
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
            //int w = this.Size.Width;
            //int h = this.Size.Height;

            //int sx1 = w / 2 - 30;

            ////if(sx1 > 50)
            //{
            //    tbTest21.Width = sx1;   // tbTest21 의 가로 크기 변경
            //    tbTest22.Location = new Point(sx1+20, tbTest21.Location.Y);
            //    tbTest22.Width = sx1;   // tbTest21 의 가로 크기 변경
            //}
        }

        int cn1, cn2, cn3, cn4, cn5;  // Form2 의 콤보박스의 선택값 보관용

        private void btnTemp_Click(object sender, EventArgs e)
        {
            //int[] nArr = new int[5];

            //nArr[0] = 1;
            //nArr[1] = 2;
            //nArr[2] = 3;
            //nArr[3] = 4;

            //int[] bArr = { 10, 20, 30 };

            //int n1 = 0;
            //foreach (int n in nArr)
            //{
            //    string str = $"nArr[{n1}] = {n}\r\n";
            //    tbTest22.Text += str;
            //    n1++;
            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    string str = $"bArr[{i}] = {bArr[i]}\r\n";
            //    tbTest22.Text += str;
            //}

            string[] Name = { "병준", "택형", "정의" }; //학생 이름
            //int[] subj1 = { 90, 80, 70 };   // 과목별 점수
            //int[] subj2 = { 80, 70, 90 };
            //int[] subj3 = { 75, 85, 95 };

            string[] subName = { "C#", "DB", "C++", "IoT", "WEB" };
            int[,] subj = { { 90, 80, 70 }, // 첫번째 과목 점수
                            { 80, 70, 90 }, // 두번째 과목 점수
                            { 75, 85, 95 }, //
                            { 75, 85, 95 },
                            { 75, 85, 95 }  // n번째 과목
                          };

            int nSubj = subj.GetLength(0);   // 첫번째 context 배열블럭의 갯수 : 5
            int nCnt = subj.Length;        // 15 : Total 요소 갯수
            int m = Name.Length;            // 배열 요소의 갯수(사람수) 3

            int[] total = new int[m];   // 0으로 초기화됨 
            double[] avg = new double[m];
            int i, j, k;

            for( i = 0; i<m;i++)  // 인원수
            {
                for( j=0, total[i]=0; j<nSubj;j++) // 과목수 (subject )
                {
                    total[i] += subj[j, i];
                }
                avg[i] = (double)total[i] / nSubj; // avg : 실수,  total/nSub 정수
                                         // 정수와 정수의 연산은 계산과정에서 정수
                                         // 연산과정에 형변환 (캐스팅:cast)필요
            }

            //    이름      C#     DB      HTML  Total   Average
            // ==================================================
            //    병준     90      80      75     245      81.7
            //    택형
            //    정의 
            //tbTest22.Text += "    이름      C#     DB      HTML  Total   Average\r\n";
            //tbTest22.Text += "==================================================\r\n";

            string str = "   이름   "; // 총 10자리
            for(j=0;j<nSubj;j++)
            {
                str += $"{subName[j],5}";   // 과목별 5자리수, 우정렬
            }
            str += $"  총점   평균\r\n";
            MemoOut(str);

            for (i = 0; i < m; i++)
            {
                str = $"{Name[i],6}    ";
                for(j=0;j<nSubj;j++)
                {
                    str += $"{subj[j,i],5}";
                }
                str += $"{total[i],7}{avg[i],7:F2}\r\n";
               // tbTest22.Text += str;
                MemoOut(str);
            }
        }

        // 함수의 일반화 #4
        // 함수명 : MemoOut(string str)
        //      인수 : string str : 출력할 문자열
        //      리턴 : 없음 (void)
        // 기능 : 윈도우 컴포넌트 중 지정된 TextBox로
        //        출력 문자열을 누적 출력
        // 추가기능 : 출력 TextBox 설정기능 - 초기화 기능

        System.Windows.Forms.TextBox tbOut = null;
        public void MemoOut(string str)
        {
            if (tbOut == null) rbText2_Click(null, null);//  tbOut = tbTest22;

            tbOut.Text += str;
        }

        private void rbText2_Click(object sender, EventArgs e)
        {
            if(rbText21.Checked) tbOut = tbTest21;
            else                 tbOut = tbTest22;
        }

        private void mnuTbSet21_Click(object sender, EventArgs e)
        {
            if (!mnuTbSet21.Checked)
            {
                tbOut = tbTest21;
                mnuTbSet21.Checked = true;
                mnuTbSet22.Checked = false;
                rbText21.Checked = true;
                rbText22.Checked = false;
            }
        }

        private void mnuTbSet22_Click(object sender, EventArgs e)
        {
            if (!mnuTbSet22.Checked)
            {
                tbOut = tbTest22;
                mnuTbSet21.Checked = false;
                mnuTbSet22.Checked = true;
                rbText22.Checked = true;
           }
        }

        private void btnFileOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
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
