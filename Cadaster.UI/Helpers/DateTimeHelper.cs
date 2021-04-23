using System;

namespace Cadaster.UI.Helpers
{
	public static class DateTimeHelper
	{
		#region Methods

		public static DateTime ToInitial(this DateTime d)
		{
			return new DateTime(d.Year, d.Month, d.Day, 0, 0, 0);
		}

		#endregion Methods
	}
}