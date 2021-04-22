﻿using System;
using System.Drawing;
using System.Windows.Forms;
using Domain;
using Cadaster.UI.Helpers;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;

namespace Cadaster.UI
{
	public partial class CadasterForm : Form
	{
		#region Properties

		public Customer Customer { get; set; }

		#endregion Properties

		#region Constructor

		public CadasterForm()
		{
			InitializeComponent();
		}

		#endregion Constructor

		#region Methods

		#region Event Handlers

		private void buttonSave_Click(object sender, EventArgs e)
		{
			Finish();
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			var result = MessageBox.Show("Are you sure you want to cancel?", "Confirm", MessageBoxButtons.YesNo);

			if (result == DialogResult.Yes)
			{
				Reset();
			}
		}

		private void buttonSearchPostalCode_Click(object sender, EventArgs e)
		{
			FindAddress();
		}

		private void textBoxPostalCode_Enter(object sender, EventArgs e)
		{
			AcceptButton = buttonSearchPostalCode;
		}

		private void textBoxPostalCode_Leave(object sender, EventArgs e)
		{
			AcceptButton = buttonSave;
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			Populate();
		}

		#endregion Event Handlers

		private void Populate()
		{
			textBoxName.Text = Customer.Name;
			textBoxEmail.Text = Customer.Email;
			textBoxPhone.Text = Customer.Phone;
			textBoxDocument.Text = Customer.Document;

			comboBoxSex.Populate<Sex>();
			comboBoxDocumentType.Populate<DocumentType>();

			textBoxPostalCode.Text = Customer.PostalCode;
			textBoxState.Text = Customer.State;
			textBoxCity.Text = Customer.City;
			textBoxBurgh.Text = Customer.Burgh;
			textBoxStreet.Text = Customer.Street;
			textBoxNumber.Text = Customer.Number;
			textBoxComplement.Text = Customer.Complement;

			textBoxNumber.Enabled = string.IsNullOrEmpty(Customer.City);
			textBoxComplement.Enabled = string.IsNullOrEmpty(Customer.City);
		}

		private new bool Validate()
		{
			var validation = new Validation();

			validation.Validate(labelName, !string.IsNullOrEmpty(textBoxName.Text));
			validation.Validate(labelEmail, Validator.ValidateEmail(textBoxEmail.Text));
			validation.Validate(labelPhone, Validator.ValidatePhone(textBoxPhone.Text));
			validation.Validate(labelSex, comboBoxSex.GetSelectedItem<Sex>() != null);

			var documentType = comboBoxDocumentType.GetSelectedItem<DocumentType>();

			validation.Validate(labelDocumentType, documentType != null);

			if (documentType != null)
			{
				if (documentType == DocumentType.CPF)
				{
					validation.Validate(labelDocument, Validator.ValidateCPF(textBoxDocument.Text));
				}
				else
				{
					validation.Validate(labelDocument, Validator.ValidateCNPJ(textBoxDocument.Text));
				}
			}

			validation.Validate(labelPostalCode, Validator.ValidatePostalCode(textBoxPostalCode.Text));
			validation.Validate(labelState, !string.IsNullOrEmpty(textBoxState.Text));
			validation.Validate(labelCity, !string.IsNullOrEmpty(textBoxCity.Text));
			validation.Validate(labelBurgh, !string.IsNullOrEmpty(textBoxBurgh.Text));
			validation.Validate(labelStreet, !string.IsNullOrEmpty(textBoxStreet.Text));
			validation.Validate(labelNumber, !string.IsNullOrEmpty(textBoxNumber.Text));

			return validation.IsValid;
		}

		private void Reset()
		{
			Customer = new Customer();

			labelName.ForeColor = Color.Black;
			labelEmail.ForeColor = Color.Black;
			labelPhone.ForeColor = Color.Black;
			labelDocument.ForeColor = Color.Black;
			labelPostalCode.ForeColor = Color.Black;

			Populate();
		}

		private void FindAddress()
		{
			var postalCode = textBoxPostalCode.Text;
			var validation = new Validation();

			validation.Validate(labelPostalCode, Validator.ValidatePostalCode(postalCode));

			if (!validation.IsValid) return;

			Address address = null;

			var form = new ProgressForm(() =>
			{
				var addressController = new AddressController();
				address = addressController.GetAddress(postalCode).Result;
			});

			var result = form.ShowDialog(this);

			if (result == DialogResult.OK)
			{
				PopulateAddress(address);
			}
		}

		private void PopulateAddress(Address address)
		{
			if (address == null) return;

			textBoxState.Text = address.State;
			textBoxCity.Text = address.City;
			textBoxBurgh.Text = address.Burgh;
			textBoxStreet.Text = address.Street;

			textBoxNumber.Enabled = true;
			textBoxComplement.Enabled = true;
		}

		private void Finish()
		{
			if (!Validate()) return;

			var customer = new Customer()
			{
				Name = textBoxName.Text,
				Email = textBoxEmail.Text,
				BirthDate = dateTimePickerBirthDate.Value,
				DocumentType = comboBoxDocumentType.GetSelectedItem<DocumentType>().Value,
				Document = textBoxDocument.Text,
				Phone = textBoxPhone.Text,
				Sex = comboBoxSex.GetSelectedItem<Sex>().Value,
				PostalCode = textBoxPostalCode.Text,
				State = textBoxState.Text,
				City = textBoxCity.Text,
				Burgh = textBoxBurgh.Text,
				Street = textBoxStreet.Text,
				Number = textBoxNumber.Text,
				Complement = textBoxComplement.Text
			};

			var form = new ProgressForm(() =>
			{
				using (var context = new CustomerContext())
				{
					var customerExists = context.Customer.AsEnumerable().Any(x => x.Document.OnlyNumbers() == customer.Document.OnlyNumbers());
					if (customerExists) throw new Exception($"There's already a customer in the database with the document {customer.Document}");

					context.Entry(customer).State = EntityState.Added;
					context.SaveChanges();
				}
			});

			var result = form.ShowDialog(this);

			if (result == DialogResult.OK)
			{
				MessageBox.Show($"Customer \"{customer.Name}\" cadastered successfully", "Success", MessageBoxButtons.OK);
				Reset();
			}
		}

		#endregion Methods
	}
}