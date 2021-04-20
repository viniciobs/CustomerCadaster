using System;
using System.Drawing;
using System.Windows.Forms;
using Domain;

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
			Reset();
		}

		#endregion Event Handlers

		private void Populate()
		{
			comboBoxSex.DataSource = Enum.GetValues(typeof(Sex));
			comboBoxDocumentType.DataSource = Enum.GetValues(typeof(DocumentType));
		}

		private new bool Validate()
		{
			var isValid = Validate(labelName, !string.IsNullOrEmpty(textBoxName.Text));
			isValid &= Validate(labelEmail, Validator.ValidateEmail(textBoxEmail.Text));
			isValid &= Validate(labelPhone, Validator.ValidatePhone(textBoxPhone.Text));

			var documentType = (DocumentType)comboBoxDocumentType.SelectedItem;

			if (documentType == DocumentType.CPF)
			{
				isValid &= Validate(labelDocument, Validator.ValidateCPF(textBoxDocument.Text));
			}
			else
			{
				isValid &= Validate(labelDocument, Validator.ValidateCNPJ(textBoxDocument.Text));
			}

			isValid &= Validate(labelPostalCode, Validator.ValidatePostalCode(textBoxPostalCode.Text));

			return isValid;
		}

		private bool Validate(Label label, bool isValid)
		{
			label.ForeColor = isValid ? Color.Black : Color.Red;

			return isValid;
		}

		private void Finish()
		{
			if (!Validate()) return;

			var customer = new Customer()
			{
				Name = textBoxName.Text,
				Email = textBoxEmail.Text,
				BirthDate = dateTimePickerBirthDate.Value,
				DocumentType = (DocumentType)comboBoxDocumentType.SelectedItem,
				Document = textBoxDocument.Text,
				Phone = textBoxPhone.Text,
				Sex = (Sex)comboBoxSex.SelectedItem,
				PostalCode = textBoxPostalCode.Text,
				State = textBoxState.Text,
				City = textBoxCity.Text,
				Burgh = textBoxNeighbor.Text,
				Street = textBoxStreet.Text,
				Number = textBoxNumber.Text,
				Complement = textBoxComplement.Text
			};
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
			textBoxNeighbor.Text = string.Empty;
			textBoxStreet.Text = string.Empty;
			textBoxNumber.Text = string.Empty;
			textBoxComplement.Text = string.Empty;
		}

		#endregion Methods
	}
}