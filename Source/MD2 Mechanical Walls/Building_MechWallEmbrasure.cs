using System.Collections.Generic;
using RimWorld;
using Verse;

namespace MD2_mechwalls;

public class Building_MechWallEmbrasure : Building_MechWall
{
    private IEnumerable<Gizmo> FabricatedMethod9 => base.GetGizmos();

    public override IEnumerable<Gizmo> GetGizmos()
    {
        var command_Action = new Command_Action
        {
            action = ToggleStateOne,
            defaultDesc = "MD2.MechWallExtendWallDesc".Translate(),
            defaultLabel = "MD2.MechWallExtendWallLable".Translate(),
            activateSound = SoundDef.Named("Click"),
            Disabled = false,
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
            Disabled = false,
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
            var command = (Command)gizmo;
            yield return command;
        }
    }

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