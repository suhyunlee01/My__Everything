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
        public todoItems()
        {
            InitializeComponent();
        }

        public todoItems(string Text) //생성자를 통해 객체를 생성하는 곳에서 Text 데이터를 받아옴
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

            int recordId = GetRecordId(); // 데이터베이스 레코드의 ID를 얻어오는 메소드임.

            // 데이터베이스 연결 설정
            string connectionString = "Server=localhost;Database=todo_db;Uid=root;Pwd=1234;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // 데이터베이스 레코드 삭제 쿼리
                string deleteQuery = "DELETE FROM myeverything_todolist WHERE id = @id";

                using (MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, connection))
                {
                    deleteCommand.Parameters.AddWithValue("@id", recordId);

                    // 삭제 쿼리
                    int rowsAffected = deleteCommand.ExecuteNonQuery();

                    // 데이터베이스에서 삭제가 성공적으로 이루어졌을 때
                    if (rowsAffected > 0)
                    {
                        // 화면에서 객체를 제거하고 메모리에서 해제
                        if (Parent != null)
                        {
                            Parent.Controls.Remove(this);
                            Dispose();
                        }

                        Console.WriteLine("데이터베이스 레코드가 성공적으로 삭제되었습니다.");
                    }
                    else
                    {
                        Console.WriteLine("데이터베이스 레코드 삭제에 실패했습니다.");
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



