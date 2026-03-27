/***********************************************************************************
* File:         SettingsDevice.cs                                                  *
* Contents:     Class SettingsDevice                                               *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2026-03-23 12:50                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using Sonoras.Domain;
using Sonoras.UI.Contracts;

namespace Sonoras.UI.WinForms
{
	public class SettingsDevice : ISettingsDevice
	{
		/// <summary>
		/// TODO *** Work here !
		/// </summary>
		public Settings GetSettings(Settings settings)
		{
			SettingsDialog  dialog = new SettingsDialog ();
			dialog.Settings = settings;

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				return dialog.Settings;
			}
			else
			{
				return null;
			}
		}
	}
}
