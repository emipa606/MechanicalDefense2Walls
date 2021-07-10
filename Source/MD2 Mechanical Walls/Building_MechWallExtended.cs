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
            var command_Action = new Command_Action
            {
                action = ToggleStateOne,
                defaultDesc = "MD2.MechWallRecessWallDesc".Translate(),
                defaultLabel = "MD2.MechWallRecessWallLable".Translate(),
                activateSound = SoundDef.Named("Click"),
                disabled = false,
                groupKey = 313740009,
                icon = RecessIcon
            };
            yield return command_Action;
            command_Action = new Command_Action
            {
                action = ToggleStateTwo,
                defaultDesc = "MD2.MechWallOpenEmbrasureDesc".Translate(),
                defaultLabel = "MD2.MechWallOpenEmbrasureLable".Translate(),
                activateSound = SoundDef.Named("Click"),
                disabled = false,
                groupKey = 313740010,
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

        // Token: 0x06000018 RID: 24 RVA: 0x00002B20 File Offset: 0x00001B20
        public override void ToggleStateOne()
        {
            if (!HasPower)
            {
                return;
            }

            var thing = ThingMaker.MakeThing(MechWallRecessed, Stuff);
            thing.SetFactionDirect(Faction);
            thing.HitPoints = base.HitPoints;
            var map = Map;
            this.DestroyedOrNull();
            DoDustPuff();
            GenSpawn.Spawn(thing, Position, map, Rotation);
        }

        // Token: 0x06000019 RID: 25 RVA: 0x00002B94 File Offset: 0x00001B94
        public override void ToggleStateTwo()
        {
            if (!HasPower)
            {
                return;
            }

            var thing = ThingMaker.MakeThing(MechWallEmbrasure, Stuff);
            thing.SetFactionDirect(Faction);
            thing.HitPoints = base.HitPoints;
            var map = Map;
            this.DestroyedOrNull();
            DoDustPuff();
            GenSpawn.Spawn(thing, Position, map, Rotation);
        }
    }
}