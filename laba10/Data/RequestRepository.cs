// RequestRepository.cs
using laba10.Models;
using Microsoft.Data.Sqlite;
using SQLitePCL;

namespace laba10.Data
{
    /// <summary>
    /// Репозиторий для работы с запросами в базе данных.
    /// </summary>
    public class RequestRepository
    {
        private const string ConnectionString = "Data Source=demo.db";

        /// <summary>
        /// Получает все запросы из базы данных.
        /// </summary>
        /// <returns>Список всех запросов.</returns>
        public List<Request> GetAllRequests()
        {
            Batteries.Init();
            var requests = new List<Request>();

            using var connection = new SqliteConnection(ConnectionString);
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Requests";

            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                requests.Add(new Request
                {
                    Id = reader.GetInt32(0),
                    UserId = reader.GetInt32(1),
                    Description = reader.GetString(2),
                    Status = reader.GetString(3)
                });
            }

            return requests;
        }

        /// <summary>
        /// Получает запросы, принадлежащие конкретному пользователю.
        /// </summary>
        /// <param name="userId">Идентификатор пользователя.</param>
        /// <returns>Список запросов пользователя.</returns>
        public List<Request> GetRequestsByUser(int userId)
        {
            Batteries.Init();
            var requests = new List<Request>();

            using var connection = new SqliteConnection(ConnectionString);
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Requests WHERE UserId = @userId";
            command.Parameters.AddWithValue("@userId", userId);

            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                requests.Add(new Request
                {
                    Id = reader.GetInt32(0),
                    UserId = reader.GetInt32(1),
                    Description = reader.GetString(2),
                    Status = reader.GetString(3)
                });
            }

            return requests;
        }

        /// <summary>
        /// Добавляет новый запрос в базу данных.
        /// </summary>
        /// <param name="userId">Идентификатор пользователя.</param>
        /// <param name="description">Описание запроса.</param>
        public void AddRequest(int userId, string description)
        {
            Batteries.Init();
            using var connection = new SqliteConnection(ConnectionString);
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = @"
                INSERT INTO Requests (UserId, Description, Status) 
                VALUES (@userId, @description, 'В ожидании')";
            command.Parameters.AddWithValue("@userId", userId);
            command.Parameters.AddWithValue("@description", description);
            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Обновляет данные существующего запроса.
        /// </summary>
        /// <param name="id">Идентификатор запроса.</param>
        /// <param name="userId">Идентификатор пользователя.</param>
        /// <param name="description">Новое описание запроса.</param>
        /// <param name="status">Новый статус запроса (по умолчанию — "В ожидании").</param>
        public void UpdateRequest(int id, int userId, string description, string status = "В ожидании")
        {
            Batteries.Init();
            using var connection = new SqliteConnection(ConnectionString);
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = @"
                UPDATE Requests 
                SET UserId = @userId, Description = @description, Status = @status 
                WHERE Id = @Id";
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@userId", userId);
            command.Parameters.AddWithValue("@description", description);
            command.Parameters.AddWithValue("@status", status);
            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Удаляет запрос по его идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор запроса.</param>
        public void RemoveRequest(int id)
        {
            Batteries.Init();
            using var connection = new SqliteConnection(ConnectionString);
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = "DELETE FROM Requests WHERE Id = @Id";
            command.Parameters.AddWithValue("@Id", id);
            command.ExecuteNonQuery();
        }
    }
}
