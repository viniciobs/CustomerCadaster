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

		private Action<object, EventArgs> _button_click;

		#endregion Fields

		#region Properties

		private bool isCapture
		{
			get
			{
				return (bool)button.Tag;
			}
		}

		#endregion Properties

		#region Constructor

		public CamCaptureController(PictureBox pictureBox, Button button, ToolTip toolTip, Action<object, EventArgs> buttonClick)
		{
			if (pictureBox == null) throw new ArgumentNullException(nameof(pictureBox));
			if (button == null) throw new ArgumentNullException(nameof(button));
			if (toolTip == null) throw new ArgumentNullException(nameof(toolTip));
			if (buttonClick == null) throw new ArgumentNullException(nameof(buttonClick));

			this.pictureBox = pictureBox;
			this.button = button;
			this.toolTip = toolTip;
			_button_click = buttonClick;

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
			if (isCapture)
			{
				Capture();
			}
			else
			{
				Start();
			}
		}

		#endregion EventHandlers

		private void Initialize()
		{
			capture = new VideoCapture(0, VideoCapture.API.DShow);

			button.Click -= (sender, e) => _button_click(sender, e);
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
			capture.ImageGrabbed -= ImageGrabbed;
			capture.Stop();

			DisplayEnableCameraOption();
		}

		public void Stop()
		{
			button.Click -= button_Click;

			capture.Stop();
			capture.Dispose();

			DisplayEnableCameraOption();

			button.Click += (sender, e) => _button_click(sender, e);
		}

		private void DisplayEnableCameraOption()
		{
			toolTip.SetToolTip(button, Resources.EnableDeviceCamera);
			button.BackgroundImage = Resources.Camera;
			button.Tag = false;
		}

		private void DisplayCaptureImageOptiion()
		{
			toolTip.SetToolTip(button, Resources.CaptureImage);
			button.BackgroundImage = Resources.Capture;
			button.Tag = true;
		}

		#endregion Methods
	}
}