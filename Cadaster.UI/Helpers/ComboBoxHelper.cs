using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Cadaster.UI.Helpers
{
	public static class ComboBoxHelper
	{
		#region Inner types

		public class ComboBoxItem
		{
			#region Properties

			public object Value { get; set; }

			public string Text { get; set; }

			#endregion Properties

			#region Methods

			public override string ToString()
			{
				return Text;
			}

			#endregion Methods
		}

		#endregion Inner types

		#region Methods

		public static void Populate<T>(this ComboBox comboBox) where T : Enum
		{
			var items = new List<ComboBoxItem>();
			items.Add(new ComboBoxItem() { Value = null, Text = string.Empty });

			foreach (var item in Enum.GetValues(typeof(T)))
			{
				items.Add(new ComboBoxItem() { Value = (int)item, Text = item.ToString() });
			}

			comboBox.BeginUpdate();

			comboBox.Items.Clear();
			comboBox.Items.AddRange(items.ToArray());

			comboBox.EndUpdate();

			comboBox.SelectedIndex = 0;
		}

		public static Nullable<T> GetSelectedItem<T>(this ComboBox comboBox) where T : struct, IConvertible
		{
			var item = (ComboBoxItem)comboBox.SelectedItem;
			if (item?.Text == null) return null;

			if (Enum.TryParse<T>(item.Text, out T result)) return result;

			return null;
		}

		#endregion Methods
	}
}