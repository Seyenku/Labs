using Microsoft.Data.Sqlite;
using SQLitePCL;

namespace laba10.Data
{
    public static class DatabaseInitializer
    {
        private const string ConnectionString = "Data Source=demo.db";

        public static void Initialize()
        {
            Batteries.Init();
            using var connection = new SqliteConnection(ConnectionString);
            connection.Open();

            // SQL-запрос для создания таблиц
            var createTablesCommand = connection.CreateCommand();
            createTablesCommand.CommandText = @"
                CREATE TABLE IF NOT EXISTS Users (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Username TEXT NOT NULL UNIQUE,
                    PasswordHash TEXT NOT NULL,
                    Email TEXT,
                    RoleId INTEGER NOT NULL,
                    FOREIGN KEY(RoleId) REFERENCES Roles(Id)
                );

                CREATE TABLE IF NOT EXISTS Roles (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL UNIQUE
                );

                CREATE TABLE IF NOT EXISTS Requests (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    UserId INTEGER NOT NULL,
                    Description TEXT NOT NULL,
                    Status TEXT NOT NULL,
                    FOREIGN KEY(UserId) REFERENCES Users(Id)
                );
            ";

            createTablesCommand.ExecuteNonQuery();

            SeedData(connection);
        }

        private static void SeedData(SqliteConnection connection)
        {
            // Предзагрузка базовых ролей
            var insertRolesCommand = connection.CreateCommand();
            insertRolesCommand.CommandText = @"
                INSERT OR IGNORE INTO Roles (Id, Name) VALUES
                (1, 'User'),
                (2, 'Admin');
            ";
            insertRolesCommand.ExecuteNonQuery();
        }
    }
}
