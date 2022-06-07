using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 설문조사
{
    public partial class Form5 : Form
    {
        state st;

        public Form5(state st)
        {
            this.st = st;
            InitializeComponent();
            this.checkBox1.CheckedChanged += CheckBox1_CheckedChanged;
            this.checkBox2.CheckedChanged += CheckBox1_CheckedChanged;
            this.checkBox3.CheckedChanged += CheckBox1_CheckedChanged;
            this.checkBox4.CheckedChanged += CheckBox1_CheckedChanged;
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            var cb = (CheckBox)sender;
            if(cb.Text == "일반 술집")
                st.sulzip = checkBox1.Checked;
            if (cb.Text == "집")
                st.zip = checkBox3.Checked;
            if (cb.Text == "바/라운지")
                st.bar = checkBox2.Checked;
            if (cb.Text == "수변공원")
                st.subbun = checkBox4.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            this.Hide();
            Form3 f3 = new Form3(st);
            f3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f6 = new Form6(st);
            f6.Show();

        }
    }
}
