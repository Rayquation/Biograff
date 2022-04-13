using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biograff
{
    internal class Program
    {
        public static string[] menu = { "sal", "ny sal", "ny film" };
        public static string[] room = { "sal1", "sal2", "sal3", "sal4" };
        public static string[] film = { "Star Wars", "Justice Leauge", "Avengers endgame", "Ninja Turtels" };
        public static string[] roomfilm = new string[room.Length];
        public static string answer;
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Velkommen til biografen");
                Menu();
                Console.ReadKey();
            }
            catch
            {
                Main(args);
            }
        }
        public static void Menu()
        {
            Random rand = new Random();
            int random = rand.Next(film.Length);
            foreach (string menuName in menu)
            {
                Console.WriteLine($"{menuName}");
            }
            Console.WriteLine($"Vælg hvilken menu du vil ind til");
            string choice = Console.ReadLine();
                if (choice == "sal")
                {
                    foreach (string roomName in room)
                    {
                        Console.WriteLine($"{roomName}");
                    }
                    Console.WriteLine("Vælg sal for at finde information om film");
                    answer = Console.ReadLine();
                    for (int i = 0; i < room.Length; i++)
                    {
                    roomfilm[i] = film[random - 1];
                    }
                    if (answer == "sal1")
                    {
                    }
                }
                else if (choice == "ny sal")
                {
                    Console.Write($"Indtast ny sal => ");
                    room[room.Length + 1] = Console.ReadLine();
                }
                else if (choice == "ny film")
                {
                    Console.Write($"Indtast ny film => ");
                    film[film.Length + 1] = Console.ReadLine();
                }
        }
    }
}
