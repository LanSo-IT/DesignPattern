using FlyweightImplementation;
using System;
using System.Collections.Generic;

namespace FlyweightImplementation
{
	public class FactoryFlyweightToys
	{
		List<FlyweightToysType> cache = new List<FlyweightToysType>();

		public FactoryFlyweightToys() { }

		public FlyweightToysType getToysType(string categorieName, char picture, MATERIAL composition)
		{
			FlyweightToysType type = new FlyweightToysType(categorieName, picture, composition);
            if ( ! cache.Contains(type)) cache.Add(type);
			return cache[cache.IndexOf(type)];
		}

	}

}

