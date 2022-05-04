using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MunakasMod.Projectiles
{
	public class FriedEggCannonProjectile : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Fried Egg");
		}

		public override void SetDefaults()
		{
			projectile.width = 32;
			projectile.height = 16;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.ranged = true;
			projectile.tileCollide = false;
			aiType = ProjectileID.Bullet;
		}

		// Additional hooks/methods here.
	}
}