using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadaster.UI
{
	public partial class ProgressForm : Form
	{
		#region Fields

		private Func<object> func;

		#endregion Fields

		#region Constructor

		public ProgressForm(Func<object> func)
		{
			this.func = func;

			InitializeComponent();
		}

		#endregion Constructor

		#region Methods

		private async Task<object> Execute()
		{
			try
			{
				return await Task.Run(() => func.Invoke());
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK);
			}

			return null;
		}

		#endregion Methods
	}
}