using FlyweightImplementation;
using System;

namespace FlyweightImplementation
{
	public class FlyweightToysType
	{
		private string categorieName;

		private char picture;

		private MATERIAL material;


		public FlyweightToysType(string categorieName, char picture,MATERIAL material){
			this.categorieName = categorieName;
			this.picture= picture;
			this.material= material;
		}

		public void FlyweightOperationDraw(float price, FlyweightToysType type){
			SingletonConsolePrintor helper = SingletonConsolePrintor.GetSingletonConsolePrintor();
			helper.Print(price.ToString(),this.ToString());
		}

        public override string ToString()
        {
            return this.categorieName+ "\t" + this.picture+ "\t"+ this.material;
		}

    }
}

