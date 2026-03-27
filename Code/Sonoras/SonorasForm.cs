using System.ComponentModel;
using System.IO;
using Gnomon.Domain.Celestial;
using Microsoft.Extensions.DependencyInjection;
using Sonoras.Application;
using Sonoras.Domain.Services;
using Sonoras.UI.Contracts;

namespace Sonoras
{
	public partial class SonorasForm : Form
	{
		ISonorasManager _manager;

		public SonorasForm()
		{
			InitializeComponent();


			Factotum.Versioning.Version version = new();
			version.FromToml();

			this.Text = $"Sonoras Version {version}";

			this._manager = Program.Provider.GetRequiredService<ISonorasManager>();
			this._manager.FileDialogService = Program.Provider.GetRequiredService<IFileDialogService>();
			this._manager.GazetteerPropertiesDevice = Program.Provider.GetRequiredService<IGazetteerPropertiesDevice>();
			this._manager.NoticeDevice = Program.Provider.GetRequiredService<INoticeDevice>();
			this._manager.LocationDevice = Program.Provider.GetRequiredService<ILocationDevice>();
			this._manager.SettingsDevice = Program.Provider.GetRequiredService<ISettingsDevice>();
			this._manager.GazetteerDevice = this._ctrlGazetteer;
			this._manager.TimeServiceDevice = this._ctrlTimeService;

			this._manager.GazetteerDevice.SelectedLocationChanged += this._manager.OnSelectedLocationChanged;

			this._manager.GazetteerDevice.AddLocationRequested += this._manager.OnAddLocationRequested;
			this._manager.GazetteerDevice.EditLocationRequested += this._manager.OnEditLocationRequested;
			this._manager.GazetteerDevice.RemoveLocationRequested += this._manager.OnRemoveLocationRequested;

			this._manager.RecentlyOpenedGazetteersChanged += this.OnRecentlyOpenedGazetteersChanged;
			this._manager.SelectedLocationChanged += this.OnSelectedLocationChanged;

			this.OnRecentlyOpenedGazetteersChanged();

			this._manager.Initialize();
		}

		private void OnSelectedLocationChanged(Location location)
		{
			if (location != null)
			{
				this._lblLocation.Text = location.ToString();
			}
		}

		private void OnRecentlyOpenedGazetteersChanged()
		{
			List<ToolStripItem> items = new List<ToolStripItem>();

			this._menuItemRecentlyUsedGazetteers.DropDownItems.Clear();

			foreach (string fileName in this._manager.Settings.RecentlyOpenedGazetteers)
			{
				ToolStripItem item = this._menuItemRecentlyUsedGazetteers.DropDownItems.Add(fileName);

				item.Click += this.RecentlyOpenedItemClicked;

				items.Add(item);
			}



		}

		private void RecentlyOpenedItemClicked(object? sender, EventArgs e)
		{
			string filePath = ((ToolStripItem)sender).Text;

			if (File.Exists(filePath))
			{
				this._manager.LoadGazetteer(filePath);
			}
			else
			{
				this._manager.Settings.RemoveRecentlyOpenedProject(filePath);
			}
		}

		private void OnGazetterNew(object sender, EventArgs e)
		{
			this._manager.NewGazetteer();
		}

		private void OnGazetteerEdit(object sender, EventArgs e)
		{
			this._manager.EditGazetteer();
		}

		private void OnGazetteerLoad(object sender, EventArgs e)
		{
			this._manager.LoadGazetteer();
		}

		private void OnGazetteerSaveAs(object sender, EventArgs e)
		{
			this._manager.SaveGazetteerAs();
		}

		private void OnGazetteerQuit(object sender, EventArgs e)
		{
			this.Close();
		}

		private void OnLocationAdd(object sender, EventArgs e)
		{
			this._manager.AddLocation();
		}

		private void OnLocationRemove(object sender, EventArgs e)
		{
			this._manager.RemoveLocation();
		}

		private void OnLocationEdit(object sender, EventArgs e)
		{
			this._manager.EditLocation();
		}

		private void OnToolsSettings(object sender, EventArgs e)
		{
			this._manager.EditSettings();
		}

		private void OnHelpAbout(object sender, EventArgs e)
		{
			SonorasAboutBox aboutBox = new SonorasAboutBox();

			aboutBox.ShowDialog();
		}
	}
}
