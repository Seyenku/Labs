using System.Text.Json;
using System.Xml.Serialization;

namespace Laba9
{
    public partial class Form1 : Form
    {
        private List<Student> students = new();

        public Form1()
        {
            InitializeComponent();
            FileTypeComboBox.Items.AddRange(new[] { "JSON", "XML", "CSV" });
            specificationComboBox.Items.AddRange(new[] { "Информатика", "Физика", "Математика" });

            UpdateListView();

            addButton.Click += AddButton_Click;
            deleteButton.Click += DeleteButton_Click;
            saveButton.Click += SaveButton_Click;
            loadButton.Click += LoadButton_Click;
            listViewStudent.DoubleClick += EditStudent_Click;
        }

        private void UpdateListView()
        {
            listViewStudent.Items.Clear();
            foreach (var student in students)
            {
                var item = new ListViewItem(new[] { student.FIO, student.RecordNumber, student.Specification });
                listViewStudent.Items.Add(item);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(fioTextBox.Text) || string.IsNullOrWhiteSpace(recordTextBox.Text) || specificationComboBox.SelectedItem == null)
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            students.Add(new Student
            {
                FIO = fioTextBox.Text,
                RecordNumber = recordTextBox.Text,
                Specification = specificationComboBox.SelectedItem.ToString()
            });

            UpdateListView();

            fioTextBox.Clear();
            recordTextBox.Clear();
            specificationComboBox.SelectedIndex = -1;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (listViewStudent.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите запись для удаления!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedIndex = listViewStudent.SelectedIndices[0];
            students.RemoveAt(selectedIndex);
            UpdateListView();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (FileTypeComboBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите формат файла!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string filter = FileTypeValidate();

            using (var saveDialog = new SaveFileDialog { Filter = filter, Title = "Сохранить файл" })
            {
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if (FileTypeComboBox.SelectedIndex == 0)
                        {
                            File.WriteAllText(saveDialog.FileName, JsonSerializer.Serialize(students));
                        }
                        else if (FileTypeComboBox.SelectedIndex == 1)
                        {
                            var serializer = new XmlSerializer(typeof(List<Student>));
                            using var writer = new StreamWriter(saveDialog.FileName);
                            serializer.Serialize(writer, students);
                        }
                        else
                        {
                            SaveToCsv(saveDialog.FileName);
                        }

                        MessageBox.Show("Файл успешно сохранён!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            if (FileTypeComboBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите формат файла!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string filter = FileTypeValidate();

            using (var openDialog = new OpenFileDialog { Filter = filter, Title = "Открыть файл" })
            {
                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if (FileTypeComboBox.SelectedIndex == 0)
                        {
                            students = JsonSerializer.Deserialize<List<Student>>(File.ReadAllText(openDialog.FileName)) ?? new List<Student>();
                        }
                        else if (FileTypeComboBox.SelectedIndex == 1)
                        {
                            var serializer = new XmlSerializer(typeof(List<Student>));
                            using var reader = new StreamReader(openDialog.FileName);
                            students = (List<Student>)(serializer.Deserialize(reader) ?? new List<Student>());
                        }
                        else
                        {
                            students = LoadFromCsv(openDialog.FileName);
                        }

                        UpdateListView();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при загрузке: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private string FileTypeValidate(string filter = "")
        {
            if (FileTypeComboBox.SelectedItem.ToString() == "JSON")
            {
                filter = "JSON files (*.json)|*.json";
            }
            else if (FileTypeComboBox.SelectedItem.ToString() == "XML")
            {
                filter = "XML files (*.xml)|*.xml";
            }
            else
            {
                filter = "CSV files (*.csv)|*.csv";
            }
            return filter;
        }

        private void SaveToCsv(string fileName)
        {
            using (var writer = new StreamWriter(fileName))
            {
                writer.WriteLine("FIO,RecordNumber,Specification");
                foreach (var student in students)
                {
                    writer.WriteLine($"{student.FIO},{student.RecordNumber},{student.Specification}");
                }
            }
        }

        private List<Student> LoadFromCsv(string fileName)
        {
            var studentsList = new List<Student>();

            using (var reader = new StreamReader(fileName))
            {
                var header = reader.ReadLine(); // Skip header
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    if (values.Length == 3)
                    {
                        studentsList.Add(new Student
                        {
                            FIO = values[0],
                            RecordNumber = values[1],
                            Specification = values[2]
                        });
                    }
                }
            }

            return studentsList;
        }

        private void EditStudent_Click(object sender, EventArgs e)
        {
            if (listViewStudent.SelectedItems.Count == 0) return;

            var selectedIndex = listViewStudent.SelectedIndices[0];
            var student = students[selectedIndex];

            if (student == null)
            {
                MessageBox.Show("Данные выбранного студента не найдены.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var editForm = new EditStudentForm(student))
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    students[selectedIndex] = editForm._student;
                    UpdateListView();
                }
            }
        }

    }
}
