using Terraria.ModLoader;

namespace Nocturnal
{
	class Nocturnal : Mod
	{
		public Nocturnal()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
