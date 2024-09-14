using System;

namespace StudentApp
{
    public class Student
    {
        private string _name;
        public int Age { get; set; }

        public int Course { get; set; } = 1;

        static int _totalCourses = 4;  // Статичные поля
        static int _dateAdmission;

        public static int TotalCourses  // Статичное свойство
        {
            get { return _totalCourses; }
            set { _totalCourses = value; }
        }

        public int DateAdmission => _dateAdmission;

        static Student() // Статичный конструктор
        {
            _dateAdmission = DateTime.Now.Year;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Student()
        {
            _name = "Andrey";
            Age = 18;
            StudentManager.AddStudent(this);
        }

        public Student(string name, int age)
        {
            _name = name;
            Age = age;
            StudentManager.AddStudent(this);
        }

        public static void CompletedHisStudies(Student person)  // Статичный метод
        {
            if (person.Course >= _totalCourses)
                Console.WriteLine($"{person.Name} выпустился.");
            else
                Console.WriteLine($"{person.Name} еще нужно учиться {TotalCourses - person.Course} года(лет) (не считая текущего года).");
        }

        public string WriteInfo()
        {
            return $"\nИмя студента: {_name}, Возраст: {Age}";
        }

        public void BecomeOlder()
        {
            Age++;
        }
    }

    public static class StudentManager      // Статический класс связанный с классом Student
    {
        private static List<Student> students = new List<Student>();

        public static void AddStudent(Student student)
        {
            students.Add(student);
        }

        public static double CalculateAverageAge()
        {
            if (students.Count == 0)
                return 0;

            return students.Average(student => student.Age);
        }

        public static void PrintAllStudents()
        {
            foreach (var student in students)
            {
                Console.WriteLine(student.WriteInfo());
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student andrey = new Student();
            Console.WriteLine(andrey.WriteInfo());

            Student steve = new Student("Steve", 19);
            Console.WriteLine(steve.WriteInfo());

            Student kane = new() { Name = "Kane", Age = 20 };
            Console.WriteLine(kane.WriteInfo());
            Console.WriteLine($"Курс: {kane.Course}");
            Console.WriteLine($"Год поступления: {kane.DateAdmission}");
            Student.CompletedHisStudies(kane);

            Console.WriteLine($"\nКурсов всего: {Student.TotalCourses}");

            Console.WriteLine("---------------------------------------");
            StudentManager.PrintAllStudents();
            Console.WriteLine($"\nСредний возраст студентов: {StudentManager.CalculateAverageAge()}");
        }
    }
}
