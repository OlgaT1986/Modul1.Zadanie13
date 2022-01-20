using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul1.Zadanie13
{
    class Building
    {
        string address;
        int lenght;
        int width;
        int height;
        // свойство с параметрами возвращает или присваивает 
        int Height 
        {
            get 
            {
                return height; 
            }
            set
            {
                if (value > 10)
                    height = 10;
                else if (value < 0)
                    height = 1;
                else
                    height = value;
            }
        }
        // классификация членов класса
        public Building(string address, int lenght, int width, int height)
        {
            this.address = address;
            this.lenght = lenght;
            this.width = width;
            this.Height = height;  
        }
        // метод вывода информации о здании
        public string Print() 
        {
            return $"\nАдрес здания: {address} \nДлина заданя: {lenght} \nШирина заданя: {width} \nВысота заданя: {height}";
        }
    }
}

