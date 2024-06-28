using AIMA.CSharp.GUI.Factory;
using AIMA.CSharp.GUI.Factory.Interfaces;
using AIMA.CSharp.GUI.Forms.Base;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

//https://www.c-sharpcorner.com/article/simplify-dependency-injection-in-net-6-for-windows-forms-development/
//https://www.wiktorzychla.com/2022/01/winforms-dependency-injection-in-net6.html#google_vignette
namespace AIMA.CSharp.GUI
{
    internal static class Program
    {
        /// <summary>
        /// 
        /// </summary>
        public static IServiceProvider ServiceProvider { get; private set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            ServiceProvider = CreateHostBuilder().Build().Services;
            Application.Run(ServiceProvider.GetService<frmAIMAMainMDIForm>());//new frmAIMAMainMDIForm());
        }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddTransient<IFormFactory, FormFactory>();
                    services.AddTransient<IEnvironmentFactory, EnvironmentFactory>();
                    services.AddTransient<ITestFactory, TestFactory>();
                    //Add all forms
                    var forms = typeof(Program).Assembly
                    .GetTypes()
                    .Where(t => t.BaseType == typeof(Form) || t.BaseType == typeof(BaseForm))
                    .ToList();

                    forms.ForEach(form =>
                    {
                        services.AddTransient(form);
                    });
                });
        }
    }
}