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
    public partial class form2 : Form
    {
        state st = new state();
        public form2()
        {
            InitializeComponent();
            this.checkBox1.CheckedChanged += CheckBox1_CheckedChanged;
            this.checkBox2.CheckedChanged += CheckBox1_CheckedChanged;
            this.checkBox3.CheckedChanged += CheckBox1_CheckedChanged;
            this.checkBox4.CheckedChanged += CheckBox1_CheckedChanged;
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            var cb = (CheckBox)sender;
            if (cb.Text == "소주")
                st.sozu = checkBox1.Checked;
            if (cb.Text == "맥주")
                st.mac = checkBox3.Checked;
            if (cb.Text == "양주")
                st.sheepzu = checkBox4.Checked;
            if (cb.Text == "와인")
                st.wine = checkBox2.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form3 f3 = new Form3(st);
            f3.Show();
        }
    }
}
