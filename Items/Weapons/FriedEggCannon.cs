using MunakasMod.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MunakasMod.Items.Weapons
{
	public class FriedEggCannon : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Fried Egg Cannon");
			Tooltip.SetDefault("Shoots a big fried egg that can destroy almost anything...");
		}

		

		public override void SetDefaults()
		{
			item.damage = 25;
			item.noMelee = true;
			item.rare = ItemRarityID.Pink;
			item.width = 40;
			item.height = 35;
			item.useTime = 20;
			item.UseSound = SoundID.DD2_ExplosiveTrapExplode;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.shootSpeed = 14f;
			item.useAnimation = 20;
			item.autoReuse = true;
			item.shoot = ModContent.ProjectileType<FriedEggCannonProjectile>();
			item.value = Item.sellPrice(silver: 3);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 10);
			recipe.AddIngredient(ItemID.DemoniteBar, 25);
			recipe.AddIngredient(mod, "FriedEgg", 5);
			recipe.AddIngredient(ItemID.Bomb, 2);
			recipe.AddTile(TileID.Tables);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}