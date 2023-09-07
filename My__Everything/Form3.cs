using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My__Everything
{
    public partial class Form3 : Form
    {
        Form4 weatherPage;
        todoItems items;
        private int gap = 10;
        public Form3()
        {
            InitializeComponent();
            weatherPage = new Form4();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm tt", new System.Globalization.CultureInfo("en-US"));
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //시계 1초에 한 번씩 업데이트
            timer1.Start();

            //날짜 업데이트
            lblDate.Text = DateTime.Now.ToString("yyyy. MM. dd. dddd");
            lbltodoDate.Text = DateTime.Now.ToString("yyyy. MM. dd");

            //명언 5초에 한 번씩 호출
            timer2.Start();
        }

        public void addItems(string Text)
        {
            //투두 아이템 컨트롤 객체 선언, 생성자에 텍스트 보내기
            items = new todoItems(Text);

            items.Parent = panel1;

            //컨트롤의 상단 위치
            items.Top = gap;

            //다른 items들의 상단 위치(y축을) 10씩 늘려서 아래로 보냄
            gap = (items.Top + items.Height + 10);

            CalcTodoNum();
        }


        //버튼 클릭 시 todoitem 추가
        private void btnSearch_Click(object sender, EventArgs e)
        {
           if(txtAddTodo.Text != "")
            {
                addItems(txtAddTodo.Text);
            }
            else
            {
                return;
            }
        }

        //todo아이템 개수 세어서 몇 개 남았는지 프린트하는 함수
        private void CalcTodoNum()
        {
            label7.Text = panel1.Controls.OfType<todoItems>().Count().ToString() + " 개 남았습니다.";
        }


        //명언 api 불러오는 함수
        private void getQuote()
        {
            using(WebClient wc = new WebClient())
            {
                string url = "https://api.adviceslip.com/advice";
                string json = wc.DownloadString(url);
                Quotes.root quote = JsonConvert.DeserializeObject<Quotes.root>(json);

                lblquote.Text = quote.slip.advice;
            }
        }

        //5초에 한 번씩 명언 api 불러오기
        private void timer2_Tick(object sender, EventArgs e)
        {
            getQuote();
        }
    }
}
