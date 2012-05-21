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
    public partial class fmMain : Form
    {
        PlayListXMLDoc doc;
        string Path = @"C:\Users\david\Documents\Visual Studio 2010\Projects\PlaylistsBuilder\RawFiles\iTunes Music Library.xml";

        public fmMain()
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

        private void fmMain_Load(object sender, EventArgs e)
        {
            doc = new PlayListXMLDoc();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About fmAbout = new About();
            fmAbout.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (fbDlg.ShowDialog() == DialogResult.OK)
            {
                txtFolder.Text = fbDlg.SelectedPath;
            }
        }
    }
}
