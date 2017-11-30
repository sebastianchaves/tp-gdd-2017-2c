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

        private static String CUIT_REGEX = "([0-9]{2})\\-([0-9]{8})\\-([0-9]{1})$";
        private static String EMAIL_REGEX = ".*?@.*?\\..+?(\\..*?)?";

        public static Boolean validarCuit(String cuit)
        {
            Regex rgx = new Regex(CUIT_REGEX, RegexOptions.IgnoreCase | RegexOptions.ECMAScript);

            Boolean matchea = rgx.IsMatch(cuit);

            return matchea;
        }

        public static Boolean numeroEnRango(String numeroS, int parteEntera)
        {
            Decimal numero;
            if (Decimal.TryParse(numeroS, out numero))
            {
                return numero < (Decimal)Math.Pow(10, parteEntera);
            }
            else
            {
                return false;
            }
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
