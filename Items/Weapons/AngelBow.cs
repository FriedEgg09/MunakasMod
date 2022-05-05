using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MunakasMod.Items.Weapons
{
    public class AngelBow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Angel Bow");
            Tooltip.SetDefault("A strong and sturdy bow.");
        }

        public override void SetDefaults()
        {
            item.damage = 22;
            item.ranged = true;
            item.width = 26;
            item.height = 54;
            item.maxStack = 1;
            item.useTime = 10;
            item.useAnimation = 10;
            item.useStyle = 5;
            item.knockBack = 2;
            item.value = 12000;
            item.rare = ItemRarityID.Pink;
            item.UseSound = SoundID.Item5;
            item.noMelee = true;
            item.shoot = 1;
            item.useAmmo = AmmoID.Arrow;
            item.shootSpeed = 9f;
            item.autoReuse = true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GoldBow, 1);
            recipe.AddIngredient(ItemID.Cloud, 10);
            recipe.AddIngredient(ItemID.HellstoneBar, 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}