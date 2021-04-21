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

		public async Task<object> Execute()
		{
			progressBar.Value = 0;

			var progress = new Progress<int>(value => { progressBar.Value = value; });

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