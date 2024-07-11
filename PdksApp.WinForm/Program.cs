using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PdksApp.Bussines.Abstract;
using PdksApp.Bussines.Concrete;
using PdksApp.DAL;
using System;
using System.Windows.Forms;

namespace PdksApp.WinForm
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            var container = ConfigureAutoFac();
            using (var scope = container.BeginLifetimeScope())
            {
                var mainForm = scope.Resolve<MainForm>();
                Application.Run(mainForm);
            }

        }
        private static IContainer ConfigureAutoFac()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddDbContext<AppDbContext>(opt =>
            opt.UseNpgsql(@"User ID=postgres;Password=1234;Host=localhost;Port=5432;Database=DemoPdks;Pooling=true;"));

            var builder = new ContainerBuilder();
            builder.Populate(serviceCollection);

            builder.RegisterType<MainForm>().AsSelf();
            builder.RegisterType<CardOperations>().AsSelf();
            builder.RegisterType<UserService>().As<IUserService>();
            builder.RegisterType<DeviceInfoService>().As<IDeviceInfoService>();
            return builder.Build();
        }
    }
}
