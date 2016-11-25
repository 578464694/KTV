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
        //播放列表数组
        ArrayList gSongClassArrayList = new ArrayList();
        //当前播放歌曲的键值
        int gPlayingSongIndex = 0;
        //当前播放状态
        static public int gLogInfo = 0;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (FormMain.gLogInfo == 0)
            {
               // this.pbxAddSongsIntoDB.Visible = false;
            }
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
              
                player.addSongsIntoDB(ref files);
            }
        }
 
        /// <summary>
        /// 自动播放 改成面向对象
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerAutoPlay_Tick(object sender, EventArgs e)
        {
            if (this.mediaPlayer.playState == WMPLib.WMPPlayState.wmppsStopped)
                player.playSongSwitch(this, ++gPlayingSongIndex, ref gSongClassArrayList, ref gPlayingSongIndex);
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
        /// 播放列表添加歌曲
        /// </summary>
        public void addSongAtList()
        {
            FormAdd formadd = new FormAdd();
            formadd.bindList("select * from T_song");
            if (formadd.ShowDialog() == DialogResult.OK)
            {
                foreach (ListViewItem al in FormAdd.gArrPlayList)
                {
                    ListViewItem lvi = new ListViewItem();
                    Song song = new Song();
                    lvi.Text = al.Text;
                    lvi.Tag = al.Tag;
                    lvi.SubItems.Add(al.SubItems[1].Text);  //1保存歌曲
                   
                    this.lvwSongs.Items.Add(lvi);
                    //设置歌曲对象
                    song.setSongInfo(int.Parse(al.SubItems[2].Text), int.Parse(al.SubItems[3].Text), al.Tag.ToString(), al.Text,al.SubItems[1].Text);
                    gSongClassArrayList.Add(song);
                }
            }
            
        }
  

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// 添加歌曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbxAddSong_Click_1(object sender, EventArgs e)
        {
            addSongAtList();
        }

        /// <summary>
        /// 下一首
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pboxNext_Click_1(object sender, EventArgs e)
        {
            player.playSongSwitch(this, ++gPlayingSongIndex, ref gSongClassArrayList, ref gPlayingSongIndex);
        }

        /// <summary>
        /// 播放与暂停
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pboxPlay_Click_1(object sender, EventArgs e)
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
        private void pboxPrevious_Click_1(object sender, EventArgs e)
        {
            player.playSongSwitch(this, --gPlayingSongIndex, ref gSongClassArrayList, ref gPlayingSongIndex);
        }

        /// <summary>
        /// 用户删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbxDelete_Click_1(object sender, EventArgs e)
        {
            for (int i = this.lvwSongs.Items.Count - 1; i >= 0; i--)
            {
                if (this.lvwSongs.Items[i].Selected)
                {
                    this.lvwSongs.Items.RemoveAt(i);
                    this.gSongClassArrayList.RemoveAt(i);
                }
            }
        }

        private void pnlParent_MouseClick(object sender, MouseEventArgs e)
        {
            this.pnlChild.Size = new Size(e.X, 10);
            int valume = this.pnlChild.Size.Width;
            setValume(valume);
        }

        private void pnlChild_MouseClick(object sender, MouseEventArgs e)
        {
            this.pnlChild.Size = new Size(e.X, 10);
            int valume = this.pnlChild.Size.Width;
            setValume(valume);
        }

        private void pboxPlay_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void pboxPlay_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
        }

        private void lvwSongs_Click(object sender, EventArgs e)
        {
            if (lvwSongs.SelectedItems.Count >= 1)
            {
                gPlayingSongIndex = this.lvwSongs.SelectedItems[0].Index;

                Song song = (Song)gSongClassArrayList[gPlayingSongIndex];
                player.play(this, song.getPath(), song.getId());
            }
        }

        private void btnQuerySinger_Click(object sender, EventArgs e)
        {
          /*  if (tbxSingerName.Text == string.Empty)
            {
                return;
            }*/
            string sql = string.Format("select * from T_song where singer like '%{0}%'", tbxSingerName.Text);
            addSongAccessSQL(sql);
            
        }
        /// <summary>
        /// 通过sql查找歌曲
        /// </summary>
        /// <param name="sql"></param>
        public void addSongAccessSQL(string sql)
        {
            FormAdd formadd = new FormAdd();
            formadd.bindList(sql);
            if (formadd.ShowDialog() == DialogResult.OK)
            {
                foreach (ListViewItem al in FormAdd.gArrPlayList)
                {
                    ListViewItem lvi = new ListViewItem();
                    Song song = new Song();
                    lvi.Text = al.Text;
                    lvi.Tag = al.Tag;
                    lvi.SubItems.Add(al.SubItems[1].Text);  //1保存歌曲

                    this.lvwSongs.Items.Add(lvi);
                    //设置歌曲对象
                    song.setSongInfo(int.Parse(al.SubItems[2].Text), int.Parse(al.SubItems[3].Text), al.Tag.ToString(), al.Text, al.SubItems[1].Text);
                    gSongClassArrayList.Add(song);
                }
            }
        }
       
    }
}
