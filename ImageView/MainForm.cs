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
		private int zoomLevel = 0;
		private Image baseImage;

		public MainForm(string arg)
		{
			InitializeComponent();
			SetImageURL(arg);
		}

		private void SetImageURL(string url)
		{
			pictureBox.ImageLocation = url;
			pictureBox.Image = Image.FromFile(url);
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			MinimumSize = new Size(230, 150);
			SetTitle();
			SetText();
		}

		private void PictureBox_Load(object sender, AsyncCompletedEventArgs e)
		{
			baseImage = pictureBox.Image;
			SetSize();
		}

		private void SetSize()
		{
			//int marginX = pictureBox.Location.X;
			//int marginY = pictureBox.Location.Y;
			//Size minSize = new Size(pictureBox.Width + 2 * marginX, pictureBox.Height + 2 * marginY);
			//Size maxSize = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
			
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
			int zoomPercent = GetZoomPercent();
			labelSize.Text = pictureBox.Size.Width + " x " + pictureBox.Size.Height
				+ " (" + zoomPercent + "%)";

			labelIndex.Text = "0 / 0";

			DateTime lastModified = System.IO.File.GetLastWriteTime(pictureBox.ImageLocation);
			labelEdited.Text = lastModified.ToString("G");
		}

		public void MainForm_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (int)Keys.Escape)
			{
				Close();
				return;
			}

			Console.WriteLine((int)e.KeyChar);

			if (e.KeyChar == 45) //minus
			{
				ZoomOut();
				return;
			}

			if (e.KeyChar == 61) //plus
			{
				ZoomIn();
				return;
			}
		}

		private void ZoomOut()
		{
			Zoom(-1);
		}

		private void ZoomIn()
		{
			Zoom(1);
		}

		private void Zoom(int addition)
		{
			zoomLevel += addition;

			double zoom = GetZoomPercent() / 100.0;
			int zoomWidth = Math.Max((int)(baseImage.Size.Width * zoom), 10);
			int zoomHeight = Math.Max((int)(baseImage.Size.Height * zoom), 10);
			Size zoomSize = new Size(zoomWidth, zoomHeight);
			Image zoomImage = new Bitmap(baseImage, zoomSize);
			pictureBox.Image = zoomImage;

			SetSize();
			SetText();
		}
		
		private int GetZoomPercent()
		{
			return (int)(100 * Math.Pow(1.1, zoomLevel));
		}
		
	}
}
