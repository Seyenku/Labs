using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba8
{
    public interface IStudentRepository
    {
        List<Student> GetAllStudents();
        void AddStudent(Student student);
        void UpdateStudent(Student student);
        void DeleteStudent(string recordBook);
        bool IsRecordBookUnique(string recordBook);
        List<string> GetSpecificationsByDepartment(string department);
    }
}
