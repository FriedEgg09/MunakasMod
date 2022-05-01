using Terraria.ModLoader;

namespace MunakasMod.Items.Materials
{
	public class FriedEgg : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Fried Egg");
			Tooltip.SetDefault("It's smart to keep this item. It's Used to craft very powerful things...");
		}

		public override bool CanBurnInLava()
		{
			return true;
		}
	}
}