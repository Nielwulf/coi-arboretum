using Mafi.Base;
using Mafi.Base.Prototypes;
using ProductID = Mafi.Core.Products.ProductProto.ID;

namespace Arboretum
{
	public static partial class MyIds
	{
		public static partial class Products
		{
			[CountableProduct(icon: Assets.Base.Products.Icons.Wood_svg,
				prefab: Assets.Base.Products.Countable.RawWood_prefab)]
			public static readonly ProductID ArboretumSeedling = Ids.Products.CreateId("ArboretumSeedling");
		}
	}
}
