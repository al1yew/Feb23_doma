using System;
using Task1_never_say_never.Models;

namespace Task1_never_say_never
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool check = true;
            //while (check)
            //{
                Console.WriteLine("Salam.\nAdiniz:");
                string name = Console.ReadLine();

                Console.WriteLine("Soyadiniz:");
                string surname = Console.ReadLine();

                Console.WriteLine("Zehmet olmasas yashinizi qeyd edin:");
                string age = Console.ReadLine();
                byte parsedage = byte.Parse(age);

                Console.WriteLine("Grupunuzun adini qeyd edin, amma duz yazin:");
                string groupno = Console.ReadLine();

                Student student = new Student(name, surname, parsedage, groupno);

            Console.WriteLine($"Adiniz ve Soyadiniz: {student.FullName}\nYashiniz {student.Age}\nOxudugunuz grupun nomresi: {student.GroupNo}\n___________________");
                //ConsoleKeyInfo y = Console.ReadKey();

                //if (y.Key.ToString() == "y")
                //{
                //    Console.WriteLine("Onda sagolun");
                //    check = false;
                //    break;
                //}
            //}
            //Student student = new Student(name, surname, parsedage, groupno);
            //Console.WriteLine($"Adiniz ve Soyadiniz: {student.FullName}\nYashiniz {student.Age}\nOxudugunuz grupun nomresi: {student.GroupNo}");
        }
    }
}
