
namespace BetterPizza
{
	public class Pizza
	{
		public Topping PizzaTopping{ get; set; }

		public Crust PizzaCrusts { get; set; }

		public Tip PizzaTips { get; set; }

		public Pizza()
		{
			PizzaTopping = new Topping();
			PizzaCrusts = new Crust();
			PizzaTips = new Tip();
		}

		public double GetToppingPrice()
		{
			return PizzaTopping.ToppingPrice();
		}

		public double GetTipAmount()
		{
			double toppingFinal = GetToppingPrice();
			double crustFinal = GetCrustPrice();
			double finalFinal = toppingFinal + crustFinal + 2;
			return PizzaTips.TotalAfterTip(finalFinal);
		}

		public double GetCrustPrice()
		{
			return PizzaCrusts.CrustPrice();
		}

		public double GetTotal()
		{
			double toppingFinal = GetToppingPrice();
			double crustFinal = GetCrustPrice();
			double finalFinal = toppingFinal + crustFinal + 2 + GetTipAmount();
			return finalFinal;
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

	public class Tip
	{
		public bool Twelve { get; set; }
		public bool Fifteen { get; set; }
		public bool Eighteen { get; set; }

		public double TotalAfterTip(double finalFinal)
		{
			if (Twelve)
			{
				finalFinal *= .12;
			}
			if (Fifteen)
			{
				finalFinal *= .15;
			}
			if (Eighteen)
			{
				finalFinal *= .18;
			}
			return finalFinal;
		}
	}

	public class Crust
	{
		public bool ThinCrust { get; set; }

		public bool PanCrust { get; set; }

		public bool HandTossed { get; set; }

		public double CrustPrice()
		{
			double runningTotal = 0;
			if (ThinCrust)
			{
				runningTotal += 5.99;
			}
			if (PanCrust)
			{
				runningTotal += 7.99;
			}
			if (HandTossed)
			{
				runningTotal += 6.99;
			}
			return runningTotal;
		}
	}
}
