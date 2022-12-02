using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayList
{

    public class AddToPlaylist
    {

        public static Dictionary<string, ArrayList> SongsAndPlaylist = new Dictionary<string, ArrayList>();

        static string[] OmahLay = { "omahlay:Bend you", "omahlay:soso" };
        public static ArrayList OmahLaySongs = new ArrayList(OmahLay);

        static string[] BurnaBoy = { "Burnaboy: it's plenty", "Burnaboy: gbona", "Burnaboy: Last Last"};
        public static ArrayList BurnaBoySongs = new ArrayList(BurnaBoy);

        static string[] NewPlaylist = { };
        public static ArrayList NewPlayList = new ArrayList(NewPlaylist);

        public static void playlist()
        {
            SongsAndPlaylist.Add("omahlay", OmahLaySongs);
            SongsAndPlaylist.Add("burnaboy", BurnaBoySongs);
        }
        public static void DisplayPlaylist()
        {
            playlist();
            int i = 1;
            foreach(var songList in SongsAndPlaylist)
            {
                Console.WriteLine("{0}. {1}",i,songList.Key);
                i++;
            }
        }
        public static void AddNewToPlaylist()
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
                AddNewToPlaylist();
            }
        }

        public static void AddOmahLaySongs()
        {
            AllSongs.allSongs();

            bool Validate = true;
            while (Validate)
            {
                Console.WriteLine("Do you want to add a Song....y/n");

                var Option = Console.ReadLine();
                switch (Option)
                {
                    case "y":
                        Console.WriteLine("Add song to OmahLay playlist");
                        string newsong = Console.ReadLine();
                        foreach (var Song in AllSongs.MusicPlayerSongs)
                        {
                            if (newsong == Song.Key && !OmahLaySongs.Contains(Song.Value))
                            {
                                OmahLaySongs.Add(Song.Value);
                            }                         
                        }
                        break;
                    case "n":
                        Validate = false;
                        break;
                }
            }
        }
        public static void DisplayOmahLaySongs()
        {
            int i = 1;
            foreach (var Song in OmahLaySongs)
            {
                Console.WriteLine("{0}. {1}",i,Song);
                i++;
            }
        }
        public static void DeleteOmalaySongs()
        {
            DisplayOmahLaySongs();
            Console.Clear();
            DisplayOmahLaySongs();

            Console.WriteLine("are you sure you want to delete this song..y/n");
            var option = Console.ReadLine();

            switch (option)
            {
                case "y":
                    Console.WriteLine("Choose the song");
                    int deleteSong = int.Parse(Console.ReadLine());
                    OmahLaySongs.RemoveAt(deleteSong-1);
                    break;
                case "n":
                    break;
            }
        }
        public static void EditOmalaySongs()
        {
            DisplayOmahLaySongs();
            Console.WriteLine("are you sure you want to edit a song....y/n");
            var option = Console.ReadLine();

            switch (option)
            {
                case "y":
                    Console.WriteLine("choose song");
                    int songIndex = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter artist name");
                    var Artiste = Console.ReadLine();

                    Console.WriteLine("Enter artist name");
                    var Songtitle = Console.ReadLine();

                    string editsong = $"{Artiste}:{Songtitle}";
                    OmahLaySongs.RemoveAt(songIndex-1);
                    OmahLaySongs.Insert(songIndex-1, editsong);

                    break;
                case "n":
                    DisplayOmahLaySongs();
                    break;
            }
        }

        public static void AddBurnaBoySongs()
        {
            AllSongs.allSongs();

            bool Validate = true;
            while (Validate)
            {
                Console.WriteLine("Do you want to add a Song....y/n");

                var Option = Console.ReadLine();
                switch (Option)
                {
                    case "y":
                        Console.WriteLine("Add song to OmahLay playlist");
                        string newsong = Console.ReadLine();
                        foreach (var Song in AllSongs.MusicPlayerSongs)
                        {
                            if (newsong == Song.Key && !BurnaBoySongs.Contains(Song.Value))
                            {
                                BurnaBoySongs.Add(Song.Value);
                            }
                        }
                        break;
                    case "n":
                        Validate = false;
                        break;
                }
            }
        }
        public static void DisplayBurnaboySongs()
        {
            int i = 0;
            foreach (var Song in BurnaBoySongs)
            {
                Console.WriteLine("{0}. {1}", i, Song);
                i++;
            }
        }
        public static void DeleteBurnaboySongs()
        {
            Console.Clear();
            DisplayOmahLaySongs();

            Console.WriteLine("are you sure you want to delete this song..y/n");
            var option = Console.ReadLine();

            switch (option)
            {
                case "y":
                    Console.WriteLine("Choose the song");
                    int deleteSong = int.Parse(Console.ReadLine());
                    BurnaBoySongs.RemoveAt(deleteSong);
                    break;
                case "n":
                    break;
            }
        }
        public static void EditBurnaboySongs()
        {
            Console.WriteLine("are you sure you want to edit a song....y/n");
            var option = Console.ReadLine();

            switch (option)
            {
                case "y":
                    Console.WriteLine("choose song");
                    int songIndex = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter artist name");
                    var Artiste = Console.ReadLine();

                    Console.WriteLine("Enter artist name");
                    var Songtitle = Console.ReadLine();

                    string editsong = $"{Artiste}:{Songtitle}";
                    BurnaBoySongs.RemoveAt(songIndex);
                    BurnaBoySongs.Insert(songIndex, editsong);
                    break;
                case "n":
                    DisplayBurnaboySongs();
                    break;
            }
        }

        public static void AddNewPlaylistSongs()
        {
            AllSongs.allSongs();

            bool Validate = true;
            while (Validate)
            {
                Console.WriteLine("Do you want to add a Song....y/n");

                var Option = Console.ReadLine();
                switch (Option)
                {
                    case "y":
                        Console.WriteLine("Add song to OmahLay playlist");
                        string newsong = Console.ReadLine();
                        foreach (var Song in AllSongs.MusicPlayerSongs)
                        {
                            if (newsong == Song.Key && !NewPlayList.Contains(Song.Value))
                            {
                                NewPlayList.Add(Song.Value);
                            }
                        }
                        break;
                    case "n":
                        Validate = false;
                        break;
                }
            }
        }
        public static void DisplayNewPlaylistSongs()
        {
            int i = 1;
            foreach (var Song in NewPlayList)
            {
                Console.WriteLine("{0}. {1}", i, Song);
                i++;
            }
        }
        public static void DeleteNewPlaylistSongs()
        {
            Console.Clear();
            DisplayOmahLaySongs();

            Console.WriteLine("are you sure you want to delete this song..y/n");
            var option = Console.ReadLine();

            switch (option)
            {
                case "y":
                    Console.WriteLine("Choose the song");
                    int deleteSong = int.Parse(Console.ReadLine());
                    BurnaBoySongs.RemoveAt(deleteSong);
                    break;
                case "n":
                    break;
            }
        }
        public static void EditNewPlaylistSongs()
        {
            Console.WriteLine("are you sure you want to edit a song....y/n");
            var option = Console.ReadLine();

            switch (option)
            {
                case "y":
                    Console.WriteLine("choose song");
                    int songIndex = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter artist name");
                    var Artiste = Console.ReadLine();

                    Console.WriteLine("Enter artist name");
                    var Songtitle = Console.ReadLine();

                    string editsong = $"{Artiste}:{Songtitle}";
                    BurnaBoySongs.RemoveAt(songIndex);
                    BurnaBoySongs.Insert(songIndex, editsong);
                    break;
                case "n":
                    DisplayNewPlaylistSongs();
                    break;
            }
        }

    }
    public class AllSongs
    {
        public static Dictionary<string, string> MusicPlayerSongs = new Dictionary<string, string>()
        {
            {"1","Burnaboy:it'splenty" }, {"2","Burnaboy:gbona" },{"3","Burnaboy:secrets" },{"4","Burnaboy:Last Last" },
            {"5","omahlay:Godly" }, {"6","omahlay:soso" },{"7","omahlay:Bend you" }, {"8","wizkid:joro" },
            {"9","wizkid:Anoti" }, {"10","Davido:fem" }
        };

        public static void allSongs()
        {
            foreach (var Song in MusicPlayerSongs)
            {
                Console.WriteLine("{0}. {1}", Song.Key, Song.Value);
            }

            Console.WriteLine();
            //MusicPlayer.Musicplayer();
        }
    }
}
