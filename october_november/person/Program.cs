using System;
using System.Collections.Generic;

namespace person
{
    class Person
    {

        String name;
        Person(String name)
        {
            this.name = name;
        }
    }
    class Student
    {
        int studentNumber;
        Person person;
        Student(int studentNumber, Person person)
        {
            this.studentNumber = studentNumber;
            this.person = person;
        }

    }
    class College
    {
        List<Student> students;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
