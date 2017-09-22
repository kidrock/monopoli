using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoli.Business.Model;
using System.Collections.Generic;
using Monopoli.Model;

namespace Monopoli.Test
{
    [TestClass]
    public class GiocoTestModel
    {
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
    }
}
