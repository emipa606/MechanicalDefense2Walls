using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Verse;

namespace MD2_mechwalls
{
	// Token: 0x02000004 RID: 4
	public class Building_MechWallRecessed : Building_MechWall
	{
		// Token: 0x0600000F RID: 15 RVA: 0x00002218 File Offset: 0x00001218
		[CompilerGenerated]
		private IEnumerable<Gizmo> FabricatedMethod9()
		{
			return base.GetGizmos();
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002600 File Offset: 0x00001600
		public override IEnumerable<Gizmo> GetGizmos()
		{
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
				defaultDesc = Translator.Translate("MD2.MechWallOpenEmbrasureDesc"),
				defaultLabel = Translator.Translate("MD2.MechWallOpenEmbrasureLable"),
				activateSound = SoundDef.Named("Click"),
				disabled = false,
				groupKey = 313740011,
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

		// Token: 0x06000011 RID: 17 RVA: 0x00002624 File Offset: 0x00001624
		public override void ToggleStateOne()
		{
			if (base.HasPower)
			{
				Thing thing = ThingMaker.MakeThing(Building_MechWall.MechWallExtended, base.Stuff);
				thing.SetFactionDirect(base.Faction);
				thing.HitPoints = this.HitPoints;
				Map map = base.Map;
				this.DestroyedOrNull();
				this.DoDustPuff();
				GenSpawn.Spawn(thing, base.Position, map, base.Rotation, WipeMode.Vanish, false);
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002698 File Offset: 0x00001698
		public override void ToggleStateTwo()
		{
			if (base.HasPower)
			{
				Thing thing = ThingMaker.MakeThing(Building_MechWall.MechWallEmbrasure, base.Stuff);
				thing.SetFactionDirect(base.Faction);
				thing.HitPoints = this.HitPoints;
				Map map = base.Map;
				this.DestroyedOrNull();
				this.DoDustPuff();
				GenSpawn.Spawn(thing, base.Position, map, base.Rotation, WipeMode.Vanish, false);
			}
		}
	}
}
