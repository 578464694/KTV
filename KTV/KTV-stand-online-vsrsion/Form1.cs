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
        ArrayList gSongsArrayList = new ArrayList();
        int gPlayingSongIndex = 0;
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
            player.playSongSwitch(this, --gPlayingSongIndex, ref gSongsArrayList, ref gPlayingSongIndex);
        }
        /// <summary>
        /// 下一首
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pboxNext_Click(object sender, EventArgs e)
        {
            player.playSongSwitch(this, ++gPlayingSongIndex, ref gSongsArrayList, ref gPlayingSongIndex);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 管理员添加歌曲
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
              //  player.addSongsPath(this, ref files, ref songsArrayList);
                player.addSongsIntoDB(this, ref files);
            }
        }
        /// <summary>
        /// 调节声音的UI效果
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelParent_MouseClick(object sender, MouseEventArgs e)
        {
            this.pnlChild.Size = new Size(e.X, 10);
            int valume = this.pnlChild.Size.Width;
            setValume(valume);
        }
        /// <summary>
        /// 点击列表播放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listViewSongs_Click(object sender, EventArgs e)
        {
            if (lvwSongs.SelectedItems.Count >= 1)
            {
                gPlayingSongIndex = this.lvwSongs.SelectedItems[0].Index;
                string path = (string)(gSongsArrayList[gPlayingSongIndex]);
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
                player.playSongSwitch(this, ++gPlayingSongIndex, ref gSongsArrayList, ref gPlayingSongIndex);
        }
        /// <summary>
        /// 设置声音
        /// </summary>
        /// <param name="valume"></param>
        public void setValume(int valume)
        {
            this.mediaPlayer.settings.volume = valume;
        }
        /// <summary>
        /// 添加歌曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbxAddSong_Click(object sender, EventArgs e)
        {
            FormAdd formAdd = new FormAdd();
            if (formAdd.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                addSongAtList();
            }
        }
        /// <summary>
        /// 播放列表和歌曲路径数组添加歌曲
        /// </summary>
        public void addSongAtList()
        {
            FormAdd formadd = new FormAdd();
            //(ArrayList)formadd.gArrPlayList;
            foreach(ListViewItem al in FormAdd.gArrPlayList)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = al.Text;
                lvi.Tag = al.Tag;
                lvi.SubItems.Add(al.SubItems[1].Text);  //1 保存id
                this.lvwSongs.Items.Add(lvi);
                gSongsArrayList.Add(lvi.Tag);
            }
            
        }
    }
}
