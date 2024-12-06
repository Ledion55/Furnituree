using System;
using System.Collections.Generic;

namespace Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Table> tables = new List<Table>
            {
                new Table { Name = "Matbord", AreaOfTable = 10.5, TypeOfFurniture = TypeOfFurniture.Bord },
                new Table { Name = "Skrivbord", AreaOfTable = 5.3, TypeOfFurniture = TypeOfFurniture.Skrivbord }
            };

            List<Lamp> lamps = new List<Lamp>
            {
                new Lamp { Name = "Taklampa", Current = 1.5, TypeOfFurniture = TypeOfFurniture.Taklampa },
                new Lamp { Name = "Bordslampa", Current = 0.5, TypeOfFurniture = TypeOfFurniture.Bordslampa }
            };

            tables.Sort();
            lamps.Sort();

            foreach (var table in tables)
            {
                Console.WriteLine(table.ToString());
            }

            foreach (var lamp in lamps)
            {
                Console.WriteLine(lamp.ToString());
            }
        }
    }
}