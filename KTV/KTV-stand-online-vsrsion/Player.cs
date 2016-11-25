using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Text.RegularExpressions;
using System.Data;
namespace KTV_stand_online_vsrsion
{
    /// <summary>
    /// Player中封装了很多操作歌曲,MediaPlay控件,ImageButton的函数
    /// </summary>
    class Player
    {
        /// <summary>
        /// 播放
        /// </summary>
        /// <param name="main"></param>
        /// <param name="path"></param>
        public void play(FormMain main,string path)
        {
            main.mediaPlayer.URL = path;
            this.playIcon(main);

        }
        /// <summary>
        /// 播放改变热度
        /// </summary>
        /// <param name="main"></param>
        /// <param name="path"></param>
        public void play(FormMain main, string path,int id)
        {
            main.mediaPlayer.URL = path;
            this.playIcon(main);
            string sql = string.Format("select hot from T_song where id = {0}",id);
            DBoperateClass operate = new DBoperateClass();
            DataSet dataset = operate.getDataset(sql);
            System.Data.DataRow row = dataset.Tables[0].Rows[0];
            int hot = int.Parse( row[0].ToString());
            hot++;
            string updatesql = string.Format("update T_song set hot={0} where id={1}",hot,id);
          int i =  operate.operate(updatesql);
        }
        /// <summary>
        /// 改变play按键的图标
        /// </summary>
        /// <param name="main"></param>
        public void playIcon(FormMain main)
        {
            if (main.mediaPlayer.currentPlaylist.count != 0)
            {
                main.pboxPlay.Image = global::KTV_stand_online_vsrsion.Properties.Resources.pause_down;
                main.mediaPlayer.Ctlcontrols.play();
            }
        }
        /// <summary>
        /// 切歌
        /// </summary>
        /// <param name="main"></param>
        /// <param name="index"></param>
        /// <param name="songsArrayList"></param>
        /// <param name="playingSongIndex"></param>
        public void playSongSwitch(FormMain main, int index, ref  ArrayList gSongClassArrayList, ref int playingSongIndex)
        {
            if (index >= gSongClassArrayList.Count)
            {
                Song song = (Song)gSongClassArrayList[0];
                play(main, song.getPath(),song.getId());
                playingSongIndex = 0;
            }
            else if (index < 0)
            {
                index = gSongClassArrayList.Count - 1;
                Song song = (Song)gSongClassArrayList[index];
                play(main, song.getPath(), song.getId());
            }
            else
            {
                Song song = (Song)gSongClassArrayList[index];
                play(main, song.getPath(), song.getId());
            }
        }
        /// <summary>
        /// 向ListView添加歌曲
        /// 向ArrayList添加歌曲路径
        /// 
        /// </summary>
        /// <param name="main"></param>
        /// <param name="songs"></param>
        /// <param name="songsArrayList"></param>
        public void addSongsPath(FormMain main,ref string[] songs, ref  ArrayList songsArrayList)
        {
            AxWMPLib.AxWindowsMediaPlayer getInfo = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(getInfo)).BeginInit();
            getInfo.Visible = false;
            main.Controls.Add(getInfo);
            ((System.ComponentModel.ISupportInitialize)(getInfo)).EndInit();
            foreach (string value in songs)
            {
                getInfo.URL = value;
                songsArrayList.Add(value);
                ListViewItem item = new ListViewItem();
                item.Text = Path.GetFileNameWithoutExtension(value);
                getInfo.Ctlcontrols.stop();
                main.lvwSongs.Items.Add(item);

            }
            main.Controls.Remove(getInfo);
        }
        /// <summary>
        /// 向数据库添加歌曲
        /// </summary>
        /// <param name="main"></param>
        /// <param name="songs"></param>
        public void addSongsIntoDB(FormMain main,ref string[] songs)
        {
            DBoperateClass operate = new DBoperateClass();
            Pinyin py = new Pinyin();
            int rows = 0;
            foreach(string value in songs)
            {
                string pattern = @".+(?=\.mp3)";  //匹配歌曲名称的正则
                Regex reg = new Regex(pattern);
                Match match = reg.Match(Path.GetFileName(value));
                string filename = match.Value;      //获得文件名
                string pyStr = py.GetChineseSpell(filename);    //获得拼音
                string insertSQL = operate.getInsertSQL(filename, value, pyStr); //获得插入SQL
                rows += operate.Insert(insertSQL); //插入数量 +1
            }
            if (rows > 0)
            {
                MessageBox.Show(string.Format("添加{0}首歌曲",rows));
            }
        }
        /// <summary>
        /// 重载向数据库添加歌曲
        /// </summary>
        /// <param name="main"></param>
        /// <param name="songs"></param>
        public void addSongsIntoDB(ref string[] songs)
        {
            DBoperateClass operate = new DBoperateClass();
            Pinyin py = new Pinyin();
            int rows = 0;
            foreach (string value in songs)
            {
                string pattern = @".+(?=\.mp3)";  //匹配歌曲名称的正则
                Regex reg = new Regex(pattern);
                Match match = reg.Match(Path.GetFileName(value));
                string filename = match.Value;      //获得文件名
                string pyStr = py.GetChineseSpell(filename);    //获得拼音
                string insertSQL = operate.getInsertSQL(filename, value, pyStr); //获得插入SQL
                rows += operate.Insert(insertSQL); //插入数量 +1
            }
            if (rows > 0)
            {
                MessageBox.Show(string.Format("添加{0}首歌曲", rows));
            }
        }
    }
}
