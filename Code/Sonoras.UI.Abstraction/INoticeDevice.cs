/***********************************************************************************
* File:         INoticeDevice.cs                                                   *
* Contents:     Interface INoticeDevice                                            *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2026-03-17 12:13                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using Sonoras.UI.Contracts.Enumerations;

namespace Sonoras.UI.Contracts
{
	public interface INoticeDevice
	{
		bool ShowMessage(string message, string caption, NoticeBoxButtons buttons, NoticeBoxIcons icon);
	}
}
