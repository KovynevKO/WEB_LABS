using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEB_Lab2
{
    abstract class Component // Абстрактный класс для наших папок и файлов
    {
        protected string nameC; // имя папки
        protected string typeC; // тип папки

        public Component(string name, string type)
        {
            this.nameC = name;
            this.typeC = type;
        }

        public virtual void Add(Component component) { }

        public virtual void Remove(Component component) { }

        public virtual void Print()
        {
            Console.WriteLine(nameC + "." + typeC);
        }
    }
}
