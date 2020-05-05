using System;
using System.Data;
using System.Threading.Tasks;
using SpotifyToYoutube.SpotifyData;

namespace SpotifyToYoutube
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Task.Run(() => Connect.MainAsync());
            Console.ReadLine();
        }
    }
}
