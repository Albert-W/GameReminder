namespace GameForm
{
    partial class GameReminder
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.InterTxb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.beginBtn = new System.Windows.Forms.Button();
            this.endBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InterTxb
            // 
            this.InterTxb.Location = new System.Drawing.Point(175, 44);
            this.InterTxb.Name = "InterTxb";
            this.InterTxb.Size = new System.Drawing.Size(100, 25);
            this.InterTxb.TabIndex = 0;
            this.InterTxb.TextChanged += new System.EventHandler(this.InterTxb_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Interval";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // beginBtn
            // 
            this.beginBtn.Location = new System.Drawing.Point(92, 139);
            this.beginBtn.Name = "beginBtn";
            this.beginBtn.Size = new System.Drawing.Size(140, 30);
            this.beginBtn.TabIndex = 2;
            this.beginBtn.Text = "Begin to play";
            this.beginBtn.UseVisualStyleBackColor = true;
            this.beginBtn.Click += new System.EventHandler(this.beginBtn_Click);
            // 
            // endBtn
            // 
            this.endBtn.Location = new System.Drawing.Point(299, 139);
            this.endBtn.Name = "endBtn";
            this.endBtn.Size = new System.Drawing.Size(140, 30);
            this.endBtn.TabIndex = 2;
            this.endBtn.Text = "End the game";
            this.endBtn.UseVisualStyleBackColor = true;
            this.endBtn.Click += new System.EventHandler(this.endBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Interval Default:5 seconds";
            // 
            // GameReminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 246);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.endBtn);
            this.Controls.Add(this.beginBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InterTxb);
            this.Name = "GameReminder";
            this.Text = "Game Reminder";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameReminder_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InterTxb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button beginBtn;
        private System.Windows.Forms.Button endBtn;
        private System.Windows.Forms.Label label2;
    }
}

