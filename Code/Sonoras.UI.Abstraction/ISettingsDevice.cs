/***********************************************************************************
* File:         ISettingsDevice.cs                                                 *
* Contents:     Interface ISettingsDevice                                          *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2026-03-23 12:37                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using Sonoras.Domain;

namespace Sonoras.UI.Contracts
{
	public interface ISettingsDevice
	{
		Settings GetSettings(Settings settings);
	}
}
