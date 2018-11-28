using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEB_Lab1
{
    abstract class Creator // Абстрактный класс Creator определяет абстрактный фабричный метод Create(), который возвращает объект Animal.
    {
        abstract public Animal Create(string name, int age, string food, int quantity_of_food);
    }
}
