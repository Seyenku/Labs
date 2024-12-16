namespace Laba8._1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Настройки конфигурации приложения
            ApplicationConfiguration.Initialize();

            // Создание экземпляров View и Repository
            var studentView = new StudentView();
            var studentRepository = new StudentRepository();

            // Создание экземпляра Presenter, связывающего View и Repository
            var studentPresenter = new StudentPresenter(studentView, studentRepository);

            // Запуск формы
            Application.Run(studentView);
        }
    }
}