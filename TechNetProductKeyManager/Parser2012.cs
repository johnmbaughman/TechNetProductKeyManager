using System;
using System.Linq;
using System.Xml.Linq;

namespace TechNetProductKeyManager {
	internal class Parser2012 {

		public Parser2012() { }

		public static void Parse(XDocument document, string password) {
			var keys = document.Descendants(Utility.Format2012Header).Descendants().Where(x => x.Name == Utility.Format2012Element);
			if (keys.Count() > 0) {
				foreach (var productKey in keys) {
					string productName = Utility.GetAttributeValue(productKey.Attribute("Name"), string.Empty);
					foreach (var key in productKey.Elements("Key")) {
						var productTable = new ProductKey();
						var newKey = new {
							Name = productName,
							KeyType = Utility.GetAttributeValue(key.Attribute("Type"), string.Empty),
							Key = Security.Encrypt(Utility.GetElementValue(key, string.Empty), password),
							ClaimedDate = DateTime.Parse(Utility.ReformatDate(Utility.GetAttributeValue(key.Attribute("ClaimeDate"), "1/1/1900"), '/', '-'))
						};

						productTable.Insert(newKey);
					}
				}
			}
			return;
		}
	}
}