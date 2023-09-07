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
using Newtonsoft.Json;
using System.Net;
using System.Security;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace My__Everything
{ public delegate void DataGetEventHandler(string data);
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

            lblLocation.Location = new Point(405, 180);
            lblTime.Location = new Point(595, 145);
            lblWeek.Location = new Point(590, 105);

        }
        private void Form4_Load(object sender, EventArgs e)
        {
            timer1.Start();
            //이미지 변경 함수 호출
            changeImg();
            //weather api 불러오는 함수 호출
            getWeather();
            //날짜 및 위치 불러오는 함수 호출
            getDate();
            getWeek();
            getLocation();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            getTime();
        }

        public void getWeather() {
            //using 문 사용해서 리소스 관리
            using (WebClient wc = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", txtSearch.Text, weatherKey);

                string json = wc.DownloadString(url); //WebClient 객체로 DownloadString()메서드를 통해 url데이터를 받아옴. 해당 데이터를 json 변수에 저장.
                Weather.root Info = JsonConvert.DeserializeObject<Weather.root>(json); //json 파일을 DeserializeObject를 통해 디시리얼라이즈함.

                //날씨 정보 출력하는 함수 호출
                SetWeatherData(Info);
            }
        }

        public void SetWeatherData(Weather.root Info)
        {
            //절대온도를 섭씨온도로 만들기 위해 273.15도를 빼줌
            //Ceiling()메서드를 통해 섭씨온도를 반올림해줌.
            lbltemp.Text = Math.Ceiling((Info.main.temp - 273.15)).ToString() + "°";

            lblHumidityResult.Text = Info.main.humidity.ToString();
            lblWindResult.Text = Info.wind.speed.ToString();
            lblDesResult.Text = Info.weather[0].description.ToString();

            lblSunRIseResult.Text = convertSunTime(Info.sys.sunrise).ToShortTimeString();
            lblSunSetResult.Text = convertSunTime(Info.sys.sunset).ToShortTimeString();
        }


        //받은 세컨드를 현지 시간으로 변환함.
        DateTime convertSunTime(long s)
        {
            //1970년부터 시작한 것이라서 첫 시작을 잡아줌.
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(s).ToLocalTime();

            return day;
        }

        public void changeImg()
        {

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

        //위치, 날짜 함수들
        public string getWeek()
        {
            lblWeek.Text = DateTime.Now.ToString("dddd", new System.Globalization.CultureInfo("en-US"));
            return lblWeek.Text;
        }

        public string getDate()
        {
            lblDate.Text = DateTime.Now.ToString("yyyy. MM. dd");
            return lblDate.Text;
        }

        public string getTime()
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm tt", new System.Globalization.CultureInfo("en-US")); //PM AM 영어로 표현하고 싶음.
            return lblTime.Text;
        }
        public string getLocation()
        {
            string loc = txtSearch.Text + ", Korea";
            return loc;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //weather api 불러오는 함수 호출
            getWeather();
            //위치 설정
            lblLocation.Text = getLocation();
        }
    }
}
