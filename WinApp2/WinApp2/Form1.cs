using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        SqlConnection sConn = new SqlConnection();
        SqlCommand sCmd = new SqlCommand();
        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kosta\source\repos\MyTable.mdf;Integrated Security=True;Connect Timeout=30";
//        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=c:\temp;Integrated Security=True;Connect Timeout=30";
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

        private void mnuSelect2_Click(object sender, EventArgs e)
        {
                tbOut = tbTest22;
                rbText22.Checked = true;
        }

        private void mnuSelect1_Click(object sender, EventArgs e)
        {
                tbOut = tbTest21;
                rbText21.Checked = true;
        }

        // Command 체계 :
        // "컬럼 명칭"  :   신규 컬럼 생성
        // "1,2,'field_value'"  :  해당 CELL 에 field_value 입력 - (1,2)
        private void btnGridCmd_Click(object sender, EventArgs e)
        {   // tbGridCmd 에 입력된 text로 Column 생성
            string str = tbGridCmd.Text;

            try
            {
                if(str != "")   // 입력 문자열이 공백이 아니면...
                {
                    if(str.IndexOf(",") == -1)  //  ","가 없으면 컬럼 생성
                    {
                        dataGridView1.Columns.Add(str, str);
                        tbGridCmd.Text = "";
                    }
                    else // 해당 Cell 이 지정된 값으로 변환
                    {   // sample data : [1,2,value_12]
                        int col = int.Parse(GetToken(0,str)); // col = 1
                        int row = int.Parse(GetToken(1,str)); // row = 2
                        dataGridView1.Rows[row].Cells[col].Value = GetToken(2, str);
                    }
                }
            }
            catch(Exception e1)
            {

            }
        }
        // 함수 일반화 #5
        // 함수명 : int RunSql(string sql)
        //   인수 : string sql : 실행할 SQL 문
        //   리턴 : -1 오류, 1 or 0 정상종료
        //   기능 : SQL 문을 sCmd 오브젝트를 이용하여 수행하고
        //         결과값이 있을 경우 (Select) Grid 에 나타내고
        //         하단의 statusBar에 수행 결과를 표시
        public int RunSql(string sSql)
        {
            try
            {
                sCmd.CommandText = sSql;
                int i, j, k;
                // "select....   Select ...
                string s1 = GetToken(0, sSql, " ").ToUpper();  // "SELECT FCODE,FNAME FROM FACILITY"
                if (s1 != "SELECT")
                    sCmd.ExecuteNonQuery(); // return 값이 없는 쿼리문 (ex) insert/update/delete
                else     //  쿼리문이 Select 인 경우
                {
                    SqlDataReader sr = sCmd.ExecuteReader();    // select 문 처리결과 수신

                    dataGridView1.Columns.Clear();
                    dataGridView1.Rows.Clear();

                    for (i = 0; i < sr.FieldCount; i++)
                    {
                        dataGridView1.Columns.Add(sr.GetName(i), sr.GetName(i));
                    }
                    for (i = 0; sr.Read(); i++)  // 처리할 데이터가 있으면 1라인씩 처리
                    {
                        if (dataGridView1.RowCount < i + 2) dataGridView1.Rows.Add();
                        for (j = 0; j < sr.FieldCount; j++)
                        {
                            object o2 = sr.GetValue(j);
                            string buf = $"{o2}";
                            dataGridView1.Rows[i].Cells[j].Value = buf;
                            //dataGridView1.Rows[i].Cells[j].Value = $"{sr.GetValue(j)}";
                        }
                    }
                    sr.Close();
                }
                StatusLabel2.BackColor = Color.Blue;
                StatusLabel2.Text = "Success";
            }
            catch (Exception e1)
            {
                StatusLabel2.BackColor = Color.Red;
                StatusLabel2.Text = " Fail!";
                StatusLabel3.Text = e1.Message;
            }

            return 0;
        }

        private void mnuAddRow_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
        }
        int DbStatus = 0;   // DB connection status
        private void mnuDBOpen_Click(object sender, EventArgs e)
        {
            try
            {
                sConn.ConnectionString = connString;
                sConn.Open();
                sCmd.Connection = sConn;

                DataTable dt = sConn.GetSchema("Tables");
                for(int i=0;i<dt.Rows.Count;i++)
                {
                    string sTablename = dt.Rows[i].ItemArray[2].ToString();
                    cbTable.Items.Add(sTablename);
                }      

                StatusLabel1.BackColor = Color.Green;
                StatusLabel1.Text = "DB opened success";
                DbStatus = 1;   // DB가 정상적으로 Open
            }
            catch(Exception e1)
            {
                StatusLabel1.BackColor = Color.Red;
                StatusLabel1.Text = "DB open Failed!";
            }
        }

        private void btnExecSql_Click(object sender, EventArgs e)
        {
            string sql = tbSql.SelectedText;
            if(sql != "") RunSql(sql);
            else RunSql(tbSql.Text);
            tbSql.Focus();
        }

        private void mnudBFileSelect_Click(object sender, EventArgs e)
        {
            openFileDialog1.ValidateNames = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {   // AttachDbFilename=C:\Users\kosta\source\repos\MyTable.mdf
                string fPath = openFileDialog1.FileName; // full path
                string s1 = GetToken(0, connString, ";"); // connString 의 첫번째 필드.
                string s2 = $"AttachDbFilename={fPath}";
                string s3 = GetToken(2, connString, ";"); // connString 의 세번째 필드.
                string s4 = GetToken(3, connString, ";"); // connString 의 네번째 필드.

                //connString = s1 + ";" + s2 + ";" + s3 + ";" + s4;   // 구분자 직접 삽입
                connString = $"{s1};{s2};{s3};{s4}";    // 보간문자열 사용
                string s5 = openFileDialog1.SafeFileName;
                tbDatabase.Text = s5;
            }
        }

        private void mnucellUpdate_Click(object sender, EventArgs e)
        {
            //int x = dataGridView1.SelectedCells[0].ColumnIndex;
            //int y = dataGridView1.SelectedCells[0].RowIndex;
            int x = dataGridView1.ColumnCount;
            int y = dataGridView1.RowCount;
            int i, j, k;

            for(i=0;i<y;i++) // Row index
            {
                for(j=0;j<x;j++)  // Column index
                {
                    if(dataGridView1.Rows[i].Cells[j].ToolTipText == ".")
                    {
                        string s1 = dataGridView1.Columns[j].HeaderText;    // field 명
                        string s2 = dataGridView1.Rows[i].Cells[j].Value.ToString(); // 수정된 데이터
                        string s3 = (string)dataGridView1.Rows[i].Cells[0].Value;    // id 번호
                        string s4 = $"update {cbTable.Text} set {s1}='{s2}' where id={s3}";
                        RunSql(s4);

                        dataGridView1.Rows[i].Cells[j].ToolTipText = "";
                    }
                }
            }
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {   // Kbd 입력이 발생했을 때
            int x = dataGridView1.SelectedCells[0].ColumnIndex;
            int y = dataGridView1.SelectedCells[0].RowIndex;

            dataGridView1.SelectedCells[0].ToolTipText = ".";
        }

        private void mnuDBClose_Click(object sender, EventArgs e)
        {
            sConn.Close();
            tbDatabase.Text = "";
            cbTable.Items.Clear();
            cbTable.Text = "";
            StatusLabel1.Text = "DB Closed.";
        }

        private void cbTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = $"Select * from {cbTable.Text}";
            RunSql(sql);
        }

        private void mnuCSVImport_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fPath = openFileDialog1.FileName; // full path

                StreamReader sr = new StreamReader(fPath);
                for(string str;(str=sr.ReadLine()) != null; )
                {
                    for (int j = 0; ; j++) ;

                }
                //string s1 = sr.ReadLine(); // 1 Line Read : if(EOF) null

                sr.Close();

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
                //string s1 = sr.ReadLine(); // 1 Line Read : if(EOF) null

                tbTest21.Text = new string(buf);
                sr.Close();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(DbStatus == 1) sConn.Close();
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
