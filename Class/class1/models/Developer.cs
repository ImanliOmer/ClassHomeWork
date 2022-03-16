using System;

namespace class1.models
{


    class Developer: Person
    {
        public int sallary;
        //fields


        public void Info()
        {
            Console.WriteLine($"{this.name} {surname} {age}");
        }
        //public student()
        //{
        //    console.writeline("costractor ishledi");
        //}

        public Developer()
        {
            Console.WriteLine("parametrsiz consturctor ishledi");
        }
        public Developer(string name) : this()
        {
            this.name = name;
        }

        public Developer(string name, string surname, int age) : this(name)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }
    }
}
