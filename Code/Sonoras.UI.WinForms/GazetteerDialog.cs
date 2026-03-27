/***********************************************************************************
* File:         GazetteerDialog.cs                                                 *
* Contents:     Class GazetteerDialog                                              *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2024-11-06 15:55                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System.ComponentModel;
using Sonoras.Domain;

namespace Sonoras.UI.WinForms
{
	public partial class GazetteerDialog : Form
	{
		public GazetteerDialog()
		{
			InitializeComponent();
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Gazetteer	Gazetteer	
		{
			get
			{
				Gazetteer gazetteer		= new Gazetteer();
				gazetteer.Title			= this._txTitle.Text;
				gazetteer.Description	= this._txDescription.Text;

				return gazetteer;
			}

			set
			{
				this._txTitle.Text			= value.Title;
				this._txDescription.Text	= value.Description;
			}
		}
	}
}
