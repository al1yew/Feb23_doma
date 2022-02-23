using System;
using System.Collections.Generic;
using System.Text;

namespace Task1_never_say_never.Models
{
    class Student
    {
        private string _fullname;
        public string FullName
        {
            get => _fullname;
            set
            {
                while (!CheckFullname(value))  //checka gonderilen value false kimi qayidsa, true olur
                {
                    Console.WriteLine("Adinizi duz yazin.");
                    value = Console.ReadLine();
                }
                _fullname = value;
            }
        }
        public int Age { get; set; } // durub ozuycun

        private string _groupno; // private get set etmirik
        public string GroupNo // burdan qayidacag ora
        {
            get => _groupno; 
            set
            {
                while (!CheckGroupNo(value)) // value gonderirik chech metoduna o da ki true gelse false olur, ili je naoborot
                {
                    Console.WriteLine("Grupun nomresini duz yazin.");
                    value = Console.ReadLine();
                }
                _groupno = value;
            }
        }
        public static bool CheckFullname(string fullname) => fullname.Split(' ').Length >= 2;
        
        public static bool CheckGroupNo(string GroupNo)
        {
            if (!(GroupNo.Length == 4 && char.IsUpper(GroupNo[0]) && char.IsDigit(GroupNo[1]) && char.IsDigit(GroupNo[2]) && char.IsDigit(GroupNo[3]))) 
            {
                return false;
            }
            return true;  // for loop da yazmag olardi i=1 bashlasaydi ve groupno[i] ++ olardi groupno.Lenght-e geder, onda coxlu return olacagdi.

                
        }
        public Student(string name, string surname, byte age, string groupno)
        {
            FullName = $"{name} {surname}";
            Age = age;
            GroupNo = groupno;
        }
    }
}
