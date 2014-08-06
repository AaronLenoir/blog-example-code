using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamplesOptionalVsOverloading
{
    class Program
    {
        static void Main(string[] args)
        {

            // Registering the users using the overloaded methods
            Overloading.RegisterUser("Aaron", "123456", phoneNumber: "09");
            Overloading.RegisterUser("Guy", "password", "+01 (0)123 456 789)");

            // Registering the users using the optional method parameters
            Optional.RegisterUser("Billy", "12345678");
            Optional.RegisterUser("Charlie", "qwerty", "+01 (0)123 456 789)");

            // Registering the users using the optional method that also has an overload alternative
            // which one will be used?
            OptionalOverload.RegisterUser("Danny", "abc123");
            OptionalOverload.RegisterUser("Eve", "123456789", "+01 (0)123 456 789)");

            // Does not compile:
            // Overloading.RegisterUser("Fred", "111111", otherSecrets: "I live on a pale blue dot.");
            
            // Compiles fine:
            Optional.RegisterUser("Harry", "1234567", otherSecrets: "I live on a pale blue dot.");

            // output:
            //Registering user: Aaron - Phone number:
            //Registering user: Guy - Phone number: +01 (0)123 456 789)
            //Registering user: Billy - Phone number:
            //Registering user: Charlie - Phone number: +01 (0)123 456 789)
            //Registering user: Danny - Phone number: 1234567890
            //Registering user: Eve - Phone number: +01 (0)123 456 789)

            Console.ReadLine();

        }
    }
}
