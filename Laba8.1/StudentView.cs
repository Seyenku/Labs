namespace Laba8._1
{
    public partial class StudentView : Form, IStudentView
    {
        public string SelectedDepartment => departmentComboBox.SelectedItem.ToString();
        public string SelectedSpecification => specificationComboBox.SelectedItem.ToString();
        public Student SelectedStudent => studentsDataGridView.SelectedRows.Count > 0
            ? (Student)studentsDataGridView.SelectedRows[0].DataBoundItem
            : null;

        public event Action AddStudent;
        public event Action EditStudent;
        public event Action DeleteStudent;
        public event Action DepartmentChanged;

        public StudentView()
        {
            InitializeComponent();
            addButton.Click += (s, e) => AddStudent?.Invoke();
            editButton.Click += (s, e) => EditStudent?.Invoke();
            deleteButton.Click += (s, e) => DeleteStudent?.Invoke();
            departmentComboBox.SelectedIndexChanged += (s, e) => DepartmentChanged?.Invoke();
        }

        public void DisplayStudents(List<Student> students)
        {
            studentsDataGridView.DataSource = students;
        }

        public void UpdateSpecifications(List<string> specifications)
        {
            specificationComboBox.DataSource = specifications;
        }
    }
}
