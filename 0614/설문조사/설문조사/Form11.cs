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
    public partial class Form11 : Form
    {
        state st;
        public Form11(state st)
        {
            this.st = st;
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            st.name = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            st.phone = textBox3.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form8 f8 = new Form8(st);
            f8.Show();
        }
    }
}
