/***********************************************************************************
* File:         FileDialogService.cs                                               *
* Contents:     Class FileDialogService                                            *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2026-03-17 09:55                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using Sonoras.Domain.Services;

namespace Sonoras.UI.WinForms
{
	public class FileDialogService : IFileDialogService
	{
		public string GetFileName(FileDialogOptions options)
		{
			switch (options.Kind)
			{
				case FileDialogKind.Load:

					OpenFileDialog ofd	= new OpenFileDialog();
					ofd.Filter			= options.Filter;
					ofd.Title			= options.Title;
					ofd.DefaultExt		= options.DefaultExtension;

					if (ofd.ShowDialog() == DialogResult.OK)
					{
						return ofd.FileName;
					}
					else
					{
						return null;
					}

				case FileDialogKind.Save:

					SaveFileDialog sfd	= new SaveFileDialog();
					sfd.Filter			= options.Filter;
					sfd.Title			= options.Title;
					sfd.DefaultExt		= options.DefaultExtension;

					if (sfd.ShowDialog() == DialogResult.OK)
					{
						return sfd.FileName;
					}
					else
					{
						return null;
					}

				case FileDialogKind.None:
				default:
					return null;
			}
		}
	}
}
