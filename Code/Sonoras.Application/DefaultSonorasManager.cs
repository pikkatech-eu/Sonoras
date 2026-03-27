/***********************************************************************************
* File:         DefaultSonorasManager.cs                                           *
* Contents:     Class DefaultSonorasManager                                        *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2026-03-16 15:28                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using Gnomon.Domain.Celestial;
using Sonoras.Domain;
using Sonoras.Domain.Services;
using Sonoras.UI.Contracts;
using Sonoras.UI.Contracts.Enumerations;

namespace Sonoras.Application
{
	public class DefaultSonorasManager : ISonorasManager
	{
		#region Constants
		internal const string FILE_FILTER = "Gazetteer files (*.gaz)|*.gaz|Json files (*.json)|*.json";
		#endregion

		#region Properties
		public Gazetteer	Gazetteer				{get;set;} = null;
		public Location		SelectedLocation		{get;set;} = null;
		public string		GazetteerFileName		{get;set;} = null;

		public TemporalService	TemporalService		{get;set;} = new TemporalService();

		public Settings		Settings				{get;set;} = new Settings();

		public IGazetteerPropertiesDevice	GazetteerPropertiesDevice	{get;set;} = null;
		public IFileDialogService FileDialogService	{get;set;} = null;

		public INoticeDevice	NoticeDevice {get;set;} = null;

		public ILocationDevice LocationDevice	{get;set;} = null;

		public IGazetteerDevice	GazetteerDevice	{get;set;} = null;

		public ITimeServiceDevice TimeServiceDevice	{get;set;}

		public ISettingsDevice	SettingsDevice	{get;set;}

		#endregion

		#region Construction
		public DefaultSonorasManager()
		{
			this.Settings = Settings.Load();

			this.TemporalService = new TemporalService();
			this.TemporalService.TemporalDataComputed += this.OnTemporalDataComputed;
		}
		#endregion

		public void Initialize()
		{
			if (this.Settings.AutoUseLastGazetteer && this.Settings.RecentlyOpenedGazetteers.Count > 0)
			{
				this.LoadGazetteer(this.Settings.RecentlyOpenedGazetteers[^1]);
			}

			if (this.Settings.AutoUseLastLocation && !String.IsNullOrEmpty(this.Settings.LastLocation))
			{
				this.SelectedLocation = this.Gazetteer.Locations.FirstOrDefault(loc => loc.Name == this.Settings.LastLocation);
				this.OnSelectedLocationChanged(this.SelectedLocation);
				this.GazetteerDevice.SelectedLocation = this.SelectedLocation;
			}
		}

		#region Gui event handlers
		public void OnAddLocationRequested()
		{
			this.AddLocation();
		}

		public void OnEditLocationRequested()
		{
			this.EditLocation();
		}

		public void OnRemoveLocationRequested()
		{
			this.RemoveLocation();
		}

		public void OnSelectedLocationChanged(Location location)
		{
			this.TemporalService.Location = location;

			if (location != null)
			{
				this.Settings.LastLocation = location.Name;
				this.Settings.Save();
			}

			this.SelectedLocationChanged?.Invoke(location);
		}

		private void OnTemporalDataComputed(TemporalData data)
		{
			this.TimeServiceDevice.Display(data);
		}
		#endregion

		#region Gazetteer management
		public void NewGazetteer()
		{
			if (this.GazetteerPropertiesDevice != null)
			{
				this.Gazetteer = this.GazetteerPropertiesDevice.GetGazetteer();

				if (this.Gazetteer != null)
				{
					this.SaveGazetteer();
				}

				this.Settings.AddRecentlyOpenedGazetteer(this.GazetteerFileName);
				this.Settings.Save();
				
				this.RecentlyOpenedGazetteersChanged?.Invoke();

				// TODO: Gazetteer -> Status Info
			}
		}

		public void EditGazetteer()
		{
			if (this.GazetteerPropertiesDevice != null)
			{
				this.Gazetteer = this.GazetteerPropertiesDevice.GetGazetteer(this.Gazetteer);
				this.SaveGazetteer();

				// TODO: Gazetteer -> Status Info
			}
		}

		public void LoadGazetteer(string fileName)
		{
			this.GazetteerFileName = fileName;
			this.Gazetteer = Gazetteer.Load(this.GazetteerFileName);
			this.GazetteerDevice.Display(this.Gazetteer);


			this.Settings.AddRecentlyOpenedGazetteer(this.GazetteerFileName);
			this.Settings.Save();

			this.TemporalService.StartTimer();
		}

		public void LoadGazetteer()
		{
			if (this.FileDialogService != null)
			{
				string fileName = this.FileDialogService.GetFileName(new FileDialogOptions{Kind=FileDialogKind.Load, Filter=FILE_FILTER});

				this.GazetteerFileName = fileName;
				this.Gazetteer = Gazetteer.Load(this.GazetteerFileName);
				this.GazetteerDevice.Display(this.Gazetteer);

				this.Settings.AddRecentlyOpenedGazetteer(this.GazetteerFileName);
				this.Settings.Save();
				this.RecentlyOpenedGazetteersChanged?.Invoke();

				this.TemporalService.StartTimer();
			}
		}

		public void SaveGazetteer()
		{
			if (this.Gazetteer != null)
			{
				if (!String.IsNullOrEmpty(this.GazetteerFileName))
				{
					this.Gazetteer.Save(this.GazetteerFileName);
				}
				else
				{
					this.SaveGazetteerAs();
				}				
			}
		}

		public void SaveGazetteerAs()
		{
			if (this.FileDialogService != null)
			{
				this.GazetteerFileName = this.FileDialogService.GetFileName(new FileDialogOptions{Kind=FileDialogKind.Save, Filter=FILE_FILTER});

				this.SaveGazetteer();
			}
		}
		#endregion

		#region Events
		public event Action RecentlyOpenedGazetteersChanged;
		public event Action<Location> SelectedLocationChanged;
		#endregion

		public void AddLocation()
		{
			if (this.Gazetteer == null)
			{
				this.NoticeDevice.ShowMessage("Load or create a gatzetteer", "No gazetteer loaded", NoticeBoxButtons.Ok, NoticeBoxIcons.Error);
				return;
			}

			if (this.LocationDevice != null)
			{
				this.TemporalService.StopTimer();

				Location location = this.LocationDevice.GetLocation();

				if (location != null)
				{
					this.Gazetteer.Locations.Add(location);
					this.GazetteerDevice.Display(this.Gazetteer);
					this.SaveGazetteer();
				}
				this.TemporalService.StartTimer();
			}
		}

		public void EditLocation()
		{
			if (this.Gazetteer == null)
			{
				this.NoticeDevice.ShowMessage("Load or create a gatzetteer", "No gazetteer loaded", NoticeBoxButtons.Ok, NoticeBoxIcons.Error);
				return;
			}

			Location location = this.GazetteerDevice.SelectedLocation;

			if (location != null)
			{
				int index = this.Gazetteer.Locations.IndexOf(location);

				location = this.LocationDevice.GetLocation(location);

				if (location != null)
				{
					this.Gazetteer.Locations[index] = location;
					this.GazetteerDevice.Display(this.Gazetteer);
					this.SaveGazetteer();
				}
			}
		}

		public void RemoveLocation()
		{
			if (this.Gazetteer == null)
			{
				this.NoticeDevice.ShowMessage("Load or create a gatzetteer", "No gazetteer loaded", NoticeBoxButtons.Ok, NoticeBoxIcons.Error);
				return;
			}

			Location location = this.GazetteerDevice.SelectedLocation;

			if (location != null)
			{
				if (this.NoticeDevice.ShowMessage
													(
														$"Location {location.Name}", 
														"Location is about to be deleted", 
														NoticeBoxButtons.OkCancel, 
														NoticeBoxIcons.Question)
													)
				{
					this.Gazetteer.Locations.Remove(location);
					this.GazetteerDevice.Display(this.Gazetteer);
					this.SaveGazetteer();
				}
			}
		}

		public void CreateAltitudeCurve()
		{
			throw new NotImplementedException();
		}

		public void ComputeSolarEvents()
		{
			throw new NotImplementedException();
		}

		public void SaveSettings()
		{
			throw new NotImplementedException();
		}

		public void LoadSettings()
		{
			throw new NotImplementedException();
		}

		public void EditSettings()
		{
			var settings = this.SettingsDevice.GetSettings(this.Settings);

			if (settings != null)
			{
				this.Settings = settings;
				this.Settings.Save();
			}
		}
	}
}
