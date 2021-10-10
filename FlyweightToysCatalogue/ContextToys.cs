using FlyweightImplementation;

namespace FlyweightImplementation
{
	public class ContextToys
	{
		private float price;


		private FlyweightToysType type;

		public ContextToys (float price, FlyweightToysType type)
        {
			this.price = price;
			this.type = type;
	}
		public void FlyweightOperationDraw() {
			type.FlyweightOperationDraw(price, type);
		}

	}

}

