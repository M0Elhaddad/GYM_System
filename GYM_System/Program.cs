using GYM_BLL;
using GYM_DAL;
using GYM_DAL.Entities;

namespace GYM_System
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            GYMDbContext dbContext =new GYMDbContext();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Login(dbContext));
        }
    }
}