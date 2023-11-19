using UnofficialTLDPatch.Utilities;
using UnofficialTLDPatch.Utilities.Exceptions;
using UnofficialTLDPatch.Utilities.Logger;

namespace UnofficialTLDPatch.Patches.GearItems
{
    [HarmonyPatch(typeof(GearItem), nameof(GearItem.Awake))]
    public class FixNaturalFoods
    {
        public static List<string> GearList { get; } = new()
        {
            "GEAR_CookedPieMeat"
        };

        public static void Prefix(GearItem __instance)
        {
            if (__instance == null) return;

            if (!Settings.Instance.FixNaturalFoods) return;

            if (__instance.name != null && GearList.Contains(CommonUtilities.NormalizeName(__instance.name)))
            {
                FoodItem foodItem = __instance.m_FoodItem;

                if (foodItem == null) return;

                foodItem.m_HarvestedByPlayer = true;
                foodItem.m_IsNatural = true;
            }
        }
    }
}
