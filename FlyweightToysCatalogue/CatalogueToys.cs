using FlyweightImplementation;
using System.Collections.Generic;

namespace FlyweightImplementation{
	public class CatalogueToys
	{
		private List<ContextToys> ListItems  = new List<ContextToys>();
		private FactoryFlyweightToys factoryFlyweightToys = new FactoryFlyweightToys();

		public CatalogueToys() { }
		public void CreateToys(float price, string categorieName, char picture, MATERIAL composition){
			FlyweightToysType type = factoryFlyweightToys.getToysType(categorieName, picture, composition);
			ContextToys contextToys = new ContextToys(price,type);
			ListItems.Add(contextToys);
		}

		public void FlyweightOperationDraw(){
			foreach (ContextToys toys in ListItems) toys.FlyweightOperationDraw();
		}
	}
}