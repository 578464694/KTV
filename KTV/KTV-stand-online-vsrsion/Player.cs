using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
namespace KTV_stand_online_vsrsion
{
    class Player
    {
        public void play(FormMain main,string path)
        {
            main.mediaPlayer.URL = path;
        }
        public void playIcon(FormMain main)
        {
            if (main.mediaPlayer.currentPlaylist.count != 0)
            {
                main.pboxPlay.Image = global::KTV_stand_online_vsrsion.Properties.Resources.pause_down;
                main.mediaPlayer.Ctlcontrols.play();
            }
        }
        public void playSongSwitch(FormMain main, int index, ref  ArrayList songsArrayList,ref int playingSongIndex)
        {
            if (index >= songsArrayList.Count)
            {
                play(main,(string)songsArrayList[0]);
                playingSongIndex = 0;
            }
            else if (index < 0)
            {
                index = songsArrayList.Count - 1;
                play(main,(string)songsArrayList[index]);
            }
            else
            {
                play(main,(string)songsArrayList[index]);
            }
        }
    }
}
