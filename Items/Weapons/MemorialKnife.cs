using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Nocturnal.Items.Weapons
{
	public class MemorialKnife : ModItem
	{
		public override void SetStaticDefaults()
		{
        Tooltip.SetDefault("Inflicts cremate on enemies, making them burn gradually");
		}
		
		public override void SetDefaults()
		{
			item.damage = 9;	
			item.melee = true;	
			item.width = 40;		
			item.height = 40;		
			item.useTime = 30;		
			item.useAnimation = 20;		
			item.useStyle = 3;		
			item.knockBack = 2;		
			item.value = Item.sellPrice(0, 0, 5, 0);
			item.rare = 1;		
			item.UseSound = SoundID.Item1;	
			item.autoReuse = true;	
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "ZombieMetal", 6);
		recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		
		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			target.AddBuff(mod.BuffType("Cremate"), 600, false);
			for (int i = 0; i < 10; i++)
			{
				int dust = Dust.NewDust(target.position, target.width, target.height, 5);
				Main.dust[dust].scale = 1.5f;
				Main.dust[dust].noGravity = true;
			}
		}
	}
}
