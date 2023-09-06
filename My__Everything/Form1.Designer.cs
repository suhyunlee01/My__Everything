namespace My__Everything
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLocation = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnCalander = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btnMenuUp = new System.Windows.Forms.Button();
            this.btnMenuUnder = new System.Windows.Forms.Button();
            this.SidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(143, 610);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(143, 610);
            this.sidebar.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLocation);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnCalander);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.btnMenuUp);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 496);
            this.panel1.TabIndex = 0;
            // 
            // btnLocation
            // 
            this.btnLocation.BackColor = System.Drawing.Color.White;
            this.btnLocation.FlatAppearance.BorderSize = 0;
            this.btnLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocation.Image = ((System.Drawing.Image)(resources.GetObject("btnLocation.Image")));
            this.btnLocation.Location = new System.Drawing.Point(56, 383);
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.Size = new System.Drawing.Size(27, 27);
            this.btnLocation.TabIndex = 24;
            this.btnLocation.UseVisualStyleBackColor = false;
            this.btnLocation.Click += new System.EventHandler(this.btnLocation_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.White;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(56, 217);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(27, 27);
            this.btnHome.TabIndex = 23;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnCalander
            // 
            this.btnCalander.BackColor = System.Drawing.Color.White;
            this.btnCalander.FlatAppearance.BorderSize = 0;
            this.btnCalander.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalander.Image = ((System.Drawing.Image)(resources.GetObject("btnCalander.Image")));
            this.btnCalander.Location = new System.Drawing.Point(56, 301);
            this.btnCalander.Name = "btnCalander";
            this.btnCalander.Size = new System.Drawing.Size(27, 27);
            this.btnCalander.TabIndex = 22;
            this.btnCalander.UseVisualStyleBackColor = false;
            this.btnCalander.Click += new System.EventHandler(this.btnCalander_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(31, 144);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(82, 338);
            this.pictureBox6.TabIndex = 21;
            this.pictureBox6.TabStop = false;
            // 
            // btnMenuUp
            // 
            this.btnMenuUp.FlatAppearance.BorderSize = 0;
            this.btnMenuUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuUp.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuUp.Image")));
            this.btnMenuUp.Location = new System.Drawing.Point(55, 23);
            this.btnMenuUp.Name = "btnMenuUp";
            this.btnMenuUp.Size = new System.Drawing.Size(27, 27);
            this.btnMenuUp.TabIndex = 20;
            this.btnMenuUp.UseVisualStyleBackColor = true;
            this.btnMenuUp.Click += new System.EventHandler(this.btnMenuUp_Click);
            // 
            // btnMenuUnder
            // 
            this.btnMenuUnder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(252)))));
            this.btnMenuUnder.FlatAppearance.BorderSize = 0;
            this.btnMenuUnder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuUnder.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuUnder.Image")));
            this.btnMenuUnder.Location = new System.Drawing.Point(58, 26);
            this.btnMenuUnder.Name = "btnMenuUnder";
            this.btnMenuUnder.Size = new System.Drawing.Size(27, 27);
            this.btnMenuUnder.TabIndex = 22;
            this.btnMenuUnder.UseVisualStyleBackColor = false;
            this.btnMenuUnder.Click += new System.EventHandler(this.btnMenuUnder_Click);
            // 
            // SidebarTimer
            // 
            this.SidebarTimer.Interval = 1;
            this.SidebarTimer.Tick += new System.EventHandler(this.SidebarTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 612);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.btnMenuUnder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLocation;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnCalander;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button btnMenuUp;
        private System.Windows.Forms.Button btnMenuUnder;
        private System.Windows.Forms.Timer SidebarTimer;
    }
}

