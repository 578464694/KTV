namespace KTV_stand_online_vsrsion
{
    partial class FormChoose
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
            this.btnMsLog = new System.Windows.Forms.Button();
            this.btnUserLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMsLog
            // 
            this.btnMsLog.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMsLog.Location = new System.Drawing.Point(120, 52);
            this.btnMsLog.Name = "btnMsLog";
            this.btnMsLog.Size = new System.Drawing.Size(122, 60);
            this.btnMsLog.TabIndex = 4;
            this.btnMsLog.Text = "管理员登录";
            this.btnMsLog.UseVisualStyleBackColor = true;
            this.btnMsLog.Click += new System.EventHandler(this.btnMsLog_Click);
            // 
            // btnUserLog
            // 
            this.btnUserLog.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUserLog.Location = new System.Drawing.Point(120, 153);
            this.btnUserLog.Name = "btnUserLog";
            this.btnUserLog.Size = new System.Drawing.Size(122, 52);
            this.btnUserLog.TabIndex = 5;
            this.btnUserLog.Text = "用户登录";
            this.btnUserLog.UseVisualStyleBackColor = true;
            this.btnUserLog.Click += new System.EventHandler(this.btnUserLog_Click);
            // 
            // FormChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 250);
            this.Controls.Add(this.btnUserLog);
            this.Controls.Add(this.btnMsLog);
            this.Name = "FormChoose";
            this.Text = "FormLog";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMsLog;
        private System.Windows.Forms.Button btnUserLog;
    }
}