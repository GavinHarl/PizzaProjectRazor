using System.Security.Cryptography.X509Certificates;

namespace BlazorTest
{
	public class Pizza
	{
		public Topping PizzaTopping{ get; set; }

		public Pizza() 
		{
			PizzaTopping = new Topping();
		}

		public double getFinalPrice()
		{
			return PizzaTopping.ToppingPrice();
		}
	}
	

	public class Topping
	{
		public bool Pepperoni { get; set; }
		public bool ExtraCheese {get; set;}

		public bool Ham { get; set;}

		public bool Chicken { get; set; }

		public double ToppingPrice()
		{
			double runningTotal = 0;

			if (Pepperoni)
			{
				runningTotal += 1.50;
			}
			if (ExtraCheese)
			{
				runningTotal += 2.00;
			}
			if (Ham)
			{
				runningTotal += 1.79;
			}
			if (Chicken)
			{
				runningTotal += 3.00;
			}
			return runningTotal;
		}

	}
}
