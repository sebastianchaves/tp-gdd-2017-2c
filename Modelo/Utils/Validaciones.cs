using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PagoAgilFrba.Modelo.Utils
{
    class Validaciones
    {

        private static String CUIT_REGEX = "\\d{2}\\-\\d{8}\\-\\d";

        public static Boolean validarCuit(String cuit)
        {
            Regex rgx = new Regex(CUIT_REGEX, RegexOptions.IgnoreCase);
            MatchCollection matches = rgx.Matches(cuit);
            return matches.Count > 1;
        }

        public static Boolean campoNumericoMayorA0(String text)
        {
            int i;
            return (Int32.TryParse(text, out i) && i > 0);
        }

        public static Boolean campoNumerico(String text)
        {
            int i;
            return Int32.TryParse(text, out i);
        }
    }
}
