namespace My__Everything
{
    partial class todoItems
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(todoItems));
            this.lblToDo = new System.Windows.Forms.Label();
            this.btnChk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblToDo
            // 
            this.lblToDo.AutoSize = true;
            this.lblToDo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(252)))));
            this.lblToDo.Font = new System.Drawing.Font("Pretendard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblToDo.ForeColor = System.Drawing.Color.Black;
            this.lblToDo.Location = new System.Drawing.Point(60, 15);
            this.lblToDo.Name = "lblToDo";
            this.lblToDo.Size = new System.Drawing.Size(73, 19);
            this.lblToDo.TabIndex = 142;
            this.lblToDo.Text = "해야 할 일";
            // 
            // btnChk
            // 
            this.btnChk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(252)))));
            this.btnChk.FlatAppearance.BorderSize = 0;
            this.btnChk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChk.Image = ((System.Drawing.Image)(resources.GetObject("btnChk.Image")));
            this.btnChk.Location = new System.Drawing.Point(25, 10);
            this.btnChk.Name = "btnChk";
            this.btnChk.Size = new System.Drawing.Size(27, 27);
            this.btnChk.TabIndex = 143;
            this.btnChk.UseVisualStyleBackColor = false;
            this.btnChk.Click += new System.EventHandler(this.btnChk_Click);
            // 
            // todoItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.btnChk);
            this.Controls.Add(this.lblToDo);
            this.Name = "todoItems";
            this.Size = new System.Drawing.Size(410, 48);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblToDo;
        private System.Windows.Forms.Button btnChk;
    }
}
