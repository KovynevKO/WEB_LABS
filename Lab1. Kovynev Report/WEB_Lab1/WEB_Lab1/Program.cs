using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEB_Lab1
{
    class Program
    {
        // Ковнев Кирилл. ИС - 62. Лабораторная работа №1. Вариант 7. Фабричный метод.

        // Реализовать задачу «Питание животных». Должна быть реализована возможность создания различных животных, 
        // с указанием например, возраста, кол-во съедаемой еды

        // Фабричный метод (Factory Method) - это паттерн, который определяет интерфейс для создания объектов некоторого класса,
        // но непосредственное решение о том, объект какого класса создавать происходит в подклассах. 
        // То есть паттерн предполагает, что базовый класс делегирует создание объектов классам-наследникам.

        static void Main(string[] args)
        {
            string name = "\0"; // имя питомца
            int age = 0; // возраст питомца
            string food = "\0"; // еда, которую ест питомец
            int quantity_of_food = 0; // количество еды, которую ест питомец

            int key=0; // ключ для меню

            while(key!=4)
            {
                Console.WriteLine("Выберите тип питомца, питание которого хотите записать и нажмите Enter: ");
                Console.WriteLine("1) Собака");
                Console.WriteLine("2) Кошка");
                Console.WriteLine("3) Попугай");
                Console.WriteLine("4) Выход");

                key = Convert.ToInt32(Console.ReadLine());

                if(key!=4)
                {
                    Feed(ref name, ref age, ref food, ref quantity_of_food);  // функция заполнения информация о питомце
                    switch (key)
                    {
                        case 1:
                            Creator dcreator = new DogCreator();
                            Animal dog = dcreator.Create(name, age, food, quantity_of_food);
                            break;
                        case 2:
                            Creator ccreator = new CatCreator();
                            Animal cat = ccreator.Create(name, age, food, quantity_of_food);
                            break;
                        case 3:
                            Creator pcreator = new ParrotCreator();
                            Animal parrot = pcreator.Create(name, age, food, quantity_of_food);
                            break;
                    }
                }
                Console.WriteLine();
            }

        }

        static void Feed(ref string nm, ref int ag, ref string fd, ref int qof) // функция заполнения информация о питомце
        {
            Console.WriteLine("Введите имя питомца:");
            nm = Console.ReadLine();
            Console.WriteLine("Ввеите возраст питомца:");
            ag = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите еду, которую ест питомец:");
            fd = Console.ReadLine();
            Console.WriteLine("Введите количество еды, потребляемой питомцем (в кг):");
            qof = Convert.ToInt32(Console.ReadLine());
        }
    }
}
