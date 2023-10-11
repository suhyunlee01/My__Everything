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
//mysql 연동
using MySql.Data.MySqlClient;

namespace My__Everything
{
    public partial class Form3 : Form
    {
        string connectionString;
        Form4 weatherPage;
        todoItems items;
        private int gap = 10;

        public Form3()
        {
            InitializeComponent();
            weatherPage = new Form4();
            connectionString = "Server=localhost;Database=todo_db;Uid=root;Pwd=1234;";
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


            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // myeverything_todolist 테이블의 모든 데이터를 읽어옴
                string selectQuery = "SELECT * FROM myeverything_todolist";
                using (MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection))
                {
                    using (MySqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // 각 행의 데이터를 읽어옴
                            string todoItem = reader["todo"].ToString();
                            addItems(todoItem);
                        }
                    }
                }
            }


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
            if (txtAddTodo.Text != "")
            {

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // txtAddTodo.Text의 값을 myeverything_todolist 테이블의 todo 열에 삽입
                    string insertQuery = "INSERT INTO myeverything_todolist (todo) VALUES (@todo)";

                    using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@todo", txtAddTodo.Text);
                        int rowsAffected = insertCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("데이터가 성공적으로 삽입되었습니다.");
                        }
                        else
                        {
                            Console.WriteLine("데이터를 삽입하는 데 실패했습니다.");
                        }
                    }

                    // myeverything_todolist 테이블의 모든 데이터를 읽어옴
                    string selectQuery = "SELECT * FROM myeverything_todolist";
                    using (MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection))
                    {
                        using (MySqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // 각 행의 데이터를 읽어옴
                                string todoItem = reader["todo"].ToString();
                                addItems(todoItem);
                            }
                        }
                    }
                }
            }
            else
            {
                // txtAddTodo.Text가 비어있을 때의 처리
                return;
            }
        }

        //todo아이템 개수 세어서 몇 개 남았는지 프린트하는 함수
        private void CalcTodoNum()
        {
            // panel1의 자식 컨트롤 중에서 todoItems 클래스 형식의 객체
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
