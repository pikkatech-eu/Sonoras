/***********************************************************************************
* File:         PikkaCoreDialog1.cs                                                  *
* Contents:     Class PikkaCoreDialog1                                               *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2024-11-06 15:55                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System.ComponentModel;
using Sonoras.Domain;

namespace Sonoras.UI.WinForms
{
	public partial class SettingsDialog : Form
	{
		public SettingsDialog()
		{
			InitializeComponent();
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Settings Settings
		{
			get
			{
				return this._pgSettings.SelectedObject as Settings;
			}

			set
			{
				this._pgSettings.SelectedObject = value;
			}
		}
	}
}
