using Mafi;
using Mafi.Base;
using Mafi.Core.Mods;
using Mafi.Core.Research;

namespace Arboretum
{
	internal class ArboretumResearchData : IResearchNodesData
	{
		public void RegisterData(ProtoRegistrator registrator)
		{
			ResearchNodeProto nodeProto = registrator.ResearchNodeProtoBuilder
				.Start("Unlock Arboretum", MyIds.Research.UnlockArboretum)
				.Description("This unlocks the Arboretum")
				.AddProductToUnlock(MyIds.Products.ArboretumSeedling)
				.AddRecipeToUnlock(MyIds.Recipes.ArboretumSeedlings)
				.AddRecipeToUnlock(MyIds.Recipes.ArboretumWood)
				.BuildAndAdd();

			nodeProto.GridPosition = new Vector2i(4, 31);
			nodeProto.AddParent(registrator.PrototypesDb.GetOrThrow<ResearchNodeProto>(Ids.Research.BasicFarming));
		}
	}
}
