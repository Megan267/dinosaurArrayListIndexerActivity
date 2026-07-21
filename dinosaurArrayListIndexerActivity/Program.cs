using prjIndexers;
using System.Collections;

namespace dinosaurArrayListIndexerActivity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating different dinosaur objects - stores any data type
            Dinosaur dino1 = new Dinosaur("DIN001", "Carnivore", "Rex", "Tyrannosaurus rex", 8000);
            Dinosaur dino2 = new Dinosaur("DIN002", "Herbivore", "Longneck", "Brachiosaurus", 56000);
            Dinosaur dino3 = new Dinosaur("DIN003", "Herbivore", "Spike", "Triceratops", 6000);
            Dinosaur dino4 = new Dinosaur("DIN004", "Carnivore", "Raptor", "Velociraptor", 15);
            Dinosaur dino5 = new Dinosaur("DIN005", "Omnivore", "Bird Beak", "Oviraptor", 33);

            //using the integer indexer
            dino1[2] = "Big Rex";
            Console.WriteLine(dino1[0]);
            Console.WriteLine(dino1[1]);
            Console.WriteLine(dino1[2]);
            Console.WriteLine(dino1[3]);
            Console.WriteLine(dino1[4]);

            //using the string indexer
            dino1["weight"] = 8500.00;
            Console.WriteLine("Dino ID: " + dino1["dinoid"]);
            Console.WriteLine("Diet Type: " + dino1["diettype"]);
            Console.WriteLine("Nickname: " + dino1["nickname"]);
            Console.WriteLine("Species: " + dino1["species"]);
            Console.WriteLine("Weight: " + dino1["weight"]);
        }
    }
}
