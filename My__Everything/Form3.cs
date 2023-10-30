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

        //todoItems 클래스의 인스턴스를 요소로 가지는 리스트를 _todoItems라고 정의
        private List<todoItems> _todoItems;

        public Form3()
        {
            InitializeComponent();
            weatherPage = new Form4();
            connectionString = "Server=localhost;Database=todo_db;Uid=root;Pwd=1234;";
        }

        // GetTodoItemsFromMySQL()메소드로 반환해온 결과를 저장한 리스트 반환
        public List<todoItems> GetTodoItems()
        {
            return _todoItems;
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
                            addItems(todoItem, id);
                        }
                    }
                }
            }


        }
        public void addItems(string todoItem, int id)
        {
            //투두 아이템 컨트롤 객체 선언, 생성자에 텍스트 보내기
            items = new todoItems(todoItem, id);

            items.Parent = panel1;

            //컨트롤의 상단 위치
            items.Top = gap;

            //다른 items들의 상단 위치(y축을) 10씩 늘려서 아래로 보냄
            gap = (items.Top + items.Height + 10);

            CalcTodoNum();
        }


        //버튼 클릭 시 todoitem 추가
        private void btnSave_Click(object sender, EventArgs e)
        {
            //텍스트가 비어있지 않을 때만 데이터베이스에 넣을거임~
            if (txtAddTodo.Text != "")
            {
                // 이 블록이 끝나면 connection이 자동으로 닫히고 리소스가 해제되게 함.
                //즉 using 블록을 벗어날 때 connection 객체의 Dispose() 메서드가 자동으로 호출되어 리소스를 해제
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    //서버 연결
                    connection.Open();


                    //INSERT
                    // txtAddTodo.Text의 값을 myeverything_todolist 테이블의 todo 열에 삽입
                    string InsertQuery = "INSERT INTO myeverything_todolist (todo) VALUES (@todo)";

                    using (MySqlCommand Insert = new MySqlCommand(InsertQuery, connection))
                    {
                        Insert.Parameters.AddWithValue("@todo", txtAddTodo.Text);

                        //해당 쿼리문을 실행해서 영향받은 행 반환하는 메서드 ExecuteNonQuery()
                        int rowsAffected = Insert.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("데이터가 INSERT 성공.");
                        }
                        else
                        {
                            Console.WriteLine("데이터 INSERT 실패.");
                        }
                    }

                    //SELECT
                    //myeverything_todolist 테이블의 id와 todo를 가져오되, id가 가장 마지막의 것만 가져옴
                    string SelectQuery = "SELECT id, todo FROM myeverything_todolist ORDER BY id DESC LIMIT 1;";
                    using (MySqlCommand Select = new MySqlCommand(SelectQuery, connection))
                    {
                        using (MySqlDataReader reader = Select.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                //id와 todoItem 의 데이터를 읽어옴

                                //정수로 변환
                                int id = Convert.ToInt32(reader["id"]);
                                //문자열로 변환
                                string todo = reader["todo"].ToString();
                                addItems(todo, id);
                            }
                        }
                    }


                    // additem을 공백없이 보여주기 위해서 item 추가 시마다 Form3를 다시 생성하고 보여줌

                    Form3 newForm3 = new Form3();
                    Form1 mainForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();
                    newForm3.Show();
                    newForm3.MdiParent = mainForm;
                    this.Hide();
                    newForm3.Location = new Point(0, 0);

                }
            }
            else
            {
                // txtAddTodo.Text가 비어있을 때의 처리
                return;
            }
        }

        //todo아이템 개수 세어서 몇 개 남았는지 프린트하는 함수
        public void CalcTodoNum()
        {
            // panel1의 자식 컨트롤 중에서 todoItems 클래스 형식의 객체를 카운트 하도록 했음.
            label7.Text = panel1.Controls.OfType<todoItems>().Count().ToString() + " 개 남았습니다.";
        }


        //명언 api 불러오는 함수
        public void getQuote()
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
