using System;

namespace StudentApp
{
    public class Student
    {
        private string _name;
        public int Age { get; set; }
        
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Student(string name)
        {
            _name = name;
            Age = 18;
        }

        public Student(string name, int age)
        {
            _name = name;
            Age = age;
        }

        public string WriteInfo()
        {
            return $"Имя студента: {_name}, Возраст: {Age}";
        }

        public void BecomeOlder()
        {
            Age++;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Andrey");
            Console.WriteLine(student1.WriteInfo());

            student1.Name = "Alex";
            Console.WriteLine(student1.WriteInfo());

            Student student2 = new Student("Steve", 19);
            Console.WriteLine(student2.WriteInfo());
            student2.BecomeOlder();
            Console.WriteLine("Через год " + student2.WriteInfo());
        }
    }
}
