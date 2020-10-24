using System;
using System.Collections.Generic;

namespace generics_exec_fix01
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            Console.Write("How many students for course A? ");
            int n = int.Parse(Console.ReadLine());
            s.AddStudents(n);
            Console.Write("How many students for course B? ");
            n = int.Parse(Console.ReadLine());
            s.AddStudents(n);
            Console.Write("How many students for course c? ");
            n = int.Parse(Console.ReadLine());
            s.AddStudents(n);
            s.Print();
        }
    }
}
