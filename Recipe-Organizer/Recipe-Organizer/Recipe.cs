using System;
using System.Collections.Generic;
using System.Text;

namespace Recipe_Organizer
{
    public class Recipe
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Servings { get; set; }
        public double preperationTime { get; set; }
        public List<string> instructions { get; set; }
        public List<Tuple<string, int>> ingedients { get; set; }


        public Recipe()
        {

        }
    }
}
