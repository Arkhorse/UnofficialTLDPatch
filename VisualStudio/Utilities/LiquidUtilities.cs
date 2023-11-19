using Il2CppTLD.Gear;
using UnofficialTLDPatch.Utilities.Logger;

namespace UnofficialTLDPatch.Utilities
{
    public class LiquidUtilities
    {
        public enum Liquid { Potable, NonPotable, Kerosene, Antiseptic }
        public static LiquidType GetLiquid(Liquid liquid)
        {
            try
            {
                return liquid switch
                {
                    Liquid.Potable          => LiquidType.GetPotableWater(),
                    Liquid.NonPotable       => LiquidType.GetNonPotableWater(),
                    Liquid.Kerosene         => LiquidType.GetKerosene(),
                    Liquid.Antiseptic       => LiquidType.GetAntiseptic(),
                    _                       => throw new NotImplementedException()
                };
            }
            catch
            {
                // this is here to give a proper error as otherwise ML does not log which mod threw the error
                Logging.LogError("LiquidType was not found");
                throw;
            }
        }
    }
}
