using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PlaylistsBuilder
{
    public partial class Form1 : Form
    {
        PlayListXMLDoc doc;
        string Path = @"C:\Users\david\Documents\Visual Studio 2010\Projects\PlaylistsBuilder\RawFiles\iTunes Music Library.xml";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            doc.LoadPlayList(Path);
            doc.GetPlaylistNames();
            List<string> Playlist = doc.BuildPlaylistFromID("62597"); // the 'Anna 1' playlist
            MessageBox.Show("saddsdsd");
            tbPlay.Clear();
            foreach(string item in Playlist)
            {
                tbPlay.AppendText(item + Environment.NewLine);
            }
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            doc = new PlayListXMLDoc();
        }
    }
}
