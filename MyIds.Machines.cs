using Mafi.Base;
using Mafi.Core.Factory.Machines;
using MachineID = Mafi.Core.Factory.Machines.MachineProto.ID;

namespace Arboretum
{
	public static partial class MyIds
	{
		public static partial class Machines
		{
			public static readonly MachineID arboretumMachine = new MachineProto.ID("Arboretum");
		}
	}
}
