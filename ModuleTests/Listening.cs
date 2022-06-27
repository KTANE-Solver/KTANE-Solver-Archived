using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using KTANE_Solver;
using System.IO;
using System.Windows.Forms;

namespace ModuleTests
{
    [TestClass]
    public class Listening
    {
        [TestMethod]
        public void CorrectAnswers()
        {
            StreamWriter streamWriter = new StreamWriter("C:\\delete later\\dummy.txt");

            KTANE_Solver.Listening module = new KTANE_Solver.Listening("Taxi Dispatch", null, streamWriter);
            Assert.AreEqual("&&&**", module.DebugSolve());

            module = new KTANE_Solver.Listening("Cow", null, streamWriter);
            Assert.AreEqual("&$#$&", module.DebugSolve());

            module = new KTANE_Solver.Listening("Extractor Fan", null, streamWriter);
            Assert.AreEqual("$#$*&", module.DebugSolve());

            module = new KTANE_Solver.Listening("Train Station", null, streamWriter);
            Assert.AreEqual("#$$**", module.DebugSolve());

            module = new KTANE_Solver.Listening("Arcade", null, streamWriter);
            Assert.AreEqual("$#$#*", module.DebugSolve());

            module = new KTANE_Solver.Listening("Casino", null, streamWriter);
            Assert.AreEqual("**$*#", module.DebugSolve());

            module = new KTANE_Solver.Listening("Supermarket", null, streamWriter);
            Assert.AreEqual("#$$&*", module.DebugSolve());

            module = new KTANE_Solver.Listening("Soccer Match", null, streamWriter);
            Assert.AreEqual("##*$*", module.DebugSolve());

            module = new KTANE_Solver.Listening("Tawny Owl", null, streamWriter);
            Assert.AreEqual("$#*$&", module.DebugSolve());

            module = new KTANE_Solver.Listening("Sewing Machine", null, streamWriter);
            Assert.AreEqual("#&&*#", module.DebugSolve());

            module = new KTANE_Solver.Listening("Thrush Nightingale", null, streamWriter);
            Assert.AreEqual("**#**", module.DebugSolve());

            module = new KTANE_Solver.Listening("Car Engine", null, streamWriter);
            Assert.AreEqual("&#**&", module.DebugSolve());

            module = new KTANE_Solver.Listening("Reloading Glock 19", null, streamWriter);
            Assert.AreEqual("$&**#", module.DebugSolve());

            module = new KTANE_Solver.Listening("Oboe", null, streamWriter);
            Assert.AreEqual("&#$$#", module.DebugSolve());

            module = new KTANE_Solver.Listening("Saxophone", null, streamWriter);
            Assert.AreEqual("$&&**", module.DebugSolve());

            module = new KTANE_Solver.Listening("Tuba", null, streamWriter);
            Assert.AreEqual("#&$##", module.DebugSolve());

            module = new KTANE_Solver.Listening("Marimba", null, streamWriter);
            Assert.AreEqual("&*$*$", module.DebugSolve());

            module = new KTANE_Solver.Listening("Phone Ringing", null, streamWriter);
            Assert.AreEqual("&$$&*", module.DebugSolve());

            module = new KTANE_Solver.Listening("Tibetan Nuns", null, streamWriter);
            Assert.AreEqual("#&&&&", module.DebugSolve());

            module = new KTANE_Solver.Listening("Throat Singing", null, streamWriter);
            Assert.AreEqual("**$$$", module.DebugSolve());

            module = new KTANE_Solver.Listening("Beach", null, streamWriter);
            Assert.AreEqual("*&*&&", module.DebugSolve());

            module = new KTANE_Solver.Listening("Dial-up Internet", null, streamWriter);
            Assert.AreEqual("*#&*&", module.DebugSolve());

            module = new KTANE_Solver.Listening("Police Radio Scanner", null, streamWriter);
            Assert.AreEqual("**###", module.DebugSolve());

            module = new KTANE_Solver.Listening("Censorship Bleep", null, streamWriter);
            Assert.AreEqual("&&$&*", module.DebugSolve());

            module = new KTANE_Solver.Listening("Medieval Weapons", null, streamWriter);
            Assert.AreEqual("&$**&", module.DebugSolve());

            module = new KTANE_Solver.Listening("Door Closing", null, streamWriter);
            Assert.AreEqual("#$#&$", module.DebugSolve());

            module = new KTANE_Solver.Listening("Chainsaw", null, streamWriter);
            Assert.AreEqual("&#&&#", module.DebugSolve());

            module = new KTANE_Solver.Listening("Compressed Air", null, streamWriter);
            Assert.AreEqual("$$*$*", module.DebugSolve());

            module = new KTANE_Solver.Listening("Servo Motor", null, streamWriter);
            Assert.AreEqual("$&#$$", module.DebugSolve());

            module = new KTANE_Solver.Listening("Waterfall", null, streamWriter);
            Assert.AreEqual("&**$$", module.DebugSolve());

            module = new KTANE_Solver.Listening("Tearing Fabric", null, streamWriter);
            Assert.AreEqual("$&&*&", module.DebugSolve());

            module = new KTANE_Solver.Listening("Zipper", null, streamWriter);
            Assert.AreEqual("&$&##", module.DebugSolve());

            module = new KTANE_Solver.Listening("Vacuum Cleaner", null, streamWriter);
            Assert.AreEqual("#&$*&", module.DebugSolve());

            module = new KTANE_Solver.Listening("Ballpoint Pen Writing", null, streamWriter);
            Assert.AreEqual("$*$**", module.DebugSolve());

            module = new KTANE_Solver.Listening("Rattling Iron Chain", null, streamWriter);
            Assert.AreEqual("*#$&&", module.DebugSolve());

            module = new KTANE_Solver.Listening("Book Page Turning", null, streamWriter);
            Assert.AreEqual("###&$", module.DebugSolve());

            module = new KTANE_Solver.Listening("Table Tennis", null, streamWriter);
            Assert.AreEqual("*$$&$", module.DebugSolve());

            module = new KTANE_Solver.Listening("Squeaky Toy", null, streamWriter);
            Assert.AreEqual("$*&##", module.DebugSolve());

            module = new KTANE_Solver.Listening("Helicopter", null, streamWriter);
            Assert.AreEqual("#&$&&", module.DebugSolve());

            module = new KTANE_Solver.Listening("Firework Exploding", null, streamWriter);
            Assert.AreEqual("$&$$*", module.DebugSolve());

            module = new KTANE_Solver.Listening("Glass Shattering", null, streamWriter);
            Assert.AreEqual("*$*$*", module.DebugSolve());
        }
    }
}
