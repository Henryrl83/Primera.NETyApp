using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primera.NETyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Song song = new Song();//1
            song.Title = "Dark side of moon";
            song.Seconds = 500;
            song.Position = new ShelvePosition(0,0);
            //song.Play();

            Song song2 = new Song();//2
            song2.Title = "Dark side of moon";
            song2.Seconds = 500;
            song2.Position = new ShelvePosition(1, 0);

            PlayList<Song> playListSongs = new PlayList<Song>();
            playListSongs.Add(song);
            playListSongs.Add(song2);

            WriteLineSpecial(song, "Start With", "enjoy");

            Console.WriteLine(song2.ToString());

            Tuple<int, string, Song> tuple = new Tuple<int, string, Song>(0, "Hola", song);

            ListExplanation();
            StackExplanation();
            QueueExplanation();
            DictionaryExplanation();
            
            //List<int> numbers = new List<int>();
            //List<Song> songs = new List<Song>();
            //List<int> ints = new List<int>();
            //ArrayList list = new ArrayList();

            Console.ReadKey();

        }
        private static void DownloadSong()
        {
            DownloadService downloadService = new DownloadService();
            byte[] song = downloadService.Download("Dark side on the moon");
        }

        private async static void DownloadSongAsync()
        {
            DownloadService downloadService = new DownloadService();
            byte[] futureSong = await downloadService.DownloadAsync("Dark side on the moon");
        }
        private static void ListExplanation()
        {
            List<int> numbers = new List<int>();
            numbers.Add(0);
            numbers.Add(1);
            //numbers.Count
        }
        private static void StackExplanation()
        {
            Stack<Song> saleSongs = new Stack<Song>();
            saleSongs.Push(new Song());
            saleSongs.Push(new Song());
            Song song = saleSongs.Pop();
        }
        private static void QueueExplanation()
        {
            Queue<int> queueNumbers = new Queue<int>();
            queueNumbers.Enqueue(1);
            int number = queueNumbers.Dequeue();
        }
        private static void DictionaryExplanation()
        {
            Dictionary<string, Client> clients = new Dictionary<string, Client>();
            clients.Add("00000000D", new Client() { Name = "Enrique Raposo" });

            if (!clients.ContainsKey("00000000D"))
            {
                clients.Add("00000000D", new Client() { Name = "Enrique Raposo" });
            }

            clients["00000000D"] = new Client();
            Client myClient = clients["00000000D"];

            var elements = new List<KeyValuePair<string, Client>>();
            elements.Add(new KeyValuePair<string, Client>("0001", new Client()));
            elements.Add(new KeyValuePair<string, Client>("0002", new Client()));


            //Utils.AddRangeDictionary(clients, elements);
            clients.AddRange(elements);
        }
        static void WriteLineSpecial<T>(T data, string prefix, string suffix) where T : new()
        {
            T myNewType = new T();
            Console.WriteLine($"{prefix} {data} {suffix}");
        }
        static void Declarations()
        {
            //==
            //!=
            //>=
            //<=
            //>
            //<
            //&& (AND)
            //|| (OR)

            int number = 0;
            double numberDecimals = 0.0d;
            bool yayOrNay = true;
            string helloWorld = string.Empty;
        }

        static void Conditions()
        {
            int number = 0;
            number += 2;
            //number=>2

            number -= 2;
            //number =>0

            //Si
            if (number == 0)
            {
                //
            }
            //sino si
            else if (number > 0)
            {
                //
            }
            //sino
            else
            {
                //
            }

        }

        static void Loops()
        {
            int number = 0;

            for (int i = 0; i < 10; i++)
            {
                //DO SOMETHING
            }

            while (number != 10)
            {
                number++;
            }
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            foreach (int num in numbers)
            {

            }
        }

        static void Switch()
        {
            int number = 0;
            switch (number)
            {
                case 0:
                    break;
                case 10:
                    break;
                default:
                    break;
            }
        }
    }
}
