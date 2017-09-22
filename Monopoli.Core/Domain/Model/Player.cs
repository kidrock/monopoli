using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoli.Model
{
    public class Player
    {
        public string Nome { get; protected set; }

        public int Casella { get; protected set; }

        public int Turno { get; protected set; }

        private Player()
        {
            this.Casella = 0;
            this.Turno = 0;
        }

        public static Player Create(string nome)
        {
            var player = new Player();

            player.Nome = nome;

            return player;
        }

        public void Update(int casella)
        {
            this.Casella = casella;
            this.Turno += 1;
        }
    }
}
