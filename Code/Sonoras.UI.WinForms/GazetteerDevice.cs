/***********************************************************************************
* File:         GazetteerDevice.cs                                                 *
* Contents:     Class GazetteerDevice                                              *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2026-03-18 10:48                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System.ComponentModel;
using Gnomon.Domain.Celestial;
using Sonoras.Domain;
using Sonoras.UI.Contracts;

namespace Sonoras.UI.WinForms
{
	public partial class GazetteerDevice : UserControl, IGazetteerDevice
	{
		public GazetteerDevice()
		{
			InitializeComponent();
		}

		public void Display(Gazetteer gazetteer)
		{
			this._lvLocations.Items.Clear();

			foreach (Location location in gazetteer.Locations)
			{
				string[] itemStrings = location.ListViewStrings();

				ListViewItem lvi = new ListViewItem(itemStrings);

				lvi.Tag = location;

				this._lvLocations.Items.Add(lvi);
			}

			this._lvLocations.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
			this._lvLocations.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
		}

		private void OnSelectedLocationChanged(object sender, EventArgs e)
		{
			this.SelectedLocationChanged?.Invoke(this.SelectedLocation);
		}

		private void OnAddLocation(object sender, EventArgs e)
		{
			this.AddLocationRequested?.Invoke();
		}

		private void OnEditLocation(object sender, EventArgs e)
		{
			this.EditLocationRequested?.Invoke();
		}

		private void OnRemoveLocation(object sender, EventArgs e)
		{
			this.RemoveLocationRequested();
		}

		private void OnMouseDoubleclick(object sender, MouseEventArgs e)
		{
			this.OnEditLocation(sender, e);
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Location SelectedLocation
		{
			get
			{
				if (this._lvLocations.SelectedItems.Count == 1)
				{
					return this._lvLocations.SelectedItems[0].Tag as Location;
				}
				else
				{
					return null;
				}
			}

			set
			{
				ListViewItem lvi = this._lvLocations.Items.OfType<ListViewItem>().FirstOrDefault(t => (t.Tag as Location).Name == value.Name);
				if (lvi != null)
				{
					lvi.Selected = true;
				}
			}

		}

		public event Action<Location> SelectedLocationChanged;

		public event Action AddLocationRequested;
		public event Action EditLocationRequested;
		public event Action RemoveLocationRequested;
	}
}
