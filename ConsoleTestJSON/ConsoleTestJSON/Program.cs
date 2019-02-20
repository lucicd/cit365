using System;
using System.Web.Script.Serialization;

namespace TestJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Joe", "Mango", 45);
            Console.WriteLine(person);

            JavaScriptSerializer js = new JavaScriptSerializer();
            string jsonData = js.Serialize(person);
            Console.WriteLine(jsonData);

            Console.WriteLine();
            jsonData = "{\"FirstName\":\"Jane\",\"LastName\":\"Apple\",\"Age\":40}";
            Console.WriteLine(jsonData);
            Person person2 = js.Deserialize<Person>(jsonData);
            Console.WriteLine(person2);

            Console.ReadLine();
        }
    }
}
