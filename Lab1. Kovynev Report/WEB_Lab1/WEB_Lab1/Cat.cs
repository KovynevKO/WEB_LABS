using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEB_Lab1
{
    class Cat : Animal // реализация класса Animal
    {
        public Cat(string name, int age, string food, int quantity_of_food) : base(name, age, food, quantity_of_food)
        {

        }
    }
}
