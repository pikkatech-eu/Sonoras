/***********************************************************************************
* File:         LocationDevice.cs                                                  *
* Contents:     Class LocationDevice                                               *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2026-03-18 09:49                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using Gnomon.Domain.Celestial;
using Sonoras.UI.Contracts;

namespace Sonoras.UI.WinForms
{
	public class LocationDevice : ILocationDevice
	{
		public Location GetLocation(Location location = null)
		{
			LocationDialog dialog = new LocationDialog();

			dialog.Location = location != null ? location : new Location();

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				return dialog.Location;
			}
			else
			{
				return null;
			}
		}
	}
}
