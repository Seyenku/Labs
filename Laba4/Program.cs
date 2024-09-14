using System;
using System.Xml.Serialization;

namespace StudentApp
{
    abstract class Person
    {
        public void SayHi() => Console.WriteLine($"{this.Name} сказал: Привет! \n ----------------------");

        public abstract string Name { get; set; }

    }

    class Student : Person
    {
        public int Age;
        private string _name;

        public override string Name
        {
            get => _name;
            set => _name = value;
        }
        public Student(string name, int age) 
        { 
            _name = name;
            Age = age;
        }

        public virtual void WriteInfo()
        {
            Console.WriteLine($"Имя студента {Name}, Возраст {Age} \n ----------------------");
        }

        public override string ToString()
        {
            return $"Переопределен метод ToString() для класса Student";
        }
    }

    class ITStudent : Student
    {
        public ITStudent(string name, int age) : base(name, age) { }

        public new void SayHi() => Console.WriteLine($"{this.Name} сказал: 404! \n ----------------------");

        public override void WriteInfo()
        {
            Console.WriteLine($"Имя IT_Студента {Name}, Возраст {Age} \n ----------------------");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student andrey = new Student("Andrey", 18);
            Console.WriteLine(andrey.ToString());
            andrey.WriteInfo();
            andrey.SayHi();

            Console.WriteLine("\nCкрытие метода:");
            Student steve = new Student("Steve", 20);
            Console.WriteLine("Студент Steve - студент");
            steve.SayHi();

            ITStudent steveIT = new ITStudent("Steve", 20);
            Console.WriteLine("IT_Студент Steve - IT_студент");
            steveIT.SayHi();

            steve = new ITStudent("Steve", 20);
            Console.WriteLine("Студент Steve - IT_студент");
            steve.SayHi();                                      // При вызове метода через ссылку на базовый класс, даже если объект на самом деле является экземпляром производного класса, будет вызван метод базового класса.


            Console.WriteLine("\nПереопределение метода:");
            Student kane = new Student("Kane", 19);
            Console.WriteLine("Студент Kane - студент");
            kane.WriteInfo();

            ITStudent kaneIT = new ITStudent("Kane", 19);
            Console.WriteLine("IT_Студент Kane - IT_студент");
            kaneIT.WriteInfo();

            kane = new ITStudent("Kane", 19);
            Console.WriteLine("Студент Kane - IT_студент");
            kane.WriteInfo();                                   // При вызове метода через ссылку на базовый класс, если объект на самом деле является экземпляром производного класса, будет вызвана переопределенная версия метода.
        }
    }
}
