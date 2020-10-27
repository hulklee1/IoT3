using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class _Default : Page
    {
        SqlConnection sConn = new SqlConnection();
        SqlCommand sCmd = new SqlCommand();
        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kosta\source\repos\MyTable.mdf;Integrated Security=True;Connect Timeout=30";

        public string GetDBData(string Table, string Field, string kField, string kValue)
        {
            sCmd.CommandText = $"Select {Field} from {Table} where {kField}='{kValue}'";
            return sCmd.ExecuteScalar().ToString();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            sConn.ConnectionString = connString;
            sConn.Open();
            sCmd.Connection = sConn;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sName = tbUserName.Text;
            string sPwd = tbPassword.Text;
            //   DB에서 사용자 명 및 암호 조회해서 OK면 진행 .
            //   아니면 회원 가입 안내 메세지,
            string s1 = GetDBData("Custom", "PWD", "Name", sName).Trim();
            if (sPwd == s1)
                lblCong.Text = $"{sName}님. 반갑습니다.";
            else
                lblCong.Text = "회원가입 정보가 없습니다. 먼저 회원에 가입하세요.";

        }
    }
}