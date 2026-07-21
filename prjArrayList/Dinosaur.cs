using System;
using System.Collections.Generic;
using System.Text;

namespace prjArrayList
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

        public void Display()
        {
            Console.WriteLine($"{DinoID}: {Nickname} ({Species}) - Diet: {DietType}, Weight: {Weight}kg");
        }
    }
}
