using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Illuminum.Items.Materials
{
	public class VortexCore : ModItem
	{
		public override void SetStaticDefaults() 
		{
			 DisplayName.SetDefault("Vortex Core"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
		}

		public override void SetDefaults() 
		{
			item.width = 36;
			item.height = 36;
			item.value = Item.buyPrice(platinum: 1);
			item.rare = ItemRarityID.Yellow;
			item.maxStack = 1;
		}
	}
}