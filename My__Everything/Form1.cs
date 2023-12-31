﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;


namespace My__Everything
{

    public partial class Form1 : Form
    {
        Form2 homePage;
        Form3 todoPage;
        Form4 weatherPage;

        bool sidebarExpand;

        public Form1()
        {
            InitializeComponent();

            IsMdiContainer = true;

            homePage = new Form2();
            homePage.MdiParent = this;
            todoPage = new Form3();
            todoPage.MdiParent = this;
            weatherPage = new Form4();
            weatherPage.MdiParent = this;
        }

        private void btnMenuUnder_Click(object sender, EventArgs e)
        {
            SidebarTimer.Start();

        }

        private void btnMenuUp_Click(object sender, EventArgs e)
        {
            SidebarTimer.Start();
        }

        private void SidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 20;// 1ms마다 20px씩 줄여줌

                //줄어들어서 사이드바가 열려있을 때. 맥시멈 사이즈라면,
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false; //다 줄어들어서 사이드바가 열리지 않은 상태
                    SidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 20; // 1ms마다 20px씩 늘려줌

                //늘어나서 사이드바가 열려있을 때. 맥시멈 사이즈라면,
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true; //다 늘어나서 사이드바가 열린 상태
                    SidebarTimer.Stop();
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType().Name == "Form2")
                    form.Hide();
            }
            // Form2를 갱신
            homePage = new Form2();
            homePage.MdiParent = this;
            homePage.Show();
            homePage.BringToFront();
            homePage.Location = new Point(0, 0);
        }

        private void btnCalander_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType().Name == "Form3")
                    form.Hide();
            }
            // Form2를 갱신
            todoPage = new Form3();
            todoPage.MdiParent = this;
            todoPage.Show();
            todoPage.BringToFront();
            todoPage.Location = new Point(0, 0);

        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType().Name == "Form4")
                    form.Hide();
            }
            weatherPage = new Form4();
            weatherPage.MdiParent = this;
            weatherPage.Show();
            weatherPage.BringToFront();
            weatherPage.Location = new Point(0, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType().Name == "Form2")
                    form.Hide();
            }
            homePage.Show();
            homePage.BringToFront();
            homePage.Location = new Point(0, 0);

            sidebar.Width = sidebar.MinimumSize.Width;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
