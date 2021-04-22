
namespace Cadaster.UI
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonSearch = new System.Windows.Forms.Button();
			this.textBoxSearch = new System.Windows.Forms.TextBox();
			this.listView = new System.Windows.Forms.ListView();
			this.columnHeaderName = new System.Windows.Forms.ColumnHeader();
			this.columnHeaderEmail = new System.Windows.Forms.ColumnHeader();
			this.columnHeaderDocument = new System.Windows.Forms.ColumnHeader();
			this.labelEmpty = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// buttonSearch
			// 
			this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSearch.Location = new System.Drawing.Point(713, 11);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(75, 23);
			this.buttonSearch.TabIndex = 1;
			this.buttonSearch.Text = "&Search";
			this.buttonSearch.UseVisualStyleBackColor = true;
			// 
			// textBoxSearch
			// 
			this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxSearch.Location = new System.Drawing.Point(12, 12);
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.PlaceholderText = "Search customer";
			this.textBoxSearch.Size = new System.Drawing.Size(695, 23);
			this.textBoxSearch.TabIndex = 0;
			// 
			// listView
			// 
			this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderEmail,
            this.columnHeaderDocument});
			this.listView.HideSelection = false;
			this.listView.Location = new System.Drawing.Point(12, 58);
			this.listView.Name = "listView";
			this.listView.Size = new System.Drawing.Size(776, 380);
			this.listView.TabIndex = 2;
			this.listView.UseCompatibleStateImageBehavior = false;
			// 
			// columnHeaderName
			// 
			this.columnHeaderName.Width = 120;
			// 
			// columnHeaderEmail
			// 
			this.columnHeaderEmail.Width = 100;
			// 
			// labelEmpty
			// 
			this.labelEmpty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelEmpty.BackColor = System.Drawing.Color.White;
			this.labelEmpty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelEmpty.Location = new System.Drawing.Point(21, 216);
			this.labelEmpty.Name = "labelEmpty";
			this.labelEmpty.Size = new System.Drawing.Size(757, 23);
			this.labelEmpty.TabIndex = 3;
			this.labelEmpty.Text = "Empty";
			this.labelEmpty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.labelEmpty);
			this.Controls.Add(this.listView);
			this.Controls.Add(this.textBoxSearch);
			this.Controls.Add(this.buttonSearch);
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.Text = "Customers";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonSearch;
		private System.Windows.Forms.TextBox textBoxSearch;
		private System.Windows.Forms.ListView listView;
		private System.Windows.Forms.Label labelEmpty;
		private System.Windows.Forms.ColumnHeader columnHeaderName;
		private System.Windows.Forms.ColumnHeader columnHeaderEmail;
		private System.Windows.Forms.ColumnHeader columnHeaderDocument;
	}
}