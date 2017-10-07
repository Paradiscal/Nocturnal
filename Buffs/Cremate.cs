using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace Nocturnal.Buffs
{
	public class Cremate : ModBuff
	{
		public override void SetDefaults()
		{
			Main.buffNoTimeDisplay[Type] = false;
			DisplayName.SetDefault("Cremate");
		}
		public override void Update(NPC npc, ref int buffIndex)
		{
			npc.lifeRegen -= 3;

			if (Main.rand.Next(2) == 0)
			{
				int dust = Dust.NewDust(npc.position, npc.width, npc.height, mod.DustType("GloopDust"));
				Main.dust[dust].scale = 1.5f;
				Main.dust[dust].noGravity = true;		
			}
		}
	}
}