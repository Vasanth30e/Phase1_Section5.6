using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section5._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Classes
            runApp();
            Console.ReadKey();
        }

        public static void runApp()
        {

            string[] arrSubjects = { "English Literature", "English Language", "Maths", "Geography", "History", "Physics", "Chemistry", "Biology" };
            string[] arrSubjectShorts = { "ELIT", "ELANG", "MATH", "GEOG", "HIST", "PHY", "CHEM", "BIO" };


            string[] arrStudents = { "Rahul Gandhi", "Vijay Mallya", "Lady Gaga", "Arun Jaitley", "MS Dhoni", "Kim Kardashian" };
            List<Student> listStudents = new List<Student>();
            List<Subject> listSubjects = new List<Subject>();

            for (int i = 0; i < arrSubjects.Length; i++)
            {
                Subject subject = new Subject();
                subject.Name = arrSubjects[i];
                subject.ShortName = arrSubjectShorts[i];
                listSubjects.Add(subject);
            }

            for (int i = 0; i < arrStudents.Length; i++)
            {
                Student student = new Student();
                student.Name = arrStudents[i];
                student.Address = "Some address";
                student.ContactNumber = "124567";
                student.GuardianName = "My Guardian";
                listStudents.Add(student);
            }
            

            Teacher classTeacher = new Teacher();
            classTeacher.Name = "Mr.RadheShyam";
            classTeacher.DateOfJoining = Convert.ToDateTime("2010-09-11 00:00:00");
            classTeacher.ContactAddress = "Some address";


            CClass class1A = new CClass();
            class1A.Name = "1A";
            class1A.Students = listStudents;
            class1A.Subjects = listSubjects;
            class1A.ClassTeacher = classTeacher;

            Console.WriteLine("Class Name: " + class1A.Name);
            Console.WriteLine("Class Teacher: " + class1A.ClassTeacher.Name);
            Console.WriteLine("Date of Joining of Class Teacher: " + class1A.ClassTeacher.DateOfJoining);
            Console.WriteLine("Contact Address of Class Teacher: " + class1A.ClassTeacher.ContactAddress);

            Console.WriteLine("Students in Class 1A:");
            foreach (Student student in class1A.Students)
            {
                Console.WriteLine("Student Name: " + student.Name);
                Console.WriteLine("Address: " + student.Address);
                Console.WriteLine("Contact Number: " + student.ContactNumber);
                Console.WriteLine("Guardian Name: " + student.GuardianName);
                Console.WriteLine();
            }

            Console.WriteLine("Subjects in Class 1A:");
            foreach (Subject subject in class1A.Subjects)
            {
                Console.WriteLine("Subject Name: " + subject.Name);
                Console.WriteLine("Subject Short Name: " + subject.ShortName);
                Console.WriteLine();
            }
        }
    }
}
