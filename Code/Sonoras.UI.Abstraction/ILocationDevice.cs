/***********************************************************************************
* File:         ILocationDevice.cs                                                 *
* Contents:     Interface ILocationDevice                                          *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2026-03-17 11:43                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using Gnomon.Domain.Celestial;

namespace Sonoras.UI.Contracts
{
	public interface ILocationDevice
	{
		Location GetLocation(Location location = null);
	}
}
