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
    public partial class Form2 : Form
    {
        Form4 weatherPage = new Form4();
        public Form2()
        {
            InitializeComponent();

            lblDate.Parent = btnHomeWeahter;
            lblLocation.Parent = btnHomeWeahter;
            lbltemp.Parent = btnHomeWeahter;
            lblTime.Parent = btnHomeWeahter;
            lblWeek.Parent = btnHomeWeahter;


            lbltemp.Location = new Point(23, 72);
            lblDate.Location = new Point(42, 180);

            lblLocation.Location = new Point(600, 180);
            lblTime.Location = new Point(595, 145);
            lblWeek.Location = new Point(588, 105);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            weatherPage.getTime();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start(); //가져온 시간부터 1초씩 증가

            //weatherPage에서 만들어둔 함수 가져오기
            weatherPage.changeImg();
        }
    }
}
