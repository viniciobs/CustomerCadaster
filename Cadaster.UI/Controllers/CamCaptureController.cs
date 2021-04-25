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
		private ICamCapture owner;

		#endregion Fields

		#region Constructor

		public CamCaptureController(ICamCapture owner, ref PictureBox pictureBox, ref Button button, ToolTip toolTip)
		{
			if (owner == null) throw new ArgumentNullException(nameof(owner));
			if (pictureBox == null) throw new ArgumentNullException(nameof(pictureBox));
			if (button == null) throw new ArgumentNullException(nameof(button));
			if (toolTip == null) throw new ArgumentNullException(nameof(toolTip));

			this.owner = owner;
			this.pictureBox = pictureBox;
			this.button = button;
			this.toolTip = toolTip;

			Initialize();
		}

		#endregion Constructor

		#region Methods

		#region EventHandlers

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

		private void button_Click(object sender, EventArgs e)
		{
			Capture();
		}

		#endregion EventHandlers

		private void Initialize()
		{
			capture = new VideoCapture(0, VideoCapture.API.DShow);
			button.Click += button_Click;
		}

		public void Start()
		{
			DisplayCaptureImageOptiion();

			capture.ImageGrabbed += ImageGrabbed;
			capture.Start();
		}

		private void Capture()
		{
			Stop();
		}

		public void Stop()
		{
			button.Click -= button_Click;

			capture.Stop();
			capture.Dispose();
			capture = null;

			DisplayEnableCameraOption();

			owner.Stop();
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