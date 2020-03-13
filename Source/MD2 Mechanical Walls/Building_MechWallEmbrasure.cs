using System;
using System.Collections.Generic;
using RimWorld;
using Verse;

namespace MD2_mechwalls
{
	// Token: 0x02000006 RID: 6
	public class Building_MechWallEmbrasure : Building_MechWall
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00002C10 File Offset: 0x00001C10
		private IEnumerable<Gizmo> FabricatedMethod9
		{
			get
			{
				return base.GetGizmos();
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002FFC File Offset: 0x00001FFC
		public override IEnumerable<Gizmo> GetGizmos()
		{
			new List<Gizmo>();
			Command_Action command_Action = new Command_Action
			{
				action = delegate()
				{
					this.ToggleStateOne();
				},
				defaultDesc = Translator.Translate("MD2.MechWallExtendWallDesc"),
				defaultLabel = Translator.Translate("MD2.MechWallExtendWallLable"),
				activateSound = SoundDef.Named("Click"),
				disabled = false,
				groupKey = 313740010,
				icon = Building_MechWall.ExtendIcon
			};
			yield return command_Action;
			command_Action = new Command_Action
			{
				action = delegate()
				{
					this.ToggleStateTwo();
				},
				defaultDesc = Translator.Translate("MD2.MechWallRecessWallDesc"),
				defaultLabel = Translator.Translate("MD2.MechWallRecessWallLable"),
				activateSound = SoundDef.Named("Click"),
				disabled = false,
				groupKey = 313740009,
				icon = Building_MechWall.RecessIcon
			};
			yield return command_Action;
			if (this.FabricatedMethod9 != null)
			{
				foreach (Gizmo gizmo in this.FabricatedMethod9)
				{
					Command command = (Command)gizmo;
					yield return command;
				}
			}
			yield break;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00003020 File Offset: 0x00002020
		public override void ToggleStateOne()
		{
			if (base.HasPower)
			{
				Thing thing = ThingMaker.MakeThing(Building_MechWall.MechWallExtended, base.Stuff);
				thing.SetFactionDirect(Faction.OfPlayer);
				thing.HitPoints = base.HitPoints;
				Map map = base.Map;
				this.DestroyedOrNull();
				this.DoDustPuff();
				GenSpawn.Spawn(thing, base.Position, map, base.Rotation, WipeMode.Vanish, false);
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003094 File Offset: 0x00002094
		public override void ToggleStateTwo()
		{
			if (base.HasPower)
			{
				Thing thing = ThingMaker.MakeThing(Building_MechWall.MechWallRecessed, base.Stuff);
				thing.SetFactionDirect(Faction.OfPlayer);
				thing.HitPoints = base.HitPoints;
				Map map = base.Map;
				this.DestroyedOrNull();
				this.DoDustPuff();
				GenSpawn.Spawn(thing, base.Position, map, base.Rotation, WipeMode.Vanish, false);
			}
		}
	}
}
