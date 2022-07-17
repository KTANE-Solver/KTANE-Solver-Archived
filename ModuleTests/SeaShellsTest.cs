using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using KTANE_Solver;
using System.IO;

namespace ModuleTests
{
    [TestClass]
    public class SeaShellsTest
    {
        StreamWriter streamWriter = new StreamWriter("C:\\Users\\Nya\\Downloads\\delete later\\dummy.txt");
        
        [TestMethod]
        public void Table1()
        {
            SeaShells module = new SeaShells(null, streamWriter, "SHE SELLS", "SEA SHELLS", "SHIH TZU");
            Assert.AreEqual("BDABDAB", module.FindLetters());
            
            module = new SeaShells(null, streamWriter, "SHE SHELLS", "SEA SHELLS", "SHIH TZU");
            Assert.AreEqual("BEEBBE", module.FindLetters());

            module = new SeaShells(null, streamWriter, "SEA SHELLS", "SEA SHELLS", "SHIH TZU");
            Assert.AreEqual("ABABA", module.FindLetters());

            module = new SeaShells(null, streamWriter, "SEA SELLS", "SEA SHELLS", "SHIH TZU");
            Assert.AreEqual("ACACEAC", module.FindLetters());

            module = new SeaShells(null, streamWriter, "SHE SELLS", "SHE SHELLS", "SHIH TZU");
            Assert.AreEqual("ACEEAC", module.FindLetters());

            module = new SeaShells(null, streamWriter, "SHE SHELLS", "SHE SHELLS", "SHIH TZU");
            Assert.AreEqual("CDCCDB", module.FindLetters());

            module = new SeaShells(null, streamWriter, "SEA SHELLS", "SHE SHELLS", "SHIH TZU");
            Assert.AreEqual("EAAEEA", module.FindLetters());

            module = new SeaShells(null, streamWriter, "SEA SELLS", "SHE SHELLS", "SHIH TZU");
            Assert.AreEqual("DBAEC", module.FindLetters());

            module = new SeaShells(null, streamWriter, "SHE SELLS", "SEA SELLS", "SHIH TZU");
            Assert.AreEqual("EACEACE", module.FindLetters());

            module = new SeaShells(null, streamWriter, "SHE SHELLS", "SEA SELLS", "SHIH TZU");
            Assert.AreEqual("EAEAEA", module.FindLetters());

            module = new SeaShells(null, streamWriter, "SEA SHELLS", "SEA SELLS", "SHIH TZU");
            Assert.AreEqual("DBEAC", module.FindLetters());

            module = new SeaShells(null, streamWriter, "SEA SELLS", "SEA SELLS", "SHIH TZU");
            Assert.AreEqual("EBDADAB", module.FindLetters());

            module = new SeaShells(null, streamWriter, "SHE SELLS", "SHE SELLS", "SHIH TZU");
            Assert.AreEqual("DAABDAB", module.FindLetters());

            module = new SeaShells(null, streamWriter, "SHE SHELLS", "SHE SELLS", "SHIH TZU");
            Assert.AreEqual("BEEDA", module.FindLetters());

            module = new SeaShells(null, streamWriter, "SEA SHELLS", "SHE SELLS", "SHIH TZU");
            Assert.AreEqual("ABDBAA", module.FindLetters());

            module = new SeaShells(null, streamWriter, "SEA SELLS", "SHE SELLS", "SHIH TZU");
            Assert.AreEqual("CECEC", module.FindLetters());

            streamWriter.Close();
        }

        [TestMethod]
        public void Table2()
        {
            SeaShells module = new SeaShells(null, streamWriter, "SEA SELLS", "SHE SHELLS", "SHIH TZU");

            Assert.AreEqual("sit, shih tzu, shoe, sushi, she".ToUpper(),module.Solve());

            module = new SeaShells(null, streamWriter, "SEA SELLS", "SHE SHELLS", "TOUCAN");

            Assert.AreEqual("2, toucan, can, cancan, tutu".ToUpper(), module.Solve());

            module = new SeaShells(null, streamWriter, "SEA SELLS", "SHE SHELLS", "SWITCH");

            Assert.AreEqual("twitch, switch, witch, stitch, itch".ToUpper(), module.Solve());

            module = new SeaShells(null, streamWriter, "SEA SELLS", "SHE SHELLS", "BURGLAR ALARM");

            Assert.AreEqual("burger, Bulgaria, burglar alarm, llama, armour".ToUpper(), module.Solve());



        }
    }
}
