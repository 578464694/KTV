namespace KTV_stand_online_vsrsion
{
    partial class FormAdd
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
            this.dgvGetData = new System.Windows.Forms.DataGridView();
            this.lvwSongsFromDB = new System.Windows.Forms.ListView();
            this.lvwColumnSong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwPlayList = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEnterAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGetData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGetData
            // 
            this.dgvGetData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGetData.Location = new System.Drawing.Point(-13, 315);
            this.dgvGetData.Name = "dgvGetData";
            this.dgvGetData.RowTemplate.Height = 23;
            this.dgvGetData.Size = new System.Drawing.Size(529, 122);
            this.dgvGetData.TabIndex = 2;
            // 
            // lvwSongsFromDB
            // 
            this.lvwSongsFromDB.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvwColumnSong});
            this.lvwSongsFromDB.FullRowSelect = true;
            this.lvwSongsFromDB.GridLines = true;
            this.lvwSongsFromDB.Location = new System.Drawing.Point(22, 12);
            this.lvwSongsFromDB.MultiSelect = false;
            this.lvwSongsFromDB.Name = "lvwSongsFromDB";
            this.lvwSongsFromDB.Size = new System.Drawing.Size(226, 212);
            this.lvwSongsFromDB.TabIndex = 3;
            this.lvwSongsFromDB.UseCompatibleStateImageBehavior = false;
            this.lvwSongsFromDB.View = System.Windows.Forms.View.Details;
            this.lvwSongsFromDB.Click += new System.EventHandler(this.lvwSongsFromDB_Click);
            // 
            // lvwColumnSong
            // 
            this.lvwColumnSong.Text = "歌曲列表";
            this.lvwColumnSong.Width = 600;
            // 
            // lvwPlayList
            // 
            this.lvwPlayList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName});
            this.lvwPlayList.FullRowSelect = true;
            this.lvwPlayList.GridLines = true;
            this.lvwPlayList.Location = new System.Drawing.Point(288, 12);
            this.lvwPlayList.Name = "lvwPlayList";
            this.lvwPlayList.Size = new System.Drawing.Size(228, 212);
            this.lvwPlayList.TabIndex = 4;
            this.lvwPlayList.UseCompatibleStateImageBehavior = false;
            this.lvwPlayList.View = System.Windows.Forms.View.Details;
            // 
            // chName
            // 
            this.chName.Text = "播放列表";
            this.chName.Width = 600;
            // 
            // btnEnterAdd
            // 
            this.btnEnterAdd.Location = new System.Drawing.Point(121, 253);
            this.btnEnterAdd.Name = "btnEnterAdd";
            this.btnEnterAdd.Size = new System.Drawing.Size(75, 23);
            this.btnEnterAdd.TabIndex = 5;
            this.btnEnterAdd.Text = "确认添加";
            this.btnEnterAdd.UseVisualStyleBackColor = true;
            this.btnEnterAdd.Click += new System.EventHandler(this.btnEnterAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(232, 253);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "重新添加";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KTV_stand_online_vsrsion.Properties.Resources.delete;
            this.pictureBox1.Location = new System.Drawing.Point(254, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(373, 253);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 8;
            this.btnReturn.Text = "回退";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 351);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEnterAdd);
            this.Controls.Add(this.lvwPlayList);
            this.Controls.Add(this.lvwSongsFromDB);
            this.Controls.Add(this.dgvGetData);
            this.Name = "FormAdd";
            this.Text = "添加歌曲";
            this.Load += new System.EventHandler(this.FormAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGetData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvGetData;
        public System.Windows.Forms.ListView lvwSongsFromDB;
        private System.Windows.Forms.ColumnHeader lvwColumnSong;
        private System.Windows.Forms.ListView lvwPlayList;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.Button btnEnterAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReturn;
    }
}