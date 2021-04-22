using Cadaster.UI.Helpers;
using Domain;
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

		private void contextMenuStrip_Click(object sender, EventArgs e)
		{
		}

		private void buttonShow_Click(object sender, EventArgs e)
		{
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
					customers = context.Customer.AsEnumerable().Where(x => x.Document.OnlyNumbers() == term.OnlyNumbers() || x.Name.ToUpper().Contains(term.ToUpper())).ToArray();
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
			if (!customers.Any()) return;

			var items = new List<ListViewItem>();

			foreach (var customer in customers)
			{
				items.Add(new ListViewItem(new string[] { customer.Name, customer.Email, customer.Document }));
			}

			listView.BeginUpdate();
			listView.Items.Clear();
			listView.Items.AddRange(items.ToArray());
			listView.EndUpdate();
		}

		#endregion Methods
	}
}