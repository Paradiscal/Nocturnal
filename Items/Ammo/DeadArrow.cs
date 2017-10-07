using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System;
using System.Collections.Generic;


namespace Nocturnal.Items.Ammo
{
    public class DeadArrow : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Leech Arrow");
        Tooltip.SetDefault("Has minimal damage, but high velocity and knockback\nInflicts cremate on enemies, making them burn gradually");

        }
        public override void SetDefaults()
		{
			
			item.width = 10;
			item.height = 28;
            item.value = 1;
            item.rare = 1;

            item.maxStack = 999;

            item.damage = 4;
			item.knockBack = 9f;
            item.ammo = AmmoID.Arrow;

            item.ranged = true;
            item.consumable = true;

            item.shoot = mod.ProjectileType("DeadArrow");
            item.shootSpeed = 6f;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "ZombieMetal", 3);
                      recipe.AddTile(16);
            recipe.SetResult(this, 99);
            recipe.AddRecipe();
        }
    }
}
