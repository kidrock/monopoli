using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoli.Business.Model;
using System.Collections.Generic;
using Monopoli.Model;
using Monopoli.Business.Domain.Service;

namespace Monopoli.Test
{
    [TestClass]
    public class GiocoTestModel
    {
        private int MAX_TURNI = 20;
        private int MAX_CARTELLE = 39;
        private List<Player> GIOCATORI = new List<Player>() { Player.Create("Cavallo"), Player.Create("Macchina") };

        [TestMethod]
        public void InizializzazioneGioco()
        {
            Gioco gioco = Gioco.Create(GIOCATORI);

            Assert.AreEqual(gioco.Giocatori.Find(g => g.Nome == "Cavallo") != null ? true : false, true);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Errore_InizializzazioneGioco_MenoNumeroMinimo()
        {
            List<Player> giocatori = new List<Player>() { Player.Create("Cavallo") };
            Gioco gioco = Gioco.Create(giocatori);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Errore_InizializzazioneGioco_Troppigiocatori()
        {
            List<Player> giocatori = new List<Player>() { Player.Create("Cavallo"),Player.Create("Macchina"),
                                                            Player.Create("Cappello"),Player.Create("FerroDaStiro"),
                                                            Player.Create("FerroDaStiro"),Player.Create("Scarpa"),
                                                            Player.Create("Cane"),Player.Create("Nave"),
                                                            Player.Create("Moto")};
            Gioco gioco = Gioco.Create(giocatori);
        }


        [TestMethod]
        public void Controlla_Ogni_Giocatore_Completa_Turni()
        {
            Gioco gioco = Gioco.Create(new List<Player>() { Player.Create("Cavallo"), Player.Create("Macchina") });
            PlayerService ps = new PlayerService(MAX_CARTELLE, MAX_TURNI);

            for (int i = 0; i < MAX_TURNI; i++)
            {
                gioco.UpdateTurno();

                foreach (var giocatore in gioco.Giocatori)
                {
                    ps.Muovi(giocatore, Dado.Lancia());
                }
            }

            Assert.AreEqual(gioco.Turno, this.MAX_TURNI);
            Assert.AreEqual(gioco.Giocatori.TrueForAll(g => g.Turno == this.MAX_TURNI), true);
        }

    }
}
