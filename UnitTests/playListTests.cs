using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlaylistsBuilder;
using System.Xml;
using System.IO;
using System.Windows.Forms;

namespace UnitTests
{
    /// <summary>
    /// Summary description for playListTests
    /// </summary>
    [TestClass]
    public class playListTests
    {
        PlayListXMLDoc doc;
        string Path = @"C:\Users\david\Documents\Visual Studio 2010\Projects\PlaylistsBuilder\RawFiles\iTunes Music Library.xml";
        string OutputDir = @"C:\Users\david\Documents\Playlists";

        public playListTests()
        {
            //
            // TODO: Add constructor logic here
            //
            doc = new PlayListXMLDoc();
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void LoadITunesFile()
        {
            //
            // TODO: Add test logic	here
            //
            doc.LoadPlayList(Path);
            XmlNode topnode = doc.DocumentElement.FirstChild;
            Assert.IsNotNull(topnode);
        }

        [TestMethod]
        public void LoadPlaylistNames()
        {
            LoadITunesFile();
            doc.GetPlaylistNames();
            Assert.AreNotEqual(doc.PlaylistNames.First(), "");
        }
        [TestMethod]
        public void LoadPlaylists()
        {
            LoadITunesFile();
            LoadPlaylistNames();
            for(int i=9; i < 200; i++)
            {
                doc.BuildPlaylists(i);
                List<string> Playlist = doc.CurrentPlayList;
                string FileName = OutputDir + System.IO.Path.DirectorySeparatorChar + doc.CurrentPlaylistName + ".m3u";
                using (StreamWriter theWriter = new StreamWriter(FileName))
                {
                    foreach (string item in Playlist)
                    {
                        theWriter.WriteLine(item);
                        //tbPlay.AppendText(item + Environment.NewLine);
                    }
                    theWriter.Close();
                    theWriter.Dispose();
                }

            }
            //doc.g
        }

        [TestMethod]
        public void LoadPlaylistFromID()
        {
            LoadITunesFile();
            LoadPlaylistNames();
            List<string> Playlist = doc.BuildPlaylistFromID("62597"); // the 'Anna 1' playlist
            MessageBox.Show("saddsdsd");
         

        }

    }
}
