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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pboxPlay = new System.Windows.Forms.PictureBox();
            this.pboxNext = new System.Windows.Forms.PictureBox();
            this.pboxPrevious = new System.Windows.Forms.PictureBox();
            this.panelParent = new System.Windows.Forms.Panel();
            this.panelChild = new System.Windows.Forms.Panel();
            this.pboxAddSongs = new System.Windows.Forms.PictureBox();
            this.lboxSongsList = new System.Windows.Forms.ListBox();
            this.mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
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
            this.pboxPrevious.Click += new System.EventHandler(this.pboxPrevious_Click);
            // 
            // panelParent
            // 
            this.panelParent.Location = new System.Drawing.Point(364, 53);
            this.panelParent.Name = "panelParent";
            this.panelParent.Size = new System.Drawing.Size(100, 10);
            this.panelParent.TabIndex = 5;
            // 
            // panelChild
            // 
            this.panelChild.BackColor = System.Drawing.Color.White;
            this.panelChild.Location = new System.Drawing.Point(364, 53);
            this.panelChild.Name = "panelChild";
            this.panelChild.Size = new System.Drawing.Size(30, 10);
            this.panelChild.TabIndex = 6;
            // 
            // pboxAddSongs
            // 
            this.pboxAddSongs.Image = global::KTV_stand_online_vsrsion.Properties.Resources.list_down;
            this.pboxAddSongs.Location = new System.Drawing.Point(307, 35);
            this.pboxAddSongs.Name = "pboxAddSongs";
            this.pboxAddSongs.Size = new System.Drawing.Size(29, 28);
            this.pboxAddSongs.TabIndex = 7;
            this.pboxAddSongs.TabStop = false;
            this.pboxAddSongs.Click += new System.EventHandler(this.pboxAddSongs_Click);
            // 
            // lboxSongsList
            // 
            this.lboxSongsList.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lboxSongsList.FormattingEnabled = true;
            this.lboxSongsList.HorizontalScrollbar = true;
            this.lboxSongsList.ItemHeight = 20;
            this.lboxSongsList.Location = new System.Drawing.Point(12, 96);
            this.lboxSongsList.Name = "lboxSongsList";
            this.lboxSongsList.Size = new System.Drawing.Size(429, 124);
            this.lboxSongsList.TabIndex = 8;
            this.lboxSongsList.DoubleClick += new System.EventHandler(this.lboxSongsList_DoubleClick);
            // 
            // mediaPlayer
            // 
            this.mediaPlayer.Enabled = true;
            this.mediaPlayer.Location = new System.Drawing.Point(109, 306);
            this.mediaPlayer.Name = "mediaPlayer";
            this.mediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayer.OcxState")));
            this.mediaPlayer.Size = new System.Drawing.Size(75, 23);
            this.mediaPlayer.TabIndex = 9;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 403);
            this.Controls.Add(this.mediaPlayer);
            this.Controls.Add(this.lboxSongsList);
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
        private System.Windows.Forms.PictureBox pboxPlay;
        private System.Windows.Forms.PictureBox pboxAddSongs;
        private System.Windows.Forms.ListBox lboxSongsList;
        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
    }
}

