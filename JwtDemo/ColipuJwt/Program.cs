using System;

namespace ColipuJwt
{
    class Program
    {
        static void Main(string[] args)
        {
            string jwt = JwtTest.GenerateJwt();

            Console.WriteLine(jwt);

            Console.ReadKey();
        }
    }
}
