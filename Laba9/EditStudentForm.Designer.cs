namespace Laba9
{
    partial class EditStudentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            fioTextBox = new TextBox();
            recordTextBox = new TextBox();
            specificationComboBox = new ComboBox();
            saveButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // fioTextBox
            // 
            fioTextBox.Location = new Point(59, 27);
            fioTextBox.Name = "fioTextBox";
            fioTextBox.Size = new Size(121, 23);
            fioTextBox.TabIndex = 0;
            // 
            // recordTextBox
            // 
            recordTextBox.Location = new Point(59, 71);
            recordTextBox.Name = "recordTextBox";
            recordTextBox.Size = new Size(121, 23);
            recordTextBox.TabIndex = 1;
            // 
            // specificationComboBox
            // 
            specificationComboBox.FormattingEnabled = true;
            specificationComboBox.Items.AddRange(new object[] { "Информатика", "Физика", "Математика" });
            specificationComboBox.Location = new Point(59, 115);
            specificationComboBox.Name = "specificationComboBox";
            specificationComboBox.Size = new Size(121, 23);
            specificationComboBox.TabIndex = 2;
            // 
            // saveButton
            // 
            saveButton.AutoSize = true;
            saveButton.Location = new Point(83, 144);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 25);
            saveButton.TabIndex = 3;
            saveButton.Text = "Сохранить";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 9);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 4;
            label1.Text = "ФИО студента";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 53);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 5;
            label2.Text = "Номер зачетки";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 97);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 6;
            label3.Text = "Направление";
            // 
            // EditStudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(236, 185);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(saveButton);
            Controls.Add(specificationComboBox);
            Controls.Add(recordTextBox);
            Controls.Add(fioTextBox);
            MaximumSize = new Size(252, 224);
            MinimumSize = new Size(252, 224);
            Name = "EditStudentForm";
            Text = "Редактор студента";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox fioTextBox;
        private TextBox recordTextBox;
        private ComboBox specificationComboBox;
        private Button saveButton;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}