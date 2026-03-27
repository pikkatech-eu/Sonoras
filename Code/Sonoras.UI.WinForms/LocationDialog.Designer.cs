namespace Sonoras.UI.WinForms
{
	partial class LocationDialog
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocationDialog));
			this._btOK = new Button();
			this._btCancel = new Button();
			this._tlpLocation = new TableLayoutPanel();
			this.label1 = new Label();
			this.label2 = new Label();
			this.label3 = new Label();
			this.label4 = new Label();
			this.label5 = new Label();
			this.label6 = new Label();
			this._txName = new TextBox();
			this._txLatitude = new TextBox();
			this._txLongitude = new TextBox();
			this._txElevation = new TextBox();
			this._cxTimeZone = new ComboBox();
			this._txDescription = new TextBox();
			this._tlpLocation.SuspendLayout();
			this.SuspendLayout();
			// 
			// _btOK
			// 
			this._btOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			this._btOK.BackColor = SystemColors.Control;
			this._btOK.DialogResult = DialogResult.OK;
			this._btOK.Location = new Point(9, 447);
			this._btOK.Margin = new Padding(0);
			this._btOK.Name = "_btOK";
			this._btOK.Size = new Size(80, 32);
			this._btOK.TabIndex = 0;
			this._btOK.Text = "OK";
			this._btOK.UseVisualStyleBackColor = false;
			// 
			// _btCancel
			// 
			this._btCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			this._btCancel.BackColor = SystemColors.Control;
			this._btCancel.DialogResult = DialogResult.Cancel;
			this._btCancel.Location = new Point(114, 447);
			this._btCancel.Margin = new Padding(0);
			this._btCancel.Name = "_btCancel";
			this._btCancel.Size = new Size(80, 32);
			this._btCancel.TabIndex = 0;
			this._btCancel.Text = "Cancel";
			this._btCancel.UseVisualStyleBackColor = false;
			// 
			// _tlpLocation
			// 
			this._tlpLocation.ColumnCount = 2;
			this._tlpLocation.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 128F));
			this._tlpLocation.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			this._tlpLocation.Controls.Add(this.label1, 0, 0);
			this._tlpLocation.Controls.Add(this.label2, 0, 1);
			this._tlpLocation.Controls.Add(this.label3, 0, 2);
			this._tlpLocation.Controls.Add(this.label4, 0, 3);
			this._tlpLocation.Controls.Add(this.label5, 0, 4);
			this._tlpLocation.Controls.Add(this.label6, 0, 5);
			this._tlpLocation.Controls.Add(this._txName, 1, 0);
			this._tlpLocation.Controls.Add(this._txLatitude, 1, 1);
			this._tlpLocation.Controls.Add(this._txLongitude, 1, 2);
			this._tlpLocation.Controls.Add(this._txElevation, 1, 3);
			this._tlpLocation.Controls.Add(this._cxTimeZone, 1, 4);
			this._tlpLocation.Controls.Add(this._txDescription, 1, 5);
			this._tlpLocation.Dock = DockStyle.Top;
			this._tlpLocation.Location = new Point(0, 0);
			this._tlpLocation.Name = "_tlpLocation";
			this._tlpLocation.RowCount = 7;
			this._tlpLocation.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
			this._tlpLocation.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
			this._tlpLocation.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
			this._tlpLocation.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
			this._tlpLocation.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
			this._tlpLocation.RowStyles.Add(new RowStyle(SizeType.Absolute, 128F));
			this._tlpLocation.RowStyles.Add(new RowStyle());
			this._tlpLocation.Size = new Size(800, 411);
			this._tlpLocation.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = DockStyle.Fill;
			this.label1.Location = new Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new Size(122, 28);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name";
			this.label1.TextAlign = ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = DockStyle.Fill;
			this.label2.Location = new Point(3, 28);
			this.label2.Name = "label2";
			this.label2.Size = new Size(122, 28);
			this.label2.TabIndex = 1;
			this.label2.Text = "Latitude";
			this.label2.TextAlign = ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = DockStyle.Fill;
			this.label3.Location = new Point(3, 56);
			this.label3.Name = "label3";
			this.label3.Size = new Size(122, 28);
			this.label3.TabIndex = 2;
			this.label3.Text = "Longitude";
			this.label3.TextAlign = ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Dock = DockStyle.Fill;
			this.label4.Location = new Point(3, 84);
			this.label4.Name = "label4";
			this.label4.Size = new Size(122, 28);
			this.label4.TabIndex = 3;
			this.label4.Text = "Elevation, m";
			this.label4.TextAlign = ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Dock = DockStyle.Fill;
			this.label5.Location = new Point(3, 112);
			this.label5.Name = "label5";
			this.label5.Size = new Size(122, 32);
			this.label5.TabIndex = 4;
			this.label5.Text = "TimeZone";
			this.label5.TextAlign = ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Dock = DockStyle.Top;
			this.label6.Location = new Point(3, 144);
			this.label6.Name = "label6";
			this.label6.Size = new Size(122, 20);
			this.label6.TabIndex = 5;
			this.label6.Text = "Description";
			this.label6.TextAlign = ContentAlignment.MiddleRight;
			// 
			// _txName
			// 
			this._txName.Dock = DockStyle.Fill;
			this._txName.Location = new Point(131, 3);
			this._txName.Name = "_txName";
			this._txName.Size = new Size(666, 27);
			this._txName.TabIndex = 6;
			// 
			// _txLatitude
			// 
			this._txLatitude.Dock = DockStyle.Fill;
			this._txLatitude.Location = new Point(131, 31);
			this._txLatitude.Name = "_txLatitude";
			this._txLatitude.Size = new Size(666, 27);
			this._txLatitude.TabIndex = 7;
			// 
			// _txLongitude
			// 
			this._txLongitude.Dock = DockStyle.Fill;
			this._txLongitude.Location = new Point(131, 59);
			this._txLongitude.Name = "_txLongitude";
			this._txLongitude.Size = new Size(666, 27);
			this._txLongitude.TabIndex = 8;
			// 
			// _txElevation
			// 
			this._txElevation.Dock = DockStyle.Fill;
			this._txElevation.Location = new Point(131, 87);
			this._txElevation.Name = "_txElevation";
			this._txElevation.Size = new Size(666, 27);
			this._txElevation.TabIndex = 9;
			this._txElevation.Text = "0";
			// 
			// _cxTimeZone
			// 
			this._cxTimeZone.BackColor = SystemColors.ControlLightLight;
			this._cxTimeZone.Dock = DockStyle.Fill;
			this._cxTimeZone.DropDownStyle = ComboBoxStyle.DropDownList;
			this._cxTimeZone.FormattingEnabled = true;
			this._cxTimeZone.Location = new Point(131, 115);
			this._cxTimeZone.Name = "_cxTimeZone";
			this._cxTimeZone.Size = new Size(666, 28);
			this._cxTimeZone.TabIndex = 10;
			// 
			// _txDescription
			// 
			this._txDescription.Dock = DockStyle.Fill;
			this._txDescription.Location = new Point(131, 147);
			this._txDescription.Multiline = true;
			this._txDescription.Name = "_txDescription";
			this._txDescription.Size = new Size(666, 122);
			this._txDescription.TabIndex = 11;
			// 
			// LocationDialog
			// 
			this.AutoScaleDimensions = new SizeF(9F, 20F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = SystemColors.Control;
			this.ClientSize = new Size(800, 488);
			this.Controls.Add(this._tlpLocation);
			this.Controls.Add(this._btCancel);
			this.Controls.Add(this._btOK);
			this.Font = new Font("Consolas", 10F);
			this.ForeColor = SystemColors.WindowText;
			this.Icon = (Icon)resources.GetObject("$this.Icon");
			this.Name = "LocationDialog";
			this.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Location Properties";
			this._tlpLocation.ResumeLayout(false);
			this._tlpLocation.PerformLayout();
			this.ResumeLayout(false);
		}

		#endregion

		private Button _btOK;
		private Button _btCancel;
		private TableLayoutPanel _tlpLocation;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private TextBox _txName;
		private TextBox _txLatitude;
		private TextBox _txLongitude;
		private TextBox _txElevation;
		private ComboBox _cxTimeZone;
		private TextBox _txDescription;
	}
}