using Mafi.Base;
using Mafi.Core.Research;
using ResNodeID = Mafi.Core.Research.ResearchNodeProto.ID;

namespace Arboretum
{
	public partial class MyIds
	{
		public partial class Research
		{
			[ResearchCosts(difficulty: 1)]
			public static readonly ResNodeID UnlockArboretum = Ids.Research.CreateId("UnlockArboretum");
		}
	}
}
