using Cadaster.UI.Helpers;
using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Cadaster.UI
{
	public partial class MainForm : Form
	{
		#region Constructor

		public MainForm()
		{
			InitializeComponent();
		}

		#endregion Constructor

		#region Methods

		#region Event Handlers

		private void buttonSearch_Click(object sender, EventArgs e)
		{
			var term = textBoxSearch.Text;
			if (string.IsNullOrEmpty(term)) return;

			Search(term);
		}

		private void listView_DoubleClick(object sender, EventArgs e)
		{
			ShowCustomer();
		}

		private void buttonShow_Click(object sender, EventArgs e)
		{
			ShowCustomer();
		}

		private void contextMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
		{
			var hasCustomerSelected = listView.SelectedItems.Count > 0;

			toolStripMenuItemDelete.Enabled = hasCustomerSelected;
			toolStripMenuItemShow.Enabled = hasCustomerSelected;
		}

		private void buttonCadaster_Click(object sender, EventArgs e)
		{
			var customer = new Customer();
			var form = new CadasterForm();
			form.Customer = customer;

			form.ShowDialog();
		}

		#endregion Event Handlers

		private void Search(string term)
		{
			var customers = new Customer[0];

			var form = new ProgressForm(() =>
			{
				using (var context = new CustomerContext())
				{
					customers = context.Customer.AsNoTracking().AsEnumerable().Where(x => x.Document.OnlyNumbers() == term.OnlyNumbers() || x.Name.ToUpper().Contains(term.ToUpper())).ToArray();
				}
			});

			var result = form.ShowDialog(this);

			if (result == DialogResult.OK)
			{
				labelEmpty.Visible = !customers.Any();

				Populate(customers);
			}
		}

		private void Populate(Customer[] customers)
		{
			listView.Items.Clear();
			if (!customers.Any()) return;

			var items = new List<ListViewItem>();

			foreach (var customer in customers)
			{
				var item = new ListViewItem();
				item.Text = customer.Name;
				item.Tag = customer;
				item.SubItems.AddRange(new string[] { customer.Email, customer.Document });
				items.Add(item);
			}

			listView.Items.AddRange(items.ToArray());
		}

		private void ShowCustomer()
		{
			var selected = listView.SelectedItems.Cast<ListViewItem>().FirstOrDefault();
			if (selected == null) return;

			var form = new CadasterForm();
			form.Customer = (Customer)selected.Tag;

			form.Show();
		}

		#endregion Methods
	}
}