using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cadaster.UI
{
	public class Validation
	{
		#region Properties

		public bool IsValid { get; private set; }

		#endregion Properties

		#region Constructor

		public Validation()
		{
			IsValid = true;
		}

		#endregion Constructor

		#region Methods

		public void Validate(Label label, bool isValid)
		{
			label.ForeColor = isValid ? Color.Black : Color.Red;
			IsValid &= isValid;
		}

		#endregion Methods
	}
}