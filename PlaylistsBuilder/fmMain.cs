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


        public fmMain()
        {
            InitializeComponent();
        }

        private void fmMain_Load(object sender, EventArgs e)
        {
            doc = new PlayListXMLDoc();
            LoadSettings();
       }

        private void click_loadPlaylists(object sender, EventArgs e)
        {
            btnLoadPlaylists.Enabled = false;
            try
            {
                lbConvert.Items.Clear();
                LoadPlaylists(txtItunesPath.Text);
            }
            finally
            {
                btnLoadPlaylists.Enabled = true;
            }

            
        }
        private void btnCopyToConvert_Click(object sender, EventArgs e)
        {
            MoveListboxItemsFromTo(lbPlayLists, lbConvert);
        }

        private void btnCopyToPlaylists_Click(object sender, EventArgs e)
        {
            MoveListboxItemsFromTo(lbConvert, lbPlayLists);
        }

        private void MoveListboxItemsFromTo(ListBox lbFrom, ListBox lbTo)
        {

            lbFrom.BeginUpdate();
            lbTo.BeginUpdate();
            try
            {
                for (int i = lbFrom.Items.Count - 1; i > -1; i--)
                {
                    if (lbFrom.GetSelected(i) == true)
                    {
                        lbTo.Items.Add(lbFrom.Items[i]);
                        lbFrom.Items.Remove(lbFrom.Items[i]);


                    }
                }
            }
            finally
            {
                lbTo.EndUpdate();
                lbFrom.EndUpdate();
                cbSelectiTunes.Checked = false;
                cbSelectConvert.Checked = false;
            }


        }


        private void LoadSettings()
        {
            txtItunesPath.Text = Properties.Settings.Default.XMLPath;
            txtFolder.Text = Properties.Settings.Default.OutputPath;
        }
        private void SaveSettings()
        {
            Properties.Settings.Default.XMLPath = txtItunesPath.Text;
            Properties.Settings.Default.OutputPath = txtFolder.Text;
            Properties.Settings.Default.Save();
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

        private void SelectOutputPath(object sender, EventArgs e)
        {
            fbDlg.SelectedPath = txtFolder.Text;
            if (fbDlg.ShowDialog() == DialogResult.OK)
            {
                txtFolder.Text = fbDlg.SelectedPath;

                
                
            }
        }



        private void fmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           lbPlayLists.BeginUpdate();

            for (int i = lbPlayLists.Items.Count-1; i > -1 ; i--)
            {
                lbPlayLists.SetSelected(i, cbSelectiTunes.Checked);
            }

           lbPlayLists.EndUpdate();
        }



        private void LoadPlaylists(string path)
        {
            lbPlayLists.Items.Clear();
            //LoadPlaylists(txtItunesPath.Text);
            doc.LoadPlayList(path);
            IDictionary<string, string> playistNames = doc.GetPlaylistNames();
            foreach (KeyValuePair<string, string> item in doc.PlaylistNames)
            {
                lbPlayLists.Items.Add(item);

            }
            
            
        }



        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            lbConvert.BeginUpdate();

            for (int i = lbConvert.Items.Count - 1; i > -1; i--)
            {
                lbConvert.SetSelected(i, cbSelectConvert.Checked);
            }

            lbConvert.EndUpdate();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            lbConvert.BeginUpdate();

            //for (int i = 0; i< lbConvert.Items.Count;i++)
              for (int i = 0; i< 2;i++)
            {
                IDictionary<string, string> item = (IDictionary<string, string>)lbConvert.Items[i];
                //string id = item.k
                List<string> Playlist = doc.BuildPlaylistFromID("62597"); 
                lbConvert.SetSelected(i, cbSelectConvert.Checked);
            }

            lbConvert.EndUpdate();
        }

    }
}
