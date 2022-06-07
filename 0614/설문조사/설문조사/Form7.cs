using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 설문조사
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\login.mdf;Integrated Security=True;Connect Timeout=30");

            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from USERINFO where USERNAME = '"+ID_txt.Text+"' and PASSWORD = '"+PW_txt.Text+"'",con);

            DataTable newTable = new DataTable();
            sda.Fill(newTable);

            if (newTable.Rows[0][0].ToString() == "1")
            {
                //로그인 성공인 경우
                this.Hide();

                Form10 f10 = new Form10();
                f10.Show();
            }
            else
            {
                // 로그인 실패시
                MessageBox.Show("아이디와 비밀번호를 확인해 주세요");
            }
        }
    }
}
