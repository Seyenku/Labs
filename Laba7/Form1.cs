namespace Laba7
{
    public partial class Form1 : Form
    {
        private readonly Dictionary<string, List<string>> departmentsSpecs = new Dictionary<string, List<string>>
        {
            { "ИТНИТ", new List<string> { "Прикладная информатика", "Физика" } },
            { "ИЭУ", new List<string> { "Экономика", "Менеджмент" } }
        };

        public Form1()
        {
            InitializeComponent();
            InitializeDGView();
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            ComboBoxDepart.DataSource = new BindingSource(departmentsSpecs.Keys.ToList(), null);
            UpdateComboBoxSpecs();
        }

        private void UpdateComboBoxSpecs()
        {
            if (ComboBoxDepart.SelectedItem is string selectedDepart && departmentsSpecs.TryGetValue(selectedDepart, out var specs))
            {
                ComboBoxSpec.DataSource = new BindingSource(specs, null);
            }
            else
            {
                ComboBoxSpec.DataSource = null;
            }
        }

        public void InitializeDGView()
        {
            List<Student> sampleStudents = new List<Student>
            {
                new Student("123456", "Иванов Иван Иванович", "101", "ИТНИТ", "Прикладная информатика", DateTime.Parse("01/09/2020")),
                new Student("234567", "Петров Петр Петрович", "102", "ИЭУ", "Экономика", DateTime.Parse("15/09/2019")),
                new Student("345678", "Сидоров Сидор Сидорович", "103", "ИТНИТ", "Физика", DateTime.Parse("01/09/2021")),
                new Student("456789", "Кузнецов Кузьма Кузьмич", "104", "ИЭУ", "Менеджмент", DateTime.Parse("01/09/2020"))
            };


            foreach (var student in sampleStudents)
            {
                DGViewStudents.Rows.Add(student.RecordBook, student.FullName, student.Group, student.Department, student.Specification, student.DateOfAdmission.ToShortDateString());
            }
        }

        private void ClearStudentDetails()
        {
            TextBoxRec.Text = "Error";
            TextBoxFIO.Clear();
            ComboBoxDepart.SelectedIndex = -1;
            ComboBoxSpec.SelectedIndex = -1;
            TPDateAdmiss.Value = DateTime.Now;
            TextBoxGroup.Clear();
        }

        private void LoadStudentInfo()
        {
            if (DGViewStudents.SelectedRows.Count > 0 && DGViewStudents.SelectedRows[0].Index >= 0)
            {
                var selectedRow = DGViewStudents.SelectedRows[0];

                // Извлекаем данные из выбранной строки
                string? recordBook = selectedRow.Cells["RecordBook"].Value?.ToString();
                string? fullName = selectedRow.Cells["FIO"].Value?.ToString();
                string? group = selectedRow.Cells["Group"].Value?.ToString();
                string? department = selectedRow.Cells["Department"].Value?.ToString();
                string? specification = selectedRow.Cells["Specification"].Value?.ToString();
                DateTime dateOfAdmission = DateTime.Parse(selectedRow.Cells["DateOfAdmission"].Value?.ToString() ?? DateTime.Now.ToString());

                // Заполняем элементы управления
                TextBoxRec.Text = recordBook;
                TextBoxFIO.Text = fullName;
                ComboBoxDepart.SelectedItem = department;
                ComboBoxSpec.SelectedItem = specification;
                TPDateAdmiss.Value = dateOfAdmission;
                TextBoxGroup.Text = group;
            }
            else
            {
                ClearStudentDetails();
            }
        }

        private void DGViewStudents_SelectionChanged(object sender, EventArgs e)
        {
            UpdateComboBoxSpecs();
            LoadStudentInfo();
        }
    }

    public class Student
    {
        public string RecordBook { get; set; } = string.Empty; // Номер зачетной книжки
        public string FullName { get; set; } = string.Empty;   // ФИО студента
        public string Group { get; set; } = string.Empty;      // Группа студента
        public string Department { get; set; } = string.Empty; // Институт
        public string Specification { get; set; } = string.Empty; // Направление
        public DateTime DateOfAdmission { get; set; }          // Дата поступления

        public Student(string recordBook, string fullName, string group, string department, string specification, DateTime dateOfAdmission)
        {
            RecordBook = recordBook;
            FullName = fullName;
            Group = group;
            Department = department;
            Specification = specification;
            DateOfAdmission = dateOfAdmission;
        }

        public Student() { }
    }

}
