using System;
using System.Threading;
using System.Windows.Forms;

namespace Cadaster.UI
{
	public partial class ProgressForm : Form
	{
		#region Fields

		private readonly MethodInvoker method;

		#endregion Fields

		#region Constructor

		public ProgressForm(MethodInvoker action)
		{
			InitializeComponent();
			StartPosition = FormStartPosition.CenterParent;

			if (action == null) throw new ArgumentNullException(nameof(action));
			method = action;
		}

		#endregion Constructor

		#region Methods

		#region Event handlers

		private void ProgressForm_Load(object sender, EventArgs e)
		{
			new Thread(() => { method.Invoke(); InvokeAction(this, Dispose); }).Start();
		}

		#endregion Event handlers

		public static void InvokeAction(Control control, MethodInvoker action)
		{
			if (control.InvokeRequired)
			{
				control.BeginInvoke(action);
			}
			else
			{
				action();
			}
		}

		#endregion Methods
	}
}