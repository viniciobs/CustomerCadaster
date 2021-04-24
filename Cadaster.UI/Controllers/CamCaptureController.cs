using Emgu.CV;
using Emgu.CV.Util;
using Emgu.CV.Structure;
using System;
using Cadaster.UI.Helpers;
using System.Windows.Forms;

namespace Cadaster.UI
{
	public class CamCaptureController
	{
		#region Fields

		private VideoCapture capture;
		private PictureBox pictureBox;

		#endregion Fields

		#region Constructor

		public CamCaptureController(PictureBox pictureBox)
		{
			this.pictureBox = pictureBox;

			capture = new VideoCapture(0, VideoCapture.API.DShow);
			capture.ImageGrabbed += ImageGrabbed;
		}

		#endregion Constructor

		#region Methods

		private void ImageGrabbed(object sender, EventArgs e)
		{
			if (capture == null) return;

			var buffer = new VectorOfByte();
			var frame = new Mat();

			capture.Retrieve(frame);

			var input = frame.ToImage<Bgr, byte>();

			CvInvoke.Imencode(".bmp", input, buffer);

			var bytes = buffer.ToArray();

			pictureBox.Image = bytes.ToImage();
		}

		public void Start()
		{
			capture.Start();
		}

		public void Stop()
		{
			capture.Stop();
			capture.Dispose();
		}

		#endregion Methods
	}
}