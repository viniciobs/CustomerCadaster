using System.Text.RegularExpressions;

namespace Cadaster.UI.Helpers
{
	public static class StringHelper
	{
		#region Methods

		public static string OnlyNumbers(this string text)
		{
			return Regex.Replace(text, @"\D+", string.Empty);
		}

		#endregion Methods
	}
}