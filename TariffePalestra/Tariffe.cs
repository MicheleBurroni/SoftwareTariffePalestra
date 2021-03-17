using System;

namespace TariffePalestra
{
    public class Tariffe
    {
        public static string OfferteTariffe(int giorni)
        {
            
            if(giorni < 90)
            {
                return "La tariffa consigliata è quella da 115,99 euro.";
            }
        }
    }
}
