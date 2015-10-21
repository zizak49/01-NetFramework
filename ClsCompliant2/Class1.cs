using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

[assembly:CLSCompliant(true)]
namespace ProvideTime
{
    public class B
    {
        public void Metoda()
        {
            TimeProvider.
        }
    }
    public class TimeProvider
    {
        /// <summary>
        ///   Vraća trenutni datum u obliku stringa.
        /// </summary>
        /// <returns>
        ///   Datum u obliku stringa.
        /// </returns>
        public static string GetDateTime()
        {
            return DateTime.Now.ToString();
        }

        /// <summary>
        ///  Opis
        /// </summary>
        /// <param name="ime">
        ///   Parametar
        /// </param>
        /// <returns>
        /// </returns>
        public static string Getdatetime(string ime)
        {
            return DateTime.Now.ToShortTimeString();
        }

        //private static string GetDatetime()
        //{
        //    return DateTime.UtcNow.ToLongDateString();
        //}

    }
}
