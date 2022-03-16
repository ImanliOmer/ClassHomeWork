using class1.models;

namespace class1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            #region Class start
            //string name1 = "Omer";
            //string surname1 = "Imanov";
            //int age1 = 18;

            //string name2 = "Rustem";
            //string surname2 = "Allahverdiyev";
            //int age2 = 18;


            //var obj1 = new
            //{
            //    name1 = "Omer",
            //    surname1 = "imanov",
            //    age1 = 18,
            //};
            //Console.WriteLine(obj1.name1);


            //var obj2 = new
            //{
            //    name2 = "Rustem",
            //    surname2 = "Allahverdiyev",
            //    age2 = 18,
            //};

            //Console.WriteLine(obj2.name2);
            #endregion

            #region Class

            //Student stu1 = new Student();
            //stu1.name = "omer";
            //stu1.surname = "imanov";
            //stu1.age = 18;
            //stu1.Info();

            #endregion
            #region costructor

            //Student stu2 = new Student("omer", "imanov", 18);

            //stu2.name = "omer";
            //Console.WriteLine(stu2.name);
            //Student stu3 = new Student("lorem", "ipsum", 25);
            ////stu3.Info();
            //Student stu4 = new Student("mamed","mamedov",25);
            #region inhertans
            Developer dev1 = new Developer();
            dev1.name = "omer";
            dev1.sallary = 100;
            #endregion




            #endregion



        }



    }
}
