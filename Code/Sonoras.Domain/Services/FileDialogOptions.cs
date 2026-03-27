/***********************************************************************************
* File:         FileDialogOptions.cs                                               *
* Contents:     Class FileDialogOptions                                            *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2026-03-17 09:52                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

namespace Sonoras.Domain.Services
{
	public class FileDialogOptions
	{
		public FileDialogKind Kind {get;set;} = FileDialogKind.None;
		public string Filter {get;set;} = "All files (*.*)|*.*";
		public string Title {get;set;}
		public string DefaultExtension {get;set;}
	}
}
