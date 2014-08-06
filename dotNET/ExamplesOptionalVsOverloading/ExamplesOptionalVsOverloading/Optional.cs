using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamplesOptionalVsOverloading
{
    class Optional
    {

        public static void RegisterUser(string username, string password, string phoneNumber = "", string otherSecrets = "")
        {
            // Register the user
            Console.WriteLine("Registering user: {0} - Phone number: {1} ({2})", username, phoneNumber, otherSecrets);
        }

    }
}
