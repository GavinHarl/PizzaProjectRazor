namespace BetterPizza
{
	public class Pizza
	{
		public Topping PizzaTopping { get; set; }

		public Pizza()
		{
			PizzaTopping = new Topping();
		}

		public decimal GetFinalPrice()
		{
			return PizzaTopping.ToppingPrice();
		}
	}

	public class Topping
	{
		public bool Bacon { get; set; }

		public bool MoreBacon { get; set; }

		public bool ExtraBacon { get; set; }

		public decimal ToppingPrice()
		{
			decimal runningTotal = 0;
			if (Bacon)
			{
				runningTotal += 30;
			}
			if (MoreBacon)
			{
				runningTotal += 50;
			}
			if (ExtraBacon)
			{
				runningTotal += 200;
			}
			return runningTotal;

		}

	}
}