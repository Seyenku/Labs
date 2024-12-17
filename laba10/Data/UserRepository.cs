using laba10.Models;
using Microsoft.Data.Sqlite;

namespace laba10.Data
{
    /// <summary>
    /// Репозиторий для работы с пользователями в базе данных.
    /// </summary>
    public class UserRepository
    {
        private const string ConnectionString = "Data Source=demo.db";

        /// <summary>
        /// Получает список всех пользователей из базы данных.
        /// </summary>
        /// <returns>Список пользователей.</returns>
        public List<User> GetAllUser()
        {
            var users = new List<User>();

            using var connection = new SqliteConnection(ConnectionString);
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = "SELECT Id, Username, PasswordHash, Email, RoleId FROM Users";

            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                users.Add(new User
                {
                    Id = reader.GetInt32(0),
                    Username = reader.GetString(1),
                    PasswordHash = reader.GetString(2),
                    Email = reader.IsDBNull(3) ? null : reader.GetString(3),
                    RoleId = reader.GetInt32(4)
                });
            }

            return users;
        }

        /// <summary>
        /// Получает роль пользователя по имени пользователя.
        /// </summary>
        /// <param name="username">Имя пользователя.</param>
        /// <returns>Название роли или сообщение об отсутствии роли.</returns>
        public string GetRoleNameByUsername(string username)
        {
            var user = GetUserByUsername(username);
            if (user == null)
                return "Пользователь не найден";

            using var connection = new SqliteConnection(ConnectionString);
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = @"
                SELECT r.Name 
                FROM Roles r 
                JOIN Users u ON u.RoleId = r.Id 
                WHERE u.Id = @userId";
            command.Parameters.AddWithValue("@userId", user.Id);

            var result = command.ExecuteScalar();
            return result?.ToString() ?? "Роль не найдена";
        }

        /// <summary>
        /// Получает пользователя по имени.
        /// </summary>
        /// <param name="username">Имя пользователя.</param>
        /// <returns>Объект пользователя или null, если пользователь не найден.</returns>
        public User? GetUserByUsername(string username)
        {
            using var connection = new SqliteConnection(ConnectionString);
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = "SELECT Id, Username, PasswordHash, Email, RoleId FROM Users WHERE Username = @username";
            command.Parameters.AddWithValue("@username", username);

            using var reader = command.ExecuteReader();
            if (reader.Read())
            {
                return new User
                {
                    Id = reader.GetInt32(0),
                    Username = reader.GetString(1),
                    PasswordHash = reader.GetString(2),
                    Email = reader.IsDBNull(3) ? null : reader.GetString(3),
                    RoleId = reader.GetInt32(4)
                };
            }

            return null;
        }

        /// <summary>
        /// Создает нового пользователя.
        /// </summary>
        /// <param name="username">Имя пользователя.</param>
        /// <param name="password">Хэш пароля.</param>
        public void CreateNewUser(string username, string password)
        {
            using var connection = new SqliteConnection(ConnectionString);
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = @"
                INSERT INTO Users (Username, PasswordHash, Email, RoleId) 
                VALUES (@username, @passwordHash, NULL, @roleId)";
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@passwordHash", password);
            command.Parameters.AddWithValue("@roleId", 1); // 1 — обычный пользователь.

            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Удаляет пользователя из базы данных.
        /// </summary>
        /// <param name="id">Идентификатор пользователя.</param>
        public void DeleteUser(int id)
        {
            using var connection = new SqliteConnection(ConnectionString);
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = "DELETE FROM Users WHERE Id = @id";
            command.Parameters.AddWithValue("@id", id);

            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Обновляет email пользователя.
        /// </summary>
        /// <param name="userId">Идентификатор пользователя.</param>
        /// <param name="newEmail">Новый email.</param>
        public void UpdateEmail(int userId, string newEmail)
        {
            using var connection = new SqliteConnection(ConnectionString);
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = "UPDATE Users SET Email = @newEmail WHERE Id = @userId";
            command.Parameters.AddWithValue("@newEmail", newEmail);
            command.Parameters.AddWithValue("@userId", userId);

            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Обновляет пароль пользователя.
        /// </summary>
        /// <param name="userId">Идентификатор пользователя.</param>
        /// <param name="newPassword">Хэш нового пароля.</param>
        public void UpdatePassword(int userId, string newPassword)
        {
            using var connection = new SqliteConnection(ConnectionString);
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = "UPDATE Users SET PasswordHash = @newPassword WHERE Id = @userId";
            command.Parameters.AddWithValue("@newPassword", newPassword);
            command.Parameters.AddWithValue("@userId", userId);

            command.ExecuteNonQuery();
        }
    }
}
