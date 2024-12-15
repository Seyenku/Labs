namespace Laba8._1
{
    partial class StudentView
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
            studentsDataGridView = new DataGridView();
            panel1 = new Panel();
            LabelRecBook = new Label();
            TextBoxRec = new TextBox();
            LabelFIO = new Label();
            TextBoxFIO = new TextBox();
            LabelDepart = new Label();
            departmentComboBox = new ComboBox();
            LabelSpec = new Label();
            specificationComboBox = new ComboBox();
            LabelDateAdmiss = new Label();
            TPDateAdmiss = new DateTimePicker();
            LabelGroup = new Label();
            TextBoxGroup = new TextBox();
            addButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)studentsDataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // studentsDataGridView
            // 
            studentsDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            studentsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentsDataGridView.Location = new Point(0, 0);
            studentsDataGridView.Name = "studentsDataGridView";
            studentsDataGridView.Size = new Size(857, 461);
            studentsDataGridView.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(LabelRecBook);
            panel1.Controls.Add(TextBoxRec);
            panel1.Controls.Add(LabelFIO);
            panel1.Controls.Add(TextBoxFIO);
            panel1.Controls.Add(LabelDepart);
            panel1.Controls.Add(departmentComboBox);
            panel1.Controls.Add(LabelSpec);
            panel1.Controls.Add(specificationComboBox);
            panel1.Controls.Add(LabelDateAdmiss);
            panel1.Controls.Add(TPDateAdmiss);
            panel1.Controls.Add(LabelGroup);
            panel1.Controls.Add(TextBoxGroup);
            panel1.Controls.Add(addButton);
            panel1.Controls.Add(editButton);
            panel1.Controls.Add(deleteButton);
            panel1.Location = new Point(0, 457);
            panel1.Name = "panel1";
            panel1.Size = new Size(857, 145);
            panel1.TabIndex = 17;
            // 
            // LabelRecBook
            // 
            LabelRecBook.Anchor = AnchorStyles.None;
            LabelRecBook.AutoSize = true;
            LabelRecBook.Location = new Point(60, 24);
            LabelRecBook.Name = "LabelRecBook";
            LabelRecBook.Size = new Size(90, 15);
            LabelRecBook.TabIndex = 13;
            LabelRecBook.Text = "Номер зачетки";
            // 
            // TextBoxRec
            // 
            TextBoxRec.Anchor = AnchorStyles.None;
            TextBoxRec.Location = new Point(60, 40);
            TextBoxRec.Name = "TextBoxRec";
            TextBoxRec.Size = new Size(190, 23);
            TextBoxRec.TabIndex = 12;
            // 
            // LabelFIO
            // 
            LabelFIO.Anchor = AnchorStyles.None;
            LabelFIO.AutoSize = true;
            LabelFIO.Location = new Point(60, 79);
            LabelFIO.Name = "LabelFIO";
            LabelFIO.Size = new Size(34, 15);
            LabelFIO.TabIndex = 15;
            LabelFIO.Text = "ФИО";
            // 
            // TextBoxFIO
            // 
            TextBoxFIO.Anchor = AnchorStyles.None;
            TextBoxFIO.Location = new Point(60, 95);
            TextBoxFIO.Name = "TextBoxFIO";
            TextBoxFIO.Size = new Size(190, 23);
            TextBoxFIO.TabIndex = 14;
            // 
            // LabelDepart
            // 
            LabelDepart.Anchor = AnchorStyles.None;
            LabelDepart.AutoSize = true;
            LabelDepart.Location = new Point(268, 24);
            LabelDepart.Name = "LabelDepart";
            LabelDepart.Size = new Size(57, 15);
            LabelDepart.TabIndex = 7;
            LabelDepart.Text = "Институт";
            // 
            // departmentComboBox
            // 
            departmentComboBox.Anchor = AnchorStyles.None;
            departmentComboBox.FormattingEnabled = true;
            departmentComboBox.Items.AddRange(new object[] { "ИТНИТ", "ИЭУ" });
            departmentComboBox.Location = new Point(268, 40);
            departmentComboBox.Margin = new Padding(15, 3, 3, 3);
            departmentComboBox.Name = "departmentComboBox";
            departmentComboBox.Size = new Size(190, 23);
            departmentComboBox.TabIndex = 1;
            // 
            // LabelSpec
            // 
            LabelSpec.Anchor = AnchorStyles.None;
            LabelSpec.AutoSize = true;
            LabelSpec.Location = new Point(268, 79);
            LabelSpec.Name = "LabelSpec";
            LabelSpec.Size = new Size(81, 15);
            LabelSpec.TabIndex = 8;
            LabelSpec.Text = "Направление";
            // 
            // specificationComboBox
            // 
            specificationComboBox.Anchor = AnchorStyles.None;
            specificationComboBox.FormattingEnabled = true;
            specificationComboBox.Location = new Point(268, 95);
            specificationComboBox.Name = "specificationComboBox";
            specificationComboBox.Size = new Size(190, 23);
            specificationComboBox.TabIndex = 6;
            // 
            // LabelDateAdmiss
            // 
            LabelDateAdmiss.Anchor = AnchorStyles.None;
            LabelDateAdmiss.AutoSize = true;
            LabelDateAdmiss.Location = new Point(476, 24);
            LabelDateAdmiss.Name = "LabelDateAdmiss";
            LabelDateAdmiss.Size = new Size(106, 15);
            LabelDateAdmiss.TabIndex = 10;
            LabelDateAdmiss.Text = "Дата поступления";
            // 
            // TPDateAdmiss
            // 
            TPDateAdmiss.Anchor = AnchorStyles.None;
            TPDateAdmiss.CustomFormat = "dd/mm/yyyy";
            TPDateAdmiss.Location = new Point(476, 40);
            TPDateAdmiss.Margin = new Padding(15, 3, 3, 3);
            TPDateAdmiss.Name = "TPDateAdmiss";
            TPDateAdmiss.Size = new Size(190, 23);
            TPDateAdmiss.TabIndex = 9;
            // 
            // LabelGroup
            // 
            LabelGroup.Anchor = AnchorStyles.None;
            LabelGroup.AutoSize = true;
            LabelGroup.Location = new Point(476, 79);
            LabelGroup.Name = "LabelGroup";
            LabelGroup.Size = new Size(46, 15);
            LabelGroup.TabIndex = 11;
            LabelGroup.Text = "Группа";
            // 
            // TextBoxGroup
            // 
            TextBoxGroup.Anchor = AnchorStyles.None;
            TextBoxGroup.Location = new Point(476, 95);
            TextBoxGroup.Name = "TextBoxGroup";
            TextBoxGroup.Size = new Size(190, 23);
            TextBoxGroup.TabIndex = 2;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.None;
            addButton.BackColor = Color.LightGray;
            addButton.Location = new Point(686, 14);
            addButton.Name = "addButton";
            addButton.Size = new Size(85, 35);
            addButton.TabIndex = 3;
            addButton.Text = "Создать";
            addButton.UseVisualStyleBackColor = false;
            // 
            // editButton
            // 
            editButton.Anchor = AnchorStyles.None;
            editButton.BackColor = Color.LightGray;
            editButton.Location = new Point(686, 55);
            editButton.Name = "editButton";
            editButton.Size = new Size(85, 35);
            editButton.TabIndex = 4;
            editButton.Text = "Изменить";
            editButton.UseVisualStyleBackColor = false;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.None;
            deleteButton.BackColor = Color.LightGray;
            deleteButton.Location = new Point(686, 96);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(85, 35);
            deleteButton.TabIndex = 5;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = false;
            // 
            // StudentView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 600);
            Controls.Add(panel1);
            Controls.Add(studentsDataGridView);
            Name = "StudentView";
            Text = "StudentView";
            ((System.ComponentModel.ISupportInitialize)studentsDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView studentsDataGridView;
        private Panel panel1;
        private Label LabelRecBook;
        private TextBox TextBoxRec;
        private Label LabelFIO;
        private TextBox TextBoxFIO;
        private Label LabelDepart;
        private ComboBox departmentComboBox;
        private Label LabelSpec;
        private ComboBox specificationComboBox;
        private Label LabelDateAdmiss;
        private DateTimePicker TPDateAdmiss;
        private Label LabelGroup;
        private TextBox TextBoxGroup;
        private Button addButton;
        private Button editButton;
        private Button deleteButton;
    }
}