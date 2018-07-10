using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace DemoJson
{
    class Program
    {
        static void Main(string[] args)
        {
            string content = Task.Run(GetData).Result;
            List<Post> posts = JsonConvert.DeserializeObject<List<Post>>(content);

            foreach(var post in posts)
            {
                Console.WriteLine("*************************************");
                Console.WriteLine($"Id: {post.Id}");
                Console.WriteLine($"Title: {post.Title}");
                Console.WriteLine($"Body: {post.Body}");
                Console.WriteLine($"UserId: {post.UserID}");
            }

            Console.ReadKey();
        }

        private static async Task<string> GetData()
        {
            string url = "https://jsonplaceholder.typicode.com/posts";

            HttpClient client = new HttpClient();

            string content = await client.GetStringAsync(url);

            return content;
        }
    }
}
