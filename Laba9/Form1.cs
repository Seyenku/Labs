using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Laba9
{
    public partial class Form1 : Form
    {
        private List<Student> students = new();

        public Form1()
        {
            InitializeComponent();
            FileTypeComboBox.Items.AddRange(new[] { "JSON", "XML" });
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

            using (var saveDialog = new SaveFileDialog { Filter = "JSON files (*.json)|*.json|XML files (*.xml)|*.xml", Title = "Сохранить файл" })
            {
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if (saveDialog.FilterIndex == 1)
                        {
                            File.WriteAllText(saveDialog.FileName, JsonSerializer.Serialize(students));
                        }
                        else if (saveDialog.FilterIndex == 2)
                        {
                            var serializer = new XmlSerializer(typeof(List<Student>));
                            using var writer = new StreamWriter(saveDialog.FileName);
                            serializer.Serialize(writer, students);
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
            using (var openDialog = new OpenFileDialog { Filter = "JSON files (*.json)|*.json|XML files (*.xml)|*.xml", Title = "Открыть файл" })
            {
                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if (openDialog.FilterIndex == 1)
                        {
                            students = JsonSerializer.Deserialize<List<Student>>(File.ReadAllText(openDialog.FileName)) ?? new List<Student>();
                        }
                        else if (openDialog.FilterIndex == 2)
                        {
                            var serializer = new XmlSerializer(typeof(List<Student>));
                            using var reader = new StreamReader(openDialog.FileName);
                            students = (List<Student>)(serializer.Deserialize(reader) ?? new List<Student>());
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
