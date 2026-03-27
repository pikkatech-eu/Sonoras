/***********************************************************************************
* File:         LocationDialog.cs                                                  *
* Contents:     Class LocationDialog                                               *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2026-03-18 10:01                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using Gnomon.Domain.Celestial;
using System.ComponentModel;

namespace Sonoras.UI.WinForms
{
	public partial class LocationDialog : Form
	{
		public LocationDialog()
		{
			InitializeComponent();

			List<string> canonicalNames = TimeZoneConverter.TZConvert.KnownIanaCanonicalNames.ToList();
			canonicalNames.Sort();
			this._cxTimeZone.DataSource = canonicalNames;
			this._cxTimeZone.SelectedItem = TimeZoneInfo.Utc;
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Location Location
		{
			get
			{
				Location location = new Location();

				location.Name			= this._txName.Text;
				location.Latitude		= Double.Parse(this._txLatitude.Text);
				location.Longitude		= Double.Parse(this._txLongitude.Text);
				location.Elevation		= Double.Parse(this._txElevation.Text);
				location.TimeZoneIanaId		= this._cxTimeZone.SelectedItem.ToString();
				location.Description	= this._txDescription.Text;

				return location;
			}

			set
			{
				this._txName.Text				= value.Name;
				this._txLatitude.Text			= value.Latitude.ToString();
				this._txLongitude.Text			= value.Longitude.ToString();
				this._txElevation.Text			= value.Elevation.ToString();
				this._cxTimeZone.SelectedItem	= value.TimeZoneIanaId;
				this._txDescription.Text		=value.Description;
			}
		}
	}
}
