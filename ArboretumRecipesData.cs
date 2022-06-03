using Mafi;
using Mafi.Base;
using Mafi.Core.Mods;

namespace Arboretum
{
	internal class ArboretumRecipesData : IModData
	{

		public void RegisterData(ProtoRegistrator registrator)
		{

			// Example of a new furnace recipe.
			registrator.RecipeProtoBuilder
				.Start(name: "Arboretum Seedlings",
					recipeId: MyIds.Recipes.ArboretumSeedlings,
					machineId: Ids.Machines.AssemblyManual)
				.AddInput(1, Ids.Products.Wood)
				.AddInput(2, Ids.Products.Water)
				.SetDuration(60.Seconds())
				.AddOutput(6, MyIds.Products.ArboretumSeedling)
				.BuildAndAdd();

			registrator.RecipeProtoBuilder
				.Start(name: "Arboretum Wood",
					recipeId: MyIds.Recipes.ArboretumWood,
					machineId: Ids.Machines.AssemblyManual)
				.AddInput(2, Ids.Products.Water)
				.AddInput(1, MyIds.Products.ArboretumSeedling)
				.SetDuration(60.Seconds())
				.AddOutput(10, Ids.Products.Wood)
				.BuildAndAdd();
		}

	}
}
