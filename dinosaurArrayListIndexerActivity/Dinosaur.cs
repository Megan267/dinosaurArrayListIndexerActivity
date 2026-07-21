using System;
using System.Collections.Generic;
using System.Text;

namespace prjIndexers
{
    public class Dinosaur
    {
        public string DinoID { get; set; }
        public string DietType { get; set; }
        public string Nickname { get; set; }
        public string Species { get; set; }
        public double Weight { get; set; }

        public Dinosaur(string dinoID, string dietType, string nickname, string species, double weight)
        {
            DinoID = dinoID;
            DietType = dietType;
            Nickname = nickname;
            Species = species;
            Weight = weight;
        }

        //Indexer - using an integer
        public object this[int index]
        {
            get
            {
                if (index == 0) return this.DinoID;
                else if (index == 1) return this.DietType;
                else if (index == 2) return this.Nickname;
                else if (index == 3) return this.Species;
                else if (index == 4) return this.Weight;
                return null;
            }
            set
            {
                if (index == 0) this.DinoID = (string)value;
                else if (index == 1) this.DietType = (string)value;
                else if (index == 2) this.Nickname = (string)value;
                else if (index == 3) this.Species = (string)value;
                else if (index == 4) this.Weight = (double)value;
            }
        }

        //Indexer - using a string
        public object this[string attrName]
        {
            get
            {
                if (attrName.ToLower().Equals("dinoid")) return this.DinoID;
                else if (attrName.ToLower().Equals("diettype")) return this.DietType;
                else if (attrName.ToLower().Equals("nickname")) return this.Nickname;
                else if (attrName.ToLower().Equals("species")) return this.Species;
                else if (attrName.ToLower().Equals("weight")) return this.Weight;
                return null;
            }
            set
            {
                if (attrName.ToLower().Equals("dinoid")) this.DinoID = (string)value;
                else if (attrName.ToLower().Equals("diettype")) this.DietType = (string)value;
                else if (attrName.ToLower().Equals("nickname")) this.Nickname = (string)value;
                else if (attrName.ToLower().Equals("species")) this.Species = (string)value;
                else if (attrName.ToLower().Equals("weight")) this.Weight = (double)value;
            }
        }

        public void Display()
        {
            Console.WriteLine($"{DinoID}: {Nickname} ({Species}) - Diet: {DietType}, Weight: {Weight}kg");
        }
    }
}
