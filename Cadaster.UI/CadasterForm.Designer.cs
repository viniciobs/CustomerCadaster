
namespace Cadaster.UI
{
	partial class CadasterForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.labelName = new System.Windows.Forms.Label();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.textBoxEmail = new System.Windows.Forms.TextBox();
			this.labelEmail = new System.Windows.Forms.Label();
			this.textBoxPhone = new System.Windows.Forms.TextBox();
			this.labelPhone = new System.Windows.Forms.Label();
			this.textBoxDocument = new System.Windows.Forms.TextBox();
			this.labelDocument = new System.Windows.Forms.Label();
			this.dateTimePickerBirthDate = new System.Windows.Forms.DateTimePicker();
			this.labelBirthDate = new System.Windows.Forms.Label();
			this.panelPhoto = new System.Windows.Forms.Panel();
			this.buttonEraser = new System.Windows.Forms.Button();
			this.buttonCamera = new System.Windows.Forms.Button();
			this.buttonLoadImage = new System.Windows.Forms.Button();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.textBoxPostalCode = new System.Windows.Forms.TextBox();
			this.labelPostalCode = new System.Windows.Forms.Label();
			this.textBoxStreet = new System.Windows.Forms.TextBox();
			this.labelStreet = new System.Windows.Forms.Label();
			this.textBoxCity = new System.Windows.Forms.TextBox();
			this.labelState = new System.Windows.Forms.Label();
			this.labelCity = new System.Windows.Forms.Label();
			this.labelBurgh = new System.Windows.Forms.Label();
			this.textBoxBurgh = new System.Windows.Forms.TextBox();
			this.labelNumber = new System.Windows.Forms.Label();
			this.labelComplement = new System.Windows.Forms.Label();
			this.textBoxNumber = new System.Windows.Forms.TextBox();
			this.textBoxComplement = new System.Windows.Forms.TextBox();
			this.labelSex = new System.Windows.Forms.Label();
			this.comboBoxSex = new System.Windows.Forms.ComboBox();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.textBoxState = new System.Windows.Forms.TextBox();
			this.buttonSearchPostalCode = new System.Windows.Forms.Button();
			this.labelDocumentType = new System.Windows.Forms.Label();
			this.comboBoxDocumentType = new System.Windows.Forms.ComboBox();
			this.textBoxStateRegistration = new System.Windows.Forms.TextBox();
			this.labelStateRegistration = new System.Windows.Forms.Label();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.panelPhoto.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// labelName
			// 
			this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(26, 22);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(45, 15);
			this.labelName.TabIndex = 0;
			this.labelName.Text = "Name :";
			// 
			// textBoxName
			// 
			this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxName.Location = new System.Drawing.Point(26, 40);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(372, 23);
			this.textBoxName.TabIndex = 1;
			// 
			// textBoxEmail
			// 
			this.textBoxEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxEmail.Location = new System.Drawing.Point(26, 144);
			this.textBoxEmail.Name = "textBoxEmail";
			this.textBoxEmail.Size = new System.Drawing.Size(372, 23);
			this.textBoxEmail.TabIndex = 3;
			// 
			// labelEmail
			// 
			this.labelEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelEmail.AutoSize = true;
			this.labelEmail.Location = new System.Drawing.Point(26, 126);
			this.labelEmail.Name = "labelEmail";
			this.labelEmail.Size = new System.Drawing.Size(47, 15);
			this.labelEmail.TabIndex = 2;
			this.labelEmail.Text = "E-mail :";
			// 
			// textBoxPhone
			// 
			this.textBoxPhone.Location = new System.Drawing.Point(26, 197);
			this.textBoxPhone.Name = "textBoxPhone";
			this.textBoxPhone.Size = new System.Drawing.Size(148, 23);
			this.textBoxPhone.TabIndex = 4;
			// 
			// labelPhone
			// 
			this.labelPhone.AutoSize = true;
			this.labelPhone.Location = new System.Drawing.Point(26, 179);
			this.labelPhone.Name = "labelPhone";
			this.labelPhone.Size = new System.Drawing.Size(47, 15);
			this.labelPhone.TabIndex = 4;
			this.labelPhone.Text = "Phone :";
			// 
			// textBoxDocument
			// 
			this.textBoxDocument.Location = new System.Drawing.Point(180, 252);
			this.textBoxDocument.Name = "textBoxDocument";
			this.textBoxDocument.Size = new System.Drawing.Size(218, 23);
			this.textBoxDocument.TabIndex = 8;
			// 
			// labelDocument
			// 
			this.labelDocument.AutoSize = true;
			this.labelDocument.Location = new System.Drawing.Point(180, 234);
			this.labelDocument.Name = "labelDocument";
			this.labelDocument.Size = new System.Drawing.Size(69, 15);
			this.labelDocument.TabIndex = 6;
			this.labelDocument.Text = "Document :";
			// 
			// dateTimePickerBirthDate
			// 
			this.dateTimePickerBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerBirthDate.Location = new System.Drawing.Point(252, 197);
			this.dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
			this.dateTimePickerBirthDate.Size = new System.Drawing.Size(146, 23);
			this.dateTimePickerBirthDate.TabIndex = 6;
			// 
			// labelBirthDate
			// 
			this.labelBirthDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelBirthDate.AutoSize = true;
			this.labelBirthDate.Location = new System.Drawing.Point(252, 179);
			this.labelBirthDate.Name = "labelBirthDate";
			this.labelBirthDate.Size = new System.Drawing.Size(61, 15);
			this.labelBirthDate.TabIndex = 10;
			this.labelBirthDate.Text = "Birthdate :";
			// 
			// panelPhoto
			// 
			this.panelPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.panelPhoto.Controls.Add(this.buttonEraser);
			this.panelPhoto.Controls.Add(this.buttonCamera);
			this.panelPhoto.Controls.Add(this.buttonLoadImage);
			this.panelPhoto.Controls.Add(this.pictureBox);
			this.panelPhoto.Location = new System.Drawing.Point(415, 22);
			this.panelPhoto.Name = "panelPhoto";
			this.panelPhoto.Size = new System.Drawing.Size(200, 253);
			this.panelPhoto.TabIndex = 11;
			// 
			// buttonEraser
			// 
			this.buttonEraser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonEraser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.buttonEraser.BackgroundImage = global::Cadaster.UI.Properties.Resources.Eraser;
			this.buttonEraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonEraser.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonEraser.FlatAppearance.BorderSize = 0;
			this.buttonEraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonEraser.Location = new System.Drawing.Point(123, 230);
			this.buttonEraser.Margin = new System.Windows.Forms.Padding(0);
			this.buttonEraser.Name = "buttonEraser";
			this.buttonEraser.Size = new System.Drawing.Size(29, 19);
			this.buttonEraser.TabIndex = 14;
			this.buttonEraser.UseVisualStyleBackColor = true;
			this.buttonEraser.Click += new System.EventHandler(this.buttonEraser_Click);
			// 
			// buttonCamera
			// 
			this.buttonCamera.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCamera.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.buttonCamera.BackgroundImage = global::Cadaster.UI.Properties.Resources.Camera;
			this.buttonCamera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonCamera.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonCamera.FlatAppearance.BorderSize = 0;
			this.buttonCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonCamera.Location = new System.Drawing.Point(97, 229);
			this.buttonCamera.Margin = new System.Windows.Forms.Padding(0);
			this.buttonCamera.Name = "buttonCamera";
			this.buttonCamera.Size = new System.Drawing.Size(22, 22);
			this.buttonCamera.TabIndex = 13;
			this.buttonCamera.UseVisualStyleBackColor = true;
			this.buttonCamera.Click += new System.EventHandler(this.buttonCamera_Click);
			// 
			// buttonLoadImage
			// 
			this.buttonLoadImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonLoadImage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.buttonLoadImage.BackColor = System.Drawing.Color.Transparent;
			this.buttonLoadImage.BackgroundImage = global::Cadaster.UI.Properties.Resources.Folder;
			this.buttonLoadImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonLoadImage.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonLoadImage.FlatAppearance.BorderSize = 0;
			this.buttonLoadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonLoadImage.Location = new System.Drawing.Point(70, 232);
			this.buttonLoadImage.Margin = new System.Windows.Forms.Padding(0);
			this.buttonLoadImage.Name = "buttonLoadImage";
			this.buttonLoadImage.Size = new System.Drawing.Size(20, 17);
			this.buttonLoadImage.TabIndex = 12;
			this.buttonLoadImage.UseVisualStyleBackColor = false;
			this.buttonLoadImage.Click += new System.EventHandler(this.buttonLoadImage_Click);
			// 
			// pictureBox
			// 
			this.pictureBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.pictureBox.Location = new System.Drawing.Point(0, 0);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(200, 227);
			this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox.TabIndex = 0;
			this.pictureBox.TabStop = false;
			// 
			// textBoxPostalCode
			// 
			this.textBoxPostalCode.Location = new System.Drawing.Point(26, 308);
			this.textBoxPostalCode.Name = "textBoxPostalCode";
			this.textBoxPostalCode.Size = new System.Drawing.Size(114, 23);
			this.textBoxPostalCode.TabIndex = 9;
			this.textBoxPostalCode.Enter += new System.EventHandler(this.textBoxPostalCode_Enter);
			this.textBoxPostalCode.Leave += new System.EventHandler(this.textBoxPostalCode_Leave);
			// 
			// labelPostalCode
			// 
			this.labelPostalCode.AutoSize = true;
			this.labelPostalCode.Location = new System.Drawing.Point(26, 290);
			this.labelPostalCode.Name = "labelPostalCode";
			this.labelPostalCode.Size = new System.Drawing.Size(74, 15);
			this.labelPostalCode.TabIndex = 12;
			this.labelPostalCode.Text = "Postal code :";
			// 
			// textBoxStreet
			// 
			this.textBoxStreet.Enabled = false;
			this.textBoxStreet.Location = new System.Drawing.Point(26, 361);
			this.textBoxStreet.Name = "textBoxStreet";
			this.textBoxStreet.Size = new System.Drawing.Size(221, 23);
			this.textBoxStreet.TabIndex = 16;
			// 
			// labelStreet
			// 
			this.labelStreet.AutoSize = true;
			this.labelStreet.Location = new System.Drawing.Point(26, 343);
			this.labelStreet.Name = "labelStreet";
			this.labelStreet.Size = new System.Drawing.Size(43, 15);
			this.labelStreet.TabIndex = 15;
			this.labelStreet.Text = "Street :";
			// 
			// textBoxCity
			// 
			this.textBoxCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxCity.Enabled = false;
			this.textBoxCity.Location = new System.Drawing.Point(274, 308);
			this.textBoxCity.Name = "textBoxCity";
			this.textBoxCity.Size = new System.Drawing.Size(124, 23);
			this.textBoxCity.TabIndex = 17;
			// 
			// labelState
			// 
			this.labelState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelState.AutoSize = true;
			this.labelState.Location = new System.Drawing.Point(211, 290);
			this.labelState.Name = "labelState";
			this.labelState.Size = new System.Drawing.Size(39, 15);
			this.labelState.TabIndex = 18;
			this.labelState.Text = "State :";
			// 
			// labelCity
			// 
			this.labelCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelCity.AutoSize = true;
			this.labelCity.Location = new System.Drawing.Point(274, 290);
			this.labelCity.Name = "labelCity";
			this.labelCity.Size = new System.Drawing.Size(34, 15);
			this.labelCity.TabIndex = 19;
			this.labelCity.Text = "City :";
			// 
			// labelBurgh
			// 
			this.labelBurgh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelBurgh.AutoSize = true;
			this.labelBurgh.Location = new System.Drawing.Point(404, 290);
			this.labelBurgh.Name = "labelBurgh";
			this.labelBurgh.Size = new System.Drawing.Size(45, 15);
			this.labelBurgh.TabIndex = 21;
			this.labelBurgh.Text = "Burgh :";
			// 
			// textBoxBurgh
			// 
			this.textBoxBurgh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxBurgh.Enabled = false;
			this.textBoxBurgh.Location = new System.Drawing.Point(404, 308);
			this.textBoxBurgh.Name = "textBoxBurgh";
			this.textBoxBurgh.Size = new System.Drawing.Size(211, 23);
			this.textBoxBurgh.TabIndex = 20;
			// 
			// labelNumber
			// 
			this.labelNumber.AutoSize = true;
			this.labelNumber.Location = new System.Drawing.Point(252, 343);
			this.labelNumber.Name = "labelNumber";
			this.labelNumber.Size = new System.Drawing.Size(57, 15);
			this.labelNumber.TabIndex = 24;
			this.labelNumber.Text = "Number :";
			// 
			// labelComplement
			// 
			this.labelComplement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelComplement.AutoSize = true;
			this.labelComplement.Location = new System.Drawing.Point(365, 343);
			this.labelComplement.Name = "labelComplement";
			this.labelComplement.Size = new System.Drawing.Size(83, 15);
			this.labelComplement.TabIndex = 25;
			this.labelComplement.Text = "Complement :";
			// 
			// textBoxNumber
			// 
			this.textBoxNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxNumber.Enabled = false;
			this.textBoxNumber.Location = new System.Drawing.Point(252, 362);
			this.textBoxNumber.Name = "textBoxNumber";
			this.textBoxNumber.Size = new System.Drawing.Size(105, 23);
			this.textBoxNumber.TabIndex = 10;
			// 
			// textBoxComplement
			// 
			this.textBoxComplement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxComplement.Enabled = false;
			this.textBoxComplement.Location = new System.Drawing.Point(365, 361);
			this.textBoxComplement.Name = "textBoxComplement";
			this.textBoxComplement.Size = new System.Drawing.Size(250, 23);
			this.textBoxComplement.TabIndex = 11;
			// 
			// labelSex
			// 
			this.labelSex.AutoSize = true;
			this.labelSex.Location = new System.Drawing.Point(180, 178);
			this.labelSex.Name = "labelSex";
			this.labelSex.Size = new System.Drawing.Size(31, 15);
			this.labelSex.TabIndex = 28;
			this.labelSex.Text = "Sex :";
			// 
			// comboBoxSex
			// 
			this.comboBoxSex.FormattingEnabled = true;
			this.comboBoxSex.Location = new System.Drawing.Point(180, 196);
			this.comboBoxSex.Name = "comboBoxSex";
			this.comboBoxSex.Size = new System.Drawing.Size(66, 23);
			this.comboBoxSex.TabIndex = 5;
			// 
			// buttonSave
			// 
			this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSave.Location = new System.Drawing.Point(459, 408);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(75, 23);
			this.buttonSave.TabIndex = 12;
			this.buttonSave.Text = "&Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCancel.Location = new System.Drawing.Point(540, 408);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 14;
			this.buttonCancel.Text = "&Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// textBoxState
			// 
			this.textBoxState.Enabled = false;
			this.textBoxState.Location = new System.Drawing.Point(211, 308);
			this.textBoxState.MaxLength = 2;
			this.textBoxState.Name = "textBoxState";
			this.textBoxState.Size = new System.Drawing.Size(57, 23);
			this.textBoxState.TabIndex = 32;
			// 
			// buttonSearchPostalCode
			// 
			this.buttonSearchPostalCode.Location = new System.Drawing.Point(140, 308);
			this.buttonSearchPostalCode.Name = "buttonSearchPostalCode";
			this.buttonSearchPostalCode.Size = new System.Drawing.Size(57, 23);
			this.buttonSearchPostalCode.TabIndex = 33;
			this.buttonSearchPostalCode.TabStop = false;
			this.buttonSearchPostalCode.Text = "Search";
			this.buttonSearchPostalCode.UseVisualStyleBackColor = true;
			this.buttonSearchPostalCode.Click += new System.EventHandler(this.buttonSearchPostalCode_Click);
			// 
			// labelDocumentType
			// 
			this.labelDocumentType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelDocumentType.AutoSize = true;
			this.labelDocumentType.Location = new System.Drawing.Point(26, 234);
			this.labelDocumentType.Name = "labelDocumentType";
			this.labelDocumentType.Size = new System.Drawing.Size(95, 15);
			this.labelDocumentType.TabIndex = 35;
			this.labelDocumentType.Text = "Document type :";
			// 
			// comboBoxDocumentType
			// 
			this.comboBoxDocumentType.FormattingEnabled = true;
			this.comboBoxDocumentType.Location = new System.Drawing.Point(26, 252);
			this.comboBoxDocumentType.Name = "comboBoxDocumentType";
			this.comboBoxDocumentType.Size = new System.Drawing.Size(148, 23);
			this.comboBoxDocumentType.TabIndex = 7;
			// 
			// textBoxStateRegistration
			// 
			this.textBoxStateRegistration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxStateRegistration.Location = new System.Drawing.Point(26, 92);
			this.textBoxStateRegistration.Name = "textBoxStateRegistration";
			this.textBoxStateRegistration.Size = new System.Drawing.Size(372, 23);
			this.textBoxStateRegistration.TabIndex = 2;
			// 
			// labelStateRegistration
			// 
			this.labelStateRegistration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelStateRegistration.AutoSize = true;
			this.labelStateRegistration.Location = new System.Drawing.Point(26, 74);
			this.labelStateRegistration.Name = "labelStateRegistration";
			this.labelStateRegistration.Size = new System.Drawing.Size(102, 15);
			this.labelStateRegistration.TabIndex = 36;
			this.labelStateRegistration.Text = "State registration :";
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog";
			// 
			// CadasterForm
			// 
			this.AcceptButton = this.buttonSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(643, 447);
			this.Controls.Add(this.textBoxStateRegistration);
			this.Controls.Add(this.labelStateRegistration);
			this.Controls.Add(this.labelDocumentType);
			this.Controls.Add(this.comboBoxDocumentType);
			this.Controls.Add(this.buttonSearchPostalCode);
			this.Controls.Add(this.textBoxState);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.comboBoxSex);
			this.Controls.Add(this.labelSex);
			this.Controls.Add(this.textBoxComplement);
			this.Controls.Add(this.textBoxNumber);
			this.Controls.Add(this.labelComplement);
			this.Controls.Add(this.labelNumber);
			this.Controls.Add(this.labelBurgh);
			this.Controls.Add(this.textBoxBurgh);
			this.Controls.Add(this.labelCity);
			this.Controls.Add(this.labelState);
			this.Controls.Add(this.textBoxCity);
			this.Controls.Add(this.textBoxStreet);
			this.Controls.Add(this.labelStreet);
			this.Controls.Add(this.textBoxPostalCode);
			this.Controls.Add(this.labelPostalCode);
			this.Controls.Add(this.panelPhoto);
			this.Controls.Add(this.labelBirthDate);
			this.Controls.Add(this.dateTimePickerBirthDate);
			this.Controls.Add(this.textBoxDocument);
			this.Controls.Add(this.labelDocument);
			this.Controls.Add(this.textBoxPhone);
			this.Controls.Add(this.labelPhone);
			this.Controls.Add(this.textBoxEmail);
			this.Controls.Add(this.labelEmail);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.labelName);
			this.MaximizeBox = false;
			this.Name = "CadasterForm";
			this.ShowIcon = false;
			this.Text = "Customer";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CadasterForm_FormClosing);
			this.panelPhoto.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.TextBox textBoxEmail;
		private System.Windows.Forms.Label labelEmail;
		private System.Windows.Forms.TextBox textBoxPhone;
		private System.Windows.Forms.Label labelPhone;
		private System.Windows.Forms.TextBox textBoxDocument;
		private System.Windows.Forms.Label labelDocument;
		private System.Windows.Forms.DateTimePicker dateTimePickerBirthDate;
		private System.Windows.Forms.Label labelBirthDate;
		private System.Windows.Forms.Panel panelPhoto;
		private System.Windows.Forms.TextBox textBoxPostalCode;
		private System.Windows.Forms.Label labelPostalCode;
		private System.Windows.Forms.TextBox textBoxStreet;
		private System.Windows.Forms.Label labelStreet;
		private System.Windows.Forms.TextBox textBoxCity;
		private System.Windows.Forms.Label labelState;
		private System.Windows.Forms.Label labelCity;
		private System.Windows.Forms.TextBox textBoxBurgh;
		private System.Windows.Forms.Label labelBurgh;
		private System.Windows.Forms.Label labelNumber;
		private System.Windows.Forms.Label labelComplement;
		private System.Windows.Forms.TextBox textBoxNumber;
		private System.Windows.Forms.TextBox textBoxComplement;
		private System.Windows.Forms.Label labelSex;
		private System.Windows.Forms.ComboBox comboBoxSex;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.TextBox textBoxState;
		private System.Windows.Forms.Button buttonSearchPostalCode;
		private System.Windows.Forms.Label labelDocumentType;
		private System.Windows.Forms.ComboBox comboBoxDocumentType;		
		private System.Windows.Forms.TextBox textBoxStateRegistration;
		private System.Windows.Forms.Label labelStateRegistration;
		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.Button buttonLoadImage;
		private System.Windows.Forms.Button buttonCamera;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.Button buttonEraser;
	}
}

