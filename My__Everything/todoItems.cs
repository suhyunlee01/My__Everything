using MySql.Data.MySqlClient;
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
        public int Id;
        public string Todo;
        //생성자를 통해 객체를 생성하는 곳에서 데이터 받아오기
        public todoItems(string todo, int id)
        {
            InitializeComponent();

            lblToDo.Text = todo;
            btnChk.Image = Properties.Resources.todonot;

            Id = id;
            Todo = todo;
        }

        private void btnChk_Click(object sender, EventArgs e)
        {
            btnChk.Image = Properties.Resources.todoclicked;

            //lblToDo 레이블과 동일한 글꼴 패밀리,  lblToDo 레이블 컨트롤의 현재 폰트 크기와 동일한 크기, FontStyle.Strikeout을 통해 폰트에 선 그어진 스타일 적용
            lblToDo.Font = new Font(lblToDo.Name, lblToDo.Font.SizeInPoints, FontStyle.Strikeout);

            if (btnChk.Image == Properties.Resources.todoclicked)
            {
                btnChk.Image = Properties.Resources.todonot;
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=todo_db;Uid=root;Pwd=1234;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                //서버 실행
                connection.Open();

                // DELETE 쿼리 실행
                string deleteQuery = "DELETE FROM myeverything_todolist WHERE id = @id";
                using (MySqlCommand cmd = new MySqlCommand(deleteQuery, connection))
                {
                    //
                    cmd.Parameters.AddWithValue("@id", Id);
                    //예외처리
                    int deletenum = cmd.ExecuteNonQuery();
                    if (deletenum > 0) {
                        Console.WriteLine("데이터 DELETE 성공!!!!!");
                    }
                }
            }
        }
        public int GetRecordId()
        {
            int dbID = 1;
            return dbID;
        }
    }
}



