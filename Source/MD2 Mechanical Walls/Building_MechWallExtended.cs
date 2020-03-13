using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Verse;

namespace MD2_mechwalls
{
	// Token: 0x02000005 RID: 5
	public class Building_MechWallExtended : Building_MechWall
	{
		// Token: 0x06000016 RID: 22 RVA: 0x00002714 File Offset: 0x00001714
		[CompilerGenerated]
		private IEnumerable<Gizmo> FabricatedMethod9()
		{
			return base.GetGizmos();
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002AFC File Offset: 0x00001AFC
		public override IEnumerable<Gizmo> GetGizmos()
		{
			Command_Action command_Action = new Command_Action
			{
				action = delegate()
				{
					this.ToggleStateOne();
				},
				defaultDesc = Translator.Translate("MD2.MechWallRecessWallDesc"),
				defaultLabel = Translator.Translate("MD2.MechWallRecessWallLable"),
				activateSound = SoundDef.Named("Click"),
				disabled = false,
				groupKey = 313740009,
				icon = Building_MechWall.RecessIcon
			};
			yield return command_Action;
			command_Action = new Command_Action
			{
				action = delegate()
				{
					this.ToggleStateTwo();
				},
				defaultDesc = Translator.Translate("MD2.MechWallOpenEmbrasureDesc"),
				defaultLabel = Translator.Translate("MD2.MechWallOpenEmbrasureLable"),
				activateSound = SoundDef.Named("Click"),
				disabled = false,
				groupKey = 313740010,
				icon = Building_MechWall.EmbrasureIcon
			};
			yield return command_Action;
			if (this.FabricatedMethod9() != null)
			{
				foreach (Gizmo gizmo in this.FabricatedMethod9())
				{
					Command command = (Command)gizmo;
					yield return command;
				}
			}
			yield break;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002B20 File Offset: 0x00001B20
		public override void ToggleStateOne()
		{
			if (base.HasPower)
			{
				Thing thing = ThingMaker.MakeThing(Building_MechWall.MechWallRecessed, base.Stuff);
				thing.SetFactionDirect(base.Faction);
				thing.HitPoints = base.HitPoints;
				Map map = base.Map;
				this.DestroyedOrNull();
				this.DoDustPuff();
				GenSpawn.Spawn(thing, base.Position, map, base.Rotation, WipeMode.Vanish, false);
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002B94 File Offset: 0x00001B94
		public override void ToggleStateTwo()
		{
			if (base.HasPower)
			{
				Thing thing = ThingMaker.MakeThing(Building_MechWall.MechWallEmbrasure, base.Stuff);
				thing.SetFactionDirect(base.Faction);
				thing.HitPoints = base.HitPoints;
				Map map = base.Map;
				this.DestroyedOrNull();
				this.DoDustPuff();
				GenSpawn.Spawn(thing, base.Position, map, base.Rotation, WipeMode.Vanish, false);
			}
		}
	}
}
