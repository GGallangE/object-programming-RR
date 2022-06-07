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
    public partial class Form6 : Form
    {
        state st;

        public Form6(state st)
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
            if (cb.Text == "한명")
                st.one = checkBox1.Checked;
            if (cb.Text == "두명")
                st.two = checkBox3.Checked;
            if (cb.Text == "세명")
                st.three = checkBox2.Checked;
            if (cb.Text == "네명")
                st.four = checkBox4.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form5 f5 = new Form5(st);
            f5.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form11 f11 = new Form11(st);
            f11.Show();
        }
    }
}
