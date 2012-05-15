namespace TechNetProductKeyManager
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
			this.ProductList = new System.Windows.Forms.ListBox();
			this.ProductName = new System.Windows.Forms.TextBox();
			this.Key = new System.Windows.Forms.TextBox();
			this.CloseForm = new System.Windows.Forms.Button();
			this.AddKey = new System.Windows.Forms.Button();
			this.Import = new System.Windows.Forms.Button();
			this.OpenFile = new System.Windows.Forms.OpenFileDialog();
			this.SuspendLayout();
			// 
			// ProductList
			// 
			this.ProductList.FormattingEnabled = true;
			this.ProductList.Location = new System.Drawing.Point(13, 13);
			this.ProductList.Name = "ProductList";
			this.ProductList.Size = new System.Drawing.Size(238, 134);
			this.ProductList.TabIndex = 0;
			this.ProductList.SelectedIndexChanged += new System.EventHandler(this.ProductList_SelectedIndexChanged);
			// 
			// ProductName
			// 
			this.ProductName.Location = new System.Drawing.Point(13, 154);
			this.ProductName.Name = "ProductName";
			this.ProductName.Size = new System.Drawing.Size(238, 20);
			this.ProductName.TabIndex = 1;
			// 
			// Key
			// 
			this.Key.Location = new System.Drawing.Point(13, 181);
			this.Key.Name = "Key";
			this.Key.Size = new System.Drawing.Size(238, 20);
			this.Key.TabIndex = 2;
			// 
			// CloseForm
			// 
			this.CloseForm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CloseForm.Location = new System.Drawing.Point(175, 208);
			this.CloseForm.Name = "CloseForm";
			this.CloseForm.Size = new System.Drawing.Size(75, 23);
			this.CloseForm.TabIndex = 3;
			this.CloseForm.Text = "Close";
			this.CloseForm.UseVisualStyleBackColor = true;
			this.CloseForm.Click += new System.EventHandler(this.Close_Click);
			// 
			// AddKey
			// 
			this.AddKey.Location = new System.Drawing.Point(94, 208);
			this.AddKey.Name = "AddKey";
			this.AddKey.Size = new System.Drawing.Size(75, 23);
			this.AddKey.TabIndex = 3;
			this.AddKey.Text = "Add Key";
			this.AddKey.UseVisualStyleBackColor = true;
			this.AddKey.Click += new System.EventHandler(this.AddKey_Click);
			// 
			// Import
			// 
			this.Import.Location = new System.Drawing.Point(13, 208);
			this.Import.Name = "Import";
			this.Import.Size = new System.Drawing.Size(75, 23);
			this.Import.TabIndex = 3;
			this.Import.Text = "Import";
			this.Import.UseVisualStyleBackColor = true;
			this.Import.Click += new System.EventHandler(this.Import_Click);
			// 
			// OpenFile
			// 
			this.OpenFile.Filter = "Product Key File|*.xml";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.CloseForm;
			this.ClientSize = new System.Drawing.Size(264, 242);
			this.Controls.Add(this.Import);
			this.Controls.Add(this.AddKey);
			this.Controls.Add(this.CloseForm);
			this.Controls.Add(this.Key);
			this.Controls.Add(this.ProductName);
			this.Controls.Add(this.ProductList);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "TechNet Product Key Manager";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ProductList;
        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.TextBox Key;
        private System.Windows.Forms.Button CloseForm;
        private System.Windows.Forms.Button AddKey;
        private System.Windows.Forms.Button Import;
        private System.Windows.Forms.OpenFileDialog OpenFile;
    }
}

