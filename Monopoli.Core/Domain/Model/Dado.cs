using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace Monopoli.Model
{
    public static class Dado
    {
        public static int Lancia()
        {
            var dadiusati = Convert.ToInt16(ConfigurationManager.AppSettings["NumDadi"]);
            return new Random().Next(0, 6) * dadiusati;
        }
    }
}
