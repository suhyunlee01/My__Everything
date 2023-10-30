using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My__Everything
{
    public partial class loadingPage : Form
    {
        public loadingPage()
        {
            InitializeComponent();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            progressBar1.Increment(6);
            if(progressBar1.Value == 100 ) { 
                timer1.Enabled=false;
                Form1 form = new Form1();
                form.Show();
                this.Hide();
            }
        }

        private void loadingPage_Load(object sender, EventArgs e)
        {
            // 인터넷 연결 상태 확인
            if (!NetworkInterface.GetIsNetworkAvailable())
            {
                // 인터넷 연결이 없을 때 MessageBox 표시
                MessageBox.Show("인터넷 연결이 되어있지 않습니다.");
                Application.Exit(); // 앱 종료하기
            }
            else
            {
                // 인터넷 연결이 있으면 타이머 시작
                timer1.Start();
            }
        }
    }
}
