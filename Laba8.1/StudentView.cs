namespace Laba8._1
{
    public partial class StudentView : Form, IStudentView
    {
        public string SelectedDepartment => departmentComboBox.SelectedItem?.ToString() ?? string.Empty;
        public string SelectedDepartmentFilter => departmentComboBoxfilter.SelectedItem?.ToString() ?? string.Empty;
        public string SelectedSpecification => specificationComboBox.SelectedItem.ToString() ?? String.Empty;
        public Student SelectedStudent => studentsDataGridView.SelectedRows.Count > 0
            ? (Student)studentsDataGridView.SelectedRows[0].DataBoundItem
            : null;

        public string GetRecordBook() => TextBoxRec.Text;
        public string GetFullName() => TextBoxFIO.Text;
        public DateTime GetDateOfAdmission() => TPDateAdmiss.Value;
        public string GetGroup() => TextBoxGroup.Text;

        public event Action AddStudent;
        public event Action EditStudent;
        public event Action DeleteStudent;
        public event Action DepartmentChanged;
        public event Action DepartmentFilterChanged;

        private List<Student> _students;

        public StudentView()
        {
            InitializeComponent();
            addButton.Click += (s, e) => AddStudent?.Invoke();
            editButton.Click += (s, e) => EditStudent?.Invoke();
            deleteButton.Click += (s, e) => DeleteStudent?.Invoke();
            departmentComboBox.SelectedIndexChanged += (s, e) => DepartmentChanged?.Invoke();
            departmentComboBoxfilter.SelectedIndexChanged += (s, e) => DepartmentFilterChanged?.Invoke();
            studentsDataGridView.Click += studentsDataGridView_Click;
            searchTextBox.TextChanged += searchTextBox_TextChanged;
            sortRecButton.Click += (s, e) => SortByRecordBook("▲" == sortRecButton.Text ? false : true);
        }

        public void DisplayStudents(List<Student> students)
        {
            _students = students;

            studentsDataGridView.AutoGenerateColumns = false;
            studentsDataGridView.Columns.Clear();

            studentsDataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "RecordBook", HeaderText = "Номер зачетки" });
            studentsDataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "FullName", HeaderText = "ФИО" });
            studentsDataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Department", HeaderText = "Институт" });
            studentsDataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Specification", HeaderText = "Направление" });
            studentsDataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "DateOfAdmission", HeaderText = "Дата поступления" });
            studentsDataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Group", HeaderText = "Группа" });

            studentsDataGridView.DataSource = students;

            SortByRecordBook(false);
        }

        public void UpdateSpecifications(List<string> specifications)
        {
            specificationComboBox.DataSource = specifications;
        }

        public void UpdateFilterSpecifications(List<string> specifications)
        {
            specificationComboBoxfilter.DataSource = specifications;
        }

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void studentsDataGridView_Click(object sender, EventArgs e)
        {
            if (SelectedStudent != null)
            {
                TextBoxRec.Text = SelectedStudent.RecordBook;
                TextBoxFIO.Text = SelectedStudent.FullName;
                departmentComboBox.SelectedItem = SelectedStudent.Department;
                specificationComboBox.SelectedItem = SelectedStudent.Specification;
                TPDateAdmiss.Value = SelectedStudent.DateOfAdmission;
                TextBoxGroup.Text = SelectedStudent.Group;
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            SearchFunc();
        }

        private void SearchFunc()
        {
            var filteredStudents = _students.Where(s =>
                (string.IsNullOrEmpty(searchTextBox.Text) ||
                 s.FullName.Contains(searchTextBox.Text, StringComparison.OrdinalIgnoreCase) ||
                 s.RecordBook.Contains(searchTextBox.Text, StringComparison.OrdinalIgnoreCase)) &&
                (departmentComboBox.SelectedIndex == -1 || s.Department == SelectedDepartment) &&
                (specificationComboBox.SelectedIndex == -1 || s.Specification == SelectedSpecification)
            ).ToList();

            studentsDataGridView.DataSource = null;
            studentsDataGridView.DataSource = filteredStudents;
        }

        private void SortByRecordBook(bool ascending)
        {
            if (_students == null) return;

            var sortedStudents = ascending
                ? _students.OrderBy(s => s.RecordBook).ToList()
                : _students.OrderByDescending(s => s.RecordBook).ToList();

            _students = sortedStudents;
            sortRecButton.Text = ascending ? "▲" : "▼";

            SearchFunc();
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            panel2.Visible = !panel2.Visible;
        }

        private void applyFilterButton_Click(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            var recordBookFilter = TextBoxRecfilter.Text?.Trim();
            var fullNameFilter = TextBoxFIOfilter.Text?.Trim();
            var departmentFilter = departmentComboBoxfilter.SelectedItem?.ToString();
            var specificationFilter = specificationComboBoxfilter.SelectedItem?.ToString();
            var groupFilter = TextBoxGroupfilter.Text?.Trim();
            var startDateFilter = TPDateAdmissfilter1.Checked ? TPDateAdmissfilter1.Value.Date : (DateTime?)null;
            var endDateFilter = TPDateAdmissfilter2.Checked ? TPDateAdmissfilter2.Value.Date : (DateTime?)null;

            // Применяем фильтры ко всем полям
            var filteredStudents = _students.Where(s =>
                (string.IsNullOrEmpty(recordBookFilter) || s.RecordBook.Contains(recordBookFilter, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrEmpty(fullNameFilter) || s.FullName.Contains(fullNameFilter, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrEmpty(departmentFilter) || s.Department == departmentFilter) &&
                (string.IsNullOrEmpty(specificationFilter) || s.Specification == specificationFilter) &&
                (string.IsNullOrEmpty(groupFilter) || s.Group.Contains(groupFilter, StringComparison.OrdinalIgnoreCase)) &&
                (!startDateFilter.HasValue || s.DateOfAdmission.Date >= startDateFilter.Value) &&
                (!endDateFilter.HasValue || s.DateOfAdmission.Date <= endDateFilter.Value)
            ).ToList();

            // Проверяем, есть ли результаты
            if (!filteredStudents.Any())
            {
                MessageBox.Show("Нет данных, соответствующих заданным критериям фильтрации.",
                    "Результаты фильтрации",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            // Обновляем отображение в DataGridView
            studentsDataGridView.DataSource = null;
            studentsDataGridView.DataSource = filteredStudents;
        }

        private void cancelFilterButton_Click(object sender, EventArgs e)
        {
            ResetFilter();
        }

        private void ResetFilter()
        {
            TextBoxRecfilter.Clear();
            TextBoxFIOfilter.Clear();
            departmentComboBoxfilter.SelectedIndex = -1;
            specificationComboBoxfilter.SelectedIndex = -1;
            specificationComboBoxfilter.Text = "";
            TextBoxGroupfilter.Clear();
            TPDateAdmissfilter1.Checked = false;
            TPDateAdmissfilter2.Checked = false;
            TPDateAdmissfilter1.Value = DateTime.Now;
            TPDateAdmissfilter2.Value = DateTime.Now;

            studentsDataGridView.DataSource = null;
            studentsDataGridView.DataSource = _students;
        }
    }
}
