using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;


namespace Homework12Seriali
{
    internal class Diet
    {
        public string Name { get; set; }
        public string Author { get; set; }
        [JsonIgnore]
        public string Code { get; set; }
        public Ingredient Ingredients { get; set; }
    }
}
