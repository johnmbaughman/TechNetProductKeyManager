using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace TechNetProductKeyManager {
	internal class ImportKeyFile {

		public ImportKeyFile() { }

		public static void Import(string fileName, string password) {
			using (TextReader reader = new StreamReader(fileName)) {
				XDocument doc = XDocument.Load(reader);

				var format2008 = doc.Descendants().Where(x => x.Name == Utility.Format2008Header);
				if (format2008.Count() > 0) {
					Parser2008.Parse(doc, password);
					return;
				}

				var format2012 = doc.Descendants().Where(x => x.Name == Utility.Format2012Header);
				if (format2012.Count() > 0) {
					Parser2012.Parse(doc, password);
					return;
				}

				reader.Close();
			}
		}
	}
}