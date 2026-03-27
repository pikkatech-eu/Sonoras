namespace Sonoras.UI.WinForms
{
	partial class GazetteerDevice
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this._tlpUserControl = new TableLayoutPanel();
			this._lvLocations = new ListView();
			this.LocationName = new ColumnHeader();
			this.Latitude = new ColumnHeader();
			this.Longitude = new ColumnHeader();
			this.TimeZone = new ColumnHeader();
			this._cmsLocations = new ContextMenuStrip(this.components);
			this.addToolStripMenuItem = new ToolStripMenuItem();
			this.editToolStripMenuItem = new ToolStripMenuItem();
			this.removeToolStripMenuItem = new ToolStripMenuItem();
			this._tlpUserControl.SuspendLayout();
			this._cmsLocations.SuspendLayout();
			this.SuspendLayout();
			// 
			// _tlpUserControl
			// 
			this._tlpUserControl.BackColor = SystemColors.Control;
			this._tlpUserControl.ColumnCount = 2;
			this._tlpUserControl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			this._tlpUserControl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 1F));
			this._tlpUserControl.Controls.Add(this._lvLocations, 0, 0);
			this._tlpUserControl.Dock = DockStyle.Fill;
			this._tlpUserControl.ForeColor = SystemColors.WindowText;
			this._tlpUserControl.Location = new Point(0, 0);
			this._tlpUserControl.Margin = new Padding(0);
			this._tlpUserControl.Name = "_tlpUserControl";
			this._tlpUserControl.RowCount = 2;
			this._tlpUserControl.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			this._tlpUserControl.RowStyles.Add(new RowStyle(SizeType.Absolute, 1F));
			this._tlpUserControl.Size = new Size(544, 531);
			this._tlpUserControl.TabIndex = 0;
			// 
			// _lvLocations
			// 
			this._lvLocations.Columns.AddRange(new ColumnHeader[] { this.LocationName, this.Latitude, this.Longitude, this.TimeZone });
			this._lvLocations.ContextMenuStrip = this._cmsLocations;
			this._lvLocations.Dock = DockStyle.Fill;
			this._lvLocations.Font = new Font("Segoe UI", 9F);
			this._lvLocations.FullRowSelect = true;
			this._lvLocations.Location = new Point(3, 3);
			this._lvLocations.Name = "_lvLocations";
			this._lvLocations.Size = new Size(537, 524);
			this._lvLocations.TabIndex = 0;
			this._lvLocations.UseCompatibleStateImageBehavior = false;
			this._lvLocations.View = View.Details;
			this._lvLocations.SelectedIndexChanged += this.OnSelectedLocationChanged;
			this._lvLocations.MouseDoubleClick += this.OnMouseDoubleclick;
			// 
			// LocationName
			// 
			this.LocationName.Text = "Name";
			// 
			// Latitude
			// 
			this.Latitude.Text = "Latitude";
			// 
			// Longitude
			// 
			this.Longitude.Text = "Longitude";
			// 
			// TimeZone
			// 
			this.TimeZone.Text = "Time Zone";
			// 
			// _cmsLocations
			// 
			this._cmsLocations.ImageScalingSize = new Size(20, 20);
			this._cmsLocations.Items.AddRange(new ToolStripItem[] { this.addToolStripMenuItem, this.editToolStripMenuItem, this.removeToolStripMenuItem });
			this._cmsLocations.Name = "_cmsLocations";
			this._cmsLocations.Size = new Size(194, 76);
			// 
			// addToolStripMenuItem
			// 
			this.addToolStripMenuItem.Name = "addToolStripMenuItem";
			this.addToolStripMenuItem.Size = new Size(193, 24);
			this.addToolStripMenuItem.Text = "&Add Location";
			this.addToolStripMenuItem.Click += this.OnAddLocation;
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new Size(193, 24);
			this.editToolStripMenuItem.Text = "&Edit Location";
			this.editToolStripMenuItem.Click += this.OnEditLocation;
			// 
			// removeToolStripMenuItem
			// 
			this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
			this.removeToolStripMenuItem.Size = new Size(193, 24);
			this.removeToolStripMenuItem.Text = "&Remove Location";
			this.removeToolStripMenuItem.Click += this.OnRemoveLocation;
			// 
			// GazetteerDevice
			// 
			this.AutoScaleDimensions = new SizeF(9F, 20F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(0, 48, 96);
			this.Controls.Add(this._tlpUserControl);
			this.Font = new Font("Consolas", 10F);
			this.ForeColor = Color.White;
			this.Margin = new Padding(0);
			this.Name = "GazetteerDevice";
			this.Size = new Size(544, 531);
			this._tlpUserControl.ResumeLayout(false);
			this._cmsLocations.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel _tlpUserControl;
		private ListView _lvLocations;
		private ColumnHeader LocationName;
		private ColumnHeader Latitude;
		private ColumnHeader Longitude;
		private ColumnHeader TimeZone;
		private ContextMenuStrip _cmsLocations;
		private ToolStripMenuItem addToolStripMenuItem;
		private ToolStripMenuItem editToolStripMenuItem;
		private ToolStripMenuItem removeToolStripMenuItem;
	}
}
