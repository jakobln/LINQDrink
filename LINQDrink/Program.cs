using System;
using System.Collections.Generic;
using System.Linq;
// ReSharper disable UnusedParameter.Local

namespace LINQDrink
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Create drinks
            List<Drink> drinks = new List<Drink>();
            drinks.Add(new Drink("Cuba Libre", "Rum", 3, "Cola", 20));
            drinks.Add(new Drink("Russia Libre", "Vodka", 3, "Cola", 20));
            drinks.Add(new Drink("The Day After", "None", 0, "Water", 20));
            drinks.Add(new Drink("Red Mule", "Vodka", 3, "Fanta", 20));
            drinks.Add(new Drink("Double Straight", "Whiskey", 6, "None", 0));
            drinks.Add(new Drink("Pearly Temple", "None", 0, "Sprite", 20));
            drinks.Add(new Drink("High Spirit", "Vodka", 6, "Sprite", 20));
            drinks.Add(new Drink("Watered Down", "Whiskey", 3, "Water", 3));
            drinks.Add(new Drink("Caribbean Gold", "Rum", 6, "Fanta", 20));
            drinks.Add(new Drink("Siberian Zone", "Vodka", 6, "None", 0));
            #endregion

            var nameOfDrinks = from d in drinks
                               select d.Name;

            var nonAlchoholicDrinks = from d in drinks
                                      where d.AlcoholicPart == "None"
                                      select d.Name;

            var alchoholicDrinks = from d in drinks
                                   where d.AlcoholicPartAmount > 0
                                   select new { d.Name, d.AlcoholicPart, d.AlcoholicPartAmount };

            var drinksAlphabetical = from d in drinks
                                     orderby d.Name
                                     select d.Name;

            var sumOfAlchohol = from d in drinks
                                select d.AlcoholicPartAmount;

            var averageAlchohol = from d in drinks
                                  select d.AlcoholicPartAmount;

            /*foreach (var element in nameOfDrinks)
            {
                Console.WriteLine(element);
            }*/

            //foreach (var element in nonAlchoholicDrinks)
            //{
            //    Console.WriteLine(element);
            //}

            //foreach (var element in alchoholicDrinks)
            //{
            //    Console.WriteLine(element.Name + ", " + element.AlcoholicPart + ", " + element.AlcoholicPartAmount + " cl.");
            //}

            //foreach (var element in drinksAlphabetical)
            //{
            //    Console.WriteLine(element);
            //}

            Console.WriteLine("The sum of all the alchohol in the drinks is " + sumOfAlchohol.Sum() + " cl.");

            Console.WriteLine("The average amount of alchohol in the drinks is " + (sumOfAlchohol.Average()) + " cl.");

            KeepConsoleWindowOpen();
        }

        private static void KeepConsoleWindowOpen()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to close application");
            Console.ReadKey();
        }
    }
}
