using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace KTV_stand_online_vsrsion
{
    public partial class FormMain : Form
    {
        /// <summary>
        /// Player见Play.cs
        /// songsArrayList 存储歌曲路径
        /// </summary>
        Player player = new Player();
        ArrayList songsArrayList = new ArrayList();
        int playingSongIndex = 0;
        public FormMain()
        {
            InitializeComponent();
        }
        
        private void pboxPlay_Click(object sender, EventArgs e)
        {
            if (this.mediaPlayer.currentPlaylist.count != 0)
            {
                if (this.mediaPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    this.pboxPlay.Image = global::KTV_stand_online_vsrsion.Properties.Resources.play_down;
                    this.mediaPlayer.Ctlcontrols.pause();
                }
                else
                {
                    this.pboxPlay.Image = global::KTV_stand_online_vsrsion.Properties.Resources.pause_down;
                    this.mediaPlayer.Ctlcontrols.play();
                }
            }

        }
        /// <summary>
        /// 上一首
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pboxPrevious_Click(object sender, EventArgs e)
        {
            player.playSongSwitch(this, --playingSongIndex, ref songsArrayList, ref playingSongIndex);
        }
        /// <summary>
        /// 下一首
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pboxNext_Click(object sender, EventArgs e)
        {
            player.playSongSwitch(this, ++playingSongIndex, ref songsArrayList, ref playingSongIndex);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 添加歌曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pboxAddSongs_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Multiselect = true;
            openfile.Filter = "mp3|*.mp3";
            if (openfile.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                string[] files = openfile.FileNames;
                player.addSongsPath(this, ref files, ref songsArrayList);
            }
        }
        /// <summary>
        /// 调节声音的UI效果
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelParent_MouseClick(object sender, MouseEventArgs e)
        {
            this.panelChild.Size = new Size(e.X, 10);
            int valume = this.panelChild.Size.Width;
            setValume(valume);
        }
        /// <summary>
        /// 点击列表播放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listViewSongs_Click(object sender, EventArgs e)
        {
            if (listViewSongs.SelectedItems.Count >= 1)
            {
                playingSongIndex = this.listViewSongs.SelectedItems[0].Index;
                string path = (string)(songsArrayList[playingSongIndex]);
                player.play(this,path);
            }
        }
        /// <summary>
        /// 自动播放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerAutoPlay_Tick(object sender, EventArgs e)
        {
            if (this.mediaPlayer.playState == WMPLib.WMPPlayState.wmppsStopped)
                player.playSongSwitch(this, ++playingSongIndex, ref songsArrayList, ref playingSongIndex);
        }
        /// <summary>
        /// 设置声音
        /// </summary>
        /// <param name="valume"></param>
        public void setValume(int valume)
        {
            this.mediaPlayer.settings.volume = valume;
        }  
    }
}
