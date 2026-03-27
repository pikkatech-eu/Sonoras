/***********************************************************************************
* File:         ITimeServiceDevice.cs                                              *
* Contents:     Interface ITimeServiceDevice                                       *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2026-03-18 12:17                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/


using Sonoras.Domain;

namespace Sonoras.UI.Contracts
{
	public interface ITimeServiceDevice
	{
		void Display(TemporalData data);
	}
}
