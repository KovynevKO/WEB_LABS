using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEB_Lab2
{
    class File : Component  // Конкретный класс, который реализует абстрактный класс Component. С помощью него мы можем создать файлы
    {
        public File(string name, string type)
           : base(name, type)
        {
        }
    }
}
