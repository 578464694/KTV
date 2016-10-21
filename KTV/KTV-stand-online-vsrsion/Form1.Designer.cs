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
            this.panelParent = new System.Windows.Forms.Panel();
            this.panelChild = new System.Windows.Forms.Panel();
            this.pboxAddSongs = new System.Windows.Forms.PictureBox();
            this.mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.listViewSongs = new System.Windows.Forms.ListView();
            this.lvColumnSongname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timerAutoPlay = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pboxPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPrevious)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAddSongs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).BeginInit();
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
            // panelParent
            // 
            this.panelParent.Location = new System.Drawing.Point(364, 53);
            this.panelParent.Name = "panelParent";
            this.panelParent.Size = new System.Drawing.Size(100, 10);
            this.panelParent.TabIndex = 5;
            this.toolTip1.SetToolTip(this.panelParent, "音量");
            this.panelParent.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelParent_MouseClick);
            // 
            // panelChild
            // 
            this.panelChild.BackColor = System.Drawing.Color.White;
            this.panelChild.Location = new System.Drawing.Point(364, 53);
            this.panelChild.Name = "panelChild";
            this.panelChild.Size = new System.Drawing.Size(30, 10);
            this.panelChild.TabIndex = 6;
            this.toolTip1.SetToolTip(this.panelChild, "音量");
            this.panelChild.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelParent_MouseClick);
            // 
            // pboxAddSongs
            // 
            this.pboxAddSongs.Image = global::KTV_stand_online_vsrsion.Properties.Resources.list_down;
            this.pboxAddSongs.Location = new System.Drawing.Point(307, 35);
            this.pboxAddSongs.Name = "pboxAddSongs";
            this.pboxAddSongs.Size = new System.Drawing.Size(29, 28);
            this.pboxAddSongs.TabIndex = 7;
            this.pboxAddSongs.TabStop = false;
            this.toolTip1.SetToolTip(this.pboxAddSongs, "添加歌曲");
            this.pboxAddSongs.Click += new System.EventHandler(this.pboxAddSongs_Click);
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
            // listViewSongs
            // 
            this.listViewSongs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvColumnSongname});
            this.listViewSongs.FullRowSelect = true;
            this.listViewSongs.GridLines = true;
            this.listViewSongs.Location = new System.Drawing.Point(30, 86);
            this.listViewSongs.Name = "listViewSongs";
            this.listViewSongs.Size = new System.Drawing.Size(419, 230);
            this.listViewSongs.TabIndex = 10;
            this.listViewSongs.UseCompatibleStateImageBehavior = false;
            this.listViewSongs.View = System.Windows.Forms.View.Details;
            this.listViewSongs.Click += new System.EventHandler(this.listViewSongs_Click);
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
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 403);
            this.Controls.Add(this.listViewSongs);
            this.Controls.Add(this.mediaPlayer);
            this.Controls.Add(this.pboxAddSongs);
            this.Controls.Add(this.panelChild);
            this.Controls.Add(this.panelParent);
            this.Controls.Add(this.pboxPrevious);
            this.Controls.Add(this.pboxNext);
            this.Controls.Add(this.pboxPlay);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPrevious)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAddSongs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChild;
        private System.Windows.Forms.Panel panelParent;
        private System.Windows.Forms.PictureBox pboxPrevious;
        private System.Windows.Forms.PictureBox pboxNext;
        public System.Windows.Forms.PictureBox pboxPlay;
        private System.Windows.Forms.PictureBox pboxAddSongs;
        public AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
        public System.Windows.Forms.ListView listViewSongs;
        private System.Windows.Forms.ColumnHeader lvColumnSongname;
        private System.Windows.Forms.Timer timerAutoPlay;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

