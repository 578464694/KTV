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

        private void pboxPrevious_Click(object sender, EventArgs e)
        {
            playSongSwitch(--playingSongIndex);
        }

        private void pboxNext_Click(object sender, EventArgs e)
        {
            playSongSwitch(++playingSongIndex);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

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
                addSongsPath(openfile.FileNames);

            }
        }

        private void panelParent_MouseClick(object sender, MouseEventArgs e)
        {
            this.panelChild.Size = new Size(e.X, 10);
            int valume = this.panelChild.Size.Width;
            setValume(valume);
        }

        private void listViewSongs_Click(object sender, EventArgs e)
        {
            if (listViewSongs.SelectedItems.Count >= 1)
            {
                playingSongIndex = this.listViewSongs.SelectedItems[0].Index;
                string path = (string)(songsArrayList[playingSongIndex]);
                play(path);
            }
        }

        private void timerAutoPlay_Tick(object sender, EventArgs e)
        {
            if(this.mediaPlayer.playState == WMPLib.WMPPlayState.wmppsStopped)
            playSongSwitch(++playingSongIndex);
        }

        public void addSongsPath(string[] songs)
        {

            AxWMPLib.AxWindowsMediaPlayer getInfo = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(getInfo)).BeginInit();
            getInfo.Visible = false;
            this.Controls.Add(getInfo);
            ((System.ComponentModel.ISupportInitialize)(getInfo)).EndInit();
            foreach (string value in songs)
            {
                getInfo.URL = value;
                songsArrayList.Add(value);
                ListViewItem item = new ListViewItem();
                item.Text = Path.GetFileNameWithoutExtension(value);
                getInfo.Ctlcontrols.stop();
                listViewSongs.Items.Add(item);

            }
            this.Controls.Remove(getInfo);

        }


        public void playIcon()
        {
            if (this.mediaPlayer.currentPlaylist.count != 0)
            {
                this.pboxPlay.Image = global::KTV_stand_online_vsrsion.Properties.Resources.pause_down;
                this.mediaPlayer.Ctlcontrols.play();
            }
        }
        public void setValume(int valume)
        {
            this.mediaPlayer.settings.volume = valume;
        }
        public void playSongSwitch(int index)
        {
            if (index >= songsArrayList.Count)
            {
                play((string)songsArrayList[0]);
                playingSongIndex = 0;
            }
            else if (index < 0)
            {
                index = songsArrayList.Count - 1;
                play((string)songsArrayList[index]);
            }
            else
            {
                play((string)songsArrayList[index]);
            }
        }
        public void play(string path)
        {

            this.mediaPlayer.URL = path;
            playIcon();
        }

        
        
    }
}
