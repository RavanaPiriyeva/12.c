using System;
using ClassLibrary1;
namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullname = "";

            bool check = true;
            do
            {
                if (check)
                {
                    Console.WriteLine("Ad ve soyadi daxil edin:");
                    check = false;
                }
                else
                {
                    Console.WriteLine("Ad ve soyadi duzgun daxil edin!!!!!");
                }
                fullname = Console.ReadLine();
            }
            while (fullname.CheckFullname() == false);



            string groupno = "";

            bool check1 = true;
            do
            {
                if (check1)
                {
                    Console.WriteLine("\nQrup nomresin daxil edin:");
                    check1 = false;
                }
                else
                {
                    Console.WriteLine("Qrup nomresin duzgun daxil edin!!!!!");
                }
                groupno = Console.ReadLine();
            }
            while (groupno.CheckGroupNo() == false);
            Console.WriteLine("\nYasi daxil edin:");
             int age = Convert.ToInt32(Console.ReadLine());


            Student student = new Student(fullname,groupno,age);
            student.FullName= fullname;
            student.Age = age;
            student.GroupNo=groupno;
            Console.WriteLine("\n\n==============================STUDENT===================================\n");
            student.GetInfo();
          
        }
    }
}
