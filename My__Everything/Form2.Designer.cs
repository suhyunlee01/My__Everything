namespace My__Everything
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label5 = new System.Windows.Forms.Label();
            this.lblquote = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.QuoteBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWeek = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lbltemp = new System.Windows.Forms.Label();
            this.btnHomeWeahter = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.QuoteBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Pretendard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(535, 510);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 19);
            this.label5.TabIndex = 68;
            this.label5.Text = "오늘의 명언";
            // 
            // lblquote
            // 
            this.lblquote.BackColor = System.Drawing.Color.White;
            this.lblquote.Font = new System.Drawing.Font("Pretendard SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblquote.ForeColor = System.Drawing.Color.Black;
            this.lblquote.Location = new System.Drawing.Point(535, 418);
            this.lblquote.Name = "lblquote";
            this.lblquote.Size = new System.Drawing.Size(259, 85);
            this.lblquote.TabIndex = 67;
            this.lblquote.Text = "Walking with a friend in the dark\nis better than walking alone in the\nlight.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Pretendard ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(132)))), ((int)(((byte)(252)))));
            this.label3.Location = new System.Drawing.Point(534, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 29);
            this.label3.TabIndex = 66;
            this.label3.Text = "Quotes";
            // 
            // QuoteBox
            // 
            this.QuoteBox.BackColor = System.Drawing.Color.White;
            this.QuoteBox.Location = new System.Drawing.Point(508, 335);
            this.QuoteBox.Name = "QuoteBox";
            this.QuoteBox.Size = new System.Drawing.Size(381, 247);
            this.QuoteBox.TabIndex = 65;
            this.QuoteBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pretendard ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(132)))), ((int)(((byte)(252)))));
            this.label1.Location = new System.Drawing.Point(814, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 61;
            this.label1.Text = "Home";
            // 
            // lblWeek
            // 
            this.lblWeek.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblWeek.BackColor = System.Drawing.Color.Transparent;
            this.lblWeek.Font = new System.Drawing.Font("Pretendard Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblWeek.Location = new System.Drawing.Point(632, 254);
            this.lblWeek.Name = "lblWeek";
            this.lblWeek.Size = new System.Drawing.Size(207, 29);
            this.lblWeek.TabIndex = 60;
            this.lblWeek.Text = "Monday";
            this.lblWeek.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Pretendard Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTime.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTime.Location = new System.Drawing.Point(635, 222);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(204, 29);
            this.lblTime.TabIndex = 59;
            this.lblTime.Text = "6:00 PM";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLocation
            // 
            this.lblLocation.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblLocation.BackColor = System.Drawing.Color.Transparent;
            this.lblLocation.Font = new System.Drawing.Font("Pretendard Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblLocation.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblLocation.Location = new System.Drawing.Point(419, 190);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(415, 29);
            this.lblLocation.TabIndex = 58;
            this.lblLocation.Text = "Seoul";
            this.lblLocation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Pretendard Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDate.Location = new System.Drawing.Point(94, 251);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(159, 32);
            this.lblDate.TabIndex = 57;
            this.lblDate.Text = "2023. 07. 12";
            // 
            // lbltemp
            // 
            this.lbltemp.AutoSize = true;
            this.lbltemp.BackColor = System.Drawing.Color.Transparent;
            this.lbltemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbltemp.Font = new System.Drawing.Font("Pretendard", 69.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbltemp.Location = new System.Drawing.Point(94, 103);
            this.lbltemp.Name = "lbltemp";
            this.lbltemp.Size = new System.Drawing.Size(202, 111);
            this.lbltemp.TabIndex = 56;
            this.lbltemp.Text = "22°";
            // 
            // btnHomeWeahter
            // 
            this.btnHomeWeahter.BackColor = System.Drawing.Color.Transparent;
            this.btnHomeWeahter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHomeWeahter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHomeWeahter.FlatAppearance.BorderSize = 0;
            this.btnHomeWeahter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHomeWeahter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHomeWeahter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomeWeahter.ForeColor = System.Drawing.Color.Transparent;
            this.btnHomeWeahter.Image = ((System.Drawing.Image)(resources.GetObject("btnHomeWeahter.Image")));
            this.btnHomeWeahter.Location = new System.Drawing.Point(59, 69);
            this.btnHomeWeahter.Name = "btnHomeWeahter";
            this.btnHomeWeahter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnHomeWeahter.Size = new System.Drawing.Size(830, 244);
            this.btnHomeWeahter.TabIndex = 55;
            this.btnHomeWeahter.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 5000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 5000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(59, 387);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 195);
            this.panel1.TabIndex = 138;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Pretendard ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(132)))), ((int)(((byte)(252)))));
            this.label2.Location = new System.Drawing.Point(84, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 29);
            this.label2.TabIndex = 139;
            this.label2.Text = "TO DO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(59, 333);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(430, 247);
            this.pictureBox1.TabIndex = 140;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(943, 608);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblquote);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.QuoteBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWeek);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lbltemp);
            this.Controls.Add(this.btnHomeWeahter);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QuoteBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblquote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox QuoteBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWeek;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lbltemp;
        private System.Windows.Forms.Button btnHomeWeahter;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}