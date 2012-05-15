using System;
using System.Windows.Forms;

namespace TechNetProductKeyManager {
	internal static class Program {

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		private static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			if (Login()) {
				Application.Run(new MainForm());
			}
		}

		private static bool Login() {
			bool continueLogin = true;
			if (!User.UserCheck()) {
				Password password = new Password {
					IsLogin = false
				};
				continueLogin = (password.ShowDialog() == System.Windows.Forms.DialogResult.OK);
			}

			if (continueLogin) {
				Password password = new Password {
					IsLogin = true
				};
				if (password.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
					return true;
				}
			}
			return false;
		}
	}
}