using Emgu.CV;
using Emgu.CV.Util;
using Emgu.CV.Structure;
using System;
using Cadaster.UI.Helpers;
using System.Windows.Forms;
using Cadaster.UI.Properties;

namespace Cadaster.UI
{
	public class CamCaptureController
	{
		#region Fields

		private VideoCapture capture;
		private PictureBox pictureBox;
		private Button button;
		private ToolTip toolTip;

		#endregion Fields

		#region Constructor

		public CamCaptureController(PictureBox pictureBox, Button button, ToolTip toolTip)
		{
			if (pictureBox == null) throw new ArgumentNullException(nameof(pictureBox));
			if (button == null) throw new ArgumentNullException(nameof(button));
			if (toolTip == null) throw new ArgumentNullException(nameof(toolTip));

			this.pictureBox = pictureBox;
			this.button = button;
			this.toolTip = toolTip;

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

			DisplayCaptureImageOptiion();
		}

		public void Stop()
		{
			capture.Stop();
			capture.Dispose();

			DisplayEnableCameraOption();
		}

		private void DisplayEnableCameraOption()
		{
			toolTip.SetToolTip(button, Resources.EnableDeviceCamera);
			button.BackgroundImage = Resources.Camera;
		}

		private void DisplayCaptureImageOptiion()
		{
			toolTip.SetToolTip(button, Resources.CaptureImage);
			button.BackgroundImage = Resources.Capture;
		}

		#endregion Methods
	}
}