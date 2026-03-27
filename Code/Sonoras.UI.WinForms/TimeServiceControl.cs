/***********************************************************************************
* File:         TimeServiceControl.cs                                              *
* Contents:     Class TimeServiceControl                                           *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2026-03-18 12:18                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System.Xml.Linq;
using Sonoras.Domain;
using Sonoras.UI.Contracts;

namespace Sonoras.UI.WinForms
{
	public partial class TimeServiceControl : UserControl, ITimeServiceDevice
	{
		public TimeServiceControl()
		{
			InitializeComponent();
		}

		public void Display(TemporalData data)
		{
			this._lblGregogianDate.SetText(data.GregorianDate.ToString());
			this._lblBahaiDate.SetText(data.BahaiDate.ToString());
			this._lblIslamicDate.SetText(data.IslamicDate.ToString());
			this._lblHebrewDate.SetText(data.HebrewDate.ToString());
			this._lblJulianDay.SetText(data.JulianDay.ToString("F6"));
			this._lblStandardTime.SetText(data.StandardTime.ToString(@"hh\:mm\:ss"));
			this._lblLocalTime.SetText(data.LocalTime.ToString(@"hh\:mm\:ss"));
			this._lblUtc.SetText(data.UtcTime.ToString(@"hh\:mm\:ss"));
			this._lblSunLongitude.SetText(data.SunLongitude.ToString("F6"));
			this._lblSunDeclination.SetText(data.SunDeclination.ToString("F4"));
			this._lblSunRA.SetText(data.SunRightAscension.ToString("F4"));
			this._lblSunAltitude.SetText(data.SunAltitude.ToString("F4"));
			this._lblSunAzimuth.SetText(data.SunAzimuth.ToString("F4"));
			this._lblSunriseSunset.SetText($"Sunrise: {data.Sunrise}; Sunset: {data.Sunset}");
		}

		private void DisplayIntern(TemporalData data)
		{
			this._lblGregogianDate.Text = data.GregorianDate.ToString();
		}

		private void _lblSunset_Click(object sender, EventArgs e)
		{

		}
	}
}
