using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace PlaylistsBuilder
{
    public class PlayListXMLDoc : XmlDocument
    {

        public string CurrentPlaylistName;
        public string CurrentPlaylistID;
        public List<string> CurrentPlayList;

        public Dictionary<string, string> PlaylistNames = new Dictionary<string, string>();

        public void LoadPlayList(string Path)
        {
            this.Load(Path);
        }

        public void GetPlaylistNames()
        {
 
            PlaylistNames.Clear();
            XmlNodeList playlistIDList = this.SelectNodes("//dict/key[.='Playlist ID']");

            string PlaylistName;
            string PlaylistID;
            foreach ( XmlNode item in playlistIDList)
            {
                PlaylistID = item.NextSibling.InnerText;
                PlaylistName = item.PreviousSibling.InnerText;
                if (PlaylistName != "")
                    if (!PlaylistNames.ContainsKey(PlaylistID))
                    {
                        List<string> itemList = new List<string>();
                        PlaylistNames.Add(PlaylistID, PlaylistName);
                    }
            }
        }

        public void BuildPlaylists(int n)
        {
            int i=0;
  
            foreach (KeyValuePair<String, string > entry in PlaylistNames)
            {
                i++;
                if (i == n)
                {
                    CurrentPlaylistID = entry.Key;
                    CurrentPlaylistName = entry.Value;
                    CurrentPlayList =  BuildPlaylistFromID(CurrentPlaylistID);
                    break;
                }

            }

        }


        public List<string> BuildPlaylistFromID(string id)
        {
            List<string> Playlist = new List<string>();
            Playlist.Add("#CURTRACK 0");
            Playlist.Add("#EXTM3U");

            foreach (KeyValuePair<String, string> entry in PlaylistNames)
            {
                string TrackID;

                if (entry.Key == id)
                {
                    // got the correct entry.
                    XmlNodeList PlayListNodes = this.SelectNodes("//dict[key='Playlist ID' and integer='" + id  + "']");
                    // we'll only be interested in 1
                    XmlNode PlayListNode = PlayListNodes[0];
                    // Now get the info we need from this Playlist node.
                    XmlNode ArrayNode = PlayListNode.SelectSingleNode("array");
                    XmlNodeList TrackList = ArrayNode.SelectNodes("dict/integer");
                    
                    foreach (XmlNode dictitem in TrackList)
                    {
                        TrackID = dictitem.InnerText;
                        // ok, got the TrackID in this playlist. 
                        // now need to get the track info
                        //XmlNode TrackKeyNode = this.SelectSingleNode("//dict/dict/key[. = '" + TrackID + "']");
                        XmlNode TrackKeyNode = this.SelectSingleNode("plist/dict/dict/key[. = '" + TrackID + "']");
                        XmlNode TrackNode = TrackKeyNode.NextSibling;
              
                        XmlNode LocationNode = TrackNode.SelectSingleNode("key[.='Location']");
                        XmlNode LocationPath = LocationNode.NextSibling;
                        XmlNode NameNode = TrackNode.SelectSingleNode("key[.='Name']");
                        XmlNode NameValueNode = NameNode.NextSibling;

                        string PCPath = LocationPath.InnerText;
                        string searchString = "iTunes";
                            int iTunesLoc = PCPath.IndexOf(searchString);
                        string path = "/media/Music/iTunes" + PCPath.Substring(iTunesLoc + searchString.Length);
                        path = path.Replace("%20", " ");
                        Playlist.Add("#EXTURL:file://" + path);
                        Playlist.Add("#EXTINF:"+NameValueNode.InnerText);
                        Playlist.Add(path);
                    }
                    
                    break;
                }
            }

            return Playlist;

        }
    }
}
