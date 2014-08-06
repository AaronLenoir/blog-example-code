using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamplesOptionalVsOverloading
{
    class Overloading
    {

        public static void RegisterUser(string username, string password)
        {
            // The default phone number value is just an empty value
            string phoneNumber = string.Empty;
            RegisterUser(username, password, phoneNumber);
        }

        public static void RegisterUser(string username, string password, string phoneNumber) {
            // Register the user
            Console.WriteLine("Registering user: {0} - Phone number: {1}", username, phoneNumber);
        }

        public static void RegisterUser(string username, string password, string phoneNumber, string otherSecrets)
        {
            Console.WriteLine("Registering user: {0} - Phone number: {1} ({2})", username, phoneNumber, otherSecrets);
        }

    }
}
