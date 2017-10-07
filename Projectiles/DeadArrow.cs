using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace Nocturnal.Projectiles
{
    class DeadArrow : ModProjectile
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Leech Arrow");
        }
        public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.WoodenArrowFriendly);
		}
		public override void Kill(int timeLeft)
		{
			if (Main.rand.Next(4) == 0 && projectile.noDropItem == false)
        	{
        		Item.NewItem((int)projectile.position.X, (int)projectile.position.Y, projectile.width, projectile.height, mod.ItemType("DeadArrow"));
        	}
			for (int i = 0; i < 5; i++)
			{
				int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 0);
				Main.dust[dust].scale = 1.5f;
				Main.dust[dust].noGravity = true;
			}
			Main.PlaySound(0, (int)projectile.position.X, (int)projectile.position.Y);
		}
		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			target.AddBuff(mod.BuffType("Cremate"), 600, false);
		}
	}
}
