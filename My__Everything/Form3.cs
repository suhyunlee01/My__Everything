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
    public partial class Form3 : Form
    {
        Form4 weatherPage;
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
            timer1.Start();
            lblDate.Text = DateTime.Now.ToString("yyyy. MM. dd. dddd");
            lbltodoDate.Text = DateTime.Now.ToString("yyyy. MM. dd");
        }
    }
}
