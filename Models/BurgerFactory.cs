namespace BanterBurger.Models
{
	public class BurgerFactory : iBurger
	{
		public Burger CreateBurger(string type)
		{
			switch (type.ToLower())
			{
				case "plain":
					return new Burger { Id = 1, Name = "Plain Burger", Price = 4.99m, Bun = "Wheat", Patty = "Beef", Condiments = "Mayo" };
				case "cheese":
					return new Burger { Id = 2, Name = "Cheese Burger", Price = 7.99m, Bun = "Wheat", Patty = "Beef", Condiments = "Cheese Sauce" };
				case "veggie":
					return new Burger { Id = 3, Name = "Veggie Burger", Price = 5.99m, Bun = "Wheat", Patty = "Lentils", Condiments = "Sweet Chillie" };
				case "chicken":
					return new Burger { Id = 4, Name = "Chicken Burger", Price = 9.99m, Bun = "Wheat", Patty = "Chicken", Condiments = "Chutney" };
				case "rib":
					return new Burger { Id = 5, Name = "Rib Burger", Price = 11.99m, Bun = "Wheat", Patty = "Beef Rib", Condiments = "Rib Sauce" };
				default:
					throw new ArgumentException("Invalid burger type");
			}
		}
	}
}
