﻿namespace ImageView
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
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.panelInfo = new System.Windows.Forms.Panel();
			this.labelSize = new System.Windows.Forms.Label();
			this.labelIndex = new System.Windows.Forms.Label();
			this.panelPicture = new System.Windows.Forms.Panel();
			this.labelEdited = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.panelInfo.SuspendLayout();
			this.panelPicture.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox
			// 
			this.pictureBox.ImageLocation = "C:\\Users\\Kai\\Pictures\\cosmic brain.jpg";
			this.pictureBox.Location = new System.Drawing.Point(0, 0);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(600, 399);
			this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox.TabIndex = 0;
			this.pictureBox.TabStop = false;
			// 
			// panelInfo
			// 
			this.panelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelInfo.Controls.Add(this.labelEdited);
			this.panelInfo.Controls.Add(this.labelIndex);
			this.panelInfo.Controls.Add(this.labelSize);
			this.panelInfo.Location = new System.Drawing.Point(0, 452);
			this.panelInfo.Name = "panelInfo";
			this.panelInfo.Size = new System.Drawing.Size(842, 35);
			this.panelInfo.TabIndex = 1;
			// 
			// labelSize
			// 
			this.labelSize.AutoSize = true;
			this.labelSize.Location = new System.Drawing.Point(4, 0);
			this.labelSize.Name = "labelSize";
			this.labelSize.Size = new System.Drawing.Size(42, 20);
			this.labelSize.TabIndex = 0;
			this.labelSize.Text = "0 x 0";
			// 
			// labelIndex
			// 
			this.labelIndex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelIndex.AutoSize = true;
			this.labelIndex.Location = new System.Drawing.Point(360, 0);
			this.labelIndex.Name = "labelIndex";
			this.labelIndex.Size = new System.Drawing.Size(39, 20);
			this.labelIndex.TabIndex = 1;
			this.labelIndex.Text = "0 / 0";
			this.labelIndex.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// panelPicture
			// 
			this.panelPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelPicture.AutoScroll = true;
			this.panelPicture.Controls.Add(this.pictureBox);
			this.panelPicture.Location = new System.Drawing.Point(8, 8);
			this.panelPicture.Name = "panelPicture";
			this.panelPicture.Size = new System.Drawing.Size(834, 427);
			this.panelPicture.TabIndex = 2;
			// 
			// labelEdited
			// 
			this.labelEdited.AutoSize = true;
			this.labelEdited.Dock = System.Windows.Forms.DockStyle.Right;
			this.labelEdited.Location = new System.Drawing.Point(687, 0);
			this.labelEdited.Name = "labelEdited";
			this.labelEdited.Size = new System.Drawing.Size(155, 20);
			this.labelEdited.TabIndex = 3;
			this.labelEdited.Text = "01/01/2000 12:00:00";
			this.labelEdited.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(842, 480);
			this.Controls.Add(this.panelPicture);
			this.Controls.Add(this.panelInfo);
			this.Name = "MainForm";
			this.Text = "ImageView";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.panelInfo.ResumeLayout(false);
			this.panelInfo.PerformLayout();
			this.panelPicture.ResumeLayout(false);
			this.panelPicture.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.Panel panelInfo;
		private System.Windows.Forms.Label labelIndex;
		private System.Windows.Forms.Label labelSize;
		private System.Windows.Forms.Panel panelPicture;
		private System.Windows.Forms.Label labelEdited;
	}
}

