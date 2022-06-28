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
        StreamWriter streamWriter = new StreamWriter("C:\\delete later\\dummy.txt");

        Bomb bomb1 = new Bomb(Day.Sunday, "Q88ZQ2", 1, 1, new Indicator("BOB", false, false), new Indicator("CAR", false, false),
                    new Indicator("CLR", false, false), new Indicator("FRK", true, true), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
                    new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", true, true), false, 2, new Port("DVID", 0), new Port("Parallel", 1),
                    new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

        Bomb bomb2 = new Bomb(Day.Sunday, "QD0SE8", 6, 4, new Indicator("BOB", true, false), new Indicator("CAR", false, false),
                    new Indicator("CLR", false, false), new Indicator("FRK", false, false), new Indicator("FRQ", false, false), new Indicator("IND", false, false), new Indicator("MSA", false, false), new Indicator("NSA", false, false),
                    new Indicator("SIG", false, false), new Indicator("SND", false, false), new Indicator("TRN", false, false), false, 0, new Port("DVID", 0), new Port("Parallel", 0),
                    new Port("ps", 0), new Port("rj", 0), new Port("serial", 1), new Port("setero", 0));

        #region Ghost
        [TestMethod]
        public void GhostTestGoal()
        {
            KTANE_Solver.Creation module = new KTANE_Solver.Creation(bomb1, streamWriter, KTANE_Solver.Creation.Weather.Clear, "", "", "", "");
            module.SetUpModule();

            Assert.IsTrue(module.lifeFormList["Ghost"] == module.goal);

            streamWriter.Close();
        }

        [TestMethod]
        public void GhostTestLength()
        {
            KTANE_Solver.Creation module = new KTANE_Solver.Creation(bomb1, streamWriter, KTANE_Solver.Creation.Weather.Clear, "", "", "", "");
            module.SetUpModule();

            Assert.IsTrue(module.DirectionCount == 3);

            streamWriter.Close();
        }

        [TestMethod]
        public void GhostTestA()
        {
            KTANE_Solver.Creation module = new KTANE_Solver.Creation(bomb1, streamWriter, KTANE_Solver.Creation.Weather.Clear, "", "", "", "");
            module.SetUpModule();

            Assert.AreEqual("Earth + Water", module.Solve(KTANE_Solver.Creation.Weather.Clear, 0));

            streamWriter.Close();
        }

        [TestMethod]
        public void GhostTestB()
        {
            KTANE_Solver.Creation module = new KTANE_Solver.Creation(bomb1, streamWriter, KTANE_Solver.Creation.Weather.Clear, "", "", "", "");
            module.SetUpModule();

            Assert.AreEqual("Fire + Air", module.Solve(KTANE_Solver.Creation.Weather.Rain, 1));


            streamWriter.Close();
        }

        [TestMethod]
        public void GhostTestC()
        {
            KTANE_Solver.Creation module = new KTANE_Solver.Creation(bomb1, streamWriter, KTANE_Solver.Creation.Weather.Clear, "", "", "", "");
            module.SetUpModule();

            Assert.AreEqual("Water + Energy,\nSwamp + Energy,\nPlasma + Life", module.Solve(KTANE_Solver.Creation.Weather.HeatWave, 2));

            streamWriter.Close();
        }

        #endregion

        #region Seeds

        [TestMethod]
        public void SeedsTestGoal()
        {
            KTANE_Solver.Creation module = new KTANE_Solver.Creation(bomb1, streamWriter, KTANE_Solver.Creation.Weather.HeatWave, "", "Fire", "", "");
            module.SetUpModule();
            streamWriter.Close();
            Assert.AreEqual(module.lifeFormList["Seeds"], module.goal);
        }

        [TestMethod]
        public void SeedsTestLength()
        {
            KTANE_Solver.Creation module = new KTANE_Solver.Creation(bomb1, streamWriter, KTANE_Solver.Creation.Weather.HeatWave, "", "Fire", "", "");
            module.SetUpModule();
            streamWriter.Close();
            Assert.IsTrue(module.DirectionCount == 4);

        }

        [TestMethod]
        public void SeedsTestA()
        {
            KTANE_Solver.Creation module = new KTANE_Solver.Creation(bomb1, streamWriter, KTANE_Solver.Creation.Weather.HeatWave, "", "Fire", "", "");
            module.SetUpModule();
            string answer = module.Solve(KTANE_Solver.Creation.Weather.HeatWave, 0);
            streamWriter.Close();
            Assert.AreEqual("Water + Air", answer);
        }

        [TestMethod]
        public void SeedsTestB()
        {
            KTANE_Solver.Creation module = new KTANE_Solver.Creation(bomb1, streamWriter, KTANE_Solver.Creation.Weather.HeatWave, "", "Fire", "", "");
            module.SetUpModule();
            string answer = module.Solve(KTANE_Solver.Creation.Weather.Rain, 1);
            streamWriter.Close();
            Assert.AreEqual("Earth + Fire,\nSwamp + Energy", answer);
        }

        [TestMethod]
        public void SeedsTestC()
        {
            KTANE_Solver.Creation module = new KTANE_Solver.Creation(bomb1, streamWriter, KTANE_Solver.Creation.Weather.HeatWave, "", "Fire", "", "");
            module.SetUpModule();
            string answer = module.Solve(KTANE_Solver.Creation.Weather.Clear, 2);
            streamWriter.Close();
            Assert.AreEqual("Life + Water", answer);
        }

        [TestMethod]
        public void SeedsTestD()
        {
            KTANE_Solver.Creation module = new KTANE_Solver.Creation(bomb1, streamWriter, KTANE_Solver.Creation.Weather.HeatWave, "", "Fire", "", "");
            module.SetUpModule();
            string answer = module.Solve(KTANE_Solver.Creation.Weather.Wind, 3);
            streamWriter.Close();
            Assert.AreEqual("Earth + Life,\nWeeds + Egg", answer);
        }
        #endregion

        #region Plankton
        [TestMethod]
        public void PlanktonTestGoal()
        {
            KTANE_Solver.Creation module = new KTANE_Solver.Creation(bomb1, streamWriter, KTANE_Solver.Creation.Weather.Rain, "", "", "Water", "");
            module.SetUpModule();
            streamWriter.Close();
            Assert.AreEqual(module.lifeFormList["Plankton"], module.goal);
        }

        [TestMethod]
        public void PlanktonTestLength()
        {
            KTANE_Solver.Creation module = new KTANE_Solver.Creation(bomb1, streamWriter, KTANE_Solver.Creation.Weather.Rain, "", "", "Water", "");
            module.SetUpModule();
            streamWriter.Close();
            Assert.IsTrue(module.DirectionCount == 3);

        }

        [TestMethod]
        public void PlanktonTestA()
        {
            KTANE_Solver.Creation module = new KTANE_Solver.Creation(bomb1, streamWriter, KTANE_Solver.Creation.Weather.Rain, "", "", "Water", "");
            module.SetUpModule();
            string answer = module.Solve(KTANE_Solver.Creation.Weather.Rain, 0);
            streamWriter.Close();
            Assert.AreEqual("Earth + Fire", answer);
        }

        [TestMethod]
        public void PlanktonTestB()
        {
            KTANE_Solver.Creation module = new KTANE_Solver.Creation(bomb1, streamWriter, KTANE_Solver.Creation.Weather.Rain, "", "", "Water", "");
            module.SetUpModule();
            string answer = module.Solve(KTANE_Solver.Creation.Weather.HeatWave, 1);
            streamWriter.Close();
            Assert.AreEqual("Water + Air,\nSwamp + Energy,\nSwamp + Life", answer);
        }

        [TestMethod]
        public void PlanktonTestC()
        {
            KTANE_Solver.Creation module = new KTANE_Solver.Creation(bomb1, streamWriter, KTANE_Solver.Creation.Weather.Rain, "", "", "Water", "");
            module.SetUpModule();
            string answer = module.Solve(KTANE_Solver.Creation.Weather.MeteorShower, 2);
            streamWriter.Close();
            Assert.AreEqual("Water + Bacteria", answer);
        }

        #endregion

        #region Mushroom
        [TestMethod]
        public void MushroomTestGoal()
        {
            KTANE_Solver.Creation module = new KTANE_Solver.Creation(bomb1, streamWriter, KTANE_Solver.Creation.Weather.HeatWave, "Fire", "", "", "");
            module.SetUpModule();
            streamWriter.Close();
            Assert.AreEqual(module.lifeFormList["Mushroom"], module.goal);
        }

        [TestMethod]
        public void MushroomTestLength()
        {
            KTANE_Solver.Creation module = new KTANE_Solver.Creation(bomb1, streamWriter, KTANE_Solver.Creation.Weather.HeatWave, "Fire", "", "", "");
            module.SetUpModule();
            streamWriter.Close();
            Assert.IsTrue(module.DirectionCount == 4);

        }

        [TestMethod]
        public void MushroomTestA()
        {
            KTANE_Solver.Creation module = new KTANE_Solver.Creation(bomb1, streamWriter, KTANE_Solver.Creation.Weather.HeatWave, "Fire", "", "", "");
            module.SetUpModule();
            string answer = module.Solve(KTANE_Solver.Creation.Weather.HeatWave, 0);
            streamWriter.Close();
            Assert.AreEqual("Earth + Water", answer);
        }

        [TestMethod]
        public void MushroomTestB()
        {
            KTANE_Solver.Creation module = new KTANE_Solver.Creation(bomb1, streamWriter, KTANE_Solver.Creation.Weather.HeatWave, "Fire", "", "", "");
            module.SetUpModule();
            string answer = module.Solve(KTANE_Solver.Creation.Weather.Wind, 1);
            streamWriter.Close();
            Assert.AreEqual("Fire + Earth,\nSwamp + Energy", answer);
        }

        [TestMethod]
        public void MushroomTestC()
        {
            KTANE_Solver.Creation module = new KTANE_Solver.Creation(bomb1, streamWriter, KTANE_Solver.Creation.Weather.HeatWave, "Fire", "", "", "");
            module.SetUpModule();
            string answer = module.Solve(KTANE_Solver.Creation.Weather.Clear, 2);
            streamWriter.Close();
            Assert.AreEqual("Life + Water", answer);
        }

        [TestMethod]
        public void MushroomTestD()
        {
            KTANE_Solver.Creation module = new KTANE_Solver.Creation(bomb1, streamWriter, KTANE_Solver.Creation.Weather.HeatWave, "Fire", "", "", "");
            module.SetUpModule();
            string answer = module.Solve(KTANE_Solver.Creation.Weather.Wind, 3);
            streamWriter.Close();
            Assert.AreEqual("Earth + Weeds", answer);
        }

        #endregion

        #region Bird
        [TestMethod]
        public void BirdTestGoal()
        {
            KTANE_Solver.Creation module = new KTANE_Solver.Creation(bomb2, streamWriter, KTANE_Solver.Creation.Weather.Wind, "", "", "Air", "");
            module.SetUpModule();
            streamWriter.Close();
            Assert.AreEqual(module.lifeFormList["Bird"], module.goal);
        }

        [TestMethod]
        public void BirdTestLength()
        {
            KTANE_Solver.Creation module = new KTANE_Solver.Creation(bomb2, streamWriter, KTANE_Solver.Creation.Weather.Wind, "", "", "Air", "");

            module.SetUpModule();
            streamWriter.Close();
            Assert.IsTrue(module.DirectionCount == 4);

        }

        [TestMethod]
        public void BirdTestA()
        {
            KTANE_Solver.Creation module = new KTANE_Solver.Creation(bomb2, streamWriter, KTANE_Solver.Creation.Weather.Wind, "", "", "Air", "");

            module.SetUpModule();
            string answer = module.Solve(KTANE_Solver.Creation.Weather.Wind, 0);
            streamWriter.Close();
            Assert.AreEqual("Earth + Water", answer);
        }

        [TestMethod]
        public void BirdTestB()
        {
            KTANE_Solver.Creation module = new KTANE_Solver.Creation(bomb2, streamWriter, KTANE_Solver.Creation.Weather.Wind, "", "", "Air", "");

            module.SetUpModule();
            string answer = module.Solve(KTANE_Solver.Creation.Weather.MeteorShower, 1);
            streamWriter.Close();
            Assert.AreEqual("Fire + Air,\nSwamp + Energy", answer);
        }

        [TestMethod]
        public void BirdTestC()
        {
            KTANE_Solver.Creation module = new KTANE_Solver.Creation(bomb2, streamWriter, KTANE_Solver.Creation.Weather.Wind, "", "", "Air", "");

            module.SetUpModule();
            string answer = module.Solve(KTANE_Solver.Creation.Weather.Clear, 2);
            streamWriter.Close();
            Assert.AreEqual("Earth + Life", answer);
        }

        [TestMethod]
        public void BirdTestD()
        {
            KTANE_Solver.Creation module = new KTANE_Solver.Creation(bomb2, streamWriter, KTANE_Solver.Creation.Weather.Wind, "", "", "Air", "");

            module.SetUpModule();
            string answer = module.Solve(KTANE_Solver.Creation.Weather.MeteorShower, 3);
            streamWriter.Close();
            Assert.AreEqual("Air + Egg", answer);
        }
        #endregion

        #region Lizard
        [TestMethod]
        public void LizardTestGoal()
        {
            KTANE_Solver.Creation module = new KTANE_Solver.Creation(bomb2, streamWriter, KTANE_Solver.Creation.Weather.Clear, "", "", "", "");
            module.SetUpModule();
            streamWriter.Close();
            Assert.AreEqual(module.lifeFormList["Lizard"], module.goal);
        }

        [TestMethod]
        public void LizardTestLength()
        {
            KTANE_Solver.Creation module = new KTANE_Solver.Creation(bomb2, streamWriter, KTANE_Solver.Creation.Weather.Clear, "", "", "", "");

            module.SetUpModule();
            streamWriter.Close();
            Assert.IsTrue(module.DirectionCount == 3);

        }

        [TestMethod]
        public void LizardTestA()
        {
            KTANE_Solver.Creation module = new KTANE_Solver.Creation(bomb2, streamWriter, KTANE_Solver.Creation.Weather.Clear, "", "", "", "");
            module.SetUpModule();
            string answer = module.Solve(KTANE_Solver.Creation.Weather.Clear, 0);
            streamWriter.Close();
            Assert.AreEqual("Earth + Water", answer);
        }

        [TestMethod]
        public void LizardTestB()
        {
            KTANE_Solver.Creation module = new KTANE_Solver.Creation(bomb2, streamWriter, KTANE_Solver.Creation.Weather.Clear, "", "", "", "");
            module.SetUpModule();
            string answer = module.Solve(KTANE_Solver.Creation.Weather.Rain, 1);
            streamWriter.Close();
            Assert.AreEqual("Fire + Air,\nSwamp + Energy", answer);
        }

        public void LizardTestC()
        {
            KTANE_Solver.Creation module = new KTANE_Solver.Creation(bomb2, streamWriter, KTANE_Solver.Creation.Weather.Clear, "", "", "", "");
            module.SetUpModule();
            string answer = module.Solve(KTANE_Solver.Creation.Weather.Rain, 2);
            streamWriter.Close();
            Assert.AreEqual("Earth + Life,\nSwamp + Egg", answer);
        }
        #endregion

        #region Worm
        [TestMethod]
        public void WormTestGoal()
        {
            KTANE_Solver.Creation module = new KTANE_Solver.Creation(bomb2, streamWriter, KTANE_Solver.Creation.Weather.Wind, "Air", "", "", "");
            module.SetUpModule();
            streamWriter.Close();
            Assert.AreEqual(module.lifeFormList["Worm"], module.goal);
        }

        [TestMethod]
        public void WormTestLength()
        {
            KTANE_Solver.Creation module = new KTANE_Solver.Creation(bomb2, streamWriter, KTANE_Solver.Creation.Weather.Wind, "Air", "", "", "");
            module.SetUpModule();
            streamWriter.Close();
            Assert.IsTrue(module.DirectionCount == 2);

        }

        [TestMethod]
        public void WormTestA()
        {
            KTANE_Solver.Creation module = new KTANE_Solver.Creation(bomb2, streamWriter, KTANE_Solver.Creation.Weather.Wind, "Air", "", "", "");
            module.SetUpModule();
            string answer = module.Solve(KTANE_Solver.Creation.Weather.Wind, 0);
            streamWriter.Close();
            Assert.AreEqual("Earth + Water", answer);
        }

        [TestMethod]
        public void WormTestB()
        {
            KTANE_Solver.Creation module = new KTANE_Solver.Creation(bomb2, streamWriter, KTANE_Solver.Creation.Weather.Wind, "Air", "", "", "");
            module.SetUpModule();
            string answer = module.Solve(KTANE_Solver.Creation.Weather.Rain, 1);
            streamWriter.Close();
            Assert.AreEqual("Fire + Air,\nSwamp + Energy,\nSwamp + Life,\nSwamp + Bacteria", answer);
        }
        #endregion

        #region Dinosaur
        [TestMethod]
        public void DinosaurTestGoal()
        {
            KTANE_Solver.Creation module = new KTANE_Solver.Creation(bomb2, streamWriter, KTANE_Solver.Creation.Weather.HeatWave, "Fire", "", "", "");
            module.SetUpModule();
            streamWriter.Close();
            Assert.AreEqual(module.lifeFormList["Dinosaur"], module.goal);
        }

        [TestMethod]
        public void DinosaurTestLength()
        {
            KTANE_Solver.Creation module = new KTANE_Solver.Creation(bomb2, streamWriter, KTANE_Solver.Creation.Weather.HeatWave, "Fire", "", "", "");
            module.SetUpModule();
            streamWriter.Close();
            Assert.IsTrue(module.DirectionCount == 4);

        }

        [TestMethod]
        public void DinosaurTestA()
        {
            KTANE_Solver.Creation module = new KTANE_Solver.Creation(bomb2, streamWriter, KTANE_Solver.Creation.Weather.HeatWave, "Fire", "", "", "");
            module.SetUpModule();
            string answer = module.Solve(KTANE_Solver.Creation.Weather.HeatWave, 0);
            streamWriter.Close();
            Assert.AreEqual("Earth + Water", answer);
        }

        [TestMethod]
        public void DinosaurTestB()
        {
            KTANE_Solver.Creation module = new KTANE_Solver.Creation(bomb2, streamWriter, KTANE_Solver.Creation.Weather.HeatWave, "Fire", "", "", "");
            module.SetUpModule();
            string answer = module.Solve(KTANE_Solver.Creation.Weather.Clear, 1);
            streamWriter.Close();
            Assert.AreEqual("Fire + Air,\nSwamp + Energy", answer);
        }

        [TestMethod]
        public void DinosaurTestC()
        {
            KTANE_Solver.Creation module = new KTANE_Solver.Creation(bomb2, streamWriter, KTANE_Solver.Creation.Weather.HeatWave, "Fire", "", "", "");
            module.SetUpModule();
            string answer = module.Solve(KTANE_Solver.Creation.Weather.HeatWave, 2);
            streamWriter.Close();
            Assert.AreEqual("Earth + Life", answer);
        }

        [TestMethod]
        public void DinosaurTestD()
        {
            KTANE_Solver.Creation module = new KTANE_Solver.Creation(bomb2, streamWriter, KTANE_Solver.Creation.Weather.HeatWave, "Fire", "", "", "");
            module.SetUpModule();
            string answer = module.Solve(KTANE_Solver.Creation.Weather.MeteorShower, 3);
            streamWriter.Close();
            Assert.AreEqual("Air + Egg", answer);
        }
        #endregion

        #region Turtle
        [TestMethod]
        public void TurtleTestGoal()
        {
            KTANE_Solver.Creation module = new KTANE_Solver.Creation(bomb2, streamWriter, KTANE_Solver.Creation.Weather.MeteorShower, "Earth", "", "", "");
            module.SetUpModule();
            streamWriter.Close();
            Assert.AreEqual(module.lifeFormList["Turtle"], module.goal);
        }

        [TestMethod]
        public void TurtleTestLength()
        {
            KTANE_Solver.Creation module = new KTANE_Solver.Creation(bomb2, streamWriter, KTANE_Solver.Creation.Weather.MeteorShower, "Earth", "", "", "");
            module.SetUpModule();
            streamWriter.Close();
            Assert.IsTrue(module.DirectionCount == 4);

        }

        [TestMethod]
        public void TurtleTestA()
        {
            KTANE_Solver.Creation module = new KTANE_Solver.Creation(bomb2, streamWriter, KTANE_Solver.Creation.Weather.MeteorShower, "Earth", "", "", "");
            module.SetUpModule();
            string answer = module.Solve(KTANE_Solver.Creation.Weather.MeteorShower, 0);
            streamWriter.Close();
            Assert.AreEqual("Air + Water", answer);
        }

        [TestMethod]
        public void TurtleTestB()
        {
            KTANE_Solver.Creation module = new KTANE_Solver.Creation(bomb2, streamWriter, KTANE_Solver.Creation.Weather.MeteorShower, "Earth", "", "", "");
            module.SetUpModule();
            string answer = module.Solve(KTANE_Solver.Creation.Weather.Clear, 1);
            streamWriter.Close();
            Assert.AreEqual("Fire + Air,\nSwamp + Energy", answer);
        }

        [TestMethod]
        public void TurtleTestC()
        {
            KTANE_Solver.Creation module = new KTANE_Solver.Creation(bomb2, streamWriter, KTANE_Solver.Creation.Weather.MeteorShower, "Earth", "", "", "");
            module.SetUpModule();
            string answer = module.Solve(KTANE_Solver.Creation.Weather.Wind, 2);
            streamWriter.Close();
            Assert.AreEqual("Earth + Life", answer);
        }

        [TestMethod]
        public void TurtleTestD()
        {
            KTANE_Solver.Creation module = new KTANE_Solver.Creation(bomb2, streamWriter, KTANE_Solver.Creation.Weather.MeteorShower, "Earth", "", "", "");
            module.SetUpModule();
            string answer = module.Solve(KTANE_Solver.Creation.Weather.MeteorShower, 3);
            streamWriter.Close();
            Assert.AreEqual("Water + Egg", answer);
        }
        #endregion
    }
}
