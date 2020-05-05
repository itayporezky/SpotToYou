using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace SpotifyToYoutube.SpotifyData
{
    public class Connect
    {

        public static void Main(string[] args)
        {
            
        }
        public static async Task MainAsync()
        {
            
            Console.WriteLine("Connecting to Spotify API");
            // Call asynchronous network methods in a try/catch block to handle exceptions.
            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri("https://accounts.spotify.com");
                    var content = new FormUrlEncodedContent(new[]
                    {

                    new KeyValuePair<string, string>("grant_type", "client_credentials")
                    });

                    //content.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
                    client.DefaultRequestHeaders.Add("Authorization", "Basic ");

                    HttpResponseMessage response = await client.PostAsync("/api/token", content);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(responseBody);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

    }
}
