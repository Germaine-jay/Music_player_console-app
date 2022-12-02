using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayList
{  
    public class AddToPlaylistTwo
    {

        public static Dictionary<string, ArrayList> SongsAndPlaylist = new Dictionary<string, ArrayList>();

        static string[] Rema = { "Rema:woman", "Rema:Soundgasm", "Rema:Lady" };
        public static ArrayList RemaSongs = new ArrayList(Rema);

        static string[] WizKid = { "wizkid:joro", "wizkid:reckless", "wizkid:blessed" };
        public static ArrayList WizkidSongs = new ArrayList(WizKid);

        static string[] NewPlaylist = { };
        public static ArrayList NewPlayList = new ArrayList(NewPlaylist);

        public void playlist()
        {
            SongsAndPlaylist.Add("omahlay", RemaSongs);
            SongsAndPlaylist.Add("burnaboy", WizkidSongs);
        }
        public void AddSongsToPlaylist()
        {
            Console.WriteLine("Add New Playlist");
            string newPlaylsit = Console.ReadLine().ToLower();

            if (!string.IsNullOrEmpty(newPlaylsit))
            {
                SongsAndPlaylist.Add(newPlaylsit, NewPlayList);
            }
            else
            {
                Console.WriteLine("invalid input");
                AddSongsToPlaylist();
            }
        }
        public void DisplayPlaylist()
        {
            int i = 0;
            foreach (var songList in SongsAndPlaylist)
            {
                Console.WriteLine("{0}, {1}", i, songList);
                i++;
            }
        }
        public static void AddOmahLaySongs()
        {
            AllSongs.allSongs();

            Console.WriteLine("Add song to OmahLay playlist");
            string newsong = Console.ReadLine();

            foreach (var Song in AllSongs.MusicPlayerSongs)
            {
                if (newsong == Song.Key)
                {
                    RemaSongs.Add(Song.Value);
                }
            }
        }
        public static void DisplayOmahLaySongs()
        {
            int i = 0;
            foreach (var Song in RemaSongs)
            {
                Console.WriteLine("{0}. {0}", i, Song);
                i++;
            }
        }
        public static void AddBurnaBoySongs()
        {
            AllSongs.allSongs();

            Console.WriteLine("Add song to OmahLay playlist");
            string newsong = Console.ReadLine();

            foreach (var Song in AllSongs.MusicPlayerSongs)
            {
                if (newsong == Song.Key)
                {
                    WizkidSongs.Add(Song.Value);
                }
            }
        }
        public static void DisplayBurnaboySongs()
        {
            int i = 0;
            foreach (var Song in WizkidSongs)
            {
                Console.WriteLine("{0}. {0}", i, Song);
                i++;
            }
        }

        public static void AddNewPlaylistSongs()
        {
            AllSongs.allSongs();

            Console.WriteLine("Add song to This playlist");
            string newsong = Console.ReadLine();

            foreach (var Song in AllSongs.MusicPlayerSongs)
            {
                if (newsong == Song.Key)
                {
                    NewPlayList.Add(Song.Value);
                }
            }
        }
        public static void DisplayNewPlaylistSongs()
        {
            int i = 0;
            foreach (var Song in NewPlayList)
            {
                Console.WriteLine("{0}. {0}", i, Song);
                i++;
            }
        }
        public void CreateList()
        {
            List<string> NewPlayList = new List<string>();
        }
    }
}
