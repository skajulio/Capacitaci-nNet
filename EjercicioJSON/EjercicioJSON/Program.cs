using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace EjercicioJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            string content = Task.Run(GetData).Result;
            List<Users> users = JsonConvert.DeserializeObject<List<Users>>(content);

            foreach (var user in users)
            {
                Console.WriteLine("*************************************");
                Console.WriteLine($"Id: {user.Id}");
                Console.WriteLine($"Nombre: {user.Name}");
                Console.WriteLine($"UserName: {user.UserName}");
                Console.WriteLine($"Email: {user.Email}");
                Console.WriteLine("ADDRESS:");
                Console.WriteLine($"Street: {user.Address.Street}");
                Console.WriteLine($"Suite: {user.Address.Suite}");
                Console.WriteLine($"City: {user.Address.City}");
                Console.WriteLine($"ZipCode: {user.Address.ZipCode}");
                Console.WriteLine($"Lat: {user.Address.Geo.Lat}");
                Console.WriteLine($"Lng: {user.Address.Geo.Lng}");
                Console.WriteLine($"Phone: {user.Phone}");
                Console.WriteLine($"Website: {user.WebSite}");
                Console.WriteLine("COMPANY");
                Console.WriteLine($"Name: {user.Company.Name}");
                Console.WriteLine($"Catch Phrase: {user.Company.CatchPhrase}");
                Console.WriteLine($"Bs: {user.Company.Bs}");
                //Console.WriteLine($": {user}");
                //Console.WriteLine($": {user}");
            }

            Console.ReadKey();
        }

        private static async Task<string> GetData()
        {
            string url = "https://jsonplaceholder.typicode.com/users";

            HttpClient client = new HttpClient();

            string content = await client.GetStringAsync(url);

            return content;
        }
    }

}
