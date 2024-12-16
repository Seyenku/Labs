namespace Laba9
{
    public partial class EditStudentForm : Form
    {
        public Student _student { get; private set; }
        public EditStudentForm(Student student)
        {
            _student = student;
            InitializeComponent();
            fioTextBox.Text = _student.FIO.ToString();
            recordTextBox.Text = _student.RecordNumber.ToString();
            specificationComboBox.Text = _student.Specification.ToString();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            _student.FIO = fioTextBox.Text;
            _student.RecordNumber = recordTextBox.Text;
            _student.Specification = specificationComboBox.SelectedItem?.ToString();
            DialogResult = DialogResult.OK;
        }
    }
}
