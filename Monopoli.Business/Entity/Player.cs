using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoli.Entity
{
    public class Player
    {
        public string Name { get; protected set; }

        public int Casella { get; protected set; }

        private int Round { get; set; }

        public Player(string name)
        {
            this.Casella = 0;
            this.Round = 0;
            this.Name = name;
        }

        public void muovi()
        {
            var valoreLancio = Dado.Lancia();

            this.Casella = this.CalcolaValoreCasella(Dado.Lancia());

            this.Round++;
        }

        private int CalcolaValoreCasella(int valorelancio)
        {
            var maxCaselle = Convert.ToInt16(ConfigurationManager.AppSettings["MaxCaselle"]);
            var risLancio = valorelancio + this.Casella;

            if (risLancio >= maxCaselle)
                return risLancio - maxCaselle;
            else
                return risLancio;
        }
    }
}
