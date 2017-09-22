using Monopoli.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoli.Business.Model
{
    public class Gioco
    {
        public List<Player> Giocatori { get; protected set; }

        public int Turno { get; protected set; }

        public static Gioco Create(List<Player> giocatori)
        {
            int numGiocatori = giocatori.Count();
            if (numGiocatori < 2 || numGiocatori > 8)
                throw new Exception(string.Format("Si sta giocando in {0}.Il nunmero di giocatori non è compreso tra {1} e {2}", numGiocatori, 2, 8));

            Gioco gioco = new Gioco();
            Random rnd = new Random();

            gioco.Giocatori = giocatori.OrderBy(p => rnd.Next(0, giocatori.Count())).ToList();

            return gioco;
        }

        public Gioco()
        {
            this.Turno = 0;
        }

        public void UpdateTurno()
        {
            this.Turno += 1;
        }


    }
}
