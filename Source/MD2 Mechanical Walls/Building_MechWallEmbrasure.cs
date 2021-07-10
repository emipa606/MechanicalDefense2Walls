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
        private IEnumerable<Gizmo> FabricatedMethod9 => base.GetGizmos();

        // Token: 0x0600001E RID: 30 RVA: 0x00002FFC File Offset: 0x00001FFC
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
                defaultDesc = "MD2.MechWallRecessWallDesc".Translate(),
                defaultLabel = "MD2.MechWallRecessWallLable".Translate(),
                activateSound = SoundDef.Named("Click"),
                disabled = false,
                groupKey = 313740009,
                icon = RecessIcon
            };
            yield return command_Action;
            if (FabricatedMethod9 == null)
            {
                yield break;
            }

            foreach (var gizmo in FabricatedMethod9)
            {
                var command = (Command) gizmo;
                yield return command;
            }
        }

        // Token: 0x0600001F RID: 31 RVA: 0x00003020 File Offset: 0x00002020
        public override void ToggleStateOne()
        {
            if (!HasPower)
            {
                return;
            }

            var thing = ThingMaker.MakeThing(MechWallExtended, Stuff);
            thing.SetFactionDirect(Faction.OfPlayer);
            thing.HitPoints = base.HitPoints;
            var map = Map;
            this.DestroyedOrNull();
            DoDustPuff();
            GenSpawn.Spawn(thing, Position, map, Rotation);
        }

        // Token: 0x06000020 RID: 32 RVA: 0x00003094 File Offset: 0x00002094
        public override void ToggleStateTwo()
        {
            if (!HasPower)
            {
                return;
            }

            var thing = ThingMaker.MakeThing(MechWallRecessed, Stuff);
            thing.SetFactionDirect(Faction.OfPlayer);
            thing.HitPoints = base.HitPoints;
            var map = Map;
            this.DestroyedOrNull();
            DoDustPuff();
            GenSpawn.Spawn(thing, Position, map, Rotation);
        }
    }
}