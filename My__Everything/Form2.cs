using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;
using System.IO;
using MySql.Data.MySqlClient;

namespace My__Everything
{
    public partial class Form2 : Form
    {
        string jsonFilePath = "C:\\Users\\KOSTA\\Desktop\\새 폴더\\My__Everything\\My__Everything\\Data\\api_key.json";
        private string txtSearch;
        private int gap;
        private string weatherKey;
        private string[] city = { "Seoul", "Busan", "Daegu", "Incheon", "Gwangju",
            "Daejeon", "Ulsan", "Sejong", "Gyeonggi-do", "Gangwon-do",
            "Chungcheongbuk-do", "Chungcheongnam-do", "Jeju", "Jeollabuk-do",
            "Jeollanam-do", "Gyeongsangbuk-do", "Gyeongsangnam-do"};
        private int currentIndex = 0;

        //아이디 읽어올 배열
        private int[] ids;
        //투두 읽어올 배열
        private string[] todoItems;

        Form4 weatherPage = new Form4();

        public Form2()
        {
            InitializeComponent();
            gap = 10;
            //api
            ApiKeyClass apiKeys;
            string jsonText = File.ReadAllText(jsonFilePath);
            apiKeys = JsonConvert.DeserializeObject<ApiKeyClass>(jsonText);
            weatherKey = apiKeys.ApiKey.ToString();


            lblDate.Parent = btnHomeWeahter;
            lblLocation.Parent = btnHomeWeahter;
            lbltemp.Parent = btnHomeWeahter;
            lblTime.Parent = btnHomeWeahter;
            lblWeek.Parent = btnHomeWeahter;


            lbltemp.Location = new Point(23, 72);
            lblDate.Location = new Point(42, 180);

            lblLocation.Location = new Point(384, 180);
            lblTime.Location = new Point(595, 145);
            lblWeek.Location = new Point(590, 105);
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            //위치, 날짜 정보 함수 호출
            //lblLocation.Text = weatherPage.getLocation();
            lblWeek.Text = weatherPage.getWeek();
            lblDate.Text = weatherPage.getDate();
            //가져온 시간부터 1초씩 증가
            timer1.Start();
            //5초에 한 번씩 지역명 바꾸기
            timer2.Start();
            //5초에 한 번씩 명언 바꾸기
            timer3.Start();

            //이미지 변경 함수 호출
            changeImg();
            getSeoulWeather();

            string connectionString = "Server=localhost;Database=todo_db;Uid=root;Pwd=1234;";
            
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                //서버 연결
                connection.Open();

                //SELECT
                //myeverything_todolist 테이블의 모든 데이터를 읽어옴
                string SelectQuery = "SELECT * FROM myeverything_todolist";
                using (MySqlCommand Select = new MySqlCommand(SelectQuery, connection))
                {
                    using (MySqlDataReader reader = Select.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // 각 행의 데이터를 읽어옴
                            int id = Convert.ToInt32(reader["id"]);
                            string todoItem = reader["todo"].ToString();
                            printItems(todoItem, id);
                        }
                    }
                }
            }
        }
        public void printItems(string todoItem, int id)
        {

            todoItems items;
            //투두 아이템 컨트롤 객체 선언, 생성자에 텍스트 보내기
            items = new todoItems(todoItem, id);

            items.Parent = panel1;

            items.Left = 10;

            //컨트롤의 상단 위치
            items.Top = gap;

            //다른 items들의 상단 위치(y축을) 10씩 늘려서 아래로 보냄
            gap = (items.Top + items.Height + 10);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = weatherPage.getTime();
        }


        //도시 다르게 해서 api 불러오기
        private void timer2_Tick(object sender, EventArgs e)
        {

            //위치정보 텍스트를 현재 인덱스로 바꿈
            if(lblLocation.Text != city[currentIndex]){
                lblLocation.Text = city[currentIndex];
            }

            //api 도시명 현재 인덱스로 바꿈
            txtSearch = city[currentIndex];

            currentIndex++;

            //배열 끝나면 다시 0으로
            if (currentIndex >= city.Length)
            {
                currentIndex = 0;
            }

            getWeather();
        }


        public void getSeoulWeather()
        {
            //using 문 사용해서 리소스 관리
            using (WebClient wc = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q=Seoul&appid={0}", weatherKey);

                string json = wc.DownloadString(url); //WebClient 객체로 DownloadString()메서드를 통해 url데이터를 받아옴. 해당 데이터를 json 변수에 저장.
                Weather.root Info = JsonConvert.DeserializeObject<Weather.root>(json); //json 파일을 DeserializeObject를 통해 디시리얼라이즈함.

                //날씨 정보 출력하는 함수 호출
                getTemp(Info);
            }
        }
        public void getWeather()
        {
            //using 문 사용해서 리소스 관리
            using (WebClient wc = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", txtSearch, weatherKey);

                string json = wc.DownloadString(url); //WebClient 객체로 DownloadString()메서드를 통해 url데이터를 받아옴. 해당 데이터를 json 변수에 저장.
                Weather.root Info = JsonConvert.DeserializeObject<Weather.root>(json); //json 파일을 DeserializeObject를 통해 디시리얼라이즈함.

                //날씨 정보 출력하는 함수 호출
                getTemp(Info);
            }
        }

        //현재 온도 저장하는 함수
        public void getTemp(Weather.root Info)
        {
            lbltemp.Text = Math.Ceiling((Info.main.temp - 273.15)).ToString() + "°";
        }

        //이미지 바꾸는 함수
        public void changeImg()
        {

            if (int.Parse(DateTime.Now.ToString("HH")) >= 05 && int.Parse(DateTime.Now.ToString("HH")) < 17)
            {
                btnHomeWeahter.Image = Properties.Resources.w1;
            }
            else if (int.Parse(DateTime.Now.ToString("HH")) >= 17 && int.Parse(DateTime.Now.ToString("HH")) < 21)
            {
                btnHomeWeahter.Image = Properties.Resources.w2;
            }
            else
            {
                btnHomeWeahter.Image = Properties.Resources.w3;
            }
        }



        //명언 api 불러오는 함수
        private void getQuote()
        {
            using (WebClient wc = new WebClient())
            {
                string url = "https://api.adviceslip.com/advice";
                string json = wc.DownloadString(url);
                Quotes.root quote = JsonConvert.DeserializeObject<Quotes.root>(json);

                lblquote.Text = quote.slip.advice;
            }
        }

        //5초에 한 번 api 불러오기
        private void timer3_Tick(object sender, EventArgs e)
        {
            getQuote();
        }
    }
}
