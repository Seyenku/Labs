namespace laba10
{
    partial class MainForm
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
            tabControl1 = new TabControl();
            mainPage = new TabPage();
            statusComboBox = new ComboBox();
            label3 = new Label();
            requestRichBox = new RichTextBox();
            userComboBox = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            editButton = new Button();
            deleteButton = new Button();
            addButton = new Button();
            RequestsDataGridView = new DataGridView();
            profilePage = new TabPage();
            deleteAccButton = new Button();
            saveAccButton = new Button();
            roleTextBox = new TextBox();
            emailTextBox = new TextBox();
            passwordTextBox = new TextBox();
            loginTextBox = new TextBox();
            IdTextBox = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            exitAccButton = new Button();
            tabControl1.SuspendLayout();
            mainPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RequestsDataGridView).BeginInit();
            profilePage.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(mainPage);
            tabControl1.Controls.Add(profilePage);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 505);
            tabControl1.TabIndex = 0;
            // 
            // mainPage
            // 
            mainPage.Controls.Add(statusComboBox);
            mainPage.Controls.Add(label3);
            mainPage.Controls.Add(requestRichBox);
            mainPage.Controls.Add(userComboBox);
            mainPage.Controls.Add(label2);
            mainPage.Controls.Add(label1);
            mainPage.Controls.Add(editButton);
            mainPage.Controls.Add(deleteButton);
            mainPage.Controls.Add(addButton);
            mainPage.Controls.Add(RequestsDataGridView);
            mainPage.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            mainPage.Location = new Point(4, 24);
            mainPage.Name = "mainPage";
            mainPage.Padding = new Padding(3);
            mainPage.Size = new Size(792, 477);
            mainPage.TabIndex = 0;
            mainPage.Text = "Основное окно";
            mainPage.UseVisualStyleBackColor = true;
            // 
            // statusComboBox
            // 
            statusComboBox.Anchor = AnchorStyles.Bottom;
            statusComboBox.Enabled = false;
            statusComboBox.Items.AddRange(new object[] { "В ожидании", "В процессе", "Выполнен" });
            statusComboBox.Location = new Point(495, 421);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(149, 33);
            statusComboBox.TabIndex = 11;
            statusComboBox.Text = "-";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Location = new Point(421, 424);
            label3.Name = "label3";
            label3.Size = new Size(68, 25);
            label3.TabIndex = 10;
            label3.Text = "Статус";
            // 
            // requestRichBox
            // 
            requestRichBox.Anchor = AnchorStyles.Bottom;
            requestRichBox.Location = new Point(99, 339);
            requestRichBox.Name = "requestRichBox";
            requestRichBox.Size = new Size(545, 66);
            requestRichBox.TabIndex = 9;
            requestRichBox.Text = "";
            // 
            // userComboBox
            // 
            userComboBox.Anchor = AnchorStyles.Bottom;
            userComboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            userComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            userComboBox.Enabled = false;
            userComboBox.FormattingEnabled = true;
            userComboBox.Location = new Point(159, 421);
            userComboBox.Name = "userComboBox";
            userComboBox.Size = new Size(235, 33);
            userComboBox.TabIndex = 8;
            userComboBox.Visible = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Location = new Point(19, 424);
            label2.Name = "label2";
            label2.Size = new Size(134, 25);
            label2.TabIndex = 7;
            label2.Text = "Пользователь";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.Location = new Point(19, 342);
            label1.Name = "label1";
            label1.Size = new Size(74, 30);
            label1.TabIndex = 5;
            label1.Text = "Запрос";
            // 
            // editButton
            // 
            editButton.Anchor = AnchorStyles.Bottom;
            editButton.AutoSize = true;
            editButton.FlatStyle = FlatStyle.Popup;
            editButton.Location = new Point(650, 378);
            editButton.Name = "editButton";
            editButton.Size = new Size(115, 35);
            editButton.TabIndex = 4;
            editButton.Text = "Изменить";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.Bottom;
            deleteButton.FlatStyle = FlatStyle.Popup;
            deleteButton.Location = new Point(650, 421);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(115, 33);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Bottom;
            addButton.AutoSize = true;
            addButton.FlatStyle = FlatStyle.Popup;
            addButton.Location = new Point(650, 337);
            addButton.Name = "addButton";
            addButton.Size = new Size(115, 35);
            addButton.TabIndex = 1;
            addButton.Text = "Создать";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // RequestsDataGridView
            // 
            RequestsDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RequestsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            RequestsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RequestsDataGridView.Location = new Point(3, 3);
            RequestsDataGridView.MultiSelect = false;
            RequestsDataGridView.Name = "RequestsDataGridView";
            RequestsDataGridView.ReadOnly = true;
            RequestsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            RequestsDataGridView.Size = new Size(786, 316);
            RequestsDataGridView.TabIndex = 0;
            RequestsDataGridView.Click += RequestsDataGridView_Click;
            // 
            // profilePage
            // 
            profilePage.Controls.Add(exitAccButton);
            profilePage.Controls.Add(deleteAccButton);
            profilePage.Controls.Add(saveAccButton);
            profilePage.Controls.Add(roleTextBox);
            profilePage.Controls.Add(emailTextBox);
            profilePage.Controls.Add(passwordTextBox);
            profilePage.Controls.Add(loginTextBox);
            profilePage.Controls.Add(IdTextBox);
            profilePage.Controls.Add(label8);
            profilePage.Controls.Add(label7);
            profilePage.Controls.Add(label6);
            profilePage.Controls.Add(label5);
            profilePage.Controls.Add(label4);
            profilePage.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            profilePage.Location = new Point(4, 24);
            profilePage.Name = "profilePage";
            profilePage.Padding = new Padding(3);
            profilePage.Size = new Size(792, 477);
            profilePage.TabIndex = 1;
            profilePage.Text = "Страница профиля";
            profilePage.UseVisualStyleBackColor = true;
            // 
            // deleteAccButton
            // 
            deleteAccButton.AutoSize = true;
            deleteAccButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            deleteAccButton.Location = new Point(673, 442);
            deleteAccButton.Name = "deleteAccButton";
            deleteAccButton.Size = new Size(113, 27);
            deleteAccButton.TabIndex = 11;
            deleteAccButton.Text = "Удалить аккаунт";
            deleteAccButton.UseVisualStyleBackColor = true;
            deleteAccButton.Click += deleteAccButton_Click;
            // 
            // saveAccButton
            // 
            saveAccButton.AutoSize = true;
            saveAccButton.Location = new Point(246, 203);
            saveAccButton.Name = "saveAccButton";
            saveAccButton.Size = new Size(115, 35);
            saveAccButton.TabIndex = 10;
            saveAccButton.Text = "Сохранить";
            saveAccButton.UseVisualStyleBackColor = true;
            saveAccButton.Click += saveAccButton_Click;
            // 
            // roleTextBox
            // 
            roleTextBox.Location = new Point(27, 237);
            roleTextBox.Margin = new Padding(3, 9, 3, 3);
            roleTextBox.Name = "roleTextBox";
            roleTextBox.ReadOnly = true;
            roleTextBox.Size = new Size(206, 33);
            roleTextBox.TabIndex = 9;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(133, 164);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.PlaceholderText = "pochta@gmail.com";
            emailTextBox.Size = new Size(228, 33);
            emailTextBox.TabIndex = 8;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(133, 125);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PlaceholderText = "******";
            passwordTextBox.Size = new Size(228, 33);
            passwordTextBox.TabIndex = 7;
            // 
            // loginTextBox
            // 
            loginTextBox.Location = new Point(133, 86);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.ReadOnly = true;
            loginTextBox.Size = new Size(228, 33);
            loginTextBox.TabIndex = 6;
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(133, 47);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(228, 33);
            IdTextBox.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(27, 203);
            label8.Name = "label8";
            label8.Size = new Size(206, 25);
            label8.TabIndex = 4;
            label8.Text = "Уровень прав доступа";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 164);
            label7.Name = "label7";
            label7.Size = new Size(66, 25);
            label7.TabIndex = 3;
            label7.Text = "Почта";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 125);
            label6.Name = "label6";
            label6.Size = new Size(78, 25);
            label6.TabIndex = 2;
            label6.Text = "Пароль";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 86);
            label5.Name = "label5";
            label5.Size = new Size(65, 25);
            label5.TabIndex = 1;
            label5.Text = "Логин";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 47);
            label4.Name = "label4";
            label4.Size = new Size(28, 25);
            label4.TabIndex = 0;
            label4.Text = "Id";
            // 
            // exitAccButton
            // 
            exitAccButton.AutoSize = true;
            exitAccButton.Location = new Point(602, 6);
            exitAccButton.Name = "exitAccButton";
            exitAccButton.Size = new Size(182, 35);
            exitAccButton.TabIndex = 12;
            exitAccButton.Text = "Выйти из профиля";
            exitAccButton.UseVisualStyleBackColor = true;
            exitAccButton.Click += exitAccButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 505);
            Controls.Add(tabControl1);
            MinimumSize = new Size(816, 544);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Основное окно";
            tabControl1.ResumeLayout(false);
            mainPage.ResumeLayout(false);
            mainPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RequestsDataGridView).EndInit();
            profilePage.ResumeLayout(false);
            profilePage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage mainPage;
        private TabPage profilePage;
        private Label label2;
        private Label label1;
        private Button editButton;
        private Button deleteButton;
        private Button addButton;
        private DataGridView RequestsDataGridView;
        private RichTextBox requestRichBox;
        private ComboBox userComboBox;
        private ComboBox statusComboBox;
        private Label label3;
        private TextBox roleTextBox;
        private TextBox emailTextBox;
        private TextBox passwordTextBox;
        private TextBox loginTextBox;
        private TextBox IdTextBox;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button saveAccButton;
        private Button deleteAccButton;
        private Button exitAccButton;
    }
}