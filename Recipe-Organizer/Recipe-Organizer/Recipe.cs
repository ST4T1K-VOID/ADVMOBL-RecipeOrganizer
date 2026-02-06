using System;
using System.Collections.Generic;
using System.Text;

namespace Recipe_Organizer
{
    public class Recipe
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Servings { get; set; }
        public double PreperationTime { get; set; }
        public List<string> Instructions { get; set; }
        public List<(string, int)> Ingredients { get; set; }


        public Recipe(string name, string description, int servings, double preperationTime, List<string> instructions, List<(string, int)> ingredients)
        {
            Name = name;
            Description = description;
            Servings = servings;
            PreperationTime = preperationTime;
            Instructions = instructions;
            Ingredients = ingredients;
        }
    }
}
