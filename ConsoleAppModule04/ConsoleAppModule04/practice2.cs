using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppModule04
{
    internal class practice2
    {
        static void Main()
        {
            List<Animal> animals = new List<Animal>
            {
                new Carnivore(1, "Лев", 5.5),
                new Omnivore(2, "Медведь", 3.0),
                new Herbivore(3, "Зебра", 10.0),
            };

            animals.Sort();
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }

            var first5Names = animals.Take(5).Select(a => a.Name);
            Console.WriteLine("Первые 5 имен: " + string.Join(", ", first5Names));

            Console.WriteLine("Последние 3 идентификатора:");
            for (int i = animals.Count - 3; i < animals.Count; i++)
            {
                Console.WriteLine(animals[i].Id);
            }
            Console.ReadKey();
        }
    }

    abstract class Animal : IComparable<Animal>
    {
        public int Id { get; }
        public string Name { get; }
        public string Type { get; }
        public abstract double FoodConsumption();

        public Animal(int id, string name, string type)
        {
            Id = id;
            Name = name;
            Type = type;
        }

        public int CompareTo(Animal other)
        {
            int foodComparison = FoodConsumption().CompareTo(other.FoodConsumption());
            if (foodComparison == 0)
            {
                return Name.CompareTo(other.Name);
            }
            return -foodComparison;
        }

        public override string ToString()
        {
            return $"{Id}: {Name} ({Type}) - {FoodConsumption()} кг в день";
        }
    }

    class Carnivore : Animal
    {
        public double MeatConsumption { get; }

        public Carnivore(int id, string name, double meatConsumption)
            : base(id, name, "Хищник")
        {
            MeatConsumption = meatConsumption;
        }

        public override double FoodConsumption()
        {
            return MeatConsumption;
        }
    }

    class Omnivore : Animal
    {
        public double PlantConsumption { get; }

        public Omnivore(int id, string name, double plantConsumption)
            : base(id, name, "Всеядное")
        {
            PlantConsumption = plantConsumption;
        }

        public override double FoodConsumption()
        {
            return PlantConsumption;
        }
    }

    class Herbivore : Animal
    {
        public double GrassConsumption { get; }

        public Herbivore(int id, string name, double grassConsumption)
            : base(id, name, "Травоядное")
        {
            GrassConsumption = grassConsumption;
        }

        public override double FoodConsumption()
        {
            return GrassConsumption;
        }
    }
}