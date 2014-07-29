using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class BossEncounter : SerializeMemoryObject
	{
		// 2.0.6.24641
		public const int SizeOf = 0x68; // 104
		
		public int x0C { get { return Field<int>(0x0C); } }
		public int x10 { get { return Field<int>(0x10); } }
		public int x14 { get { return Field<int>(0x14); } }
		public int x18 { get { return Field<int>(0x18); } }
		public int x1C { get { return Field<int>(0x1C); } }
		public int x20 { get { return Field<int>(0x20); } }
		public int x24 { get { return Field<int>(0x24); } }
		public int x28 { get { return Field<int>(0x28); } }
		public int x2C { get { return Field<int>(0x2C); } }
		public int x30 { get { return Field<int>(0x30); } }
		public int x34 { get { return Field<int>(0x34); } }
		public int x38 { get { return Field<int>(0x38); } }
		public float x3C { get { return Field<float>(0x3C); } }
		public Sno x40_QuestRangeSno { get { return Field<Sno>(0x40); } }
		public Sno[] x44_Snos { get { return Field<Sno>(0x44, 4); } }
		public Sno[] x54_Snos { get { return Field<Sno>(0x54, 3); } }
		public Sno x60_LevelAreaSno { get { return Field<Sno>(0x60); } }
		public Sno x64_ActorSno { get { return Field<Sno>(0x64); } }
	}
}
