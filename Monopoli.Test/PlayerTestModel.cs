using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Monopoli.Test
{
    [TestClass]
    public class PlayerTestModel
    {
        private int VALORE_DADI_LANCIO = 7;

        [TestMethod]
        public void LocationTest()
        {
            var giocatore = Monopoli.Model.Player.Create("fungo");

            Assert.AreEqual(giocatore.Casella, 0);

            giocatore.Update(VALORE_DADI_LANCIO);

            Assert.AreEqual(giocatore.Casella, VALORE_DADI_LANCIO);
        }
    }
}
