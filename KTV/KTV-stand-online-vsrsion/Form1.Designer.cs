namespace KTV_stand_online_vsrsion
{
    partial class FormMain
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.timerAutoPlay = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pbxAddSong = new System.Windows.Forms.PictureBox();
            this.pnlChild = new System.Windows.Forms.Panel();
            this.pnlParent = new System.Windows.Forms.Panel();
            this.pboxPrevious = new System.Windows.Forms.PictureBox();
            this.pboxNext = new System.Windows.Forms.PictureBox();
            this.pboxPlay = new System.Windows.Forms.PictureBox();
            this.tabControlPlayMain = new System.Windows.Forms.TabControl();
            this.tpPlayList = new System.Windows.Forms.TabPage();
            this.pbxDelete = new System.Windows.Forms.PictureBox();
            this.lvwSongs = new System.Windows.Forms.ListView();
            this.lvColumnSongname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvColumnSinger = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpSinger = new System.Windows.Forms.TabPage();
            this.mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.tbxSingerName = new System.Windows.Forms.TextBox();
            this.btnQuerySinger = new System.Windows.Forms.Button();
            this.tpPinyin = new System.Windows.Forms.TabPage();
            this.tpHot = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAddSong)).BeginInit();
            this.pnlParent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPrevious)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPlay)).BeginInit();
            this.tabControlPlayMain.SuspendLayout();
            this.tpPlayList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDelete)).BeginInit();
            this.tpSinger.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // timerAutoPlay
            // 
            this.timerAutoPlay.Tick += new System.EventHandler(this.timerAutoPlay_Tick);
            // 
            // pbxAddSong
            // 
            this.pbxAddSong.Image = global::KTV_stand_online_vsrsion.Properties.Resources.list_down;
            this.pbxAddSong.Location = new System.Drawing.Point(319, 17);
            this.pbxAddSong.Name = "pbxAddSong";
            this.pbxAddSong.Size = new System.Drawing.Size(27, 28);
            this.pbxAddSong.TabIndex = 30;
            this.pbxAddSong.TabStop = false;
            this.toolTip1.SetToolTip(this.pbxAddSong, "全部歌曲");
            this.pbxAddSong.Click += new System.EventHandler(this.pbxAddSong_Click_1);
            this.pbxAddSong.MouseEnter += new System.EventHandler(this.pboxPlay_MouseEnter);
            this.pbxAddSong.MouseLeave += new System.EventHandler(this.pboxPlay_MouseLeave);
            // 
            // pnlChild
            // 
            this.pnlChild.BackColor = System.Drawing.Color.Cyan;
            this.pnlChild.Location = new System.Drawing.Point(3, 0);
            this.pnlChild.Name = "pnlChild";
            this.pnlChild.Size = new System.Drawing.Size(30, 10);
            this.pnlChild.TabIndex = 28;
            this.toolTip1.SetToolTip(this.pnlChild, "音量");
            this.pnlChild.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlChild_MouseClick);
            this.pnlChild.MouseEnter += new System.EventHandler(this.pboxPlay_MouseEnter);
            this.pnlChild.MouseLeave += new System.EventHandler(this.pboxPlay_MouseLeave);
            // 
            // pnlParent
            // 
            this.pnlParent.BackColor = System.Drawing.Color.Transparent;
            this.pnlParent.Controls.Add(this.pnlChild);
            this.pnlParent.Location = new System.Drawing.Point(401, 59);
            this.pnlParent.Name = "pnlParent";
            this.pnlParent.Size = new System.Drawing.Size(100, 10);
            this.pnlParent.TabIndex = 27;
            this.toolTip1.SetToolTip(this.pnlParent, "音量");
            this.pnlParent.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlParent_MouseClick);
            this.pnlParent.MouseEnter += new System.EventHandler(this.pboxPlay_MouseEnter);
            this.pnlParent.MouseLeave += new System.EventHandler(this.pboxPlay_MouseLeave);
            // 
            // pboxPrevious
            // 
            this.pboxPrevious.Image = global::KTV_stand_online_vsrsion.Properties.Resources.preview_down;
            this.pboxPrevious.Location = new System.Drawing.Point(109, 17);
            this.pboxPrevious.Name = "pboxPrevious";
            this.pboxPrevious.Size = new System.Drawing.Size(30, 26);
            this.pboxPrevious.TabIndex = 26;
            this.pboxPrevious.TabStop = false;
            this.toolTip1.SetToolTip(this.pboxPrevious, "上一首");
            this.pboxPrevious.Click += new System.EventHandler(this.pboxPrevious_Click_1);
            this.pboxPrevious.MouseEnter += new System.EventHandler(this.pboxPlay_MouseEnter);
            this.pboxPrevious.MouseLeave += new System.EventHandler(this.pboxPlay_MouseLeave);
            // 
            // pboxNext
            // 
            this.pboxNext.Image = global::KTV_stand_online_vsrsion.Properties.Resources.next_down;
            this.pboxNext.Location = new System.Drawing.Point(246, 17);
            this.pboxNext.Name = "pboxNext";
            this.pboxNext.Size = new System.Drawing.Size(29, 27);
            this.pboxNext.TabIndex = 25;
            this.pboxNext.TabStop = false;
            this.toolTip1.SetToolTip(this.pboxNext, "下一首");
            this.pboxNext.Click += new System.EventHandler(this.pboxNext_Click_1);
            this.pboxNext.MouseEnter += new System.EventHandler(this.pboxPlay_MouseEnter);
            this.pboxNext.MouseLeave += new System.EventHandler(this.pboxPlay_MouseLeave);
            // 
            // pboxPlay
            // 
            this.pboxPlay.Image = global::KTV_stand_online_vsrsion.Properties.Resources.play_down;
            this.pboxPlay.Location = new System.Drawing.Point(180, 16);
            this.pboxPlay.Name = "pboxPlay";
            this.pboxPlay.Size = new System.Drawing.Size(29, 29);
            this.pboxPlay.TabIndex = 24;
            this.pboxPlay.TabStop = false;
            this.toolTip1.SetToolTip(this.pboxPlay, "播放/暂停");
            this.pboxPlay.Click += new System.EventHandler(this.pboxPlay_Click_1);
            this.pboxPlay.MouseEnter += new System.EventHandler(this.pboxPlay_MouseEnter);
            this.pboxPlay.MouseLeave += new System.EventHandler(this.pboxPlay_MouseLeave);
            // 
            // tabControlPlayMain
            // 
            this.tabControlPlayMain.Controls.Add(this.tpPlayList);
            this.tabControlPlayMain.Controls.Add(this.tpSinger);
            this.tabControlPlayMain.Controls.Add(this.tpPinyin);
            this.tabControlPlayMain.Controls.Add(this.tpHot);
            this.tabControlPlayMain.Location = new System.Drawing.Point(4, 0);
            this.tabControlPlayMain.Name = "tabControlPlayMain";
            this.tabControlPlayMain.SelectedIndex = 0;
            this.tabControlPlayMain.Size = new System.Drawing.Size(544, 405);
            this.tabControlPlayMain.TabIndex = 13;
            // 
            // tpPlayList
            // 
            this.tpPlayList.BackColor = System.Drawing.Color.White;
            this.tpPlayList.Controls.Add(this.pnlParent);
            this.tpPlayList.Controls.Add(this.pbxDelete);
            this.tpPlayList.Controls.Add(this.pbxAddSong);
            this.tpPlayList.Controls.Add(this.lvwSongs);
            this.tpPlayList.Controls.Add(this.pboxPrevious);
            this.tpPlayList.Controls.Add(this.pboxNext);
            this.tpPlayList.Controls.Add(this.pboxPlay);
            this.tpPlayList.Location = new System.Drawing.Point(4, 22);
            this.tpPlayList.Name = "tpPlayList";
            this.tpPlayList.Padding = new System.Windows.Forms.Padding(3);
            this.tpPlayList.Size = new System.Drawing.Size(536, 379);
            this.tpPlayList.TabIndex = 0;
            this.tpPlayList.Text = "播放列表";
            // 
            // pbxDelete
            // 
            this.pbxDelete.Image = ((System.Drawing.Image)(resources.GetObject("pbxDelete.Image")));
            this.pbxDelete.Location = new System.Drawing.Point(474, 163);
            this.pbxDelete.Name = "pbxDelete";
            this.pbxDelete.Size = new System.Drawing.Size(39, 33);
            this.pbxDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDelete.TabIndex = 31;
            this.pbxDelete.TabStop = false;
            this.pbxDelete.Click += new System.EventHandler(this.pbxDelete_Click_1);
            this.pbxDelete.MouseEnter += new System.EventHandler(this.pboxPlay_MouseEnter);
            this.pbxDelete.MouseLeave += new System.EventHandler(this.pboxPlay_MouseLeave);
            // 
            // lvwSongs
            // 
            this.lvwSongs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvColumnSongname,
            this.lvColumnSinger});
            this.lvwSongs.FullRowSelect = true;
            this.lvwSongs.GridLines = true;
            this.lvwSongs.Location = new System.Drawing.Point(35, 88);
            this.lvwSongs.Name = "lvwSongs";
            this.lvwSongs.Size = new System.Drawing.Size(419, 230);
            this.lvwSongs.TabIndex = 29;
            this.lvwSongs.UseCompatibleStateImageBehavior = false;
            this.lvwSongs.View = System.Windows.Forms.View.Details;
            this.lvwSongs.Click += new System.EventHandler(this.lvwSongs_Click);
            // 
            // lvColumnSongname
            // 
            this.lvColumnSongname.Text = "歌名";
            this.lvColumnSongname.Width = 300;
            // 
            // lvColumnSinger
            // 
            this.lvColumnSinger.Text = "歌手";
            this.lvColumnSinger.Width = 114;
            // 
            // tpSinger
            // 
            this.tpSinger.Controls.Add(this.btnQuerySinger);
            this.tpSinger.Controls.Add(this.tbxSingerName);
            this.tpSinger.Location = new System.Drawing.Point(4, 22);
            this.tpSinger.Name = "tpSinger";
            this.tpSinger.Padding = new System.Windows.Forms.Padding(3);
            this.tpSinger.Size = new System.Drawing.Size(536, 379);
            this.tpSinger.TabIndex = 1;
            this.tpSinger.Text = "歌手";
            this.tpSinger.UseVisualStyleBackColor = true;
            // 
            // mediaPlayer
            // 
            this.mediaPlayer.Enabled = true;
            this.mediaPlayer.Location = new System.Drawing.Point(4, 395);
            this.mediaPlayer.Name = "mediaPlayer";
            this.mediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayer.OcxState")));
            this.mediaPlayer.Size = new System.Drawing.Size(10, 10);
            this.mediaPlayer.TabIndex = 20;
            this.mediaPlayer.Visible = false;
            // 
            // tbxSingerName
            // 
            this.tbxSingerName.Location = new System.Drawing.Point(65, 38);
            this.tbxSingerName.Name = "tbxSingerName";
            this.tbxSingerName.Size = new System.Drawing.Size(176, 21);
            this.tbxSingerName.TabIndex = 0;
            // 
            // btnQuerySinger
            // 
            this.btnQuerySinger.Location = new System.Drawing.Point(281, 36);
            this.btnQuerySinger.Name = "btnQuerySinger";
            this.btnQuerySinger.Size = new System.Drawing.Size(75, 23);
            this.btnQuerySinger.TabIndex = 1;
            this.btnQuerySinger.Text = "查找歌手";
            this.btnQuerySinger.UseVisualStyleBackColor = true;
            this.btnQuerySinger.Click += new System.EventHandler(this.btnQuerySinger_Click);
            // 
            // tpPinyin
            // 
            this.tpPinyin.Location = new System.Drawing.Point(4, 22);
            this.tpPinyin.Name = "tpPinyin";
            this.tpPinyin.Padding = new System.Windows.Forms.Padding(3);
            this.tpPinyin.Size = new System.Drawing.Size(536, 379);
            this.tpPinyin.TabIndex = 2;
            this.tpPinyin.Text = "拼音";
            this.tpPinyin.UseVisualStyleBackColor = true;
            // 
            // tpHot
            // 
            this.tpHot.Location = new System.Drawing.Point(4, 22);
            this.tpHot.Name = "tpHot";
            this.tpHot.Padding = new System.Windows.Forms.Padding(3);
            this.tpHot.Size = new System.Drawing.Size(536, 379);
            this.tpHot.TabIndex = 3;
            this.tpHot.Text = "热度";
            this.tpHot.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 403);
            this.Controls.Add(this.mediaPlayer);
            this.Controls.Add(this.tabControlPlayMain);
            this.Name = "FormMain";
            this.Text = "播放列表";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAddSong)).EndInit();
            this.pnlParent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxPrevious)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPlay)).EndInit();
            this.tabControlPlayMain.ResumeLayout(false);
            this.tpPlayList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxDelete)).EndInit();
            this.tpSinger.ResumeLayout(false);
            this.tpSinger.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerAutoPlay;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabControl tabControlPlayMain;
        private System.Windows.Forms.TabPage tpPlayList;
        private System.Windows.Forms.TabPage tpSinger;
        public AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
        private System.Windows.Forms.PictureBox pbxDelete;
        private System.Windows.Forms.PictureBox pbxAddSong;
        public System.Windows.Forms.ListView lvwSongs;
        private System.Windows.Forms.ColumnHeader lvColumnSongname;
        private System.Windows.Forms.ColumnHeader lvColumnSinger;
        private System.Windows.Forms.Panel pnlChild;
        private System.Windows.Forms.Panel pnlParent;
        private System.Windows.Forms.PictureBox pboxPrevious;
        private System.Windows.Forms.PictureBox pboxNext;
        public System.Windows.Forms.PictureBox pboxPlay;
        private System.Windows.Forms.Button btnQuerySinger;
        private System.Windows.Forms.TextBox tbxSingerName;
        private System.Windows.Forms.TabPage tpPinyin;
        private System.Windows.Forms.TabPage tpHot;
    }
}

