using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using KTANE_Solver;
using System.Windows.Forms;
using System.IO;
namespace ModuleTests
{
    [TestClass]
    public class Creation
    {
        StreamWriter streamWriter = new StreamWriter("C:\\Users\\Nya\\Downloads\\delete later\\dummy.txt");

        Bomb bomb = new Bomb(Day.Sunday, "Q88ZQ2", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
                    new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
                    new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
                    new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

        [TestMethod]
        public void GhostTestGoal()
        {
            KTANE_Solver.Creation module = new KTANE_Solver.Creation(bomb, streamWriter, KTANE_Solver.Creation.Weather.Clear, "", "", "", "");
            module.SetUpModule();

            Assert.IsTrue(module.lifeFormList["Ghost"] == module.goal);

            streamWriter.Close();
        }

        [TestMethod]
        public void GhostTestLength()
        {
            KTANE_Solver.Creation module = new KTANE_Solver.Creation(bomb, streamWriter, KTANE_Solver.Creation.Weather.Clear, "", "", "", "");
            module.SetUpModule();

            Assert.IsTrue(module.DirectionCount == 3);

            streamWriter.Close();
        }

        [TestMethod]
        public void GhostTestA()
        {
            KTANE_Solver.Creation module = new KTANE_Solver.Creation(bomb, streamWriter, KTANE_Solver.Creation.Weather.Clear, "", "", "", "");
            module.SetUpModule();

            Assert.AreEqual("Earth + Water", module.Solve(KTANE_Solver.Creation.Weather.Clear, 0));

            streamWriter.Close();
        }

        [TestMethod]
        public void GhostTestB()
        {
            KTANE_Solver.Creation module = new KTANE_Solver.Creation(bomb, streamWriter, KTANE_Solver.Creation.Weather.Clear, "", "", "", "");
            module.SetUpModule();

            Assert.AreEqual("Fire + Air", module.Solve(KTANE_Solver.Creation.Weather.Rain, 1));


            streamWriter.Close();
        }

        [TestMethod]
        public void GhostTestC()
        {
            KTANE_Solver.Creation module = new KTANE_Solver.Creation(bomb, streamWriter, KTANE_Solver.Creation.Weather.Clear, "", "", "", "");
            module.SetUpModule();

            Assert.AreEqual("Water + Energy,\nSwamp + Energy,\nPlasma + Life", module.Solve(KTANE_Solver.Creation.Weather.HeatWave, 2));

            streamWriter.Close();
        }

        [TestMethod]
        public void SeedsTestGoal()
        {
            KTANE_Solver.Creation module = new KTANE_Solver.Creation(bomb, streamWriter, KTANE_Solver.Creation.Weather.HeatWave, "", "Fire", "", "");
            module.SetUpModule();
            streamWriter.Close();
            Assert.AreEqual(module.lifeFormList["Seeds"], module.goal);
        }

        [TestMethod]
        public void SeedsTestLength()
        {
            KTANE_Solver.Creation module = new KTANE_Solver.Creation(bomb, streamWriter, KTANE_Solver.Creation.Weather.HeatWave, "", "Fire", "", "");
            module.SetUpModule();
            streamWriter.Close();
            Assert.IsTrue(module.DirectionCount == 4);

        }

        [TestMethod]
        public void SeedsTestA()
        {
            KTANE_Solver.Creation module = new KTANE_Solver.Creation(bomb, streamWriter, KTANE_Solver.Creation.Weather.HeatWave, "", "Fire", "", "");
            module.SetUpModule();
            string answer = module.Solve(KTANE_Solver.Creation.Weather.HeatWave, 0);
            streamWriter.Close();
            Assert.AreEqual("Water + Air", answer);
        }

        [TestMethod]
        public void SeedsTestB()
        {
            KTANE_Solver.Creation module = new KTANE_Solver.Creation(bomb, streamWriter, KTANE_Solver.Creation.Weather.HeatWave, "", "Fire", "", "");
            module.SetUpModule();
            string answer = module.Solve(KTANE_Solver.Creation.Weather.Rain, 1);
            streamWriter.Close();
            Assert.AreEqual("Earth + Fire,\nSwamp + Energy", answer);
        }

        [TestMethod]
        public void SeedsTestC()
        {
            KTANE_Solver.Creation module = new KTANE_Solver.Creation(bomb, streamWriter, KTANE_Solver.Creation.Weather.HeatWave, "", "Fire", "", "");
            module.SetUpModule();
            string answer = module.Solve(KTANE_Solver.Creation.Weather.Clear, 2);
            streamWriter.Close();
            Assert.AreEqual("Life + Water", answer);
        }

        [TestMethod]
        public void SeedsTestD()
        {
            KTANE_Solver.Creation module = new KTANE_Solver.Creation(bomb, streamWriter, KTANE_Solver.Creation.Weather.HeatWave, "", "Fire", "", "");
            module.SetUpModule();
            string answer = module.Solve(KTANE_Solver.Creation.Weather.Wind, 3);
            streamWriter.Close();
            Assert.AreEqual("Earth + Life,\nWeeds + Egg", answer);
        }

        [TestMethod]
        public void PlanktonTestGoal()
        {
            KTANE_Solver.Creation module = new KTANE_Solver.Creation(bomb, streamWriter, KTANE_Solver.Creation.Weather.HeatWave, "", "Fire", "", "");
            module.SetUpModule();
            streamWriter.Close();
            Assert.AreEqual(module.lifeFormList["Seeds"], module.goal);
        }

        [TestMethod]
        public void PlanktonTestLength()
        {
            KTANE_Solver.Creation module = new KTANE_Solver.Creation(bomb, streamWriter, KTANE_Solver.Creation.Weather.Rain, "", "", "Water", "");
            module.SetUpModule();
            streamWriter.Close();
            Assert.IsTrue(module.DirectionCount == 3);

        }

        [TestMethod]
        public void PlanktonTestA()
        {
            KTANE_Solver.Creation module = new KTANE_Solver.Creation(bomb, streamWriter, KTANE_Solver.Creation.Weather.Rain, "", "", "Water", "");
            module.SetUpModule();
            string answer = module.Solve(KTANE_Solver.Creation.Weather.Rain, 0);
            streamWriter.Close();
            Assert.AreEqual("Earth + Fire", answer);
        }

        [TestMethod]
        public void PlanktonTestB()
        {
            KTANE_Solver.Creation module = new KTANE_Solver.Creation(bomb, streamWriter, KTANE_Solver.Creation.Weather.Rain, "", "", "Water", "");
            module.SetUpModule();
            string answer = module.Solve(KTANE_Solver.Creation.Weather.HeatWave, 1);
            streamWriter.Close();
            Assert.AreEqual("Water + Air,\nSwamp + Energy,\nLife + Swamp", answer);
        }

        [TestMethod]
        public void PlanktonTestC()
        {
            KTANE_Solver.Creation module = new KTANE_Solver.Creation(bomb, streamWriter, KTANE_Solver.Creation.Weather.MeteorShower, "", "", "Water", "");
            module.SetUpModule();
            string answer = module.Solve(KTANE_Solver.Creation.Weather.Clear, 2);
            streamWriter.Close();
            Assert.AreEqual("Bacteria + Water", answer);
        }
    }
}
