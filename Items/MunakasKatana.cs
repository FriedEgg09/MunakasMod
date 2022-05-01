using Terraria.ID;
using Terraria.ModLoader;
using System;

namespace MunakasMod.Items
{
	public class MunakasKatana : ModItem
	{
		public override void SetStaticDefaults()
		{
			//sDisplayName.SetDefault("MunakasKatana"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Munakas");
		}

		public override void SetDefaults()
		{
			item.damage = 14;
			item.melee = true;
			item.width = 31;
			item.height = 31;
			item.maxStack = 1;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.knockBack = 8;
			item.value = 10000;
			item.rare = -12;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
		}

		public override void AddRecipes()
		{
			//ModRecipe recipe = new ModRecipe(mod);
			//recipe.AddIngredient(ItemID.DirtBlock, 1);
			//recipe.AddTile(TileID.WorkBenches);
			//recipe.SetResult(this);
			//recipe.AddRecipe();
		}
	}
}