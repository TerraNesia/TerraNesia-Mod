using Terraria.ModLoader;

namespace TerraNesiaMod
{
	class TerraNesiaMod : Mod
	{
		public TerraNesiaMod()
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
