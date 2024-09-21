using System;
using System.Xml.Serialization;

namespace StudentApp
{
    interface IPerson
    {
        string Name { get; set; }
        void SayHi();
    }

    // Интерфейс ISpecialist расширяет IPerson и добавляет функциональность специалиста
    interface ISpecialist : IPerson
    {
        string GetSpecialization();
    }

    public class Subject
    {
        public string SubjectName { get; set; }

        public Subject(string subjectName)
        {
            SubjectName = subjectName;
        }

        public override string ToString()
        {
            return SubjectName;
        }
    }

    // Класс Student реализует интерфейсы ICloneable, IComparable и включает объект Subject
    public class Student : IPerson, ICloneable, IComparable<Student>
    {
        public int Age { get; set; }
        private string _name;
        public Subject FavoriteSubject { get; set; } // Любимый предмет студента

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public Student(string name, int age, Subject favoriteSubject)
        {
            _name = name;
            Age = age;
            FavoriteSubject = favoriteSubject;
        }

        public void SayHi() => Console.WriteLine($"{this.Name} сказал: Привет! \n ----------------------");

        public virtual void WriteInfo()
        {
            Console.WriteLine($"Имя студента {Name}, Возраст {Age}, Любимый предмет: {FavoriteSubject} \n ----------------------");
        }

        public override string ToString()
        {
            return $"Переопределен метод ToString() для класса Student";
        }

        // Реализация ICloneable
        public object Clone()
        {
            return new Student(this.Name, this.Age, new Subject(this.FavoriteSubject.SubjectName));
        }

        // Реализация IComparable для сравнения по возрасту
        public int CompareTo(Student other)
        {
            return this.Age.CompareTo(other.Age);
        }
    }

    // Класс ITStudent реализует интерфейс ISpecialist
    public class ITStudent : Student, ISpecialist
    {
        public ITStudent(string name, int age, Subject favoriteSubject) : base(name, age, favoriteSubject) { }

        public new void SayHi() => Console.WriteLine($"{this.Name} сказал: 404! \n ----------------------");

        public override void WriteInfo()
        {
            Console.WriteLine($"Имя IT_Студента {Name}, Возраст {Age}, Любимый предмет: {FavoriteSubject} \n ----------------------");
        }

        // Реализация метода интерфейса ISpecialist
        public string GetSpecialization()
        {
            return "IT";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Subject math = new Subject("Math");
            Student andrey = new Student("Andrey", 18, math);
            Console.WriteLine(andrey.ToString());
            andrey.WriteInfo();
            andrey.SayHi();

            Subject programming = new Subject("Programming");
            ITStudent steveIT = new ITStudent("Steve", 20, programming);
            Console.WriteLine("IT_Студент Steve - IT_студент");
            steveIT.SayHi();
            steveIT.WriteInfo();

            // Сравнение студентов
            Student kane = new Student("Kane", 19, math);
            Console.WriteLine(kane.CompareTo(andrey));  // Сравнение по возрасту

            // Клонирование студента
            Student cloneKane = (Student)kane.Clone();
            cloneKane.Name = "Клон-Kane";
            Console.WriteLine($"Клон студента {kane.Name}: {cloneKane.Name}, Возраст {cloneKane.Age}, Любимый предмет: {cloneKane.FavoriteSubject}");
        }
    }
}
