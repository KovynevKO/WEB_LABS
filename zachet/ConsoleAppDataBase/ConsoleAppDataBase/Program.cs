using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDataBase
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ковынев Кирилл. ИС-62. ФИОТ
            // ВНИАНИЕ! Для работы с БД необходимо включить SQL сервер, присеоденить к нему БД, и изменить путь в AppConfig
            DataBaseClass tdb = new DataBaseClass();
            Console.WriteLine("Дані з таблиці міст ");
            tdb.SelectTown();
            Console.WriteLine("Дані з таблиці мешканців ");
            tdb.SelectResidentType();
            Console.WriteLine("Вивести інформацію про всіх мешканців заданого міста, котрі розмовляють заданою мовою. ");
            tdb.FirstQuery();
            Console.WriteLine("Вивести інформацію про всі міста, в яких проживають мешканці заданого типу.");
            tdb.SecondQuery();
            Console.WriteLine("Вивести інформацію про місто з заданою кількістю мешканців та всі типи мешканців, котрі в ньому проживають. ");
            tdb.ThirdQuery();
            Console.WriteLine("Вивести інформацію про найбільш старий тип мешканців. ");
            tdb.ForthQuery();
            Console.Read();
        }
    }
}
