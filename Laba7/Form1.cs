
namespace Laba7
{
    public partial class Form1 : Form
    {
        private readonly List<Student> students = []; // ��������� ���������
        private readonly Dictionary<string, List<string>> departmentsSpecs = new()
        {
            { "�������� ������ ���� � �������������� ����������", new() { "���������� �����������", "���������� � ������������ �����" } },
            { "�������� ��������� � ����������", new() { "���������", "����������" } }
        };


        public Form1()
        {
            InitializeComponent();
            InitializeCustomComponents();

        }

        private void InitializeCustomComponents()
        {
            // �������� ComboBox ���������� � ���������� ���������� �����������
            ComboBoxDepart.DataSource = departmentsSpecs.Keys.ToList();
            ComboBoxDepart.SelectedIndexChanged += ComboBoxDepart_SelectedIndexChanged;
            UpdateComboBoxSpecs();

            // ������������� DataGridView
            DGViewStudents.AutoGenerateColumns = false;
            DGViewStudents.DataSource = students;
            DGViewStudents.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "RecordBook", HeaderText = "� �������" });
            DGViewStudents.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "FullName", HeaderText = "���" });
            DGViewStudents.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Group", HeaderText = "������" });
            DGViewStudents.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Department", HeaderText = "��������" });
            DGViewStudents.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Specification", HeaderText = "�����������" });
            DGViewStudents.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "DateOfAdmission", HeaderText = "���� ����������" });
        }

        private void ComboBoxDepart_SelectedIndexChanged(object? sender, EventArgs e)
        {
            UpdateComboBoxSpecs();
        }

        private void UpdateComboBoxSpecs()
        {
            if (ComboBoxDepart.SelectedItem is string selectedDepart && departmentsSpecs.TryGetValue(selectedDepart, out var specs))
            {
                ComboBoxSpec.DataSource = specs;
            }
        }

        private void AddBtn_Click(object? sender, EventArgs e)
        {
            // �������� ������������ �������
            if (students.Any(s => s.RecordBook == TextBoxRec.Text))
            {
                MessageBox.Show("������� � ����� ������� ������� ��� ����������.");
                return;
            }

            // ���������� ��������
            var newStudent = new Student
            {
                RecordBook = TextBoxRec.Text,
                FullName = TextBoxFIO.Text,
                Department = ComboBoxDepart.Text,
                Specification = ComboBoxSpec.Text,
                DateOfAdmission = TPDateAdmiss.Value,
                Group = TextBoxGroup.Text
            };
            students.Add(newStudent);
            UpdateDataGridView();
        }

        private void ChangeBtn_Click(object? sender, EventArgs e)
        {
            // ��������, ������� �� ������
            if (DGViewStudents.SelectedRows.Count > 0 && DGViewStudents.SelectedRows[0].Index != -1)
            {
                if (DGViewStudents.SelectedRows[0].DataBoundItem is Student selectedStudent)
                {
                    selectedStudent.FullName = TextBoxFIO.Text;
                    selectedStudent.Department = ComboBoxDepart.Text;
                    selectedStudent.Specification = ComboBoxSpec.Text;
                    selectedStudent.DateOfAdmission = TPDateAdmiss.Value;
                    selectedStudent.Group = TextBoxGroup.Text;
                    UpdateDataGridView();
                }
            }
            else
            {
                MessageBox.Show("�������� ������ ��� ���������.");
            }
        }

        private void DelBtn_Click(object? sender, EventArgs e)
        {
            if (DGViewStudents.SelectedRows.Count > 0)
            {
                if (DGViewStudents.SelectedRows[0].DataBoundItem is Student selectedStudent)
                {
                    students.Remove(selectedStudent);
                    UpdateDataGridView();
                }
            }
            else
            {
                MessageBox.Show("����������, �������� ������ ��� ��������.");
            }
        }

        private void UpdateDataGridView()
        {
            DGViewStudents.DataSource = null;
            DGViewStudents.DataSource = students;
        }

        private void DGViewStudents_SelectionChanged(object sender, EventArgs e)
        {
            if (DGViewStudents.SelectedRows.Count > 0)
            {
                var selectedRowIndex = DGViewStudents.SelectedRows[0].Index;
                if (selectedRowIndex >= 0 && DGViewStudents.Rows[selectedRowIndex].DataBoundItem is Student selectedStudent)
                {
                    // ��������� ��������� ���� ����������� � ��������� ��������
                    TextBoxRec.Text = selectedStudent.RecordBook;
                    TextBoxFIO.Text = selectedStudent.FullName;
                    ComboBoxDepart.Text = selectedStudent.Department;
                    ComboBoxSpec.Text = selectedStudent.Specification;
                    TPDateAdmiss.Value = selectedStudent.DateOfAdmission;
                    TextBoxGroup.Text = selectedStudent.Group;
                }
            }
        }
    }

    public class Student
    {
        public string RecordBook { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;
        public string Specification { get; set; } = string.Empty;
        public DateTime DateOfAdmission { get; set; }
        public string Group { get; set; } = string.Empty;
    }
}
