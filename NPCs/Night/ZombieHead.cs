using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace Nocturnal.NPCs.Night
{
	public class  ZombieHead : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Undead Head");
			Main.npcFrameCount[npc.type] = 2;
		}

		public override void SetDefaults()
		{
			npc.width = 16;
			npc.height = 16;
			npc.damage = 15;
			npc.defense = 2;
			npc.lifeMax = 50;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = 60f;
			npc.aiStyle = 1; 
			animationType = NPCID.BlueSlime;
			npc.buffImmune[BuffID.Poisoned] = true;
			npc.buffImmune[BuffID.Confused] = true;
			banner = npc.type;
			bannerItem = mod.ItemType("ZombieHeadBannerItem");
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return SpawnCondition.OverworldNightMonster.Chance * 0.08f;
		}
		public override void HitEffect(int hitDirection, double damage)
        {
            if (npc.life <= 0)
            {
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/UndeadHead1"), 1f);
                 Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/UndeadHead2"), 1f);
            }
        }
		
		public override void NPCLoot()
		{
			if (Main.rand.Next(1) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ZombieMetal"), Main.rand.Next(1, 8));
			}
		}
	}
}