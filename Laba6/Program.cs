using System;

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
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Имя студента не может быть пустым или null.");
                _name = value;
            }
        }

        public Student(string name, int age)
        {
            if (age <= 0)
                throw new ArgumentOutOfRangeException(nameof(age), "Возраст должен быть положительным.");
            Name = name;
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
            try
            {
                Student andrey = new Student("Andrey", 18);
                andrey.WriteInfo();
                andrey.SayHi();

                // Попытка создать студента с недопустимыми параметрами
                Student invalidStudent2 = new Student("", 18);
                Student invalidStudent = new Student("Sasha", -1);
                
            }
            catch (ArgumentException ex) when (ex.Message.Contains("Имя"))
            {
                Console.WriteLine($"Ошибка в имени: {ex.Message}");
            }
            catch (ArgumentOutOfRangeException ex) when (ex.ParamName == "age")
            {
                Console.WriteLine($"Ошибка в возрасте: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Общая ошибка: {ex.Message}");
            }
        }
    }
}
