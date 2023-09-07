using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My__Everything
{

    public partial class todoItems : UserControl
    {
        public todoItems()
        {
            InitializeComponent();
        }

        public todoItems(string Text) //생성자를 통해 객체를 생성하는 곳에서 Text 데이터를 받아옴
        {
            InitializeComponent();

            lblToDo.Text = Text;
            btnChk.Image = Properties.Resources.todonot;
        }

        private void btnChk_Click(object sender, EventArgs e)
        {
            btnChk.Image = Properties.Resources.todoclicked;

            //lblToDo 레이블과 동일한 글꼴 패밀리,  lblToDo 레이블 컨트롤의 현재 폰트 크기와 동일한 크기, FontStyle.Strikeout을 통해 폰트에 선 그어진 스타일 적용
            lblToDo.Font = new Font(lblToDo.Name, lblToDo.Font.SizeInPoints ,FontStyle.Strikeout);

            if (btnChk.Image == Properties.Resources.todoclicked)
            {
                btnChk.Image = Properties.Resources.todonot;
            }
        }
    }
}
