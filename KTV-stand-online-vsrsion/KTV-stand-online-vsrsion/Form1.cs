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
       // Player player = new Player();
        ArrayList songsArrayList = new ArrayList();
        public FormMain()
        {
            InitializeComponent();
        }
        
        private void pboxPlay_Click(object sender, EventArgs e)
        {
           // player.Play(this,@"D:\mp3\iphone.mp3");
            this.pboxPlay.Image = global::KTV_stand_online_vsrsion.Properties.Resources.pause_down;
        }

        private void pboxPrevious_Click(object sender, EventArgs e)
        {

        }

        private void pboxNext_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void pboxAddSongs_Click(object sender, EventArgs e)
        {
            addSongsPath();
        }
        public void addSongsPath()
        {
            
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Multiselect = true;
            if (openfile.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                string[] songs = openfile.FileNames;
                foreach (string value in songs)
                {
                    songsArrayList.Add(value);
                    this.lboxSongsList.Items.Add(Path.GetFileNameWithoutExtension(value));
                }
            }
        }

        private void lboxSongsList_DoubleClick(object sender, EventArgs e)
        {
            this.mediaPlayer.Ctlcontrols.stop();
            int index = this.lboxSongsList.SelectedIndex;
            string path = (string)(songsArrayList[index]);
            
            this.mediaPlayer.URL = path;
            this.mediaPlayer.Ctlcontrols.play();
        }
    }
}
