﻿/*
 * Creato da SharpDevelop.
 * Utente: Riccardo
 * Data: 27/01/2008
 * Ora: 16.01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PortAudioSharp.PortAudioSharp
{
	partial class NoDevicesDeviceControl
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the control.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.settingsGroupBox = new System.Windows.Forms.GroupBox();
			this.inputTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.inputDeviceLabel = new System.Windows.Forms.Label();
			this.settingsGroupBox.SuspendLayout();
			this.inputTableLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// settingsGroupBox
			// 
			this.settingsGroupBox.Controls.Add(this.inputTableLayoutPanel);
			this.settingsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.settingsGroupBox.Location = new System.Drawing.Point(0, 0);
			this.settingsGroupBox.Name = "settingsGroupBox";
			this.settingsGroupBox.Size = new System.Drawing.Size(250, 195);
			this.settingsGroupBox.TabIndex = 2;
			this.settingsGroupBox.TabStop = false;
			// 
			// inputTableLayoutPanel
			// 
			this.inputTableLayoutPanel.ColumnCount = 3;
			this.inputTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
			this.inputTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.inputTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
			this.inputTableLayoutPanel.Controls.Add(this.inputDeviceLabel, 1, 0);
			this.inputTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.inputTableLayoutPanel.Location = new System.Drawing.Point(3, 16);
			this.inputTableLayoutPanel.Name = "inputTableLayoutPanel";
			this.inputTableLayoutPanel.RowCount = 7;
			this.inputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
			this.inputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
			this.inputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
			this.inputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
			this.inputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
			this.inputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
			this.inputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
			this.inputTableLayoutPanel.Size = new System.Drawing.Size(244, 176);
			this.inputTableLayoutPanel.TabIndex = 0;
			// 
			// inputDeviceLabel
			// 
			this.inputDeviceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.inputDeviceLabel.Location = new System.Drawing.Point(18, 8);
			this.inputDeviceLabel.Name = "inputDeviceLabel";
			this.inputDeviceLabel.Size = new System.Drawing.Size(208, 18);
			this.inputDeviceLabel.TabIndex = 3;
			this.inputDeviceLabel.Text = "No devices found";
			// 
			// NoDevicesDeviceControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.settingsGroupBox);
			this.Name = "NoDevicesDeviceControl";
			this.Size = new System.Drawing.Size(250, 195);
			this.settingsGroupBox.ResumeLayout(false);
			this.inputTableLayoutPanel.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.GroupBox settingsGroupBox;
		private System.Windows.Forms.Label inputDeviceLabel;
		private System.Windows.Forms.TableLayoutPanel inputTableLayoutPanel;
	}
}
