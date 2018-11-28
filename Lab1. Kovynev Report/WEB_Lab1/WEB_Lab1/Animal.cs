using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEB_Lab1
{
    abstract class Animal // определяет интерфейс класса, объекты которого надо создавать
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Food { get; set; }
        public int QuantityOfFood { get; set; }

        public Animal(string name, int age, string food, int quantity_of_food)
        {
            Name = name;
            Age = age;
            Food = food;
            QuantityOfFood = quantity_of_food;
            Console.WriteLine("Информация о питании питомца " + Name + " создана");
        }
    }
}
