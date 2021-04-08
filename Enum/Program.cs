using System;

namespace assingment
{
    class Program
    {

        enum Colors
        {
            Red,
            Blue,
            White,
            Black,
            Grey
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Enter a color:");
            string color = Console.ReadLine();
            Colors value = (Colors)Enum.Parse(typeof(Colors), color);
            switch (value)
            {
                case Colors.Red:
                    Console.WriteLine("You have given Red ");
                    break;
                case Colors.Blue:
                    Console.WriteLine("You have given Blue");
                    break;
                case Colors.White:
                    Console.WriteLine("You have given White");
                    break;
                case Colors.Black:
                    Console.WriteLine("You have given Black");
                    break;
                case Colors.Grey:
                    Console.WriteLine("You have given Grey");
                    break;

            }
            Console.ReadLine();


        }
    }
}
