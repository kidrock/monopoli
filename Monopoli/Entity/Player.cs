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
        public string Name { get; protected set; }

        public int Location { get; protected set; }

        private int Round { get; set; }

        public Player(string name)
        {
            this.Location = 0;
            this.Round = 0;
            this.Name = name;
        }

        public void muovi()
        {
            var valoreLancio = Dado.Lancia();
            var maxCaselle = Convert.ToInt16(ConfigurationManager.AppSettings["MaxCaselle"]);
            var risLancio = valoreLancio + this.Location;

            if (risLancio >= maxCaselle)
                this.Location = maxCaselle - risLancio;
            else
                this.Location = risLancio;

            this.Round++;
        }
    }
}
