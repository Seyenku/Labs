using System;

namespace StudentApp
{
    public class Subject
    {
        public string Name;
        private string _description;

        public Subject(string name, string description)
        {
            Name = name;
            _description = description;
        }

        public string GetDescription()      // Для получения _description c модификатором private
        {
            return _description;
        }
    }

    public class Game
    {
        public string Name { get; set; }

        public Game(string name)
        {
            Name = name;
        }
    }

    public class Student
    {
        private string _name;
        public int Age { get; set; }
        public Subject FavoriteSubject { get; set; }
        public Game FavoriteGame { get; set; }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Student(string name)
        {
            _name = name;
            Age = 18;                   // Возраст по умолчанию
        }

        public Student(string name, int age)
        {
            _name = name;
            Age = age;
        }

        public string WriteInfo()
        {
            return $"\nИмя студента {_name}, Возраст {Age}";
        }

        public void BecomeOlder()
        {
            Age++;
        }

        public string GetFavorites()
        {
            return $"Любимый предмет: {FavoriteSubject.Name}, игра: {FavoriteGame.Name}";
        }
    }

    class Program
    {
        static void ChangeAgeValue(int age)
        {
            age++;
        }

        static void ChangeAgeReference(ref int age)
        {
            age++;
        }

        static void Main(string[] args)
        {
            Student student1 = new Student("Andrey");
            student1.FavoriteSubject = new Subject("Математика", "Числа и формулы");
            student1.FavoriteGame = new Game("Шахматы");

            Console.WriteLine($"student1 {student1.WriteInfo()}");
            Console.WriteLine(student1.GetFavorites());
            Console.WriteLine($"Описание любимого предмета: {student1.FavoriteSubject.GetDescription()}");

            student1.Name = "Alex";
            Console.WriteLine($"\nИзменение имени студента: {student1.WriteInfo()}");

            Student student2 = new Student("Steve", 19);
            student2.FavoriteSubject = new Subject("Физика", "Строение всего");
            student2.FavoriteGame = new Game("Футбол");

            Console.WriteLine($"\nstudent2 {student2.WriteInfo()}");
            Console.WriteLine(student2.GetFavorites());

            student2.BecomeOlder();
            Console.WriteLine("\nЧерез год: " + student2.WriteInfo());

            int age = student2.Age;
            Console.WriteLine("\nПередача параметра по значению:");
            ChangeAgeValue(age);
            Console.WriteLine($"Его возраст до {student2.Age} после {age}");

            Console.WriteLine("\nПередача параметра по ссылке:");
            ChangeAgeReference(ref age);
            Console.WriteLine($"Его возраст до {student2.Age} после {age}");
        }
    }
}
