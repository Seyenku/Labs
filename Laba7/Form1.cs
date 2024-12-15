namespace Laba7
{
    public partial class Form1 : Form
    {
        private readonly Dictionary<string, List<string>> departmentsSpecs = new()
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
            // Bind department ComboBox to departments
            ComboBoxDepart.DataSource = departmentsSpecs.Keys.ToList();

            // Add an event handler for department change
            ComboBoxDepart.SelectedIndexChanged += ComboBoxDepart_SelectedIndexChanged;

            // Set initial values for specifications
            UpdateComboBoxSpecs();
        }

        // Event handler to update specifications based on selected department
        private void ComboBoxDepart_SelectedIndexChanged(object? sender, EventArgs e)
        {
            UpdateComboBoxSpecs();
        }

        // Update ComboBoxSpec based on selected department
        private void UpdateComboBoxSpecs()
        {
            if (ComboBoxDepart.SelectedItem is string selectedDepart && departmentsSpecs.TryGetValue(selectedDepart, out var specs))
            {
                ComboBoxSpec.DataSource = specs; // No need for BindingSource here
            }
            else
            {
                ComboBoxSpec.DataSource = null; // Clear specs if no department is selected
            }
        }

        // Initialize the DataGridView with sample students
        public void InitializeDGView()
        {
            // Create a list of sample students
            List<Student> sampleStudents = new()
            {
                new Student("123456", "Иванов Иван Иванович", "101", "ИТНИТ", "Прикладная информатика", DateTime.Parse("01/09/2020")),
                new Student("234567", "Петров Петр Петрович", "102", "ИЭУ", "Экономика", DateTime.Parse("15/09/2019")),
                new Student("345678", "Сидоров Сидор Сидорович", "103", "ИТНИТ", "Физика", DateTime.Parse("01/09/2021")),
                new Student("456789", "Кузнецов Кузьма Кузьмич", "104", "ИЭУ", "Менеджмент", DateTime.Parse("01/09/2020"))
            };

            // Clear existing rows and populate with student data
            DGViewStudents.Rows.Clear();
            foreach (var student in sampleStudents)
            {
                DGViewStudents.Rows.Add(student.RecordBook, student.FullName, student.Group, student.Department, student.Specification, student.DateOfAdmission.ToShortDateString());
            }
        }

        // Clears all input fields
        private void ClearStudentDetails()
        {
            TextBoxRec.Text = "Error";
            TextBoxFIO.Clear();
            ComboBoxDepart.SelectedIndex = -1;
            ComboBoxSpec.SelectedIndex = -1;
            TPDateAdmiss.Value = DateTime.Now;
            TextBoxGroup.Clear();
        }

        // Loads selected student info into input fields
        private void LoadStudentInfo()
        {
            if (DGViewStudents.SelectedRows.Count > 0 && DGViewStudents.SelectedRows[0].Index >= 0)
            {
                var selectedRow = DGViewStudents.SelectedRows[0];

                // Use the correct column names
                string? recordBook = selectedRow.Cells["RecordBook"].Value?.ToString();
                string? fullName = selectedRow.Cells["FullName"].Value?.ToString();
                string? group = selectedRow.Cells["Group"].Value?.ToString();
                string? department = selectedRow.Cells["Department"].Value?.ToString();
                string? specification = selectedRow.Cells["Specification"].Value?.ToString();

                // Safely parse date
                DateTime.TryParse(selectedRow.Cells["DateOfAdmission"].Value?.ToString(), out DateTime dateOfAdmission);

                // Update controls with selected student details
                TextBoxRec.Text = recordBook ?? "N/A";
                TextBoxFIO.Text = fullName ?? "N/A";
                ComboBoxDepart.SelectedItem = department ?? "N/A";
                ComboBoxSpec.SelectedItem = specification ?? "N/A";
                TPDateAdmiss.Value = dateOfAdmission != DateTime.MinValue ? dateOfAdmission : DateTime.Now;
                TextBoxGroup.Text = group ?? "N/A";
            }
            else
            {
                ClearStudentDetails();
            }
        }

        // Handles selection change in DataGridView
        private void DGViewStudents_SelectionChanged(object sender, EventArgs e)
        {
            LoadStudentInfo();
        }
    }

    // Student class with properties
    public class Student
    {
        public string RecordBook { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string Group { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;
        public string Specification { get; set; } = string.Empty;
        public DateTime DateOfAdmission { get; set; }

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
