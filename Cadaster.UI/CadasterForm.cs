using System;
using System.Drawing;
using System.Windows.Forms;
using Domain;
using Cadaster.UI.Helpers;
using Microsoft.EntityFrameworkCore;

namespace Cadaster.UI
{
	public partial class CadasterForm : Form
	{
		#region Constructor

		public CadasterForm()
		{
			InitializeComponent();

			Populate();
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

		#endregion Event Handlers

		private void Populate()
		{
			comboBoxSex.Populate<Sex>();
			comboBoxDocumentType.Populate<DocumentType>();
		}

		private new bool Validate()
		{
			var isValid = Validate(labelName, !string.IsNullOrEmpty(textBoxName.Text));
			isValid &= Validate(labelEmail, Validator.ValidateEmail(textBoxEmail.Text));
			isValid &= Validate(labelPhone, Validator.ValidatePhone(textBoxPhone.Text));
			isValid &= Validate(labelSex, comboBoxSex.GetSelectedItem<Sex>() != null);

			var documentType = comboBoxDocumentType.GetSelectedItem<DocumentType>();

			isValid &= Validate(labelDocumentType, documentType != null);

			if (isValid)
			{
				if (documentType == DocumentType.CPF)
				{
					isValid &= Validate(labelDocument, Validator.ValidateCPF(textBoxDocument.Text));
				}
				else
				{
					isValid &= Validate(labelDocument, Validator.ValidateCNPJ(textBoxDocument.Text));
				}
			}

			isValid &= Validate(labelPostalCode, Validator.ValidatePostalCode(textBoxPostalCode.Text));
			isValid &= Validate(labelState, !string.IsNullOrEmpty(textBoxState.Text));
			isValid &= Validate(labelCity, !string.IsNullOrEmpty(textBoxCity.Text));
			isValid &= Validate(labelBurgh, !string.IsNullOrEmpty(textBoxBurgh.Text));
			isValid &= Validate(labelStreet, !string.IsNullOrEmpty(textBoxStreet.Text));
			isValid &= Validate(labelNumber, !string.IsNullOrEmpty(textBoxNumber.Text));

			return isValid;
		}

		private bool Validate(Label label, bool isValid)
		{
			label.ForeColor = isValid ? Color.Black : Color.Red;

			return isValid;
		}

		private void Reset()
		{
			labelName.ForeColor = Color.Black;
			textBoxName.Text = string.Empty;

			labelEmail.ForeColor = Color.Black;
			textBoxEmail.Text = string.Empty;

			labelPhone.ForeColor = Color.Black;
			textBoxPhone.Text = string.Empty;

			labelDocument.ForeColor = Color.Black;
			textBoxDocument.Text = string.Empty;

			labelPostalCode.ForeColor = Color.Black;
			textBoxPostalCode.Text = string.Empty;

			textBoxState.Text = string.Empty;
			textBoxCity.Text = string.Empty;
			textBoxBurgh.Text = string.Empty;
			textBoxStreet.Text = string.Empty;

			textBoxNumber.Enabled = false;
			textBoxNumber.Text = string.Empty;

			textBoxComplement.Enabled = false;
			textBoxComplement.Text = string.Empty;

			comboBoxSex.Populate<Sex>();
			comboBoxDocumentType.Populate<DocumentType>();
		}

		private async void FindAddress()
		{
			var postalCode = textBoxPostalCode.Text;
			if (!Validate(labelPostalCode, Validator.ValidatePostalCode(postalCode))) return;

			var addressController = new AddressController();
			var address = await addressController.GetAddress(postalCode);

			PopulateAddress(address);
		}

		private void PopulateAddress(Address address)
		{
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

			try
			{
				using (var context = new CustomerContext())
				{
					context.Entry(customer).State = EntityState.Added;
					context.SaveChanges();
				}

				MessageBox.Show($"Customer \"{customer.Name}\" cadastered successfully", "Error", MessageBoxButtons.OK);
				Reset();
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK);
			}
		}

		#endregion Methods
	}
}