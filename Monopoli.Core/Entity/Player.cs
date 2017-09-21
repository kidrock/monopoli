﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoli.Entity
{
    public class Player
    {
        public string Nome { get; protected set; }

        public int Casella { get; protected set; }

        private Player()
        {
            this.Casella = 0;
        }

        public static Player Create(string nome)
        {
            var player = new Player();

            player.Nome = nome;

            return player;
        }

        public void Muovi(int valoreDado)
        {
            var prossimaCasella = valoreDado + this.Casella;

            if (prossimaCasella >= 39)
                this.Casella = prossimaCasella - 39;
            else
                this.Casella = prossimaCasella;
        }

    }
}
