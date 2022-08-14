using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using KTANE_Solver;
using System.IO;
using System.Windows.Forms;

namespace ModuleTests
{
    [TestClass]
    public class ListeningTest
    {
        [TestMethod]
        public void CorrectAnswers()
        {
            StreamWriter streamWriter = new StreamWriter("dummy.txt");

            Listening module = new Listening("Taxi Dispatch", null, streamWriter);
            Assert.AreEqual("&&&**", module.DebugSolve());

            module = new Listening("Cow", null, streamWriter);
            Assert.AreEqual("&$#$&", module.DebugSolve());

            module = new Listening("Extractor Fan", null, streamWriter);
            Assert.AreEqual("$#$*&", module.DebugSolve());

            module = new Listening("Train Station", null, streamWriter);
            Assert.AreEqual("#$$**", module.DebugSolve());

            module = new Listening("Arcade", null, streamWriter);
            Assert.AreEqual("$#$#*", module.DebugSolve());

            module = new Listening("Casino", null, streamWriter);
            Assert.AreEqual("**$*#", module.DebugSolve());

            module = new Listening("Supermarket", null, streamWriter);
            Assert.AreEqual("#$$&*", module.DebugSolve());

            module = new Listening("Soccer Match", null, streamWriter);
            Assert.AreEqual("##*$*", module.DebugSolve());

            module = new Listening("Tawny Owl", null, streamWriter);
            Assert.AreEqual("$#*$&", module.DebugSolve());

            module = new Listening("Sewing Machine", null, streamWriter);
            Assert.AreEqual("#&&*#", module.DebugSolve());

            module = new Listening("Thrush Nightingale", null, streamWriter);
            Assert.AreEqual("**#**", module.DebugSolve());

            module = new Listening("Car Engine", null, streamWriter);
            Assert.AreEqual("&#**&", module.DebugSolve());

            module = new Listening("Reloading Glock 19", null, streamWriter);
            Assert.AreEqual("$&**#", module.DebugSolve());

            module = new Listening("Oboe", null, streamWriter);
            Assert.AreEqual("&#$$#", module.DebugSolve());

            module = new Listening("Saxophone", null, streamWriter);
            Assert.AreEqual("$&&**", module.DebugSolve());

            module = new Listening("Tuba", null, streamWriter);
            Assert.AreEqual("#&$##", module.DebugSolve());

            module = new Listening("Marimba", null, streamWriter);
            Assert.AreEqual("&*$*$", module.DebugSolve());

            module = new Listening("Phone Ringing", null, streamWriter);
            Assert.AreEqual("&$$&*", module.DebugSolve());

            module = new Listening("Tibetan Nuns", null, streamWriter);
            Assert.AreEqual("#&&&&", module.DebugSolve());

            module = new Listening("Throat Singing", null, streamWriter);
            Assert.AreEqual("**$$$", module.DebugSolve());

            module = new Listening("Beach", null, streamWriter);
            Assert.AreEqual("*&*&&", module.DebugSolve());

            module = new Listening("Dial-up Internet", null, streamWriter);
            Assert.AreEqual("*#&*&", module.DebugSolve());

            module = new Listening("Police Radio Scanner", null, streamWriter);
            Assert.AreEqual("**###", module.DebugSolve());

            module = new Listening("Censorship Bleep", null, streamWriter);
            Assert.AreEqual("&&$&*", module.DebugSolve());

            module = new Listening("Medieval Weapons", null, streamWriter);
            Assert.AreEqual("&$**&", module.DebugSolve());

            module = new Listening("Door Closing", null, streamWriter);
            Assert.AreEqual("#$#&$", module.DebugSolve());

            module = new Listening("Chainsaw", null, streamWriter);
            Assert.AreEqual("&#&&#", module.DebugSolve());

            module = new Listening("Compressed Air", null, streamWriter);
            Assert.AreEqual("$$*$*", module.DebugSolve());

            module = new Listening("Servo Motor", null, streamWriter);
            Assert.AreEqual("$&#$$", module.DebugSolve());

            module = new Listening("Waterfall", null, streamWriter);
            Assert.AreEqual("&**$$", module.DebugSolve());

            module = new Listening("Tearing Fabric", null, streamWriter);
            Assert.AreEqual("$&&*&", module.DebugSolve());

            module = new Listening("Zipper", null, streamWriter);
            Assert.AreEqual("&$&##", module.DebugSolve());

            module = new Listening("Vacuum Cleaner", null, streamWriter);
            Assert.AreEqual("#&$*&", module.DebugSolve());

            module = new Listening("Ballpoint Pen Writing", null, streamWriter);
            Assert.AreEqual("$*$**", module.DebugSolve());

            module = new Listening("Rattling Iron Chain", null, streamWriter);
            Assert.AreEqual("*#$&&", module.DebugSolve());

            module = new Listening("Book Page Turning", null, streamWriter);
            Assert.AreEqual("###&$", module.DebugSolve());

            module = new Listening("Table Tennis", null, streamWriter);
            Assert.AreEqual("*$$&$", module.DebugSolve());

            module = new Listening("Squeaky Toy", null, streamWriter);
            Assert.AreEqual("$*&##", module.DebugSolve());

            module = new Listening("Helicopter", null, streamWriter);
            Assert.AreEqual("#&$&&", module.DebugSolve());

            module = new Listening("Firework Exploding", null, streamWriter);
            Assert.AreEqual("$&$$*", module.DebugSolve());

            module = new Listening("Glass Shattering", null, streamWriter);
            Assert.AreEqual("*$*$*", module.DebugSolve());
        }
    }
}
