using laba10.Data;
using laba10.Services;

namespace laba10
{
    public partial class reg_auth_From : Form
    {
        private readonly UserRepository _userRepository;
        private readonly UserService _userService;
        public reg_auth_From()
        {
            InitializeComponent();
            _userRepository = new UserRepository(); // Инициализация репозитория
            _userService = new UserService(_userRepository); // Инициализация сервиса
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            string login = loginBox.Text;
            string password = passBox.Text;

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Заполните все поля для авторизации!");
                return;
            }

            var user = _userService.Authenticate(login, password);
            if (user != null)
            {
                MessageBox.Show($"Добро пожаловать, {user.Username}!");
                var mainForm = new MainForm(user);
                Hide();
                mainForm.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!");
            }
        }

        private void registrationLabel_Click(object sender, EventArgs e)
        {
            loginGroupBox.Visible = !loginGroupBox.Visible;
            loginGroupBox.Enabled = !loginGroupBox.Enabled;

            regGroupBox.Visible = !regGroupBox.Visible;
            regGroupBox.Enabled = !regGroupBox.Enabled;

            registrationLabel.Text = regGroupBox.Visible ? "Перейти к авторизации" : "Перейти к регистрации";
        }

        private void newAccButton_Click(object sender, EventArgs e)
        {
            string login = loginForNewAccTextBox.Text;
            string password = passForNewAccTextBox.Text;

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Заполните все поля для регистрации!");
                return;
            }

            bool isSuccess = _userService.Registration(login, password);
            if (isSuccess)
            {
                MessageBox.Show("Регистрация успешна! Теперь вы можете войти.");
                loginBox.Text = login;
                registrationLabel_Click(sender, e); // Переключение на форму авторизации
            }
            else
            {
                MessageBox.Show("Пользователь с таким логином уже существует!");
            }
        }
    }
}
