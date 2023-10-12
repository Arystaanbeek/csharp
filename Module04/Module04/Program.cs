using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Module04
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Furniture[] furnitureArray = new Furniture[5];

            furnitureArray[0] = new Furniture("Стол", 80, 120, "Дерево");
            furnitureArray[1] = new Furniture("Шкаф", 200, 100, "ДСП");
            furnitureArray[2] = new Furniture("Диван", 90, 200, "Ткань");
            furnitureArray[3] = new Furniture("Стул", 45, 45, "Металл");
            furnitureArray[4] = new Furniture(); 

            foreach (var furniture in furnitureArray)
            {
                Console.WriteLine($"Изготовитель: {Furniture.Manufacturer}");
                furniture.PrintInfo();
                if (!furniture.IsAssembled)
                {
                    furniture.Assemble();
                    Console.WriteLine("Мебель собрана.");
                }
            }

            Console.WriteLine($"Всего создано {Furniture.NumberOfFurnitureItems} объектов Furniture.");

            Furniture.Manufacturer = "New Furniture Co.";
            Console.WriteLine($"Новый изготовитель: {Furniture.Manufacturer}");

            Console.ReadKey();
        }
    }

    public partial class Furniture
    {
        public string Name { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public string Material { get; set; }
        public bool IsAssembled { get; private set; }

        public static int NumberOfFurnitureItems { get; private set; } = 0;
        public static string Manufacturer { get; set; } = "Furniture Co.";

        public Furniture()
        {
            NumberOfFurnitureItems++;
        }

        public Furniture(string name, int height, int width, string material)
        {
            Name = name;
            Height = height;
            Width = width;
            Material = material;
            NumberOfFurnitureItems++;
        }

        public void Assemble()
        {
            IsAssembled = true;
        }

        public void Disassemble()
        {
            IsAssembled = false;
        }

        public void UpdateDimensions(ref int newHeight, ref int newWidth)
        {
            Height = newHeight;
            Width = newWidth;
        }

        static Furniture()
        {
            Console.WriteLine("Статический конструктор Furniture вызван.");
        }
    }

    partial class Furniture
    {
        public void PrintInfo()
        {
            Console.WriteLine($"Имя: {Name}");
            Console.WriteLine($"Высота: {Height} см");
            Console.WriteLine($"Ширина: {Width} см");
            Console.WriteLine($"Материал: {Material}");
            Console.WriteLine($"Собрана: {IsAssembled}");
        }
    }
}

