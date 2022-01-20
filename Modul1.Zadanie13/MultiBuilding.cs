using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul1.Zadanie13
{
    class MultiBuilding : Building
    {
        int level;
        // конструктор для наследования
        public MultiBuilding(string address, int lenght, int width, int height, int level) 
         // вызов родительского конструктора
            : base(address, lenght, width, height) 
        {
            // инициализация 5-ого параметра 
            this.level = level; 
        }
        public string Print()
        {
            // помещение в переменную строки из род класса - public string Print
            string result = base.Print();  
            // добавляем вывод этажа здания
            result += $"\nЭтажность здания: {level}"; 
            return result; 
        }
    }
}

