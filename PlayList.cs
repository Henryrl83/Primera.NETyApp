using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Primera.NETyApp
{
    /*public class PlayList<T, V, Z>
    {

    }*/
    public class PlayList
    {

        List<Song> mediaList = new List<Song>();
        //ArrayList list = new ArrayList();
        //T[] medialist = new T[] { };
        public void Add(Song media)
        {
            mediaList.Add(media);
        }
        public void PlayAll()
        {
            foreach(Song media in mediaList)
            {
                Console.WriteLine(media);
            }
        }

        public void Preview()
        {
            if (mediaList.Count > 0)
            {
                Console.WriteLine(mediaList[0]);
            }
        }

        public List<Song> SearchForCategory (string category)
        {
            //Linq: la siguiente línea es exactamente lo mismo que lo comentado
            var songs = mediaList.Where(x => x.Category == category);
            /*List<Song> songs = new List<Song>();
            foreach (Song song in mediaList)
            {
                if (song.Category == category)
                {
                    songs.Add(song);
                }
            }*/
            return songs.ToList();
        }
        public List<Song> SearchForTitle (String title)
        {
            /*Linq: la siguiente línea es exactamente lo mismo que lo comentado
             !!OJO la en entrada de parametros X es la condicion del "if"*/
            var songs = mediaList.Where (x => x.Title.Contains(title));
            /*List<Song> songs = new List<Song> ();
            foreach (Song song in mediaList)
            {
                if (song.Title.Contains(title))
                {
                    songs.Add(song);
                }
            }*/
            return songs.ToList();
        }
        public List<string> GimmeTitlesFromSong ()
        {

            var titles = mediaList.Select(x => x.Title);
            /*List<string> titles = new List<string>();
            {
            foreach (Song song in mediaList)
                {
                  titles.Add(song.Title);
                }*/
            return titles.ToList();
        }

        public List<string> GimmeNameOfArtists()
        {
            var nameOfArtists = mediaList.SelectMany(x => x.Artists)
                                         .Select(x => x.Name);
            return nameOfArtists.ToList();
        }

        public bool HaveATitle (string title)
        {
            return mediaList.Any(x => x.Title == title);
        }

        public Song GetFirstSongWhithLess1Minute()
        {
            var song = mediaList.FirstOrDefault(x => x.Seconds < 60);
            return song;
            
            /*if (song != null)
            {
                song = new Song();
            }*/
        }

        public Song GetLastSongWhitLess1Minute()
        {
            var song = mediaList.LastOrDefault(x => x.Seconds < 60); 
            return song;
        }

        public List<Song> Top10()
        {
            return mediaList.OrderByDescending(x => x.Visits)
                .Take(10).ToList();
        }

        public Song[] Bottom10()
        {
            return mediaList.OrderBy(x => x.Visits)
                .Take(10).ToArray();
        }
        public void GroupFromCategory()
        {
            mediaList.GroupBy(x => x.Category)
                     .ToDictionary(x => x.Key);
        }
        public List<Song> Skip10Top20()
        {
            return mediaList.Skip(10).Take(10).ToList();
        }

        public List<Media> ToConvertMedia()
        {
            return mediaList.OfType<Media>().ToList();
        }

    }
}
