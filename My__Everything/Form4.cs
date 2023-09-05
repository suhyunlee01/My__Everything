using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My__Everything
{
    public partial class Form4 : Form
    {
        private string weatherKey;

        public Form4()
        {
            InitializeComponent();

            weatherKey = "cd5d65fbfa690a917640d67804c5f2e3";

            lblDate.Parent = btnHomeWeahter;
            lblLocation.Parent = btnHomeWeahter;
            lbltemp.Parent = btnHomeWeahter;
            lblTime.Parent = btnHomeWeahter;
            lblWeek.Parent = btnHomeWeahter;

            lbltemp.Location = new Point(16, 72);
            lblDate.Location = new Point(36, 180);

            lblLocation.Location = new Point(600, 180);
            lblTime.Location = new Point(595, 145);
            lblWeek.Location = new Point(588, 105);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            timer1.Start();
            //이미지 변경 함수 호출
            changeImg();
            //weather api 불러오는 함수 호출
            getWeather();
        }

        private void getWeather() {
            using (WebClient wc = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", txtSearch.Text, weatherKey);
                var json = wc.DownloadString(url);
            }
        }

        public void changeImg()
        {
            lblDate.Text = DateTime.Now.ToString("yyyy. MM. dd");

            if (int.Parse(DateTime.Now.ToString("HH")) >= 05 && int.Parse(DateTime.Now.ToString("HH")) < 18)
            {
                btnHomeWeahter.Image = Properties.Resources.w1;
            }
            else if (int.Parse(DateTime.Now.ToString("HH")) >= 18 && int.Parse(DateTime.Now.ToString("HH")) < 21)
            {
                btnHomeWeahter.Image = Properties.Resources.w2;
            }
            else
            {
                btnHomeWeahter.Image = Properties.Resources.w3;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            getTime();
        }

        public void getTime()
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm tt", new System.Globalization.CultureInfo("en-US")); //PM AM 영어로 표현하고 싶음.
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //weather api 불러오는 함수 호출
            getWeather();
        }
    }
}
