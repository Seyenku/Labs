using laba10.Data;

namespace laba10
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            DatabaseInitializer.Initialize();
            ApplicationConfiguration.Initialize();
            reg_auth_From form = new reg_auth_From();
            Application.Run(form);
        }
    }
}