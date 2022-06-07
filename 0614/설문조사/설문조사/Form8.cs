using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace 설문조사
{
    public partial class Form8 : Form
    {
        state st;
        string _server = "localhost";
        int _port = 3306;
        string _database = "new_schema";
        string _id = "root";
        string _pw = "";
        string _connectionAddress = "";
        public Form8(state st)
        {
            this.st = st;
            InitializeComponent();
            _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4};charset=utf8", _server, _port, _database, _id, _pw);

            if (this.st.sozu == true)
                label1.Text = "소주";
            if (this.st.mac == true)
                label1.Text = "맥주";
            if (this.st.sheepzu == true)
                label1.Text = "양주";
            if (this.st.wine == true) 
                label1.Text = "와인";
            
            if (this.st.cowbeef == true)
                label2.Text = "소고기";
            if (this.st.guk == true)
                label2.Text = "국물요리";
            if (this.st.fry == true)
                label2.Text = "튀김/부침";
            if (this.st.sushi == true)
                label2.Text = "회";

            if (this.st.an || this.st.bn || this.st.cn || this.st.dn == false)
                label3.Text = " ";
            if (this.st.an == true)
                label3.Text = "안창살";
            if (this.st.bn == true)
                label3.Text = "채끝살";
            if (this.st.cn == true)
                label3.Text = "안심";
            if (this.st.dn == true)
                label3.Text = "등심";

            if (this.st.aan || this.st.bbn || this.st.ccn || this.st.ddn == false)
                label6.Text = " ";
            if (this.st.aan == true)
                label6.Text = "rare";
            if (this.st.bbn == true)
                label6.Text = "rare/medium";
            if (this.st.ccn == true)
                label6.Text = "medium";
            if (this.st.ddn == true)
                label6.Text = "well-done";
           

            if (this.st.sulzip == true)
                label4.Text = "일반술집";
            if (this.st.zip == true)
                label4.Text = "집";
            if (this.st.subbun == true)
                label4.Text = "수변공원";
            if (this.st.bar == true)
                label4.Text = "바/라운지";


            if (this.st.one == true)
                label5.Text = "한명";
            if (this.st.two == true)
                label5.Text = "두명";
            if (this.st.three == true)
                label5.Text = "세명";
            if (this.st.four == true)
                label5.Text = "네명";

            if (this.st.name != null)
                label7.Text = this.st.name;
            if (this.st.phone != null)
                label8.Text = this.st.phone;

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();
                    string insertQuery = string.Format("INSERT INTO exam_table (drink,food,which,cook,place,count,name,phone) VALUES ('{0}', '{1}','{2}','{3}','{4}','{5}','{6}','{7}');", label1.Text, label2.Text,label3.Text,label6.Text,label4.Text,label5.Text,label7.Text,label8.Text);

                    MySqlCommand command = new MySqlCommand(insertQuery, mysql);
                    if (command.ExecuteNonQuery() != 1)
                        MessageBox.Show("Failed to insert data.");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            this.Hide();
            Form9 f9 = new Form9();
            f9.Show();
        }
    }
}
