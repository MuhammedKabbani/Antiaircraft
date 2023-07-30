namespace PresentaionLayer
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.panelInfo = new DevExpress.XtraEditors.PanelControl();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.lblTimer = new DevExpress.XtraEditors.LabelControl();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.panelHome = new DevExpress.XtraEditors.PanelControl();
			this.panelBoard = new DevExpress.XtraEditors.PanelControl();
			this.lblScore = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize)(this.panelInfo)).BeginInit();
			this.panelInfo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.panelHome)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.panelBoard)).BeginInit();
			this.SuspendLayout();
			// 
			// panelInfo
			// 
			this.panelInfo.Controls.Add(this.lblScore);
			this.panelInfo.Controls.Add(this.labelControl3);
			this.panelInfo.Controls.Add(this.lblTimer);
			this.panelInfo.Controls.Add(this.labelControl1);
			this.panelInfo.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelInfo.Location = new System.Drawing.Point(0, 0);
			this.panelInfo.Name = "panelInfo";
			this.panelInfo.Size = new System.Drawing.Size(1167, 113);
			this.panelInfo.TabIndex = 0;
			// 
			// labelControl3
			// 
			this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
			this.labelControl3.Appearance.Options.UseFont = true;
			this.labelControl3.Location = new System.Drawing.Point(868, 60);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(80, 40);
			this.labelControl3.TabIndex = 2;
			this.labelControl3.Text = "Score";
			// 
			// lblTimer
			// 
			this.lblTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblTimer.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
			this.lblTimer.Appearance.Options.UseFont = true;
			this.lblTimer.Appearance.Options.UseTextOptions = true;
			this.lblTimer.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.lblTimer.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.lblTimer.Location = new System.Drawing.Point(987, 14);
			this.lblTimer.Name = "lblTimer";
			this.lblTimer.Size = new System.Drawing.Size(114, 30);
			this.lblTimer.TabIndex = 1;
			this.lblTimer.Text = "0:00";
			// 
			// labelControl1
			// 
			this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
			this.labelControl1.Appearance.Options.UseFont = true;
			this.labelControl1.Location = new System.Drawing.Point(868, 9);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(72, 40);
			this.labelControl1.TabIndex = 0;
			this.labelControl1.Text = "Time";
			// 
			// panelHome
			// 
			this.panelHome.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelHome.Location = new System.Drawing.Point(0, 487);
			this.panelHome.Name = "panelHome";
			this.panelHome.Size = new System.Drawing.Size(1167, 64);
			this.panelHome.TabIndex = 1;
			// 
			// panelBoard
			// 
			this.panelBoard.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelBoard.Location = new System.Drawing.Point(0, 113);
			this.panelBoard.Name = "panelBoard";
			this.panelBoard.Size = new System.Drawing.Size(1167, 374);
			this.panelBoard.TabIndex = 2;
			// 
			// lblScore
			// 
			this.lblScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblScore.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
			this.lblScore.Appearance.Options.UseFont = true;
			this.lblScore.Appearance.Options.UseTextOptions = true;
			this.lblScore.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.lblScore.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.lblScore.Location = new System.Drawing.Point(987, 65);
			this.lblScore.Name = "lblScore";
			this.lblScore.Size = new System.Drawing.Size(114, 30);
			this.lblScore.TabIndex = 3;
			this.lblScore.Text = "0";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1167, 551);
			this.Controls.Add(this.panelBoard);
			this.Controls.Add(this.panelHome);
			this.Controls.Add(this.panelInfo);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "Aircraft Game";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.panelInfo)).EndInit();
			this.panelInfo.ResumeLayout(false);
			this.panelInfo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.panelHome)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.panelBoard)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.PanelControl panelInfo;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.LabelControl lblTimer;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.PanelControl panelHome;
		private DevExpress.XtraEditors.PanelControl panelBoard;
		private DevExpress.XtraEditors.LabelControl lblScore;
	}
}

