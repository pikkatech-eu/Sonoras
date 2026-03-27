/***********************************************************************************
* File:         MessageDevice.cs                                                   *
* Contents:     Class MessageDevice                                                *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2026-03-17 12:15                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using Sonoras.UI.Contracts;
using Sonoras.UI.Contracts.Enumerations;

namespace Sonoras.UI.WinForms
{
	public class NoticeDevice : INoticeDevice
	{
		public bool ShowMessage(string message, string caption, NoticeBoxButtons buttons, NoticeBoxIcons icon)
		{
			MessageBoxButtons mbb;

			switch (buttons)
			{
				case NoticeBoxButtons.Ok:
					mbb = MessageBoxButtons.OK;
					break;

				case NoticeBoxButtons.OkCancel:
					mbb = MessageBoxButtons.OKCancel;
					break;

				default:
					mbb = MessageBoxButtons.OK;
					break;
			}

			MessageBoxIcon mbi = MessageBoxIcon.None;

			switch (icon)
			{
				case NoticeBoxIcons.Info:
					mbi = MessageBoxIcon.Information;
					break;

				case NoticeBoxIcons.Warning:
					mbi = MessageBoxIcon.Warning;
					break;

				case NoticeBoxIcons.Error:
					mbi = MessageBoxIcon.Error;
					break;

				case NoticeBoxIcons.Question:
					mbi = MessageBoxIcon.Question;
					break;

				default:
					break;
			}

			return MessageBox.Show(message, caption, mbb, mbi) == DialogResult.OK;
		}
	}
}
