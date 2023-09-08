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
using System.Text.RegularExpressions;

namespace My__Everything
{ public delegate void DataGetEventHandler(string data);
    public partial class Form4 : Form
    {
        private string weatherKey;
        public Form4()
        {
            InitializeComponent();

            weatherKey = "cd5d65fbfa690a917640d67804c5f2e3";

            //디자인
            lblDate.Parent = btnHomeWeahter;
            lblLocation.Parent = btnHomeWeahter;
            lbltemp.Parent = btnHomeWeahter;
            lblTime.Parent = btnHomeWeahter;
            lblWeek.Parent = btnHomeWeahter;
            lblAlert.Parent = btnHomeWeahter;

            lbltemp.Location = new Point(16, 72);
            lblDate.Location = new Point(36, 180);

            lblAlert.Location = new Point(405, 40);
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
            //시간 불러오는 함수 호출
            getTime();
        }

        public void getWeather() {

            //API URL 저장
            //string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", txtSearch.Text, weatherKey);


            //WebClient wc = new WebClient();
            //string json = wc.DownloadString(url);
            //Weather.root info = JsonConvert.DeserializeObject<Weather.root>(json);
            //SetWeatherData(info);


            //메모리 누수 방지를 위해 using문으로 코드를 감싸서 dispose 메서드 호출
            using (WebClient wc = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", txtSearch.Text, weatherKey);

                /* webclient 클래스의 downloadstring 메서드를 통해서 api에서 데이터를 받아 string으로 받아오기. 주로 Json 파일로 받음 */
                string json = wc.DownloadString(url);

                /* Json 파일 객체를 매핑할 객체 info / JsonConvert.DeserializeObject<T>() 메서드를 사용하여 JSON 데이터를 디시리얼라이즈 하여 C# 객체로 변환 후 Info 객체에 대입 */
                Weather.root Info = JsonConvert.DeserializeObject<Weather.root>(json);

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

            lblSunRIseResult.Text = convertSunTime(Info.sys.sunrise).ToShortTimeString(); //convertSunTime메서드를 통해 DateTime 객체 받아왔음. 따라서 DateTime 메서드를 쓸 수 있다.
            lblSunSetResult.Text = convertSunTime(Info.sys.sunset).ToShortTimeString();
        }


        //받은 세컨드(long타입)를 DateTime 객체로 반환함. //string int 등이 아니라 Datetime 형 객체를 반환하기 때문에 private DateTime이라고 함
        private DateTime convertSunTime(long s)
        {
            //1970년부터 시작한 것이라서 첫 시작을 잡아줌.
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(s).ToLocalTime();

            return day;
        }


        //시간에 따라 이미지 변경하기
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


        //위치, 날짜, 시간 함수들
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
            lblLocation.Text = txtSearch.Text + ", Korea";
            return lblLocation.Text;
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            try {
                //weather api 불러오는 함수 호출해서 계속 다른 txtSearch.Text(city명)로 api 가져오게 함
                if (txtSearch.Text != "" && Regex.IsMatch(txtSearch.Text, "^[a-zA-Z]+$"))
                { //api가 영어로 검색해야해서 검색창에 텍스트가 있고, 영어일 때만 api 불러옴
                    getWeather();
                    getLocation();
                    lblAlert.Text = "";
                }
                else
                {
                    lblAlert.Text = "영어로 지역명을 검색해주세요.";
                }
            } catch {
                lblAlert.Text = "잘못된 지역명입니다.";
            }
            

            //날짜 및 위치 불러오는 함수 호출
            getDate();
            getWeek();
            
        }
    }
}
