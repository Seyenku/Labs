using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba8
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
                // Assign data from the view
            };

            if (_repository.IsRecordBookUnique(newStudent.RecordBook))
            {
                _repository.AddStudent(newStudent);
                LoadStudents();
            }
            else
            {
                // Show error
            }
        }

        private void OnEditStudent()
        {
            var student = _view.SelectedStudent;
            if (student != null)
            {
                _repository.UpdateStudent(student);
                LoadStudents();
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
        }

        private void OnDepartmentChanged()
        {
            var specifications = _repository.GetSpecificationsByDepartment(_view.SelectedDepartment);
            _view.UpdateSpecifications(specifications);
        }
    }
}
