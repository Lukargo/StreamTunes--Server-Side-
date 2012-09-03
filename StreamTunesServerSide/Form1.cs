using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StreamTunesServerSide
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ipTestButton_Click(object sender, EventArgs e)
        {

            SQLManager.WriteCurrentIP();
        }

        private void getIPButton_Click(object sender, EventArgs e)
        {
            lbIP.Text = SQLManager.CurrentIP;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Song curSong in ID3Reader.ReadTags(StreamTunes.SongPathList)){
                ListViewItem itm = new ListViewItem();
                itm.Text = curSong.FileName;
                itm.SubItems.Add(curSong.Artist);
                itm.SubItems.Add(curSong.Album);
                itm.SubItems.Add(curSong.Name);
                listViewFiles.Items.Add(itm);
            }
        }
    }
}
