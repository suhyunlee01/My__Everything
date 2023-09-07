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

        public todoItems(string Text) //todoPage에서 텍스트 받아옴
        {
            InitializeComponent();

            lblToDo.Text = Text;
            btnChk.Image = Properties.Resources.todonot;
        }

        private void btnChk_Click(object sender, EventArgs e)
        {
            btnChk.Image = Properties.Resources.todoclicked;
            lblToDo.Font = new Font(lblToDo.Name, lblToDo.Font.SizeInPoints ,FontStyle.Strikeout);

            if (btnChk.Image == Properties.Resources.todoclicked)
            {
                btnChk.Image = Properties.Resources.todonot;
            }
        }
    }
}
