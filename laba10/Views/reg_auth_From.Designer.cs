namespace laba10
{
    partial class reg_auth_From
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
            registrationLabel = new Label();
            loginBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            enterButton = new Button();
            loginGroupBox = new GroupBox();
            passBox = new TextBox();
            regGroupBox = new GroupBox();
            passForNewAccTextBox = new TextBox();
            newAccButton = new Button();
            label3 = new Label();
            label4 = new Label();
            loginForNewAccTextBox = new TextBox();
            loginGroupBox.SuspendLayout();
            regGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // registrationLabel
            // 
            registrationLabel.AutoSize = true;
            registrationLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Underline, GraphicsUnit.Point, 204);
            registrationLabel.Location = new Point(92, 282);
            registrationLabel.Margin = new Padding(4, 0, 4, 0);
            registrationLabel.Name = "registrationLabel";
            registrationLabel.Size = new Size(146, 17);
            registrationLabel.TabIndex = 6;
            registrationLabel.Text = "Перейти к регистрации";
            registrationLabel.Click += registrationLabel_Click;
            // 
            // loginBox
            // 
            loginBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginBox.Location = new Point(46, 75);
            loginBox.Margin = new Padding(4);
            loginBox.Name = "loginBox";
            loginBox.Size = new Size(127, 29);
            loginBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(46, 50);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 21);
            label1.TabIndex = 8;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(46, 112);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(63, 21);
            label2.TabIndex = 9;
            label2.Text = "Пароль";
            // 
            // enterButton
            // 
            enterButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            enterButton.ForeColor = SystemColors.ActiveCaptionText;
            enterButton.Location = new Point(62, 181);
            enterButton.Margin = new Padding(4);
            enterButton.Name = "enterButton";
            enterButton.Size = new Size(96, 32);
            enterButton.TabIndex = 2;
            enterButton.Text = "Войти";
            enterButton.UseVisualStyleBackColor = true;
            enterButton.Click += enterButton_Click;
            // 
            // loginGroupBox
            // 
            loginGroupBox.BackColor = Color.DarkSalmon;
            loginGroupBox.Controls.Add(passBox);
            loginGroupBox.Controls.Add(enterButton);
            loginGroupBox.Controls.Add(label2);
            loginGroupBox.Controls.Add(label1);
            loginGroupBox.Controls.Add(loginBox);
            loginGroupBox.FlatStyle = FlatStyle.Popup;
            loginGroupBox.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            loginGroupBox.ForeColor = SystemColors.Control;
            loginGroupBox.Location = new Point(51, 33);
            loginGroupBox.Name = "loginGroupBox";
            loginGroupBox.Size = new Size(228, 233);
            loginGroupBox.TabIndex = 7;
            loginGroupBox.TabStop = false;
            loginGroupBox.Text = "Вход в аккаунт";
            // 
            // passBox
            // 
            passBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passBox.Location = new Point(45, 137);
            passBox.Margin = new Padding(4);
            passBox.Name = "passBox";
            passBox.PasswordChar = '*';
            passBox.Size = new Size(127, 29);
            passBox.TabIndex = 1;
            // 
            // regGroupBox
            // 
            regGroupBox.BackColor = Color.DarkSalmon;
            regGroupBox.Controls.Add(passForNewAccTextBox);
            regGroupBox.Controls.Add(newAccButton);
            regGroupBox.Controls.Add(label3);
            regGroupBox.Controls.Add(label4);
            regGroupBox.Controls.Add(loginForNewAccTextBox);
            regGroupBox.Enabled = false;
            regGroupBox.FlatStyle = FlatStyle.Popup;
            regGroupBox.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            regGroupBox.ForeColor = SystemColors.Control;
            regGroupBox.Location = new Point(39, 34);
            regGroupBox.Name = "regGroupBox";
            regGroupBox.Size = new Size(253, 233);
            regGroupBox.TabIndex = 12;
            regGroupBox.TabStop = false;
            regGroupBox.Text = "Создание аккаунта";
            regGroupBox.Visible = false;
            // 
            // passForNewAccTextBox
            // 
            passForNewAccTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passForNewAccTextBox.Location = new Point(58, 137);
            passForNewAccTextBox.Margin = new Padding(4);
            passForNewAccTextBox.Name = "passForNewAccTextBox";
            passForNewAccTextBox.PasswordChar = '*';
            passForNewAccTextBox.Size = new Size(127, 29);
            passForNewAccTextBox.TabIndex = 1;
            // 
            // newAccButton
            // 
            newAccButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            newAccButton.ForeColor = SystemColors.ActiveCaptionText;
            newAccButton.Location = new Point(75, 181);
            newAccButton.Margin = new Padding(4);
            newAccButton.Name = "newAccButton";
            newAccButton.Size = new Size(96, 32);
            newAccButton.TabIndex = 3;
            newAccButton.Text = "Создать";
            newAccButton.UseVisualStyleBackColor = true;
            newAccButton.Click += newAccButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(59, 112);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(63, 21);
            label3.TabIndex = 9;
            label3.Text = "Пароль";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(59, 50);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(54, 21);
            label4.TabIndex = 8;
            label4.Text = "Логин";
            // 
            // loginForNewAccTextBox
            // 
            loginForNewAccTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginForNewAccTextBox.Location = new Point(59, 75);
            loginForNewAccTextBox.Margin = new Padding(4);
            loginForNewAccTextBox.Name = "loginForNewAccTextBox";
            loginForNewAccTextBox.Size = new Size(127, 29);
            loginForNewAccTextBox.TabIndex = 0;
            // 
            // reg_auth_From
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(334, 311);
            Controls.Add(loginGroupBox);
            Controls.Add(registrationLabel);
            Controls.Add(regGroupBox);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "reg_auth_From";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            loginGroupBox.ResumeLayout(false);
            loginGroupBox.PerformLayout();
            regGroupBox.ResumeLayout(false);
            regGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label registrationLabel;
        private TextBox loginBox;
        private Label label1;
        private Label label2;
        private Button enterButton;
        private GroupBox loginGroupBox;
        private TextBox passBox;
        private GroupBox regGroupBox;
        private TextBox passForNewAccTextBox;
        private Button newAccButton;
        private Label label3;
        private Label label4;
        private TextBox loginForNewAccTextBox;
    }
}
