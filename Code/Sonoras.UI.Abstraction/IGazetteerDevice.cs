/***********************************************************************************
* File:         IGazetteerDevice.cs                                                *
* Contents:     Interface IGazetteerDevice                                         *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2026-03-16 15:27                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using Gnomon.Domain.Celestial;
using Sonoras.Domain;

namespace Sonoras.UI.Contracts
{
	public interface IGazetteerDevice
	{
		void Display(Gazetteer gazetteer);

		Location SelectedLocation	{get;set;}

		event Action<Location> SelectedLocationChanged;

		event Action AddLocationRequested;

		event Action EditLocationRequested;
		event Action RemoveLocationRequested;
	}
}
