namespace Laba8._1
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
