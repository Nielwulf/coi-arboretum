using Mafi.Base;
using RecipeID = Mafi.Core.Factory.Recipes.RecipeProto.ID;

namespace Arboretum
{
	public partial class MyIds
	{
		public partial class Recipes
		{
			public static readonly RecipeID ArboretumSeedlings = Ids.Recipes.CreateId("ArboretumSeedlings");

			public static readonly RecipeID ArboretumWood = Ids.Recipes.CreateId("ArboretumWood");
		}
	}
}
