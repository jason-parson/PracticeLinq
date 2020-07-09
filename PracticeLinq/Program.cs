using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {

            //string[] carName = { "Honda", "Toyota", "Buick", "Kia", "Tesla", "Lexus", "Audi" };

            //var carLetter = from car in carName
            //                where car.Contains("o")
            //                orderby car descending
            //                select car;

            //foreach (var i in carLetter)
            //{
            //    Console.WriteLine(i);

            //}

            List<string> gameName = new List<string> { "Madden", "Street Fighter", "Mario Kart", "Tetris", "NBA 2020", "Rainbow Six", "StarWars" };
            var orderNames = gameName.Where(game => game.Length > 0).OrderBy(game => game.Length);

            foreach (var i in gameName)
            {
                Console.WriteLine(i);

            }
        }
    }
}
