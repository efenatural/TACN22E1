
using System;
using StudentDatabase.Models;

namespace StudentDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StudentContext())
            {
                context.Database.EnsureCreated();

                var student = new Student
                {
                    FirstName = "John",
                    LastName = "Doe",
                    Age = 20
                };

                context.Students.Add(student);
                context.SaveChanges();

                Console.WriteLine("Student added to the database successfully!");
            }
        }
    }
}
