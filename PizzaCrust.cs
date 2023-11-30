namespace BetterPizza
{
	public class PizzaCrust
	{
		public Crust PizzaCrusts { get; set; }

		public PizzaCrust()
		{
			PizzaCrusts = new Crust();
		}

		public double GetFinalPrice()
		{
			return PizzaCrusts.CrustPrice();
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