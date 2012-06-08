using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TechNetProductKeyManager {
	public partial class MainForm : Form {
		private bool loadingList = false;

		public MainForm() {
			InitializeComponent();
			LoadProducts();
		}

		private void AddKey_Click(object sender, EventArgs e) {
			AddKey addKey = new AddKey();
			addKey.ShowDialog(this);
		}

		private void Import_Click(object sender, EventArgs e) {
			bool continueImport = true;
			if (!User.UserCheck()) {
				Password password = new Password {
					IsLogin = false
				};
				continueImport = (password.ShowDialog() == System.Windows.Forms.DialogResult.OK);
			}

			if (continueImport) {
				if (OpenFile.ShowDialog() != DialogResult.Cancel) {
					ImportKeyFile.Import(OpenFile.FileName, User.GetPassword());
					LoadProducts();
				}
			}
		}

		private void Close_Click(object sender, EventArgs e) {
			Application.Exit();
		}

		private void LoadProducts() {
			loadingList = true;
			ProductList.DataSource = null;
			List<ProductKey> products = ProductKey.GetProducts();
			ProductList.DataSource = products;
			ProductList.DisplayMember = "Name";
			ProductList.ValueMember = "Id";
			loadingList = false;
		}

		private void ProductList_SelectedIndexChanged(object sender, EventArgs e) {
			if (!loadingList) {
				ProductName.Text = ProductList.Text;
				Key.Text = ProductKey.GetProductKey((int)ProductList.SelectedValue);
			}
		}
	}
}