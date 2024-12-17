using laba10.Data;
using laba10.Models;
using laba10.Services;
using System.Net.Mail;
using User = laba10.Models.User;

namespace laba10
{
    public partial class MainForm : Form
    {
        private readonly RequestRepository _reqRepository;
        private readonly RequestService _reqService;

        private readonly UserRepository _userRepository;
        private readonly UserService _userService;

        public Request SelectedRequest => RequestsDataGridView.SelectedRows.Count > 0
            ? (Request)RequestsDataGridView.SelectedRows[0].DataBoundItem
            : null;

        User _user;

        public MainForm(User user)
        {
            InitializeComponent();

            _user = user;

            _reqRepository = new RequestRepository(); // Инициализация репозитория
            _reqService = new RequestService(_reqRepository); // Инициализация сервиса

            _userRepository = new UserRepository(); // Инициализация репозитория
            _userService = new UserService(_userRepository); // Инициализация сервиса

            InitializeDataGrid();
            InitializeProfile();

            if (_user.RoleId == 2)
            {
                InitializeAdminUI();
            }
            else
            {
                label2.Text += $" {_user.Username}";
            }
        }

        public void InitializeDataGrid()
        {
            RequestsDataGridView.AutoGenerateColumns = false;
            RequestsDataGridView.Columns.Clear();

            RequestsDataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id", Visible = false });
            RequestsDataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "UserId", HeaderText = "Id пользователя", Visible = false });
            RequestsDataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Description", HeaderText = "Описание запроса", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            RequestsDataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Status", HeaderText = "Статус" });

            UpdateDataGrid();
        }

        public void UpdateDataGrid()
        {
            List<Request> requestList = _user.RoleId == 2 ? _reqService.GetRequests() : _reqService.GetUserRequests(_user.Id);
            RequestsDataGridView.DataSource = requestList.ToArray();
        }

        public void InitializeAdminUI()
        {
            statusComboBox.Enabled = true;
            userComboBox.Enabled = true;
            userComboBox.Visible = true;
            List<string> usersNames = new List<string>();
            foreach (User user in _userService.GetUsers())
            {
                usersNames.Add(user.Username);
            }

            userComboBox.Items.Clear();
            userComboBox.DataSource = usersNames;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(requestRichBox.Text)
                || (string.IsNullOrEmpty(userComboBox.Text) && userComboBox.Enabled))
            {
                MessageBox.Show("Заполните поле описания запроса");
                return;
            }
            if (userComboBox.Enabled)
            {
                User usr = _userRepository.GetUserByUsername(userComboBox.SelectedItem.ToString());
                _reqService.CreateRequest(usr.Id, requestRichBox.Text.ToString());
            }
            else
            {
                _reqService.CreateRequest(_user.Id, requestRichBox.Text.ToString());
            }
            UpdateDataGrid();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (SelectedRequest == null || string.IsNullOrEmpty(requestRichBox.Text)
                || (string.IsNullOrEmpty(userComboBox.Text) && userComboBox.Enabled)) return;
            if (userComboBox.Enabled && statusComboBox.Enabled)
            {
                User usr = _userRepository.GetUserByUsername(userComboBox.SelectedItem.ToString());
                _reqService.UpdateRequest(SelectedRequest.Id, usr.Id, requestRichBox.Text.ToString(), statusComboBox.Text);
            }
            else
            {
                _reqService.UpdateRequest(SelectedRequest.Id, _user.Id, requestRichBox.Text.ToString());
            }
            UpdateDataGrid();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (SelectedRequest != null)
            {
                _reqService.RemoveRequest(SelectedRequest.Id);
                UpdateDataGrid();
            }
        }

        private void RequestsDataGridView_Click(object sender, EventArgs e)
        {
            if (SelectedRequest != null)
            {
                requestRichBox.Text = SelectedRequest.Description;
                statusComboBox.Text = SelectedRequest.Status;
                if (userComboBox.Enabled)
                {
                    int id = SelectedRequest.UserId;
                    foreach (string item in userComboBox.Items)
                    {
                        if (_userRepository.GetUserByUsername(item).Id == id) userComboBox.SelectedIndex = userComboBox.Items.IndexOf(item);
                    }
                }
            }
        }

        private void InitializeProfile()
        {
            IdTextBox.Text = _user.Id.ToString();
            loginTextBox.Text = _user.Username;
            passwordTextBox.Text = string.Empty;
            emailTextBox.Text = _user.Email;
            roleTextBox.Text = _userService.GetRoleUser(_user.Username);
        }

        private void deleteAccButton_Click(object sender, EventArgs e)
        {
            bool isConfirm = ShowConfirmation("Вы точно хотите удалить аккаунт?", "Удаление аккаунта");
            if (isConfirm)
            {
                _userService.Delete(_user.Id);
                var form = new reg_auth_From();
                Hide();
                form.ShowDialog();
                Close();
            }
        }

        public static bool ShowConfirmation(string message, string title)
        {
            DialogResult result = MessageBox.Show(
                message,
                title,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            return result == DialogResult.Yes;
        }

        private void saveAccButton_Click(object sender, EventArgs e)
        {
            string pass = passwordTextBox.Text;
            string email = emailTextBox.Text;

            if (!string.IsNullOrEmpty(pass) && pass.Length >= 6) _userService.UpdatePassword(_user.Id, pass);
            else if (string.IsNullOrEmpty(pass)) return;
            else MessageBox.Show("Пароль должен быть (6) шесть или более символов");

            if (!string.IsNullOrEmpty(email) && IsValidEmail(email)) _userService.UpdateEmail(_user.Id, email);
            else if (string.IsNullOrEmpty(email)) return;
            else MessageBox.Show("Неправильный почтовый адрес");
        }

        public static bool IsValidEmail(string email)
        {
            try
            {
                var mailAddress = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void exitAccButton_Click(object sender, EventArgs e)
        {
            var form = new reg_auth_From();
            Hide();
            form.ShowDialog();
            Close();
        }
    }
}
