﻿//using Greenhouse.Building;
using Mafi;
using Mafi.Base;
using Mafi.Core;
using Mafi.Core.Mods;

namespace Arboretum {
	public sealed class MyMod : DataOnlyMod {

		public override string Name => "Arboretum Mod";

		public override int Version => 1;


		// Constructor that lists mod dependencies as parameters. You probably want to depend on both core and base
		// mods so this mod will be initialized after them.
		public MyMod(CoreMod coreMod, BaseMod baseMod) {
			Log.Info("My mod was created!");
		}

		public override void RegisterPrototypes(ProtoRegistrator registrator) {
			// Register all prototypes here.

			// Registers all products from this assembly. See MyIds.Products.cs for examples.
			registrator.RegisterAllProducts();

			// Use data class registration to register other protos such as machines, recipes, etc.
			registrator.RegisterData<ArboretumRecipesData>();

			// Registers all research from this assembly. See ExampleResearchData.cs for examples.
			registrator.RegisterDataWithInterface<IResearchNodesData>();

			// TODO: Add Greenhouse buildings.
			//registrator.RegisterData<ArboretumBuildingData>();
		}

	}
}
