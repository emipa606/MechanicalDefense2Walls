using RimWorld;
using Verse;

namespace MD2_mechwalls;

[DefOf]
public static class Keys
{
    public static KeyBindingDef BuildingOnOffToggle => Named("BuildingOnOffToggle");

    public static KeyBindingDef ExtendMechWall => Named("ExtendMechWall");

    public static KeyBindingDef ExtendMechEmbrasure => Named("ExtendMechEmbrasure");

    public static KeyBindingDef RecessMechWall => Named("RecessMechWall");

    public static KeyBindingDef DeactivateDroid => Named("DeactivateDroid");

    public static KeyBindingDef FissureGeneratorChangeFissure => Named("FissureGeneratorChangeFissure");

    public static KeyBindingDef Named(string defName)
    {
        return DefDatabase<KeyBindingDef>.GetNamed(defName);
    }
}