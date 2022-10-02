using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(var client = new HttpClient())
            {
                var endpoint = new Uri("https://rickandmortyapi.com/api/character");
                var result = client.GetAsync(endpoint).Result;
                var json = result.Content.ReadAsStringAsync().Result;
                dynamic posts = JsonConvert.DeserializeObject(json);



            foreach(var item in posts.results)
                {
                   // Console.WriteLine(item.name );
                    Console.WriteLine(item.name);

                }
            }
        }
    }
}