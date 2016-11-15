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
            this.pboxPlay = new System.Windows.Forms.PictureBox();
            this.pboxNext = new System.Windows.Forms.PictureBox();
            this.pboxPrevious = new System.Windows.Forms.PictureBox();
            this.pnlParent = new System.Windows.Forms.Panel();
            this.pnlChild = new System.Windows.Forms.Panel();
            this.pbxAddSongsIntoDB = new System.Windows.Forms.PictureBox();
            this.mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.lvwSongs = new System.Windows.Forms.ListView();
            this.lvColumnSongname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timerAutoPlay = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pbxAddSong = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPrevious)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAddSongsIntoDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAddSong)).BeginInit();
            this.SuspendLayout();
            // 
            // pboxPlay
            // 
            this.pboxPlay.Image = global::KTV_stand_online_vsrsion.Properties.Resources.play_down;
            this.pboxPlay.Location = new System.Drawing.Point(156, 36);
            this.pboxPlay.Name = "pboxPlay";
            this.pboxPlay.Size = new System.Drawing.Size(29, 29);
            this.pboxPlay.TabIndex = 1;
            this.pboxPlay.TabStop = false;
            this.toolTip1.SetToolTip(this.pboxPlay, "播放/暂停");
            this.pboxPlay.Click += new System.EventHandler(this.pboxPlay_Click);
            // 
            // pboxNext
            // 
            this.pboxNext.Image = global::KTV_stand_online_vsrsion.Properties.Resources.next_down;
            this.pboxNext.Location = new System.Drawing.Point(234, 36);
            this.pboxNext.Name = "pboxNext";
            this.pboxNext.Size = new System.Drawing.Size(29, 27);
            this.pboxNext.TabIndex = 3;
            this.pboxNext.TabStop = false;
            this.toolTip1.SetToolTip(this.pboxNext, "下一首");
            this.pboxNext.Click += new System.EventHandler(this.pboxNext_Click);
            // 
            // pboxPrevious
            // 
            this.pboxPrevious.Image = global::KTV_stand_online_vsrsion.Properties.Resources.preview_down;
            this.pboxPrevious.Location = new System.Drawing.Point(77, 39);
            this.pboxPrevious.Name = "pboxPrevious";
            this.pboxPrevious.Size = new System.Drawing.Size(30, 26);
            this.pboxPrevious.TabIndex = 4;
            this.pboxPrevious.TabStop = false;
            this.toolTip1.SetToolTip(this.pboxPrevious, "上一首");
            this.pboxPrevious.Click += new System.EventHandler(this.pboxPrevious_Click);
            // 
            // pnlParent
            // 
            this.pnlParent.Location = new System.Drawing.Point(364, 53);
            this.pnlParent.Name = "pnlParent";
            this.pnlParent.Size = new System.Drawing.Size(100, 10);
            this.pnlParent.TabIndex = 5;
            this.toolTip1.SetToolTip(this.pnlParent, "音量");
            this.pnlParent.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelParent_MouseClick);
            // 
            // pnlChild
            // 
            this.pnlChild.BackColor = System.Drawing.Color.White;
            this.pnlChild.Location = new System.Drawing.Point(364, 53);
            this.pnlChild.Name = "pnlChild";
            this.pnlChild.Size = new System.Drawing.Size(30, 10);
            this.pnlChild.TabIndex = 6;
            this.toolTip1.SetToolTip(this.pnlChild, "音量");
            this.pnlChild.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelParent_MouseClick);
            // 
            // pbxAddSongsIntoDB
            // 
            this.pbxAddSongsIntoDB.Image = global::KTV_stand_online_vsrsion.Properties.Resources.list_down;
            this.pbxAddSongsIntoDB.Location = new System.Drawing.Point(307, 35);
            this.pbxAddSongsIntoDB.Name = "pbxAddSongsIntoDB";
            this.pbxAddSongsIntoDB.Size = new System.Drawing.Size(29, 28);
            this.pbxAddSongsIntoDB.TabIndex = 7;
            this.pbxAddSongsIntoDB.TabStop = false;
            this.toolTip1.SetToolTip(this.pbxAddSongsIntoDB, "添加歌曲");
            this.pbxAddSongsIntoDB.Click += new System.EventHandler(this.pboxAddSongs_Click);
            // 
            // mediaPlayer
            // 
            this.mediaPlayer.Enabled = true;
            this.mediaPlayer.Location = new System.Drawing.Point(43, 340);
            this.mediaPlayer.Name = "mediaPlayer";
            this.mediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayer.OcxState")));
            this.mediaPlayer.Size = new System.Drawing.Size(75, 23);
            this.mediaPlayer.TabIndex = 9;
            this.mediaPlayer.Visible = false;
            // 
            // lvwSongs
            // 
            this.lvwSongs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvColumnSongname});
            this.lvwSongs.FullRowSelect = true;
            this.lvwSongs.GridLines = true;
            this.lvwSongs.Location = new System.Drawing.Point(30, 86);
            this.lvwSongs.Name = "lvwSongs";
            this.lvwSongs.Size = new System.Drawing.Size(419, 230);
            this.lvwSongs.TabIndex = 10;
            this.lvwSongs.UseCompatibleStateImageBehavior = false;
            this.lvwSongs.View = System.Windows.Forms.View.Details;
            this.lvwSongs.Click += new System.EventHandler(this.listViewSongs_Click);
            // 
            // lvColumnSongname
            // 
            this.lvColumnSongname.Text = "歌名";
            this.lvColumnSongname.Width = 600;
            // 
            // timerAutoPlay
            // 
            this.timerAutoPlay.Enabled = true;
            this.timerAutoPlay.Tick += new System.EventHandler(this.timerAutoPlay_Tick);
            // 
            // pbxAddSong
            // 
            this.pbxAddSong.Image = global::KTV_stand_online_vsrsion.Properties.Resources.list_down;
            this.pbxAddSong.Location = new System.Drawing.Point(498, 39);
            this.pbxAddSong.Name = "pbxAddSong";
            this.pbxAddSong.Size = new System.Drawing.Size(27, 28);
            this.pbxAddSong.TabIndex = 11;
            this.pbxAddSong.TabStop = false;
            this.pbxAddSong.Click += new System.EventHandler(this.pbxAddSong_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 403);
            this.Controls.Add(this.pbxAddSong);
            this.Controls.Add(this.lvwSongs);
            this.Controls.Add(this.mediaPlayer);
            this.Controls.Add(this.pbxAddSongsIntoDB);
            this.Controls.Add(this.pnlChild);
            this.Controls.Add(this.pnlParent);
            this.Controls.Add(this.pboxPrevious);
            this.Controls.Add(this.pboxNext);
            this.Controls.Add(this.pboxPlay);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPrevious)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAddSongsIntoDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAddSong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlChild;
        private System.Windows.Forms.Panel pnlParent;
        private System.Windows.Forms.PictureBox pboxPrevious;
        private System.Windows.Forms.PictureBox pboxNext;
        public System.Windows.Forms.PictureBox pboxPlay;
        private System.Windows.Forms.PictureBox pbxAddSongsIntoDB;
        public AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
        public System.Windows.Forms.ListView lvwSongs;
        private System.Windows.Forms.ColumnHeader lvColumnSongname;
        private System.Windows.Forms.Timer timerAutoPlay;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pbxAddSong;
    }
}

