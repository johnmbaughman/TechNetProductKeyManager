using Massive.SQLite;

namespace TechNetProductKeyManager {
	internal class User : DynamicModel {

		public User() : base("productkeys", "User") { }

		public static bool UserCheck() {
			User user = new User();
			return user.Count() > 0;
		}

		public static void SetPassword(string password) {
			User user = new User();
			user.Insert(new { Password = Security.ComputeHash(password, Security.HashAlgorithm.SHA384, null) });
		}

		public static string GetPassword() {
			User user = new User();
			var password = user.Single("Password is not null", null);
			return password.Password;
		}
	}
}