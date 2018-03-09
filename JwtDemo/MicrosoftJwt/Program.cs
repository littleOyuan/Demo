using System;

namespace MicrosoftJwt
{
    class Program
    {
        static void Main(string[] args)
        {
            string jwt = JwtTest.GenerateToken("Donnie");

            Console.WriteLine(jwt);

            Console.ReadKey();
        }
    }
}
