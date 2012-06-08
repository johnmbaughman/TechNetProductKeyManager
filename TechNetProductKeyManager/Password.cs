using System;
using System.Windows.Forms;

namespace TechNetProductKeyManager {
	public partial class Password : Form {

		public Password() {
			InitializeComponent();
		}

		public bool IsLogin { get; set; }

		private void Ok_Click(object sender, EventArgs e) {
			if (!IsLogin) {
				User.SetPassword(passwordText.Text);
				this.DialogResult = System.Windows.Forms.DialogResult.OK;
			}

			if (IsLogin) {
				if (Security.VerifyHash(passwordText.Text, Security.HashAlgorithm.SHA384, User.GetPassword())) {
					this.DialogResult = System.Windows.Forms.DialogResult.OK;
				}
				else {
					this.DialogResult = System.Windows.Forms.DialogResult.No;
				}
			}
		}
	}
}