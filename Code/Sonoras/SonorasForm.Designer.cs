namespace Sonoras
{
	partial class SonorasForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SonorasForm));
			this._msSonoras = new MenuStrip();
			this.gazetteerToolStripMenuItem = new ToolStripMenuItem();
			this.newToolStripMenuItem = new ToolStripMenuItem();
			this.editToolStripMenuItem = new ToolStripMenuItem();
			this.loadToolStripMenuItem = new ToolStripMenuItem();
			this.saveasToolStripMenuItem = new ToolStripMenuItem();
			this._menuItemRecentlyUsedGazetteers = new ToolStripMenuItem();
			this.toolStripSeparator1 = new ToolStripSeparator();
			this.quitToolStripMenuItem = new ToolStripMenuItem();
			this.locationToolStripMenuItem = new ToolStripMenuItem();
			this.addToolStripMenuItem = new ToolStripMenuItem();
			this.editToolStripMenuItem1 = new ToolStripMenuItem();
			this.removeToolStripMenuItem = new ToolStripMenuItem();
			this.toolsToolStripMenuItem = new ToolStripMenuItem();
			this.altitudeCirveToolStripMenuItem = new ToolStripMenuItem();
			this.solarEventsToolStripMenuItem = new ToolStripMenuItem();
			this.settingsToolStripMenuItem = new ToolStripMenuItem();
			this.helpToolStripMenuItem = new ToolStripMenuItem();
			this.aboutToolStripMenuItem = new ToolStripMenuItem();
			this._tsSonoras = new ToolStrip();
			this._btGazetteerNew = new ToolStripButton();
			this.toolStripButton1 = new ToolStripButton();
			this.toolStripButton2 = new ToolStripButton();
			this.toolStripSeparator3 = new ToolStripSeparator();
			this.toolStripButton3 = new ToolStripButton();
			this.toolStripSeparator4 = new ToolStripSeparator();
			this._lblLocation = new ToolStripLabel();
			this.toolStripButton4 = new ToolStripButton();
			this._stsSonoras = new StatusStrip();
			this._scSonoras = new SplitContainer();
			this._ctrlGazetteer = new Sonoras.UI.WinForms.GazetteerDevice();
			this._ctrlTimeService = new Sonoras.UI.WinForms.TimeServiceControl();
			this._msSonoras.SuspendLayout();
			this._tsSonoras.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this._scSonoras).BeginInit();
			this._scSonoras.Panel1.SuspendLayout();
			this._scSonoras.Panel2.SuspendLayout();
			this._scSonoras.SuspendLayout();
			this.SuspendLayout();
			// 
			// _msSonoras
			// 
			this._msSonoras.ImageScalingSize = new Size(20, 20);
			this._msSonoras.Items.AddRange(new ToolStripItem[] { this.gazetteerToolStripMenuItem, this.locationToolStripMenuItem, this.toolsToolStripMenuItem, this.helpToolStripMenuItem });
			this._msSonoras.Location = new Point(0, 0);
			this._msSonoras.Name = "_msSonoras";
			this._msSonoras.Size = new Size(1100, 28);
			this._msSonoras.TabIndex = 0;
			this._msSonoras.Text = "menuStrip1";
			// 
			// gazetteerToolStripMenuItem
			// 
			this.gazetteerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.newToolStripMenuItem, this.editToolStripMenuItem, this.loadToolStripMenuItem, this.saveasToolStripMenuItem, this._menuItemRecentlyUsedGazetteers, this.toolStripSeparator1, this.quitToolStripMenuItem });
			this.gazetteerToolStripMenuItem.Name = "gazetteerToolStripMenuItem";
			this.gazetteerToolStripMenuItem.Size = new Size(87, 24);
			this.gazetteerToolStripMenuItem.Text = "Gazetteer";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
			this.newToolStripMenuItem.Size = new Size(256, 26);
			this.newToolStripMenuItem.Text = "&New";
			this.newToolStripMenuItem.ToolTipText = "Creates new gazetteer";
			this.newToolStripMenuItem.Click += this.OnGazetterNew;
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.E;
			this.editToolStripMenuItem.Size = new Size(256, 26);
			this.editToolStripMenuItem.Text = "&Edit";
			this.editToolStripMenuItem.Click += this.OnGazetteerEdit;
			// 
			// loadToolStripMenuItem
			// 
			this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
			this.loadToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.L;
			this.loadToolStripMenuItem.Size = new Size(256, 26);
			this.loadToolStripMenuItem.Text = "&Load";
			this.loadToolStripMenuItem.ToolTipText = "Opens a gazetteer file";
			this.loadToolStripMenuItem.Click += this.OnGazetteerLoad;
			// 
			// saveasToolStripMenuItem
			// 
			this.saveasToolStripMenuItem.Name = "saveasToolStripMenuItem";
			this.saveasToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
			this.saveasToolStripMenuItem.Size = new Size(256, 26);
			this.saveasToolStripMenuItem.Text = "Save &as";
			this.saveasToolStripMenuItem.ToolTipText = "Saves gazetteer in a new file";
			this.saveasToolStripMenuItem.Click += this.OnGazetteerSaveAs;
			// 
			// _menuItemRecentlyUsedGazetteers
			// 
			this._menuItemRecentlyUsedGazetteers.Name = "_menuItemRecentlyUsedGazetteers";
			this._menuItemRecentlyUsedGazetteers.Size = new Size(256, 26);
			this._menuItemRecentlyUsedGazetteers.Text = "Recently used gazetteers";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new Size(253, 6);
			// 
			// quitToolStripMenuItem
			// 
			this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
			this.quitToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Q;
			this.quitToolStripMenuItem.Size = new Size(256, 26);
			this.quitToolStripMenuItem.Text = "&Quit";
			this.quitToolStripMenuItem.ToolTipText = "Quits program";
			this.quitToolStripMenuItem.Click += this.OnGazetteerQuit;
			// 
			// locationToolStripMenuItem
			// 
			this.locationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.addToolStripMenuItem, this.editToolStripMenuItem1, this.removeToolStripMenuItem });
			this.locationToolStripMenuItem.Name = "locationToolStripMenuItem";
			this.locationToolStripMenuItem.Size = new Size(80, 24);
			this.locationToolStripMenuItem.Text = "Location";
			// 
			// addToolStripMenuItem
			// 
			this.addToolStripMenuItem.Name = "addToolStripMenuItem";
			this.addToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
			this.addToolStripMenuItem.Size = new Size(197, 26);
			this.addToolStripMenuItem.Text = "&Add";
			this.addToolStripMenuItem.ToolTipText = "Add location";
			this.addToolStripMenuItem.Click += this.OnLocationAdd;
			// 
			// editToolStripMenuItem1
			// 
			this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
			this.editToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.E;
			this.editToolStripMenuItem1.Size = new Size(197, 26);
			this.editToolStripMenuItem1.Text = "&Edit";
			this.editToolStripMenuItem1.ToolTipText = "Edit selected location";
			this.editToolStripMenuItem1.Click += this.OnLocationEdit;
			// 
			// removeToolStripMenuItem
			// 
			this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
			this.removeToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.R;
			this.removeToolStripMenuItem.Size = new Size(197, 26);
			this.removeToolStripMenuItem.Text = "&Remove";
			this.removeToolStripMenuItem.ToolTipText = "Delete selected location";
			this.removeToolStripMenuItem.Click += this.OnLocationRemove;
			// 
			// toolsToolStripMenuItem
			// 
			this.toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.altitudeCirveToolStripMenuItem, this.solarEventsToolStripMenuItem, this.settingsToolStripMenuItem });
			this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			this.toolsToolStripMenuItem.Size = new Size(58, 24);
			this.toolsToolStripMenuItem.Text = "&Tools";
			// 
			// altitudeCirveToolStripMenuItem
			// 
			this.altitudeCirveToolStripMenuItem.Name = "altitudeCirveToolStripMenuItem";
			this.altitudeCirveToolStripMenuItem.Size = new Size(191, 26);
			this.altitudeCirveToolStripMenuItem.Text = "&Altitude Cirve";
			// 
			// solarEventsToolStripMenuItem
			// 
			this.solarEventsToolStripMenuItem.Name = "solarEventsToolStripMenuItem";
			this.solarEventsToolStripMenuItem.Size = new Size(191, 26);
			this.solarEventsToolStripMenuItem.Text = "&Solar Events";
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.S;
			this.settingsToolStripMenuItem.Size = new Size(191, 26);
			this.settingsToolStripMenuItem.Text = "&Settings";
			this.settingsToolStripMenuItem.ToolTipText = "Open settings dialog";
			this.settingsToolStripMenuItem.Click += this.OnToolsSettings;
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.aboutToolStripMenuItem });
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new Size(55, 24);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new Size(224, 26);
			this.aboutToolStripMenuItem.Text = "&About";
			this.aboutToolStripMenuItem.Click += this.OnHelpAbout;
			// 
			// _tsSonoras
			// 
			this._tsSonoras.AutoSize = false;
			this._tsSonoras.ImageScalingSize = new Size(20, 20);
			this._tsSonoras.Items.AddRange(new ToolStripItem[] { this._btGazetteerNew, this.toolStripButton1, this.toolStripButton2, this.toolStripSeparator3, this.toolStripButton3, this.toolStripSeparator4, this._lblLocation, this.toolStripButton4 });
			this._tsSonoras.Location = new Point(0, 28);
			this._tsSonoras.Name = "_tsSonoras";
			this._tsSonoras.Size = new Size(1100, 38);
			this._tsSonoras.TabIndex = 1;
			this._tsSonoras.Text = "toolStrip1";
			// 
			// _btGazetteerNew
			// 
			this._btGazetteerNew.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this._btGazetteerNew.Image = Properties.Resources.gazetteer_new_32;
			this._btGazetteerNew.ImageScaling = ToolStripItemImageScaling.None;
			this._btGazetteerNew.ImageTransparentColor = Color.Magenta;
			this._btGazetteerNew.Margin = new Padding(2, 0, 5, 0);
			this._btGazetteerNew.Name = "_btGazetteerNew";
			this._btGazetteerNew.Size = new Size(36, 38);
			this._btGazetteerNew.Text = "toolStripButton1";
			this._btGazetteerNew.ToolTipText = "Creates new gazetteer";
			this._btGazetteerNew.Click += this.OnGazetterNew;
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = Properties.Resources.gazetteer_load_32;
			this.toolStripButton1.ImageScaling = ToolStripItemImageScaling.None;
			this.toolStripButton1.ImageTransparentColor = Color.Magenta;
			this.toolStripButton1.Margin = new Padding(0, 0, 5, 0);
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new Size(36, 38);
			this.toolStripButton1.Text = "toolStripButton1";
			this.toolStripButton1.ToolTipText = "Opens a gazetteer file";
			this.toolStripButton1.Click += this.OnGazetteerLoad;
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton2.Image = Properties.Resources.gazetteer_save_32;
			this.toolStripButton2.ImageScaling = ToolStripItemImageScaling.None;
			this.toolStripButton2.ImageTransparentColor = Color.Magenta;
			this.toolStripButton2.Margin = new Padding(1, 0, 0, 0);
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new Size(36, 38);
			this.toolStripButton2.Text = "toolStripButton2";
			this.toolStripButton2.ToolTipText = "Saves gazetteer in a new file";
			this.toolStripButton2.Click += this.OnGazetteerSaveAs;
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new Size(6, 38);
			// 
			// toolStripButton3
			// 
			this.toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
			this.toolStripButton3.ImageTransparentColor = Color.Magenta;
			this.toolStripButton3.Margin = new Padding(0, 3, 0, 3);
			this.toolStripButton3.Name = "toolStripButton3";
			this.toolStripButton3.Size = new Size(29, 32);
			this.toolStripButton3.Text = "toolStripButton3";
			this.toolStripButton3.ToolTipText = "Opens settings dialog";
			this.toolStripButton3.Click += this.OnToolsSettings;
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new Size(6, 38);
			// 
			// _lblLocation
			// 
			this._lblLocation.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			this._lblLocation.ForeColor = Color.DarkGreen;
			this._lblLocation.Name = "_lblLocation";
			this._lblLocation.Size = new Size(91, 35);
			this._lblLocation.Text = "Location...";
			// 
			// toolStripButton4
			// 
			this.toolStripButton4.Alignment = ToolStripItemAlignment.Right;
			this.toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton4.Image = Properties.Resources.sonoras_close_32;
			this.toolStripButton4.ImageTransparentColor = Color.Magenta;
			this.toolStripButton4.Name = "toolStripButton4";
			this.toolStripButton4.Size = new Size(29, 35);
			this.toolStripButton4.Text = "toolStripButton4";
			this.toolStripButton4.ToolTipText = "Quits program";
			this.toolStripButton4.Click += this.OnGazetteerQuit;
			// 
			// _stsSonoras
			// 
			this._stsSonoras.ImageScalingSize = new Size(20, 20);
			this._stsSonoras.Location = new Point(0, 532);
			this._stsSonoras.Name = "_stsSonoras";
			this._stsSonoras.Size = new Size(1100, 22);
			this._stsSonoras.TabIndex = 2;
			this._stsSonoras.Text = "statusStrip1";
			// 
			// _scSonoras
			// 
			this._scSonoras.Dock = DockStyle.Fill;
			this._scSonoras.Location = new Point(0, 66);
			this._scSonoras.Name = "_scSonoras";
			// 
			// _scSonoras.Panel1
			// 
			this._scSonoras.Panel1.Controls.Add(this._ctrlGazetteer);
			// 
			// _scSonoras.Panel2
			// 
			this._scSonoras.Panel2.Controls.Add(this._ctrlTimeService);
			this._scSonoras.Size = new Size(1100, 466);
			this._scSonoras.SplitterDistance = 365;
			this._scSonoras.TabIndex = 3;
			// 
			// _ctrlGazetteer
			// 
			this._ctrlGazetteer.BackColor = Color.FromArgb(0, 48, 96);
			this._ctrlGazetteer.Dock = DockStyle.Fill;
			this._ctrlGazetteer.Font = new Font("Consolas", 10F);
			this._ctrlGazetteer.ForeColor = Color.White;
			this._ctrlGazetteer.Location = new Point(0, 0);
			this._ctrlGazetteer.Margin = new Padding(0);
			this._ctrlGazetteer.Name = "_ctrlGazetteer";
			this._ctrlGazetteer.Size = new Size(365, 466);
			this._ctrlGazetteer.TabIndex = 0;
			// 
			// _ctrlTimeService
			// 
			this._ctrlTimeService.Dock = DockStyle.Fill;
			this._ctrlTimeService.Location = new Point(0, 0);
			this._ctrlTimeService.Name = "_ctrlTimeService";
			this._ctrlTimeService.Size = new Size(731, 466);
			this._ctrlTimeService.TabIndex = 0;
			// 
			// SonorasForm
			// 
			this.AutoScaleDimensions = new SizeF(8F, 20F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = SystemColors.Window;
			this.ClientSize = new Size(1100, 554);
			this.Controls.Add(this._scSonoras);
			this.Controls.Add(this._stsSonoras);
			this.Controls.Add(this._tsSonoras);
			this.Controls.Add(this._msSonoras);
			this.Icon = (Icon)resources.GetObject("$this.Icon");
			this.MainMenuStrip = this._msSonoras;
			this.Name = "SonorasForm";
			this.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Sonoras 1.0.0.0";
			this._msSonoras.ResumeLayout(false);
			this._msSonoras.PerformLayout();
			this._tsSonoras.ResumeLayout(false);
			this._tsSonoras.PerformLayout();
			this._scSonoras.Panel1.ResumeLayout(false);
			this._scSonoras.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this._scSonoras).EndInit();
			this._scSonoras.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		#endregion

		private MenuStrip _msSonoras;
		private ToolStrip _tsSonoras;
		private ToolStripMenuItem gazetteerToolStripMenuItem;
		private ToolStripMenuItem newToolStripMenuItem;
		private ToolStripMenuItem editToolStripMenuItem;
		private ToolStripMenuItem saveasToolStripMenuItem;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripMenuItem quitToolStripMenuItem;
		private ToolStripMenuItem locationToolStripMenuItem;
		private ToolStripMenuItem addToolStripMenuItem;
		private ToolStripMenuItem editToolStripMenuItem1;
		private ToolStripMenuItem removeToolStripMenuItem;
		private ToolStripMenuItem toolsToolStripMenuItem;
		private ToolStripMenuItem altitudeCirveToolStripMenuItem;
		private ToolStripMenuItem solarEventsToolStripMenuItem;
		private ToolStripMenuItem settingsToolStripMenuItem;
		private ToolStripMenuItem helpToolStripMenuItem;
		private ToolStripMenuItem aboutToolStripMenuItem;
		private StatusStrip _stsSonoras;
		private ToolStripMenuItem loadToolStripMenuItem;
		private SplitContainer _scSonoras;
		private UI.WinForms.GazetteerDevice _ctrlGazetteer;
		private UI.WinForms.TimeServiceControl _ctrlTimeService;
		private ToolStripMenuItem _menuItemRecentlyUsedGazetteers;
		private ToolStripLabel _lblLocation;
		private ToolStripButton _btGazetteerNew;
		private ToolStripButton toolStripButton1;
		private ToolStripButton toolStripButton2;
		private ToolStripSeparator toolStripSeparator3;
		private ToolStripButton toolStripButton3;
		private ToolStripSeparator toolStripSeparator4;
		private ToolStripButton toolStripButton4;
	}
}
