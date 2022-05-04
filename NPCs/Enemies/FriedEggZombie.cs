using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MunakasMod.NPCs.Enemies
{
	// https://github.com/tModLoader/tModLoader/wiki/Advanced-Vanilla-Code-Adaption#example-npc-npc-clone-with-modified-projectile-hoplite
	//
	//
	public class FriedEggZombie : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Zombie");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Zombie];
		}

		public override void SetDefaults()
		{
			npc.width = 34;
			npc.height = 46;
			npc.damage = 16;
			npc.defense = 6;
			npc.lifeMax = 45;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = 60f;
			npc.knockBackResist = 0.5f;
			npc.aiStyle = 3;
			aiType = NPCID.Zombie;
			animationType = NPCID.Zombie;
			banner = Item.NPCtoBanner(NPCID.Zombie);
			bannerItem = Item.BannerToItem(banner);
		}

		public override void NPCLoot()
		{
			if (Main.rand.NextBool(10))
			{
				Item.NewItem(npc.position, mod.ItemType("FriedEgg"));
			}
		}
		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			if (spawnInfo.player.ZoneOverworldHeight)
			{
				return SpawnCondition.OverworldNightMonster.Chance * 0.1f;
			}
			return 0f;
		}
	}
}