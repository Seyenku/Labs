namespace Laba9
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            deleteButton = new Button();
            addButton = new Button();
            specificationComboBox = new ComboBox();
            recordTextBox = new TextBox();
            fioTextBox = new TextBox();
            groupBox2 = new GroupBox();
            saveButton = new Button();
            FileTypeComboBox = new ComboBox();
            loadButton = new Button();
            listViewStudent = new ListView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Right;
            groupBox1.Controls.Add(deleteButton);
            groupBox1.Controls.Add(addButton);
            groupBox1.Controls.Add(specificationComboBox);
            groupBox1.Controls.Add(recordTextBox);
            groupBox1.Controls.Add(fioTextBox);
            groupBox1.FlatStyle = FlatStyle.System;
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox1.Location = new Point(543, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(222, 185);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Студент";
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(127, 143);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(89, 31);
            deleteButton.TabIndex = 5;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            addButton.AutoSize = true;
            addButton.Location = new Point(6, 143);
            addButton.Name = "addButton";
            addButton.Size = new Size(89, 31);
            addButton.TabIndex = 4;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            // 
            // specificationComboBox
            // 
            specificationComboBox.FormattingEnabled = true;
            specificationComboBox.Location = new Point(6, 108);
            specificationComboBox.Name = "specificationComboBox";
            specificationComboBox.Size = new Size(210, 29);
            specificationComboBox.TabIndex = 3;
            // 
            // recordTextBox
            // 
            recordTextBox.Location = new Point(6, 73);
            recordTextBox.Name = "recordTextBox";
            recordTextBox.PlaceholderText = "Номер зачетки";
            recordTextBox.Size = new Size(210, 29);
            recordTextBox.TabIndex = 1;
            // 
            // fioTextBox
            // 
            fioTextBox.Location = new Point(6, 38);
            fioTextBox.Name = "fioTextBox";
            fioTextBox.PlaceholderText = "ФИО студента";
            fioTextBox.Size = new Size(210, 29);
            fioTextBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Right;
            groupBox2.Controls.Add(saveButton);
            groupBox2.Controls.Add(FileTypeComboBox);
            groupBox2.Controls.Add(loadButton);
            groupBox2.FlatStyle = FlatStyle.System;
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox2.Location = new Point(543, 194);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(222, 110);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Работа с файлом";
            // 
            // saveButton
            // 
            saveButton.AutoSize = true;
            saveButton.Location = new Point(120, 63);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(96, 31);
            saveButton.TabIndex = 7;
            saveButton.Text = "Сохранить";
            saveButton.UseVisualStyleBackColor = true;
            // 
            // FileTypeComboBox
            // 
            FileTypeComboBox.FormattingEnabled = true;
            FileTypeComboBox.Location = new Point(6, 28);
            FileTypeComboBox.Name = "FileTypeComboBox";
            FileTypeComboBox.Size = new Size(210, 29);
            FileTypeComboBox.TabIndex = 6;
            // 
            // loadButton
            // 
            loadButton.AutoSize = true;
            loadButton.Location = new Point(6, 63);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(96, 31);
            loadButton.TabIndex = 6;
            loadButton.Text = "Загрузить";
            loadButton.UseVisualStyleBackColor = true;
            // 
            // listViewStudent
            // 
            listViewStudent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listViewStudent.Location = new Point(3, 3);
            listViewStudent.Name = "listViewStudent";
            listViewStudent.Size = new Size(534, 301);
            listViewStudent.TabIndex = 3;
            listViewStudent.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 310);
            Controls.Add(listViewStudent);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Student";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private TextBox recordTextBox;
        private TextBox fioTextBox;
        private GroupBox groupBox2;
        private Button deleteButton;
        private Button addButton;
        private ComboBox specificationComboBox;
        private Button saveButton;
        private ComboBox FileTypeComboBox;
        private Button loadButton;
        private ListView listViewStudent;
    }
}
