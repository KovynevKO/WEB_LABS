using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEB_Lab2
{
    class Directory : Component // Конкретный класс, который реализует абстрактный класс Component. С помощью него мы можем создать папки, в которых юудут лежать файлы
    {
        private List<Component> components = new List<Component>();

        public Directory(string name, string type)
            : base(name, type)
        {
        }

        public override void Add(Component component) // функция для добавления в папку новой папки или файла
        {
            components.Add(component);
        }

        public override void Remove(Component component) // функция для удаления из папки файла
        {
            components.Remove(component);
        }

        public override void Print()
        {
            Console.WriteLine(nameC + ":");
            for (int i = 0; i < components.Count; i++)
            {
                components[i].Print();
            }
        }

    }
}
