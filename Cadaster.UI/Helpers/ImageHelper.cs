using System.Drawing;
using Cadaster.UI.Properties;
using System.IO;
using System.Drawing.Imaging;

namespace Cadaster.UI.Helpers
{
	public static class ImageHelper
	{
		public static Image ToImage(this byte[] byteArray)
		{
			using (var stream = new MemoryStream(byteArray))
			{
				return Image.FromStream(stream);
			}
		}

		public static Image DefaultImage()
		{
			return Resources.Default;
		}

		public static byte[] ToByteArray(this Image image)
		{
			return null;
		}
	}
}