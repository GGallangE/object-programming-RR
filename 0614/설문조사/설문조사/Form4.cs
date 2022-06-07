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
    public partial class Form4 : Form
    {
        state st;
        public Form4(state st)
        {
            this.st = st;
            InitializeComponent();
            this.checkBox1.CheckedChanged += CheckBox1_CheckedChanged;
            this.checkBox2.CheckedChanged += CheckBox1_CheckedChanged;
            this.checkBox3.CheckedChanged += CheckBox1_CheckedChanged;
            this.checkBox4.CheckedChanged += CheckBox1_CheckedChanged;
            this.checkBox5.CheckedChanged += CheckBox1_CheckedChanged;
            this.checkBox6.CheckedChanged += CheckBox1_CheckedChanged;
            this.checkBox7.CheckedChanged += CheckBox1_CheckedChanged;
            this.checkBox8.CheckedChanged += CheckBox1_CheckedChanged;
        }

        

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            var cb = (CheckBox)sender;
            if (cb.Text == "안창살")
                st.an = checkBox1.Checked;
            if (cb.Text == "채끝살")
                st.bn = checkBox2.Checked;
            if (cb.Text == "안심")
                st.cn = checkBox3.Checked;
            if (cb.Text == "등심")
                st.dn = checkBox4.Checked;
            if (cb.Text == "rare")
                st.aan = checkBox8.Checked;
            if (cb.Text == "rare/mediun")
                st.bbn = checkBox7.Checked;
            if (cb.Text == "medium")
                st.ccn = checkBox6.Checked;
            if (cb.Text == "well-done")
                st.ddn = checkBox5.Checked;


        }
        


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form f3 = new Form3(st);
            f3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5(st);
            f5.Show();
        }
    }
}
