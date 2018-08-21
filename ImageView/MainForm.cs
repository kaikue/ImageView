using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageView
{
	public partial class MainForm : Form
	{
		private int zoomPercent = 100;

		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			LoadPicture();
		}

		private void LoadPicture()
		{
			SetSize();
			SetTitle();
			SetText();
		}

		private void SetSize()
		{
			//int marginX = pictureBox.Location.X;
			//int marginY = pictureBox.Location.Y;
			//Size minSize = new Size(pictureBox.Width + 2 * marginX, pictureBox.Height + 2 * marginY);
			//Size maxSize = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
			MinimumSize = new Size(230, 150);

			int fullWidth = pictureBox.Size.Width;
			int fullHeight = pictureBox.Size.Height;
			int width = Math.Min(fullWidth, Screen.PrimaryScreen.Bounds.Width);
			int height = Math.Min(fullHeight, Screen.PrimaryScreen.Bounds.Height);
			Size = new Size(width, height);
		}

		private void SetTitle()
		{
			string url = pictureBox.ImageLocation;
			Text = "ImageView - " + url;
		}

		private void SetText()
		{
			labelSize.Text = pictureBox.Size.Width + " x " + pictureBox.Size.Height
				+ " (" + zoomPercent + "%)";

			labelIndex.Text = "0 / 0";

			DateTime lastModified = System.IO.File.GetLastWriteTime(pictureBox.ImageLocation);
			labelEdited.Text = lastModified.ToString("G");
		}
	}
}
