namespace Laba8._1
{
    public class StudentPresenter
    {
        private readonly IStudentView _view;
        private readonly IStudentRepository _repository;

        public StudentPresenter(IStudentView view, IStudentRepository repository)
        {
            _view = view;
            _repository = repository;

            _view.AddStudent += OnAddStudent;
            _view.EditStudent += OnEditStudent;
            _view.DeleteStudent += OnDeleteStudent;
            _view.DepartmentChanged += OnDepartmentChanged;
            _view.DepartmentFilterChanged += OnDepartmentFilterChanged;

            LoadStudents();
        }

        private void LoadStudents()
        {
            _view.DisplayStudents(_repository.GetAllStudents());
        }

        private void OnAddStudent()
        {
            var newStudent = new Student
            {
                RecordBook = _view.GetRecordBook(),
                FullName = _view.GetFullName(),
                Department = _view.SelectedDepartment,
                Specification = _view.SelectedSpecification,
                DateOfAdmission = _view.GetDateOfAdmission(),
                Group = _view.GetGroup()
            };

            if (_repository.IsRecordBookUnique(newStudent.RecordBook))
            {
                _repository.AddStudent(newStudent);
                LoadStudents();
            }
            else
            {
                _view.ShowError("Студент с таким номером зачетки уже существует.");
            }
        }

        private void OnEditStudent()
        {
            var student = _view.SelectedStudent;
            if (student != null)
            {
                student.FullName = _view.GetFullName();
                student.Department = _view.SelectedDepartment;
                student.Specification = _view.SelectedSpecification;
                student.DateOfAdmission = _view.GetDateOfAdmission();
                student.Group = _view.GetGroup();

                _repository.UpdateStudent(student);
                LoadStudents();
            }
            else
            {
                _view.ShowError("Выберите студента для редактирования.");
            }
        }

        private void OnDeleteStudent()
        {
            var student = _view.SelectedStudent;
            if (student != null)
            {
                _repository.DeleteStudent(student.RecordBook);
                LoadStudents();
            }
            else
            {
                _view.ShowError("Выберите студента для удаления.");
            }
        }

        private void OnDepartmentChanged()
        {
            var specifications = _repository.GetSpecificationsByDepartment(_view.SelectedDepartment);
            _view.UpdateSpecifications(specifications);
        }

        private void OnDepartmentFilterChanged()
        {
            var specifications = _repository.GetSpecificationsByDepartment(_view.SelectedDepartmentFilter);
            _view.UpdateFilterSpecifications(specifications);
        }
    }
}
