using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Homework12Seriali
{
    internal class Ingredient
    {
        public List <string> Name { get; set; }
        public double Price { get; set; }
        [JsonProperty ("Energy")]
        public double EnergyCost { get; set; }
        public string Manufacturer { get; set; }

    }
}
