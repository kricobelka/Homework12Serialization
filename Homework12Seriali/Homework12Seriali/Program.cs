using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Homework12Seriali
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Diet diet = new Diet();
            diet.Name = "Mix";
            diet.Author = "Helesi";
            diet.Code = "AH28";

            Ingredient ingredients = new Ingredient();

            ingredients.Name = new List<string>()
            {
                "coal",
                "acid",
                "banana"
            };
            ingredients.Manufacturer = "Recipimal";
            ingredients.Price = 199.9d;
            ingredients.EnergyCost = 97.5d;

            diet.Ingredients = ingredients;

            var dietobject = JsonConvert.SerializeObject(diet, Formatting.Indented);
            Console.WriteLine($"Diet information: {dietobject} ");

        }
    }
}
