using Mafi.Base;
using Mafi.Core.Entities.Static.Layout;
using Mafi.Core.Factory.Machines;
using Mafi.Core.Mods;
using Mafi.Core.Ports.Io;
using Mafi.Core.Prototypes;

namespace Arboretum.ArboretumBuilding {
	/// <summary>
	/// In order to add your new balancers to the game, add following code to your mod registration.
	/// <code>
	/// registrator.RegisterData{BalancersData}(); // replace { and } with angle brackets (thanks, XML comments).
	/// </code>
	/// </summary>
	public class ArboretumData : IModData {
		public void RegisterData(ProtoRegistrator registrator) {

			registerArboretum(registrator,
				name: "Arboretum",
				costs: Costs.Machines.AssemblyElectrified);
		}

		private static void registerArboretum(
			ProtoRegistrator registrator,
			string name,
			EntityCostsTpl costs
		) {
			ProtosDb db = registrator.PrototypesDb;
			IoPortShapeProto flat = db.GetOrThrow<IoPortShapeProto>(Ids.IoPortShapes.FlatConveyor);
			IoPortShapeProto pipe = db.GetOrThrow<IoPortShapeProto>(Ids.IoPortShapes.Pipe);
			MachineProto machine = db.GetOrThrow<MachineProto>(Ids.Machines.AssemblyElectrified);
			registrator.PrototypesDb.Add(new MachineProto(
				id: MyIds.Machines.arboretumMachine,
				strings: Proto.CreateStr(MyIds.Machines.arboretumMachine, name,
					"Turns seedlings into wood",
					translationComment: "small machine that creates wood from seedlings"),
				layout: registrator.LayoutParser.ParseLayoutOrThrow(
					// Allow port connection only to transports, otherwise balancing logic can is broken.
					// Ground Restrictions: [] mean concrete flat ground, () mean any flat ground, {} means no restriction
					// # for flat, @ for pipe, ~ for loose, ' for molten, and | for shaft
					new EntityLayoutParams(useNewLayoutSyntax: true, portsCanOnlyConnectToTransports: true),
					   "   [4][4][4][4][4]   ",
					   "A#>[4][4][4][4][4]   ",
					   "   [4][4][4][4][4]>#X",
					   "B@>[4][4][4][4][4]   ",
				       "   [4][4][4][4][4]   "),
				costs: costs.MapToEntityCosts(registrator),
				consumedPowerPerTick: machine.ConsumedPowerPerTick,
				buffersMultiplier: machine.BuffersMultiplier,
				computingConsumed: machine.ComputingConsumed,
				nextTier: machine.NextTier,
				useAllRecipesAtStartOrAfterUnlock: true,
				animParams: machine.AnimParams,
				graphics: machine.Graphics));
		}
	}
}
