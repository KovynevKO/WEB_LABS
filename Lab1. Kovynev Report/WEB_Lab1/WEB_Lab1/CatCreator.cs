using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEB_Lab1
{
    class CatCreator : Creator
    {
        public override Animal Create(string name, int age, string food, int quantity_of_food) //Конкретный класс CatCreator - наследник класса Creator, определяющий свою реализацию метода Create()
        {
            return new Cat(name, age, food, quantity_of_food);
        }
    }
}
