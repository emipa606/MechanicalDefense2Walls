using System;
using RimWorld;
using UnityEngine;
using Verse;
using Verse.Sound;

namespace MD2_mechwalls
{
	// Token: 0x02000003 RID: 3
	[StaticConstructorOnStartup]
	public abstract class Building_MechWall : Building
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002114 File Offset: 0x00001114
		public bool HasPower
		{
			get
			{
				return this.power != null && this.power.PowerOn;
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x0000213D File Offset: 0x0000113D
		public virtual void DoDustPuff()
		{
			MoteMaker.ThrowDustPuff(base.Position, base.Map, 1f);
			Building_MechWall.sound.PlayOneShot(new TargetInfo(base.Position, base.Map, false));
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002179 File Offset: 0x00001179
		public override void SpawnSetup(Map map, bool respawningAfterLoad)
		{
			base.SpawnSetup(map, respawningAfterLoad);
			this.power = base.GetComp<CompPowerTrader>();
		}

		// Token: 0x0600000B RID: 11
		public abstract void ToggleStateOne();

		// Token: 0x0600000C RID: 12
		public abstract void ToggleStateTwo();

		// Token: 0x04000001 RID: 1
		public static readonly Texture2D EmbrasureIcon = ContentFinder<Texture2D>.Get("UI/Icons/Metal", true);

		// Token: 0x04000002 RID: 2
		public static readonly Texture2D ExtendIcon = ContentFinder<Texture2D>.Get("UI/Commands/DumpContentsUI", true);

		// Token: 0x04000003 RID: 3
		public static readonly ThingDef MechWallEmbrasure = DefDatabase<ThingDef>.GetNamed("MD2MechEmbrasure", true);

		// Token: 0x04000004 RID: 4
		public static readonly ThingDef MechWallExtended = DefDatabase<ThingDef>.GetNamed("MechWallExtended", true);

		// Token: 0x04000005 RID: 5
		public static readonly ThingDef MechWallRecessed = DefDatabase<ThingDef>.GetNamed("MechWallRecessed", true);

		// Token: 0x04000006 RID: 6
		public CompPowerTrader power;

		// Token: 0x04000007 RID: 7
		public static readonly Texture2D RecessIcon = ContentFinder<Texture2D>.Get("UI/Commands/RecessWall", true);

		// Token: 0x04000008 RID: 8
		private static readonly SoundDef sound = SoundDef.Named("ChunkRock_Drop");
	}
}
