/***********************************************************************************
* File:         GazetteerPropertiesDevice.cs                                       *
* Contents:     Class GazetteerPropertiesDevice                                    *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2026-03-17 11:55                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using Sonoras.Domain;
using Sonoras.UI.Contracts;

namespace Sonoras.UI.WinForms
{
	public class GazetteerPropertiesDevice : IGazetteerPropertiesDevice
	{
		public Gazetteer GetGazetteer(Gazetteer gazetteer = null)
		{
			GazetteerDialog dialog = new GazetteerDialog();

			dialog.Gazetteer = gazetteer != null ? gazetteer : new Gazetteer();

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				return dialog.Gazetteer;
			}
			else
			{
				return null;
			}
		}
	}
}
