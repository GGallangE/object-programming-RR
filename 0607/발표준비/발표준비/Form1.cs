using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 발표준비
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            if(ID_txt.ToString() == "kimdg1122")
            {
                if(PW_txt.ToString() == "ehrbs@2997")
                {
                    this.Hide();

                    Form2 f2 = new Form2();
                    f2.Show();
                }
            }
            else
            {
                MessageBox.Show("로그인이 완료 되었습니다. 다음화면으로 넘어갑니다.");
            }
        }
    }
}
