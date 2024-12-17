using laba10.Data;
using laba10.Models;

namespace laba10.Services
{
    /// <summary>
    /// Сервис для работы с пользователями.
    /// </summary>
    public class UserService
    {
        private readonly UserRepository _userRepository;

        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        /// <summary>
        /// Получает список всех пользователей.
        /// </summary>
        public List<User> GetUsers() => _userRepository.GetAllUser();

        /// <summary>
        /// Получает название роли пользователя по имени.
        /// </summary>
        /// <param name="username">Имя пользователя.</param>
        public string GetRoleUser(string username) =>
            _userRepository.GetRoleNameByUsername(username);

        /// <summary>
        /// Аутентифицирует пользователя по имени и паролю.
        /// </summary>
        /// <param name="username">Имя пользователя.</param>
        /// <param name="password">Пароль пользователя.</param>
        /// <returns>Объект пользователя или null, если аутентификация не удалась.</returns>
        public User? Authenticate(string username, string password)
        {
            var user = _userRepository.GetUserByUsername(username);
            if (user == null) return null;

            var hashedPassword = HashPassword(password);
            return user.PasswordHash == hashedPassword ? user : null;
        }

        /// <summary>
        /// Регистрирует нового пользователя.
        /// </summary>
        /// <param name="username">Имя нового пользователя.</param>
        /// <param name="password">Пароль нового пользователя.</param>
        /// <returns>True, если регистрация успешна, иначе False.</returns>
        public bool Registration(string username, string password)
        {
            if (_userRepository.GetUserByUsername(username) != null)
                return false;

            var hashedPassword = HashPassword(password);
            _userRepository.CreateNewUser(username, hashedPassword);
            return true;
        }

        /// <summary>
        /// Изменяет email пользователя.
        /// </summary>
        /// <param name="userId">Идентификатор пользователя.</param>
        /// <param name="newEmail">Новый email.</param>
        public void UpdateEmail(int userId, string newEmail)
        {
            if (string.IsNullOrWhiteSpace(newEmail))
                throw new ArgumentException("Email не может быть пустым.");

            _userRepository.UpdateEmail(userId, newEmail);
        }

        /// <summary>
        /// Изменяет пароль пользователя.
        /// </summary>
        /// <param name="userId">Идентификатор пользователя.</param>
        /// <param name="newPass">Новый пароль.</param>
        public void UpdatePassword(int userId, string newPass)
        {
            if (string.IsNullOrWhiteSpace(newPass))
                throw new ArgumentException("Пароль не может быть пустым.");

            var hashedPassword = HashPassword(newPass);
            _userRepository.UpdatePassword(userId, hashedPassword);
        }

        /// <summary>
        /// Удаляет пользователя.
        /// </summary>
        /// <param name="userId">Идентификатор пользователя.</param>
        public void Delete(int userId) => _userRepository.DeleteUser(userId);

        /// <summary>
        /// Хэширует пароль с использованием SHA256.
        /// </summary>
        /// <param name="password">Пароль для хэширования.</param>
        /// <returns>Хэшированный пароль в Base64.</returns>
        private string HashPassword(string password)
        {
            using var sha256 = System.Security.Cryptography.SHA256.Create();
            var hashedBytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(hashedBytes);
        }
    }
}