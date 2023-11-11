using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFApproach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            StudentContext stdctx = new StudentContext();
            Student std = new Student()
            {
                StudentId = 2, Name = "Mounica", Marks = 550,Department="HR2"

            };

            stdctx.Students.Add(std);
            stdctx.SaveChanges();
            Console.WriteLine("Data Added Successfuly");
            var students = stdctx.Students.ToList();
            foreach (var student in students) 
            {
                Console.WriteLine(student.StudentId+ " "+student.Name+"  "+student.Marks+"  "+student.Department);
            }
            Console.ReadKey();
        }
    }
}
