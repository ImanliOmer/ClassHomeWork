using System;

namespace class1.models
{
    class Student:Person
    {
        //fields
      
        public string profession;

        public void Info()
        {
            Console.WriteLine($"{this.name} {surname} {age}");
        }
        //public Student()
        //{
        //  Console.WriteLine("costractor ishledi");
        //}

        public Student()
        {
            Console.WriteLine("parametrsiz consturctor ishledi");
        }
        public Student(string name):this()
        {
            this.name = name;
        }

        public Student(string name, string surname, int age): this(name)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

    }

}
