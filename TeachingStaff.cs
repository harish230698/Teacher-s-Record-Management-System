using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ConApp02
{
    class TeachingStaff
    {
         List<Teacher> teachers;
        public TeachingStaff()
        {
            this.teachers = new List<Teacher>
            {
                new Teacher{id=101,name="Harish",classname="Maths",section="A"},
                new Teacher{id=102,name="Hari",classname="English",section="B"},
                new Teacher{id=103,name="Hans",classname="Physics",section="C"},
                new Teacher{id=104,name="Jeya",classname="Tamil",section="D"},
                new Teacher{id=105,name="Barath",classname="Biology",section="E"},
                new Teacher{id=106,name="Ram",classname="EVS",section="F"}
            };

        }
        public void StoreAllRecords()
        {
            StreamWriter fname = new StreamWriter("e:/TeacherDetails.txt");
            foreach (Teacher e in teachers)
                fname.WriteLine($"{e.id} {e.name} {e.classname} {e.section}");
            Console.WriteLine("Added Successfully");
            fname.Close();
        }
        public void RetreiveAllRecords()
        {
            StreamReader sr = new StreamReader(@"e:/TeacherDetails.txt");
            string msg = sr.ReadToEnd();
            Console.Write(msg);
            sr.Close();
        }

      

        public Teacher GetAllTeacherById(int id)
        {
            Teacher e = null;
            for (int i = 0; i < teachers.Count; i++)
                if (teachers[i].id == id)
                {
                    e = teachers[i];
                    break;
                }


            return e;
        }
        public List<Teacher> GetAllTeacherBySection(string section)
        {
            List<Teacher> teachers = new List<Teacher>();
            for (int i = 0; i < this.teachers.Count; i++)
                if (this.teachers[i].section == section)
                    teachers.Add(this.teachers[i]);

            return teachers;
        }
        public List<Teacher> GetAllTeacherByName(string name)
        {
            List<Teacher> teachers = new List<Teacher>();
            for (int i = 0; i < this.teachers.Count; i++)
                if (this.teachers[i].name == name)
                    teachers.Add(this.teachers[i]);

            return teachers;
        }
        public List<Teacher> GetAllTeacherByClassName(string className)
        {
            List<Teacher> teachers = new List<Teacher>();
            for (int i = 0; i < this.teachers.Count; i++)
                if (this.teachers[i].classname == className)
                    teachers.Add(this.teachers[i]);

            return teachers;
        }

        public void AddTeachingStaff(Teacher s)
        {
            StreamWriter stream = new StreamWriter(@"e:/TeacherDetails.txt", true);
            stream.WriteLine($"{s.id} {s.name} {s.classname} {s.section}");
            stream.Close();
        }
       
                
        
            public void editTeacherDetails(int id,string n1,string n2)
            {
                StreamReader sr = new StreamReader("e:TeacherDetails.txt", true);
                string msg = sr.ReadToEnd();
                sr.Close();
                if(msg.Contains((char)id))
                {
                    msg = Regex.Replace(msg, n1, n2);
                    Console.WriteLine("the row has been edited successfully");
                }   
                StreamWriter f = new StreamWriter("e:/TeacherDetails.txt");
                f.Write(msg);
                f.Close();



            }
    }
}


       