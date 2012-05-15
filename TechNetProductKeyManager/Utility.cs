using System;
using System.Xml.Linq;

namespace TechNetProductKeyManager {
	internal static class Utility {
		public const string Format2008Header = "Your_Product_Keys";
		public const string Format2008Element = "Product_Key";
		public const string Format2012Header = "YourKey";
		public const string Format2012Element = "Product_Key";

		internal static string GetElementValue(XElement element, string defaultValue) {
			return element == null ? defaultValue : element.Value;
		}

		internal static string GetAttributeValue(XAttribute attribute, string defaultValue) {
			return attribute == null ? defaultValue : attribute.Value;
		}

		internal static string ReformatDate(string dateToFormat, char oldFormatCharacter, char newFormatCharacter) {
			string[] tempDate = dateToFormat.Split(oldFormatCharacter);
			return string.Format("{1}{0}{2}{0}{3}", newFormatCharacter, tempDate[2], tempDate[0].PadLeft(2, '0'), tempDate[1].PadLeft(2, '0'));
		}

		internal static string ReverseString(string s) {
			char[] arr = s.ToCharArray();
			Array.Reverse(arr);
			return new string(arr);
		}
	}
}