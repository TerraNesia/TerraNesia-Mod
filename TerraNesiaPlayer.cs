using Terraria.ModLoader;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerraNesiaMod
{
    public class TerraNesiaPlayer : ModPlayer
    {
        public override void CatchFish(Item fishingRod, Item bait, int power, int liquidType, int poolSize, int worldLayer, int questFish, ref int caughtType, ref bool junk)
        {
            if (junk)
            {
                return;
            }
            if (questFish == mod.ItemType("Lele") && Main.rand.Next(2) == 0)
            {
                caughtType = mod.ItemType("Lele");
            }
        }
    }
}
