using System;
using System.Windows.Forms;

namespace Cadaster.UI
{
	internal static class Program
	{
		#region Methods

		[STAThread]
		private static void Main()
		{
			Application.SetHighDpiMode(HighDpiMode.SystemAware);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}

		#endregion Methods
	}
}