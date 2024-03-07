using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<String> Programming { get; set; }

        public static List<Student> GetStudents()
        {
            List<Student> students = new List<Student>()
            {
                new Student()
                {
                    Id = 1,
                    Name = "Alice",
                    Email = "alice@example.com",
                    Programming = new List<string> { "Java", "Python", "C#" }
                },
                new Student
                {
                    Id = 2,
                    Name = "Bob",
                    Email = "bob@example.com",
                    Programming = new List<string> { "JavaScript", "C++", "Ruby" }
                },
                new Student
                {
                    Id = 3,
                    Name = "Charlie",
                    Email = "charlie@example.com",
                    Programming = new List<string> { "Python", "C#", "Swift" }
                },
                new Student
                {
                    Id = 4,
                    Name = "David",
                    Email = "david@example.com",
                    Programming = new List<string> { "Java", "JavaScript", "PHP" }
                },
                new Student
                {
                    Id = 5,
                    Name = "Emma",
                    Email = "emma@example.com",
                    Programming = new List<string> { "Python", "C#", "Go" }
                },
                new Student
                {
                    Id = 6,
                    Name = "Frank",
                    Email = "frank@example.com",
                    Programming = new List<string> { "C++", "Ruby", "Rust" }
                },
                new Student
                {
                    Id = 7,
                    Name = "Grace",
                    Email = "grace@example.com",
                    Programming = new List<string> { "Java", "C#", "Swift" }
                },
                new Student
                {
                    Id = 8,
                    Name = "Henry",
                    Email = "henry@example.com",
                    Programming = new List<string> { "Python", "JavaScript", "PHP" }
                },
                new Student
                {
                    Id = 9,
                    Name = "Ivy",
                    Email = "ivy@example.com",
                    Programming = new List<string> { "Java", "C++", "Go" }
                },
                new Student
                {
                    Id = 10,
                    Name = "Jack",
                    Email = "jack@example.com",
                    Programming = new List<string> { "Python", "Ruby", "Rust" }
                }
            };
            return students;
        }
}
}
