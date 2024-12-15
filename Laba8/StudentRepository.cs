using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba8
{
    public class StudentRepository : IStudentRepository
    {
        private readonly string _connectionString = "Data Source=students.db;";

        public StudentRepository()
        {
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();
            var command = new SqliteCommand(
                @"CREATE TABLE IF NOT EXISTS Student (
                RecordBook TEXT PRIMARY KEY,
                FullName TEXT,
                Department TEXT,
                Specification TEXT,
                DateOfAdmission TEXT,
                Group TEXT
            );", connection);
            command.ExecuteNonQuery();
        }

        public List<Student> GetAllStudents()
        {
            var students = new List<Student>();
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();
            var command = new SqliteCommand("SELECT * FROM Student;", connection);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                students.Add(new Student
                {
                    RecordBook = reader["RecordBook"].ToString(),
                    FullName = reader["FullName"].ToString(),
                    Department = reader["Department"].ToString(),
                    Specification = reader["Specification"].ToString(),
                    DateOfAdmission = DateTime.Parse(reader["DateOfAdmission"].ToString()),
                    Group = reader["Group"].ToString()
                });
            }
            return students;
        }

        public void AddStudent(Student student)
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();
            var command = new SqliteCommand(
                @"INSERT INTO Student (RecordBook, FullName, Department, Specification, DateOfAdmission, Group)
              VALUES (@RecordBook, @FullName, @Department, @Specification, @DateOfAdmission, @Group);", connection);
            command.Parameters.AddWithValue("@RecordBook", student.RecordBook);
            command.Parameters.AddWithValue("@FullName", student.FullName);
            command.Parameters.AddWithValue("@Department", student.Department);
            command.Parameters.AddWithValue("@Specification", student.Specification);
            command.Parameters.AddWithValue("@DateOfAdmission", student.DateOfAdmission.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@Group", student.Group);
            command.ExecuteNonQuery();
        }

        public void UpdateStudent(Student student)
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();
            var command = new SqliteCommand(
                @"UPDATE Student SET FullName=@FullName, Department=@Department, 
              Specification=@Specification, DateOfAdmission=@DateOfAdmission, Group=@Group 
              WHERE RecordBook=@RecordBook;", connection);
            command.Parameters.AddWithValue("@RecordBook", student.RecordBook);
            command.Parameters.AddWithValue("@FullName", student.FullName);
            command.Parameters.AddWithValue("@Department", student.Department);
            command.Parameters.AddWithValue("@Specification", student.Specification);
            command.Parameters.AddWithValue("@DateOfAdmission", student.DateOfAdmission.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@Group", student.Group);
            command.ExecuteNonQuery();
        }

        public void DeleteStudent(string recordBook)
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();
            var command = new SqliteCommand("DELETE FROM Student WHERE RecordBook=@RecordBook;", connection);
            command.Parameters.AddWithValue("@RecordBook", recordBook);
            command.ExecuteNonQuery();
        }

        public bool IsRecordBookUnique(string recordBook)
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();
            var command = new SqliteCommand("SELECT COUNT(*) FROM Student WHERE RecordBook=@RecordBook;", connection);
            command.Parameters.AddWithValue("@RecordBook", recordBook);
            return Convert.ToInt32(command.ExecuteScalar()) == 0;
        }

        public List<string> GetSpecificationsByDepartment(string department)
        {
            // Dummy data, replace with a real query if specifications are stored in a separate table
            return department switch
            {
                "Engineering" => new List<string> { "Software Engineering", "Civil Engineering" },
                "Science" => new List<string> { "Physics", "Biology" },
                _ => new List<string>()
            };
        }
    }
}
