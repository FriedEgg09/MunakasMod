using Terraria.ID;
using Terraria.ModLoader;
using System;

namespace MunakasMod.Items
{
	public class ForkedPork : ModItem
	{
		public override void SetStaticDefaults()
		{
			//sDisplayName.SetDefault("ForkedPork"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Forked pork");
		}

		public override void SetDefaults()
		{
			item.damage = 30;
			item.melee = true;
			item.width = 48;
			item.height = 44;
			item.maxStack = 1;
			item.useTime = 28;
			item.useAnimation = 28;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 4;
			item.value = 10000;
			item.rare = -2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
		}

		public override void AddRecipes()
		{
			//ModRecipe recipe = new ModRecipe(mod);
			//recipe.AddIngredient(ItemID.GoldBroadsword);
			//recipe.AddIngredient(ItemID.GoldBar, 10);
			//var modCalamityMod = ModLoader.GetMod("CalamityMod");
			//if (modCalamityMod != null)
			//{
				//recipe.AddIngredient(modCalamityMod, "PiggyItem");
				//recipe.AddTile(TileID.Anvils);
				//recipe.SetResult(this);
				//recipe.AddRecipe();
			//}
		}
	}
}