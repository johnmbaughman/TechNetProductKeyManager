using System.Collections.Generic;
using Massive.SQLite;

namespace TechNetProductKeyManager {
	internal class ProductKey : DynamicModel {

		public ProductKey() : base("productkeys", "ProductKey", "Id") { }

		public static List<ProductKey> GetProducts() {
			ProductKey productKey = new ProductKey();
			List<ProductKey> returnProducts = new List<ProductKey>();
			var products = productKey.All(orderBy: "Name");
			foreach (var product in products) {
				returnProducts.Add(new ProductKey {
					Id = (int)product.Id,
					Name = product.Name
				});
			}
			return returnProducts;
		}

		public static string GetProductKey(int id) {
			ProductKey productKey = new ProductKey();
			var product = productKey.Single(where: "Id = @0", args: id);
			return Security.Decrypt(product.Key, User.GetPassword());
		}

		public string Name { get; private set; }

		public int Id { get; private set; }
	}
}