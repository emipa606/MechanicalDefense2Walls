using System;
using RimWorld;
using Verse;

namespace MD2_mechwalls
{
	// Token: 0x02000002 RID: 2
	[DefOf]
	public static class Keys
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00001050
		public static KeyBindingDef BuildingOnOffToggle
		{
			get
			{
				return Keys.Named("BuildingOnOffToggle");
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000002 RID: 2 RVA: 0x0000206C File Offset: 0x0000106C
		public static KeyBindingDef ExtendMechWall
		{
			get
			{
				return Keys.Named("ExtendMechWall");
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002088 File Offset: 0x00001088
		public static KeyBindingDef ExtendMechEmbrasure
		{
			get
			{
				return Keys.Named("ExtendMechEmbrasure");
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000004 RID: 4 RVA: 0x000020A4 File Offset: 0x000010A4
		public static KeyBindingDef RecessMechWall
		{
			get
			{
				return Keys.Named("RecessMechWall");
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000005 RID: 5 RVA: 0x000020C0 File Offset: 0x000010C0
		public static KeyBindingDef DeactivateDroid
		{
			get
			{
				return Keys.Named("DeactivateDroid");
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000006 RID: 6 RVA: 0x000020DC File Offset: 0x000010DC
		public static KeyBindingDef FissureGeneratorChangeFissure
		{
			get
			{
				return Keys.Named("FissureGeneratorChangeFissure");
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000020F8 File Offset: 0x000010F8
		public static KeyBindingDef Named(string defName)
		{
			return DefDatabase<KeyBindingDef>.GetNamed(defName, true);
		}
	}
}
