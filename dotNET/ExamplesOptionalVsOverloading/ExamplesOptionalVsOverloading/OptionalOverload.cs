using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamplesOptionalVsOverloading
{
    class OptionalOverload
    {

        public static void RegisterUser(string username, string password)
        {
            // The default phone number value is just "1234567890", for example purpose ...
            string phoneNumber = "1234567890";
            RegisterUser(username, password, phoneNumber);
        }

        public static void RegisterUser(string username, string password, string phoneNumber = "")
        {
            // Register the user
            Console.WriteLine("Registering user: {0} - Phone number: {1}", username, phoneNumber);
        }

    }
}
