using Il2CppSystem.Text.RegularExpressions;

namespace UnofficialTLDPatch.Utilities
{
    internal class CommonUtilities
    {
        // NOTE: These "Get" methods are volitile. Ensure it is always up to date as otherwise it can break anything tied to GearItem
        // This is used to load prefab info of a GearItem
        [return: NotNullIfNotNull(nameof(name))]
        public static GearItem GetGearItemPrefab(string name) => GearItem.LoadGearItemPrefab(name);
        [return: NotNullIfNotNull(nameof(name))]
        public static ToolsItem GetToolItemPrefab(string name) => GearItem.LoadGearItemPrefab(name).GetComponent<ToolsItem>();
        [return: NotNullIfNotNull(nameof(name))]
        public static ClothingItem GetClothingItemPrefab(string name) => GearItem.LoadGearItemPrefab(name).GetComponent<ClothingItem>();

        /// <summary>
        /// Normalizes the name given to remove extra bits using regex for most of the changes
        /// </summary>
        /// <param name="name">The name of the thing to normalize</param>
        /// <returns>Normalized name without <c>(Clone)</c> or any numbers appended</returns>
        [return: NotNullIfNotNull(nameof(name))]
        public static string? NormalizeName(string name)
        {
            string name0 = Regex.Replace(name, @"(?:\(\d{0,}\))", string.Empty);
            string name1 = Regex.Replace(name0, @"(?:\s\d{0,})", string.Empty);
            string name2 = name1.Replace("(Clone)", string.Empty, StringComparison.InvariantCultureIgnoreCase);
            string name3 = name2.Replace("\0", string.Empty);
            return name3.Trim();
        }
    }
}