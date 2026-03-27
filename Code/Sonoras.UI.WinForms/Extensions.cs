/***********************************************************************************
* File:         Extensions.cs                                                      *
* Contents:     Class Extensions                                                   *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2026-03-18 10:50                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using Gnomon.Domain.Celestial;

namespace Sonoras.UI.WinForms
{
	public static class Extensions
	{
		public static string[] ListViewStrings(this Location location)
		{
			return 
					[
						location.Name, 
						location.Latitude.ToString("F4"), 
						location.Longitude.ToString("F4"), 
						location.TimeZoneIanaId];
		}

		public static void SetText(this Label label, string text)
		{
			if (label.InvokeRequired)
			{
				label.Invoke(() => label.Text = text);
			}
			else
			{
				label.Text = text;
			}
		}
	}
}
