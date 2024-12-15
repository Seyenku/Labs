using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba8
{
    public interface IStudentView
    {
        string SelectedDepartment { get; }
        string SelectedSpecification { get; }
        Student SelectedStudent { get; }
        void DisplayStudents(List<Student> students);
        void UpdateSpecifications(List<string> specifications);
        event Action AddStudent;
        event Action EditStudent;
        event Action DeleteStudent;
        event Action DepartmentChanged;
    }
}
