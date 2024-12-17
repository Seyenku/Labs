using laba10.Data;
using laba10.Models;

namespace laba10.Services
{
    /// <summary>
    /// Сервис для работы с запросами пользователей.
    /// </summary>
    public class RequestService
    {
        private readonly RequestRepository _requestRepository;

        /// <summary>
        /// Конструктор сервиса запросов.
        /// </summary>
        /// <param name="requestRepository">Репозиторий запросов.</param>
        public RequestService(RequestRepository requestRepository)
        {
            _requestRepository = requestRepository;
        }

        /// <summary>
        /// Получает полный список запросов.
        /// </summary>
        /// <returns>Список всех запросов.</returns>
        public List<Request> GetRequests()
        {
            return _requestRepository.GetAllRequests();
        }

        /// <summary>
        /// Получает список запросов, связанных с конкретным пользователем.
        /// </summary>
        /// <param name="userId">Идентификатор пользователя.</param>
        /// <returns>Список запросов пользователя.</returns>
        public List<Request> GetUserRequests(int userId)
        {
            return _requestRepository.GetRequestsByUser(userId);
        }

        /// <summary>
        /// Создает новый запрос от имени пользователя.
        /// </summary>
        /// <param name="userId">Идентификатор пользователя.</param>
        /// <param name="description">Описание запроса.</param>
        /// <exception cref="ArgumentException">Выбрасывается, если описание пустое.</exception>
        public void CreateRequest(int userId, string description)
        {
            if (string.IsNullOrWhiteSpace(description))
                throw new ArgumentException("Описание не может быть пустым.");

            _requestRepository.AddRequest(userId, description);
        }

        /// <summary>
        /// Обновляет существующий запрос.
        /// </summary>
        /// <param name="id">Идентификатор запроса.</param>
        /// <param name="userId">Идентификатор пользователя.</param>
        /// <param name="description">Новое описание запроса.</param>
        /// <param name="status">Новый статус запроса. По умолчанию — "В ожидании".</param>
        /// <exception cref="ArgumentException">Выбрасывается, если описание пустое.</exception>
        public void UpdateRequest(int id, int userId, string description, string status = "В ожидании")
        {
            if (string.IsNullOrWhiteSpace(description))
                throw new ArgumentException("Описание не может быть пустым.");

            _requestRepository.UpdateRequest(id, userId, description, status);
        }

        /// <summary>
        /// Удаляет запрос по его идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор запроса.</param>
        public void RemoveRequest(int id)
        {
            _requestRepository.RemoveRequest(id);
        }
    }
}
