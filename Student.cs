using System;
using System.Collections.Generic;
using System.Text;

namespace generics_exec_fix01
{
    class Student
    {
        public int Id { get; set; }
        HashSet<Student> set = new HashSet<Student>();

        public Student(int id)
        {
            Id = id;
        }

        public Student()
        {
        }

        public void AddStudents(int n)
        {
            for (int i = 0; i < n; i++)
            {
                int id = int.Parse(Console.ReadLine());
                set.Add(new Student(id));
            }
        }

        public void Print()
        {
            Console.Write("Total students: " + set.Count);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Student other = obj as Student;
            return Id.Equals(other.Id);
        }
    }
}
