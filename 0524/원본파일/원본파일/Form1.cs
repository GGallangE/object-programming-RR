using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 원본파일
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void 새로만들기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbContents.Text = "";
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 1. 사용자에게 열 파일을 선택하게 함
            // 2. 파일으 ㅣ내용을 읽는다.
            // 3. 화면에 표시한다.
        }

        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 파일 명이 입력되어있으면 해당파일로 현재 내용저장
            // 그게 아니면 다름이름으로 동일하게 작동
        }

        private void 다른이름으로저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 사용자에게 저장할 파일을 선택하게 함
        }
    }
}
