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
            var command_Action = new Command_Action
            {
                action = ToggleStateOne,
                defaultDesc = "MD2.MechWallExtendWallDesc".Translate(),
                defaultLabel = "MD2.MechWallExtendWallLable".Translate(),
                activateSound = SoundDef.Named("Click"),
                disabled = false,
                groupKey = 313740010,
                icon = ExtendIcon
            };
            yield return command_Action;
            command_Action = new Command_Action
            {
                action = ToggleStateTwo,
                defaultDesc = "MD2.MechWallOpenEmbrasureDesc".Translate(),
                defaultLabel = "MD2.MechWallOpenEmbrasureLable".Translate(),
                activateSound = SoundDef.Named("Click"),
                disabled = false,
                groupKey = 313740011,
                icon = EmbrasureIcon
            };
            yield return command_Action;
            if (FabricatedMethod9() == null)
            {
                yield break;
            }

            foreach (var gizmo in FabricatedMethod9())
            {
                var command = (Command) gizmo;
                yield return command;
            }
        }

        // Token: 0x06000011 RID: 17 RVA: 0x00002624 File Offset: 0x00001624
        public override void ToggleStateOne()
        {
            if (!HasPower)
            {
                return;
            }

            var thing = ThingMaker.MakeThing(MechWallExtended, Stuff);
            thing.SetFactionDirect(Faction);
            thing.HitPoints = HitPoints;
            var map = Map;
            this.DestroyedOrNull();
            DoDustPuff();
            GenSpawn.Spawn(thing, Position, map, Rotation);
        }

        // Token: 0x06000012 RID: 18 RVA: 0x00002698 File Offset: 0x00001698
        public override void ToggleStateTwo()
        {
            if (!HasPower)
            {
                return;
            }

            var thing = ThingMaker.MakeThing(MechWallEmbrasure, Stuff);
            thing.SetFactionDirect(Faction);
            thing.HitPoints = HitPoints;
            var map = Map;
            this.DestroyedOrNull();
            DoDustPuff();
            GenSpawn.Spawn(thing, Position, map, Rotation);
        }
    }
}