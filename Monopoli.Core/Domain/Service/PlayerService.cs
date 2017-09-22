using Monopoli.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoli.Business.Domain.Service
{
    public class PlayerService
    {
        private int MaxCaselle;
        private int MaxTurni;

        public PlayerService(int maxCaselle, int maxTurni) {

            this.MaxCaselle = maxCaselle;
            this.MaxTurni = maxTurni;
        }

        public void Muovi(Player giocatore,int valoreTiro)
        {
            if (giocatore.Turno == this.MaxTurni)
                throw new Exception("Raggiunto il numero massimo di turni pssibili");

            int nextCasella = giocatore.Casella + valoreTiro;

            if (nextCasella >= this.MaxCaselle)
                nextCasella = nextCasella - this.MaxCaselle;

            giocatore.Update(nextCasella);
        }

    }
}
