using RimWorld;
using UnityEngine;
using Verse;
using Verse.Sound;

namespace MD2_mechwalls;

[StaticConstructorOnStartup]
public abstract class Building_MechWall : Building
{
    protected static readonly Texture2D EmbrasureIcon = ContentFinder<Texture2D>.Get("UI/Icons/Metal");

    protected static readonly Texture2D ExtendIcon = ContentFinder<Texture2D>.Get("UI/Commands/DumpContentsUI");

    protected static readonly ThingDef MechWallEmbrasure = DefDatabase<ThingDef>.GetNamed("MD2MechEmbrasure");

    protected static readonly ThingDef MechWallExtended = DefDatabase<ThingDef>.GetNamed("MechWallExtended");

    protected static readonly ThingDef MechWallRecessed = DefDatabase<ThingDef>.GetNamed("MechWallRecessed");

    protected static readonly Texture2D RecessIcon = ContentFinder<Texture2D>.Get("UI/Commands/RecessWall");

    private static readonly SoundDef sound = SoundDef.Named("ChunkRock_Drop");

    private CompPowerTrader power;

    protected bool HasPower => power is { PowerOn: true };

    protected virtual void DoDustPuff()
    {
        FleckMaker.ThrowDustPuff(Position, Map, 1f);
        sound.PlayOneShot(new TargetInfo(Position, Map));
    }

    public override void SpawnSetup(Map map, bool respawningAfterLoad)
    {
        base.SpawnSetup(map, respawningAfterLoad);
        power = GetComp<CompPowerTrader>();
    }

    public abstract void ToggleStateOne();

    public abstract void ToggleStateTwo();
}