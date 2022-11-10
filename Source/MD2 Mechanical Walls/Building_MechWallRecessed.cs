using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Verse;

namespace MD2_mechwalls;

public class Building_MechWallRecessed : Building_MechWall
{
    [CompilerGenerated]
    private IEnumerable<Gizmo> FabricatedMethod9()
    {
        return base.GetGizmos();
    }

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
        thing.SetFactionDirect(Faction);
        thing.HitPoints = HitPoints;
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

        var thing = ThingMaker.MakeThing(MechWallEmbrasure, Stuff);
        thing.SetFactionDirect(Faction);
        thing.HitPoints = HitPoints;
        var map = Map;
        this.DestroyedOrNull();
        DoDustPuff();
        GenSpawn.Spawn(thing, Position, map, Rotation);
    }
}