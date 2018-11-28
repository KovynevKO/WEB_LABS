using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEB_Lab2
{
    class Program
    {
        // Ковынев Кирилл. ИС - 62. 7 вариант. Компоновщик

        // Разработать структуру организации дискового пространства, где каталоги содержат другие каталоги и файлы 

        // Паттерн Компоновщик (Composite) объединяет группы объектов в древовидную структуру по принципу "часть-целое"
        // и позволяет клиенту одинаково работать как с отдельными объектами, так и с группой объектов.

        static void Main(string[] args)
        {
            // Создаем файловую систему, наполняем ее файлами и папками
            Component thisComputer = new Directory("Этот Компьютер", "\0");
            // Диски
            Component diskC = new Directory("C", "\0");
            Component diskD = new Directory("D", "\0");
            // Папки
            Component folderWin = new Directory("Windows", "\0");
            Component folderPro = new Directory("Programs", "\0");
            Component folderGam = new Directory("Games", "\0");
            Component folderUse = new Directory("Users", "\0");
            Component folderPrF = new Directory("Program Files", "\0");
            Component folderFil = new Directory("Filmes", "\0");
            // Файлы
            Component aviFil = new File("Transformers", "avi");
            Component aviMov = new File("Harry Potter", "avi");
            Component exeGam = new File("Counter-Strike", "exe");
            Component exePro = new File("Photoshop", "exe");
            Component exePrF = new File("Visual studio", "exe");
            Component pngIma = new File("UserImage", "png");
            // Делаем иерархию системы, дисков, папок и файлов
            thisComputer.Add(diskC);
            thisComputer.Add(diskD);

            diskC.Add(folderUse);
            diskC.Add(folderPrF);
            diskD.Add(folderGam);
            diskD.Add(folderFil);
            diskC.Add(folderWin);

            folderWin.Add(folderPro);
            folderFil.Add(aviFil);
            folderFil.Add(aviMov);
            folderPro.Add(exePro);
            folderPrF.Add(exePrF);
            folderUse.Add(pngIma);
            folderGam.Add(exeGam);

            // Выведение нашей системы
            thisComputer.Print();
            
            Console.ReadKey();
            Console.Clear();
            // Отформатируем диск Д и посмотрим на систему еще раз
            diskD.Remove(folderGam);
            diskD.Remove(folderFil);
            thisComputer.Print();

            Console.Read();
        }
    }
}
