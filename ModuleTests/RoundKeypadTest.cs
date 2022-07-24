using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using KTANE_Solver;
using System.Collections.Generic;
namespace ModuleTests
{
    [TestClass]
    public class RoundKeypadTest
    {
        StreamWriter streamWriter = new StreamWriter("C:\\Users\\nyabe\\Downloads\\delete later\\dummy.txt");

        [TestMethod]
        public void TestMethod1()
        {
            RoundKeypad module = new RoundKeypad(null, streamWriter, new List<RoundKeypad.Symbol>() { RoundKeypad.Symbol.Lightning, RoundKeypad.Symbol.Lambda, RoundKeypad.Symbol.Omega, RoundKeypad.Symbol.Swirl, RoundKeypad.Symbol.UfinishedR, RoundKeypad.Symbol.WhiteStar, RoundKeypad.Symbol.N, RoundKeypad.Symbol.Three });
            RoundKeypad.Symbol[] answer = module.Solve();


            Assert.AreEqual(answer.Length, 4);
            Assert.IsTrue(Array.Exists(answer, symbol => symbol == RoundKeypad.Symbol.Lightning)); 
            Assert.IsTrue(Array.Exists(answer, symbol => symbol == RoundKeypad.Symbol.Omega));
            Assert.IsTrue(Array.Exists(answer, symbol => symbol == RoundKeypad.Symbol.N));
            Assert.IsTrue(Array.Exists(answer, symbol => symbol == RoundKeypad.Symbol.Three));

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod2()
        {
            RoundKeypad module = new RoundKeypad(null, streamWriter, new List<RoundKeypad.Symbol>() { RoundKeypad.Symbol.Squid, RoundKeypad.Symbol.Swirl, RoundKeypad.Symbol.Hashtag, RoundKeypad.Symbol.E, RoundKeypad.Symbol.BackwardsC, RoundKeypad.Symbol.Three, RoundKeypad.Symbol.Copyright, RoundKeypad.Symbol.A });
            RoundKeypad.Symbol[] answer = module.Solve();

            Assert.AreEqual(answer.Length, 5);
            Assert.IsTrue(Array.Exists(answer, symbol => symbol == RoundKeypad.Symbol.Squid));
            Assert.IsTrue(Array.Exists(answer, symbol => symbol == RoundKeypad.Symbol.Hashtag));
            Assert.IsTrue(Array.Exists(answer, symbol => symbol == RoundKeypad.Symbol.Three));
            Assert.IsTrue(Array.Exists(answer, symbol => symbol == RoundKeypad.Symbol.A));
            Assert.IsTrue(Array.Exists(answer, symbol => symbol == RoundKeypad.Symbol.Copyright));

            streamWriter.Close();
        }
    }
}
