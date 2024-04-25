using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonConvertDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            User user = new User() { FirstName = "Harshal", LastName = "Jain", Salary = 25000 };

            // serialization ie c# instance to JSON
            string userDetailsInJson = JsonConvert.SerializeObject(user);
            Console.WriteLine(userDetailsInJson);


            // deserialization ie. JSON to C# object
            User user2 = JsonConvert.DeserializeObject<User>(userDetailsInJson);
        }
    }

    class User
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Salary { get; set; }
    }
}
