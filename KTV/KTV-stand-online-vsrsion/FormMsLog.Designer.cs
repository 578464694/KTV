namespace KTV_stand_online_vsrsion
{
    partial class FormMsLog
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
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.tbxPwd = new System.Windows.Forms.TextBox();
            this.labTipName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMsLog = new System.Windows.Forms.Button();
            this.labTip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxUsername
            // 
            this.tbxUsername.Location = new System.Drawing.Point(107, 75);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(151, 21);
            this.tbxUsername.TabIndex = 0;
            // 
            // tbxPwd
            // 
            this.tbxPwd.Location = new System.Drawing.Point(107, 122);
            this.tbxPwd.Name = "tbxPwd";
            this.tbxPwd.Size = new System.Drawing.Size(151, 21);
            this.tbxPwd.TabIndex = 1;
            // 
            // labTipName
            // 
            this.labTipName.AutoSize = true;
            this.labTipName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTipName.Location = new System.Drawing.Point(29, 80);
            this.labTipName.Name = "labTipName";
            this.labTipName.Size = new System.Drawing.Size(65, 20);
            this.labTipName.TabIndex = 2;
            this.labTipName.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(43, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "密码：";
            // 
            // btnMsLog
            // 
            this.btnMsLog.Location = new System.Drawing.Point(107, 186);
            this.btnMsLog.Name = "btnMsLog";
            this.btnMsLog.Size = new System.Drawing.Size(75, 23);
            this.btnMsLog.TabIndex = 4;
            this.btnMsLog.Text = "登录";
            this.btnMsLog.UseVisualStyleBackColor = true;
            this.btnMsLog.Click += new System.EventHandler(this.btnMsLog_Click);
            // 
            // labTip
            // 
            this.labTip.AutoSize = true;
            this.labTip.ForeColor = System.Drawing.Color.Red;
            this.labTip.Location = new System.Drawing.Point(47, 162);
            this.labTip.Name = "labTip";
            this.labTip.Size = new System.Drawing.Size(0, 12);
            this.labTip.TabIndex = 5;
            // 
            // FormMsLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 261);
            this.Controls.Add(this.labTip);
            this.Controls.Add(this.btnMsLog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labTipName);
            this.Controls.Add(this.tbxPwd);
            this.Controls.Add(this.tbxUsername);
            this.Name = "FormMsLog";
            this.Text = "管理员登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.TextBox tbxPwd;
        private System.Windows.Forms.Label labTipName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMsLog;
        private System.Windows.Forms.Label labTip;
    }
}