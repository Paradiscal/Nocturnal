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
	class StareProj : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			ProjectileID.Sets.YoyosLifeTimeMultiplier[projectile.type] = 8f;
			ProjectileID.Sets.YoyosMaximumRange[projectile.type] = 180f;
			ProjectileID.Sets.YoyosTopSpeed[projectile.type] = 10f;
		}

		public override void SetDefaults()
		{
			projectile.extraUpdates = 0;
			projectile.width = 16;
			projectile.height = 16;
			projectile.aiStyle = 99;
			projectile.friendly = true;
			projectile.penetrate = -1;
			projectile.melee = true;
			projectile.scale = 1f;
		}
		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			target.AddBuff(mod.BuffType("Cremate"), 600, false);
		}
	}
}
