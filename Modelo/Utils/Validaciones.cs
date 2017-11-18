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
        private static String EMAIL_REGEX = ".*?@.*?\\..+?(\\..*?)?";

        public static Boolean validarCuit(String cuit)
        {
            Regex rgx = new Regex(CUIT_REGEX, RegexOptions.IgnoreCase);
            MatchCollection matches = rgx.Matches(cuit);
            return matches.Count > 0;
        }

        public static bool campoNumericoMayorA0(String text)
        {
            int i;
            return (Int32.TryParse(text, out i) && i > 0);
        }

        public static bool campoNumerico(String text)
        {
            int i;
            return Int32.TryParse(text, out i);
        }

        public static bool mailValido(String mail) {
            return Regex.IsMatch(mail,
                @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
        }
    }
}
