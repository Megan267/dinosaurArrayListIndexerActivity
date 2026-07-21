using System.Collections;

namespace prjArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arraylist
            ArrayList dinosaurs = new ArrayList();

            //Creating different dinosaur objects - stores any data type
            Dinosaur dino1 = new Dinosaur("DIN001", "Carnivore", "Rex", "Tyrannosaurus rex", 8000);
            Dinosaur dino2 = new Dinosaur("DIN002", "Herbivore", "Longneck", "Brachiosaurus", 56000);
            Dinosaur dino3 = new Dinosaur("DIN003", "Herbivore", "Spike", "Triceratops", 6000);
            Dinosaur dino4 = new Dinosaur("DIN004", "Carnivore", "Raptor", "Velociraptor", 15);
            Dinosaur dino5 = new Dinosaur("DIN005", "Omnivore", "Bird Beak", "Oviraptor", 33);

            //Lets add
            Console.WriteLine("Dinosaurs will be added");
            dinosaurs.Add(dino1);
            dinosaurs.Add(dino2);
            dinosaurs.Add(dino3);
            dinosaurs.Add(dino5);
            PrintList(dinosaurs);

            //Insert dino4 at a specific index
            dinosaurs.Insert(2, dino4);
            Console.WriteLine("The List once every dinosaur has been added");
            PrintList(dinosaurs);

            //Now we want to remove a discovery
            dinosaurs.Remove(dino1);

            //Remove a dinosaur at a specific index
            dinosaurs.RemoveAt(0);

            //Or remove dinosaurs from an index range
            dinosaurs.RemoveRange(0, 1);

            Console.WriteLine("Dinosaurs after some discoveries were removed");
            PrintList(dinosaurs);

            Console.WriteLine("DIN001 was rediscovered");
            dinosaurs.Add(dino1);
            PrintList(dinosaurs);

            Console.WriteLine("The Dinosaurs left in the tracker");
            PrintList(dinosaurs);
        }

        public static void PrintList(ArrayList list)
        {
            foreach (object item in list)
            {
                Dinosaur dino = (Dinosaur)item;
                dino.Display();
            }
            Console.WriteLine($"Total Dinosaurs: {list.Count}\n");
        }
    }
}