using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Monopoli.Test
{
    [TestClass]
    public class PlayerTest
    {
        private int VALORE_DADI_LANCIO = 7;

        [TestMethod]
        public void LocationTest()
        {
            var giocatore = Monopoli.Entity.Player.Create("fungo");

            Assert.AreEqual(giocatore.Casella, 0);

            giocatore.Muovi(VALORE_DADI_LANCIO);

            Assert.AreEqual(giocatore.Casella, VALORE_DADI_LANCIO);
        }
    }
}
