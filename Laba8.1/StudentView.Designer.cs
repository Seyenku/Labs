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
            label6 = new Label();
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
            TextBoxGroup = new TextBox();
            addButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            LabelGroup = new Label();
            searchTextBox = new TextBox();
            filterButton = new Button();
            sortRecButton = new Button();
            panel2 = new Panel();
            cancelFilterButton = new Button();
            applyFilterButton = new Button();
            TPDateAdmissfilter1 = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            specificationComboBoxfilter = new ComboBox();
            departmentComboBoxfilter = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            TextBoxGroupfilter = new TextBox();
            TextBoxFIOfilter = new TextBox();
            TextBoxRecfilter = new TextBox();
            TPDateAdmissfilter2 = new DateTimePicker();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)studentsDataGridView).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // studentsDataGridView
            // 
            studentsDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            studentsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            studentsDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            studentsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentsDataGridView.Location = new Point(0, 23);
            studentsDataGridView.Margin = new Padding(0);
            studentsDataGridView.MultiSelect = false;
            studentsDataGridView.Name = "studentsDataGridView";
            studentsDataGridView.ReadOnly = true;
            studentsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            studentsDataGridView.Size = new Size(857, 431);
            studentsDataGridView.TabIndex = 0;
            studentsDataGridView.Click += studentsDataGridView_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(label6);
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
            panel1.Controls.Add(TextBoxGroup);
            panel1.Controls.Add(addButton);
            panel1.Controls.Add(editButton);
            panel1.Controls.Add(deleteButton);
            panel1.Location = new Point(0, 457);
            panel1.Name = "panel1";
            panel1.Size = new Size(857, 145);
            panel1.TabIndex = 17;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Location = new Point(476, 79);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 22;
            label6.Text = "Группа";
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
            TextBoxRec.MaxLength = 6;
            TextBoxRec.Name = "TextBoxRec";
            TextBoxRec.PlaceholderText = "123456";
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
            TextBoxFIO.PlaceholderText = "Иванов Иван Иванович";
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
            // TextBoxGroup
            // 
            TextBoxGroup.Anchor = AnchorStyles.None;
            TextBoxGroup.Location = new Point(476, 95);
            TextBoxGroup.MaxLength = 3;
            TextBoxGroup.Name = "TextBoxGroup";
            TextBoxGroup.PlaceholderText = "123";
            TextBoxGroup.Size = new Size(190, 23);
            TextBoxGroup.TabIndex = 2;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.None;
            addButton.BackColor = Color.LightGray;
            addButton.FlatStyle = FlatStyle.System;
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
            editButton.FlatStyle = FlatStyle.System;
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
            deleteButton.BackColor = Color.MistyRose;
            deleteButton.FlatStyle = FlatStyle.System;
            deleteButton.Location = new Point(686, 96);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(85, 35);
            deleteButton.TabIndex = 5;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // LabelGroup
            // 
            LabelGroup.Anchor = AnchorStyles.Top;
            LabelGroup.AutoSize = true;
            LabelGroup.Location = new Point(14, 92);
            LabelGroup.Name = "LabelGroup";
            LabelGroup.Size = new Size(46, 15);
            LabelGroup.TabIndex = 11;
            LabelGroup.Text = "Группа";
            // 
            // searchTextBox
            // 
            searchTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            searchTextBox.BackColor = Color.LightGray;
            searchTextBox.BorderStyle = BorderStyle.FixedSingle;
            searchTextBox.Location = new Point(30, 0);
            searchTextBox.Margin = new Padding(0);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.PlaceholderText = "Введите текст для поиска";
            searchTextBox.Size = new Size(744, 23);
            searchTextBox.TabIndex = 18;
            // 
            // filterButton
            // 
            filterButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            filterButton.BackColor = Color.LightSteelBlue;
            filterButton.FlatStyle = FlatStyle.Flat;
            filterButton.Location = new Point(774, 0);
            filterButton.Margin = new Padding(0);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(83, 23);
            filterButton.TabIndex = 16;
            filterButton.Text = "Фильтр";
            filterButton.UseVisualStyleBackColor = false;
            filterButton.Click += filterButton_Click;
            // 
            // sortRecButton
            // 
            sortRecButton.BackColor = Color.LightSteelBlue;
            sortRecButton.FlatStyle = FlatStyle.Popup;
            sortRecButton.Location = new Point(0, 0);
            sortRecButton.Margin = new Padding(0);
            sortRecButton.Name = "sortRecButton";
            sortRecButton.Size = new Size(30, 23);
            sortRecButton.TabIndex = 16;
            sortRecButton.Text = "▲";
            sortRecButton.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(TPDateAdmissfilter2);
            panel2.Controls.Add(cancelFilterButton);
            panel2.Controls.Add(applyFilterButton);
            panel2.Controls.Add(TPDateAdmissfilter1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(specificationComboBoxfilter);
            panel2.Controls.Add(departmentComboBoxfilter);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(TextBoxGroupfilter);
            panel2.Controls.Add(TextBoxFIOfilter);
            panel2.Controls.Add(TextBoxRecfilter);
            panel2.Controls.Add(LabelGroup);
            panel2.Location = new Point(657, 23);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 579);
            panel2.TabIndex = 19;
            panel2.Visible = false;
            // 
            // cancelFilterButton
            // 
            cancelFilterButton.Anchor = AnchorStyles.Bottom;
            cancelFilterButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cancelFilterButton.Location = new Point(87, 533);
            cancelFilterButton.Name = "cancelFilterButton";
            cancelFilterButton.Size = new Size(101, 32);
            cancelFilterButton.TabIndex = 21;
            cancelFilterButton.Text = "Очистить";
            cancelFilterButton.UseVisualStyleBackColor = true;
            cancelFilterButton.Click += cancelFilterButton_Click;
            // 
            // applyFilterButton
            // 
            applyFilterButton.AutoSize = true;
            applyFilterButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            applyFilterButton.Location = new Point(14, 353);
            applyFilterButton.Name = "applyFilterButton";
            applyFilterButton.Size = new Size(174, 32);
            applyFilterButton.TabIndex = 20;
            applyFilterButton.Text = "Применить";
            applyFilterButton.UseVisualStyleBackColor = true;
            applyFilterButton.Click += applyFilterButton_Click;
            // 
            // TPDateAdmissfilter1
            // 
            TPDateAdmissfilter1.Anchor = AnchorStyles.Top;
            TPDateAdmissfilter1.CustomFormat = "dd/mm/yyyy";
            TPDateAdmissfilter1.Location = new Point(14, 266);
            TPDateAdmissfilter1.Margin = new Padding(15, 3, 3, 3);
            TPDateAdmissfilter1.Name = "TPDateAdmissfilter1";
            TPDateAdmissfilter1.Size = new Size(174, 23);
            TPDateAdmissfilter1.TabIndex = 16;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(14, 224);
            label5.Name = "label5";
            label5.Size = new Size(173, 17);
            label5.TabIndex = 19;
            label5.Text = "Дата поступления - Период";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(14, 180);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 16;
            label4.Text = "Направление";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(14, 136);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 16;
            label3.Text = "Институт";
            // 
            // specificationComboBoxfilter
            // 
            specificationComboBoxfilter.Anchor = AnchorStyles.Top;
            specificationComboBoxfilter.FormattingEnabled = true;
            specificationComboBoxfilter.Items.AddRange(new object[] { "ИТНИТ", "ИЭУ" });
            specificationComboBoxfilter.Location = new Point(14, 198);
            specificationComboBoxfilter.Margin = new Padding(15, 3, 3, 3);
            specificationComboBoxfilter.Name = "specificationComboBoxfilter";
            specificationComboBoxfilter.Size = new Size(174, 23);
            specificationComboBoxfilter.TabIndex = 18;
            // 
            // departmentComboBoxfilter
            // 
            departmentComboBoxfilter.Anchor = AnchorStyles.Top;
            departmentComboBoxfilter.FormattingEnabled = true;
            departmentComboBoxfilter.Items.AddRange(new object[] { "ИТНИТ", "ИЭУ" });
            departmentComboBoxfilter.Location = new Point(14, 154);
            departmentComboBoxfilter.Margin = new Padding(15, 3, 3, 3);
            departmentComboBoxfilter.Name = "departmentComboBoxfilter";
            departmentComboBoxfilter.Size = new Size(174, 23);
            departmentComboBoxfilter.TabIndex = 17;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(14, 48);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 16;
            label2.Text = "ФИО";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Location = new Point(14, 4);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 14;
            label1.Text = "Номер зачетки";
            // 
            // TextBoxGroupfilter
            // 
            TextBoxGroupfilter.Location = new Point(14, 110);
            TextBoxGroupfilter.MaxLength = 3;
            TextBoxGroupfilter.Name = "TextBoxGroupfilter";
            TextBoxGroupfilter.Size = new Size(174, 23);
            TextBoxGroupfilter.TabIndex = 2;
            // 
            // TextBoxFIOfilter
            // 
            TextBoxFIOfilter.Location = new Point(14, 66);
            TextBoxFIOfilter.Name = "TextBoxFIOfilter";
            TextBoxFIOfilter.Size = new Size(174, 23);
            TextBoxFIOfilter.TabIndex = 1;
            // 
            // TextBoxRecfilter
            // 
            TextBoxRecfilter.Location = new Point(14, 22);
            TextBoxRecfilter.MaxLength = 6;
            TextBoxRecfilter.Name = "TextBoxRecfilter";
            TextBoxRecfilter.Size = new Size(174, 23);
            TextBoxRecfilter.TabIndex = 0;
            // 
            // TPDateAdmissfilter2
            // 
            TPDateAdmissfilter2.Anchor = AnchorStyles.Top;
            TPDateAdmissfilter2.CustomFormat = "dd/mm/yyyy";
            TPDateAdmissfilter2.Location = new Point(14, 309);
            TPDateAdmissfilter2.Margin = new Padding(15, 3, 3, 3);
            TPDateAdmissfilter2.Name = "TPDateAdmissfilter2";
            TPDateAdmissfilter2.Size = new Size(174, 23);
            TPDateAdmissfilter2.TabIndex = 22;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Location = new Point(14, 248);
            label7.Margin = new Padding(0);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 23;
            label7.Text = "Начало";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Location = new Point(14, 292);
            label8.Margin = new Padding(0);
            label8.Name = "label8";
            label8.Size = new Size(41, 15);
            label8.TabIndex = 24;
            label8.Text = "Конец";
            // 
            // StudentView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 600);
            Controls.Add(panel2);
            Controls.Add(sortRecButton);
            Controls.Add(filterButton);
            Controls.Add(searchTextBox);
            Controls.Add(panel1);
            Controls.Add(studentsDataGridView);
            Name = "StudentView";
            Text = "StudentView";
            ((System.ComponentModel.ISupportInitialize)studentsDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private TextBox searchTextBox;
        private Button filterButton;
        private Button sortRecButton;
        private Panel panel2;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox specificationComboBoxfilter;
        private ComboBox departmentComboBoxfilter;
        private Label label2;
        private Label label1;
        private TextBox TextBoxGroupfilter;
        private TextBox TextBoxFIOfilter;
        private TextBox TextBoxRecfilter;
        private Button cancelFilterButton;
        private Button applyFilterButton;
        private DateTimePicker TPDateAdmissfilter1;
        private Label label6;
        private Label label7;
        private DateTimePicker TPDateAdmissfilter2;
        private Label label8;
    }
}