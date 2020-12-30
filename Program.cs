using System;
using System.Collections.Generic;

namespace ConApp02
{
    class Program
    {
        static TeachingStaff teachingstaff = new TeachingStaff();
        static void choice1()
        {
            teachingstaff.RetreiveAllRecords();
        }
        static void choice2()
        {
            Console.WriteLine("Enter the id:");
            int id = Convert.ToInt32(Console.ReadLine());

            Teacher e = teachingstaff.GetAllTeacherById(id);

            if (e is null)
                Console.WriteLine("row is not exist");
            else
                Console.WriteLine($"{e.id} {e.name} {e.classname} {e.section}");
        }
        static void choice3()
        {
            Console.WriteLine("Enter the className:");
            string subject = Console.ReadLine();

            List<Teacher> teachers = teachingstaff.GetAllTeacherByClassName(subject);

            foreach (Teacher e1 in teachers)
                Console.WriteLine($"{e1.id} {e1.name} {e1.classname} {e1.section}");
        }
        static void choice4()
        {
            Console.WriteLine("Enter the section:");
            string section = Console.ReadLine();

            List<Teacher> teachers = teachingstaff.GetAllTeacherBySection(section);

            foreach (Teacher e1 in teachers)
                Console.WriteLine($"{e1.id} {e1.name} {e1.classname} {e1.section}");
        }
        static void choice5()
        {
            Console.Write("Enter the id:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter n1:");
            string n1 = Console.ReadLine();
            Console.Write("Enter n2:");
            string n2 = Console.ReadLine();
            teachingstaff.editTeacherDetails(id, n1, n2);
        }
        static void choice6()
        {
            Teacher s = new Teacher();
            Console.Write("Enter the id:");
            s.id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the name:");
            s.name = Console.ReadLine();
            Console.Write("Enter the classname:");
            s.classname = Console.ReadLine();
            Console.Write("Enter the section:");
            s.section = Console.ReadLine();
            teachingstaff.AddTeachingStaff(s);
           
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Rainbow School");
            Console.WriteLine("==========================");
            teachingstaff.StoreAllRecords();
            int ch;
            do
            {
                Console.WriteLine("========================");
                Console.WriteLine("Menu");
                Console.WriteLine("1.Display All\n2.Display By Id\n3.Display By Classname\n4.Display By section \n5.Edit Row\n6.Add Teaching Staff \n7.exit");
                Console.WriteLine("========================");
                Console.Write("Enter the choice:");
                ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        {
                            choice1();
                        }
                        break;
                    case 2:
                        {
                            choice2();                           
                        }
                        break;
                    case 3:
                        {
                            choice3();
                        }
                        break;
                    case 4:
                        {
                            choice4();
                        }
                        break;
                    case 5:
                        {
                            choice5();
                        }
                        break;
                    case 6:
                        {
                            choice6();
                        }
                        break;
                    
                    case 7:
                        {

                        }
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }

            }
            while (ch != 7);
        }
    }
}
