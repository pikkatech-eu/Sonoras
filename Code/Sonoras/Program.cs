using Microsoft.Extensions.DependencyInjection;
using Sonoras.Application;
using Sonoras.Domain.Services;
using Sonoras.UI.Contracts;
using Sonoras.UI.WinForms;


namespace Sonoras
{
	internal static class Program
	{
		public static ServiceProvider Provider;

		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			var services = new ServiceCollection();
 
			services.AddSingleton<SonorasForm>();

            services.AddSingleton<ISonorasManager,				DefaultSonorasManager>(); 
			services.AddSingleton<IGazetteerPropertiesDevice,	GazetteerPropertiesDevice>();
			services.AddSingleton<ILocationDevice,				LocationDevice>();
			services.AddSingleton<IFileDialogService,			FileDialogService>();
			services.AddSingleton<INoticeDevice,				NoticeDevice>();			
			services.AddSingleton<IGazetteerDevice,				GazetteerDevice>();		
			services.AddSingleton<ITimeServiceDevice,			TimeServiceControl>();

			services.AddTransient<ISettingsDevice,				SettingsDevice>();

            Provider = services.BuildServiceProvider();


			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();

			System.Windows.Forms.Application.Run(Provider.GetRequiredService<SonorasForm>());
		}
	}
}