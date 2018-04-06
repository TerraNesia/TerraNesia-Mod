using Terraria;
using Terraria.ModLoader;

namespace TerraNesiaMod.Items
{
	public class Lele : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lele");
            Tooltip.SetDefault("Ikan Lele");
        }

        public override void SetDefaults()
        {
            item.questItem = true;
            item.maxStack = 1;
            item.width = 26;
            item.height = 26;
            item.uniqueStack = true;
            item.rare = -11;        //The rarity of -11 gives the item orange color
        }

        public override bool IsQuestFish()
        {
            return true;
        }

        public override bool IsAnglerQuestAvailable()
        {
            return Main.hardMode;
        }

        public override void AnglerQuestChat(ref string description, ref string catchLocation)
        {
            description = "Tangkapin ikan Lele buat aku! Lagi pengen bikin Pecel Lele nih cepetan ya!";
            catchLocation = "Tangkep di manapun boleh empang atau manapun.";
        }
    }
}
