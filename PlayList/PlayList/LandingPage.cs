using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayList
{
    internal class MusicPlayer
    {
        public static void Musicplayer()
        {
            Console.WriteLine("Germaine Music PLayer\n");
            Console.WriteLine("select option:\n1. To View all Songs\n2. To Select Playlist \n3. To Create a New Playlist");

            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Console.WriteLine("Allsongs");
                    AllSongs.allSongs();
                    Musicplayer();
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Select Playlist");
                    PlaylistOption();
                    break;
                case "3":
                    Console.WriteLine("Create a New Playlist");
                    AddToPlaylist.AddNewToPlaylist();
                    AddToPlaylist.DisplayPlaylist();
                    NewCreatedPlalist();
                    break;

                    default:Musicplayer();break;
            }
        } 
        public static void PlaylistOption()
        {
            AddToPlaylist.DisplayPlaylist();

            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("OmahLay Playlist Selected");
                    OmahLay();
                    break;

                case "2":
                    Console.Clear();
                    Console.WriteLine("Burna boy selected");
                    Burnaboy();
                    break;
               /* case "3":
                    Console.Clear();
                    Console.WriteLine($"{AddToPlaylist.newPlaylsit} selected");
                    NewCreatedPlalist();
                    break;*/
            }
        }
        public static void OmahLay()
        {
            AddToPlaylist.DisplayOmahLaySongs();
            Console.WriteLine("\nselect option:\n1. To Add Song\n2. To Edit Song\n3. To Delete Song");

            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Console.WriteLine("Add Songs:\n");
                    AddToPlaylist.AddOmahLaySongs();
                    OmahLay();
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Edit a Song:\n");
                    AddToPlaylist.EditOmalaySongs();

                    OmahLay();
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Delete a Song:\n");
                    AddToPlaylist.DeleteOmalaySongs();
                    AddToPlaylist.DisplayOmahLaySongs();

                    OmahLay();
                    break;
            }

        }
        public static void Burnaboy()
        {
            AddToPlaylist.DisplayBurnaboySongs();

            Console.WriteLine("\nselect option:\n1. To Add Song\n2. To Edit Song\n3. To Delete Song");

            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Console.WriteLine("Add Songs:\n");
                    AddToPlaylist.AddBurnaBoySongs();
                    OmahLay();
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Edit a Song:\n");
                    AddToPlaylist.EditOmalaySongs();

                    OmahLay();
                    break;
                case "3":
                    //Console.Clear();
                    Console.WriteLine("Delete a Song:\n");
                    AddToPlaylist.DeleteOmalaySongs();
                    AddToPlaylist.DisplayBurnaboySongs();

                    OmahLay();
                    break;
            }

        }
        public static void NewCreatedPlalist()
        {
            AddToPlaylist.DisplayNewPlaylistSongs();

            Console.WriteLine("\nselect option:\n1. To Add Song\n2. To Edit Song\n3. To Delete Song");

            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Console.WriteLine("Add Songs:\n");
                    AddToPlaylist.AddNewPlaylistSongs();
                    NewCreatedPlalist();
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Edit a Song:\n");
                    AddToPlaylist.EditNewPlaylistSongs();

                    NewCreatedPlalist();
                    break;
                case "3":
                    //Console.Clear();
                    Console.WriteLine("Delete a Song:\n");
                    AddToPlaylist.DeleteNewPlaylistSongs();
                    AddToPlaylist.DisplayNewPlaylistSongs();

                    NewCreatedPlalist();
                    break;
            }
        }

    }  
}
