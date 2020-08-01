using BUS_Controls;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            BUS_SignIn bUS = new BUS_SignIn();

            Console.WriteLine( bUS.SignIn(new DTO_Hotel.DTO_SignIn("admin", "admin")));
        }
    }
}
