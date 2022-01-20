using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul1.Zadanie13
{
    class Program
    {
        static void Main(string[] args)
        {
            // задаем экзепляр класса
            Building building = new Building("пр-к Советский дом 55", 100, 20, 30);  
            Console.WriteLine(building.Print());
            MultiBuilding multiBuilding = new MultiBuilding("Красный проспект дом 30", 100, 50, 50, 10);
            Console.WriteLine(multiBuilding.Print());
            Console.ReadKey();
        }
    }
}

