namespace Laba8._1
{
    public interface IStudentView
    {
        string SelectedDepartment { get; }
        string SelectedDepartmentFilter { get; }
        string SelectedSpecification { get; }
        Student SelectedStudent { get; }
        void DisplayStudents(List<Student> students);
        void UpdateSpecifications(List<string> specifications);
        void UpdateFilterSpecifications(List<string> specifications);
        void ShowError(string message);

        string GetRecordBook();
        string GetFullName();
        DateTime GetDateOfAdmission();
        string GetGroup();

        event Action AddStudent;
        event Action EditStudent;
        event Action DeleteStudent;
        event Action DepartmentChanged;
        event Action DepartmentFilterChanged;
    }
}
