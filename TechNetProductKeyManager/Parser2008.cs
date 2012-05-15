using System;
using System.Linq;
using System.Xml.Linq;

namespace TechNetProductKeyManager {
	internal class Parser2008 {

		public Parser2008() { }

		public static void Parse(XDocument document, string password) {
			var keys = document.Descendants(Utility.Format2008Header).Descendants().Where(x => x.Name == Utility.Format2008Element);
			if (keys.Count() > 0) {
				foreach (var key in keys) {
					var productTable = new ProductKey();
					var productKey = new {
						Name = Utility.GetAttributeValue(key.Attribute("Name"), string.Empty),
						KeyType = Utility.GetAttributeValue(key.Attribute("Key_Type"), string.Empty),
						Key = Security.Encrypt(Utility.GetAttributeValue(key.Attribute("Key"), string.Empty), password),
						ClaimedDate = DateTime.Parse(Utility.GetAttributeValue(key.Attribute("Date_Key_Claimed"), "1900-01-01"))
					};

					productTable.Insert(productKey);
				}
			}
			return;
		}
	}
}