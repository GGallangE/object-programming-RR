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
    public partial class Form3 : Form
    {
        state st;
        public Form3(state st)
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
            if (cb.Text == "소고기")
                st.cowbeef = checkBox1.Checked;
            if (cb.Text == "국물요리")
                st.guk = checkBox2.Checked;
            if (cb.Text == "튀김/부침")
                st.fry = checkBox3.Checked;
            if (cb.Text == "회")
                st.sushi = checkBox4.Checked;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();

            Form4 f5 = new Form4(st);
            f5.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            form2 f2 = new form2();
            f2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5(st);
            f5.Show();
        }
    }
}
