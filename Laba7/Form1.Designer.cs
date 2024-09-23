namespace Laba7
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
            DGViewStudents = new DataGridView();
            ComboBoxDepart = new ComboBox();
            TextBoxGroup = new TextBox();
            AddBtn = new Button();
            ChangeBtn = new Button();
            DelBtn = new Button();
            ComboBoxSpec = new ComboBox();
            LabelDepart = new Label();
            LabelSpec = new Label();
            TPDateAdmiss = new DateTimePicker();
            LabelDateAdmiss = new Label();
            LabelGroup = new Label();
            LabelRecBook = new Label();
            TextBoxRec = new TextBox();
            LabelFIO = new Label();
            TextBoxFIO = new TextBox();
            panel1 = new Panel();
            RecordBook = new DataGridViewTextBoxColumn();
            FIO = new DataGridViewTextBoxColumn();
            Group = new DataGridViewTextBoxColumn();
            Department = new DataGridViewTextBoxColumn();
            Specification = new DataGridViewTextBoxColumn();
            DateOfAdmission = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DGViewStudents).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // DGViewStudents
            // 
            DGViewStudents.AllowUserToAddRows = false;
            DGViewStudents.AllowUserToDeleteRows = false;
            DGViewStudents.AllowUserToResizeRows = false;
            DGViewStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGViewStudents.Columns.AddRange(new DataGridViewColumn[] { RecordBook, FIO, Group, Department, Specification, DateOfAdmission });
            DGViewStudents.Dock = DockStyle.Fill;
            DGViewStudents.Location = new Point(0, 0);
            DGViewStudents.Margin = new Padding(0);
            DGViewStudents.MultiSelect = false;
            DGViewStudents.Name = "DGViewStudents";
            DGViewStudents.ReadOnly = true;
            DGViewStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGViewStudents.Size = new Size(800, 342);
            DGViewStudents.TabIndex = 0;
            DGViewStudents.SelectionChanged += DGViewStudents_SelectionChanged;
            // 
            // ComboBoxDepart
            // 
            ComboBoxDepart.Anchor = AnchorStyles.None;
            ComboBoxDepart.FormattingEnabled = true;
            ComboBoxDepart.Items.AddRange(new object[] { "ИТНИТ", "ИЭУ" });
            ComboBoxDepart.Location = new Point(246, 30);
            ComboBoxDepart.Margin = new Padding(15, 3, 3, 3);
            ComboBoxDepart.Name = "ComboBoxDepart";
            ComboBoxDepart.Size = new Size(190, 23);
            ComboBoxDepart.TabIndex = 1;
            // 
            // TextBoxGroup
            // 
            TextBoxGroup.Anchor = AnchorStyles.None;
            TextBoxGroup.Location = new Point(454, 85);
            TextBoxGroup.Name = "TextBoxGroup";
            TextBoxGroup.Size = new Size(190, 23);
            TextBoxGroup.TabIndex = 2;
            // 
            // AddBtn
            // 
            AddBtn.Anchor = AnchorStyles.None;
            AddBtn.BackColor = Color.LightGray;
            AddBtn.Location = new Point(684, 14);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(85, 35);
            AddBtn.TabIndex = 3;
            AddBtn.Text = "Создать";
            AddBtn.UseVisualStyleBackColor = false;
            // 
            // ChangeBtn
            // 
            ChangeBtn.Anchor = AnchorStyles.None;
            ChangeBtn.BackColor = Color.LightGray;
            ChangeBtn.Location = new Point(684, 55);
            ChangeBtn.Name = "ChangeBtn";
            ChangeBtn.Size = new Size(85, 35);
            ChangeBtn.TabIndex = 4;
            ChangeBtn.Text = "Изменить";
            ChangeBtn.UseVisualStyleBackColor = false;
            // 
            // DelBtn
            // 
            DelBtn.Anchor = AnchorStyles.None;
            DelBtn.BackColor = Color.LightGray;
            DelBtn.Location = new Point(684, 96);
            DelBtn.Name = "DelBtn";
            DelBtn.Size = new Size(85, 35);
            DelBtn.TabIndex = 5;
            DelBtn.Text = "Удалить";
            DelBtn.UseVisualStyleBackColor = false;
            // 
            // ComboBoxSpec
            // 
            ComboBoxSpec.Anchor = AnchorStyles.None;
            ComboBoxSpec.FormattingEnabled = true;
            ComboBoxSpec.Location = new Point(246, 85);
            ComboBoxSpec.Name = "ComboBoxSpec";
            ComboBoxSpec.Size = new Size(190, 23);
            ComboBoxSpec.TabIndex = 6;
            // 
            // LabelDepart
            // 
            LabelDepart.Anchor = AnchorStyles.None;
            LabelDepart.AutoSize = true;
            LabelDepart.Location = new Point(246, 14);
            LabelDepart.Name = "LabelDepart";
            LabelDepart.Size = new Size(57, 15);
            LabelDepart.TabIndex = 7;
            LabelDepart.Text = "Институт";
            // 
            // LabelSpec
            // 
            LabelSpec.Anchor = AnchorStyles.None;
            LabelSpec.AutoSize = true;
            LabelSpec.Location = new Point(246, 69);
            LabelSpec.Name = "LabelSpec";
            LabelSpec.Size = new Size(81, 15);
            LabelSpec.TabIndex = 8;
            LabelSpec.Text = "Направление";
            // 
            // TPDateAdmiss
            // 
            TPDateAdmiss.Anchor = AnchorStyles.None;
            TPDateAdmiss.CustomFormat = "dd/mm/yyyy";
            TPDateAdmiss.Location = new Point(454, 30);
            TPDateAdmiss.Margin = new Padding(15, 3, 3, 3);
            TPDateAdmiss.Name = "TPDateAdmiss";
            TPDateAdmiss.Size = new Size(190, 23);
            TPDateAdmiss.TabIndex = 9;
            // 
            // LabelDateAdmiss
            // 
            LabelDateAdmiss.Anchor = AnchorStyles.None;
            LabelDateAdmiss.AutoSize = true;
            LabelDateAdmiss.Location = new Point(454, 14);
            LabelDateAdmiss.Name = "LabelDateAdmiss";
            LabelDateAdmiss.Size = new Size(106, 15);
            LabelDateAdmiss.TabIndex = 10;
            LabelDateAdmiss.Text = "Дата поступления";
            // 
            // LabelGroup
            // 
            LabelGroup.Anchor = AnchorStyles.None;
            LabelGroup.AutoSize = true;
            LabelGroup.Location = new Point(454, 69);
            LabelGroup.Name = "LabelGroup";
            LabelGroup.Size = new Size(46, 15);
            LabelGroup.TabIndex = 11;
            LabelGroup.Text = "Группа";
            // 
            // LabelRecBook
            // 
            LabelRecBook.Anchor = AnchorStyles.None;
            LabelRecBook.AutoSize = true;
            LabelRecBook.Location = new Point(38, 14);
            LabelRecBook.Name = "LabelRecBook";
            LabelRecBook.Size = new Size(90, 15);
            LabelRecBook.TabIndex = 13;
            LabelRecBook.Text = "Номер зачетки";
            // 
            // TextBoxRec
            // 
            TextBoxRec.Anchor = AnchorStyles.None;
            TextBoxRec.Location = new Point(38, 30);
            TextBoxRec.Name = "TextBoxRec";
            TextBoxRec.Size = new Size(190, 23);
            TextBoxRec.TabIndex = 12;
            // 
            // LabelFIO
            // 
            LabelFIO.Anchor = AnchorStyles.None;
            LabelFIO.AutoSize = true;
            LabelFIO.Location = new Point(38, 69);
            LabelFIO.Name = "LabelFIO";
            LabelFIO.Size = new Size(34, 15);
            LabelFIO.TabIndex = 15;
            LabelFIO.Text = "ФИО";
            // 
            // TextBoxFIO
            // 
            TextBoxFIO.Anchor = AnchorStyles.None;
            TextBoxFIO.Location = new Point(38, 85);
            TextBoxFIO.Name = "TextBoxFIO";
            TextBoxFIO.Size = new Size(190, 23);
            TextBoxFIO.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.Controls.Add(LabelRecBook);
            panel1.Controls.Add(TextBoxRec);
            panel1.Controls.Add(LabelFIO);
            panel1.Controls.Add(TextBoxFIO);
            panel1.Controls.Add(LabelDepart);
            panel1.Controls.Add(ComboBoxDepart);
            panel1.Controls.Add(LabelSpec);
            panel1.Controls.Add(ComboBoxSpec);
            panel1.Controls.Add(LabelDateAdmiss);
            panel1.Controls.Add(TPDateAdmiss);
            panel1.Controls.Add(LabelGroup);
            panel1.Controls.Add(TextBoxGroup);
            panel1.Controls.Add(AddBtn);
            panel1.Controls.Add(ChangeBtn);
            panel1.Controls.Add(DelBtn);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 342);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 145);
            panel1.TabIndex = 16;
            // 
            // RecordBook
            // 
            RecordBook.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            RecordBook.HeaderText = "Номер зачетки";
            RecordBook.Name = "RecordBook";
            RecordBook.ReadOnly = true;
            RecordBook.Width = 106;
            // 
            // FIO
            // 
            FIO.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FIO.HeaderText = "ФИО";
            FIO.Name = "FIO";
            FIO.ReadOnly = true;
            // 
            // Group
            // 
            Group.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Group.HeaderText = "Группа";
            Group.Name = "Group";
            Group.ReadOnly = true;
            Group.Width = 71;
            // 
            // Department
            // 
            Department.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Department.HeaderText = "Институт";
            Department.Name = "Department";
            Department.ReadOnly = true;
            // 
            // Specification
            // 
            Specification.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Specification.HeaderText = "Направление";
            Specification.Name = "Specification";
            Specification.ReadOnly = true;
            // 
            // DateOfAdmission
            // 
            DateOfAdmission.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DateOfAdmission.HeaderText = "Дата поступления";
            DateOfAdmission.Name = "DateOfAdmission";
            DateOfAdmission.ReadOnly = true;
            DateOfAdmission.Width = 120;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 487);
            Controls.Add(DGViewStudents);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)DGViewStudents).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGViewStudents;
        private ComboBox ComboBoxDepart;
        private TextBox TextBoxGroup;
        private Button AddBtn;
        private Button ChangeBtn;
        private Button DelBtn;
        private ComboBox ComboBoxSpec;
        private Label LabelDepart;
        private Label LabelSpec;
        private DateTimePicker TPDateAdmiss;
        private Label LabelDateAdmiss;
        private Label LabelGroup;
        private Label LabelRecBook;
        private TextBox TextBoxRec;
        private Label LabelFIO;
        private TextBox TextBoxFIO;
        private Panel panel1;
        private DataGridViewTextBoxColumn RecordBook;
        private DataGridViewTextBoxColumn FIO;
        private DataGridViewTextBoxColumn Group;
        private DataGridViewTextBoxColumn Department;
        private DataGridViewTextBoxColumn Specification;
        private DataGridViewTextBoxColumn DateOfAdmission;
    }
}
