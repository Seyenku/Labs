namespace Laba8._1
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
