/***********************************************************************************
* File:         ISonorasManager.cs                                                 *
* Contents:     Interface ISonorasManager                                          *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2026-03-16 14:46                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using Gnomon.Domain.Celestial;
using Sonoras.Domain;
using Sonoras.Domain.Services;
using Sonoras.UI.Contracts;

namespace Sonoras.Application
{
	public interface ISonorasManager
	{
		Gazetteer	Gazetteer			{get;set;}
		Location	SelectedLocation	{get;set;}
		string		GazetteerFileName	{get;set;}

		TemporalService	TemporalService	{get;set;}

		Settings		Settings		{get;set;}

		IGazetteerPropertiesDevice	GazetteerPropertiesDevice	{get;set;}
		IFileDialogService FileDialogService	{get;set;}

		INoticeDevice	NoticeDevice {get;set;}

		ILocationDevice LocationDevice	{get;set;}

		IGazetteerDevice	GazetteerDevice	{get;set;}

		ITimeServiceDevice TimeServiceDevice	{get;set;}

		ISettingsDevice	SettingsDevice	{get;set;}

		void Initialize();
		void NewGazetteer();
		void EditGazetteer();
		void LoadGazetteer();

		void LoadGazetteer(string fileName);

		void SaveGazetteer();
		void SaveGazetteerAs();

		void AddLocation();
		void EditLocation();
		void RemoveLocation();

		void CreateAltitudeCurve();

		/// <summary>
		/// Computes solar events for selected location and an interval of dates from UI input.
		/// </summary>
		void ComputeSolarEvents();

		void SaveSettings();
		void LoadSettings();
		void EditSettings();


		void OnSelectedLocationChanged(Location location);

		void OnAddLocationRequested();
		void OnEditLocationRequested();
		void OnRemoveLocationRequested();

		event Action RecentlyOpenedGazetteersChanged;
		event Action<Location> SelectedLocationChanged;
	}
}
