using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using KTANE_Solver;
using System.IO;

namespace ModuleTests
{
    [TestClass]
    public class ChordQualitiesTest
    {
        StreamWriter streamWriter = new StreamWriter("C:\\Users\\nyabe\\Downloads\\delete later.dummy.txt");

        [TestMethod]
        public void TestMethod1()
        {
            ChordQualities module = new ChordQualities(null, streamWriter, ChordQualities.Note.DSharp, ChordQualities.Note.F, ChordQualities.Note.GSharp, ChordQualities.Note.A);

            Assert.AreEqual("A, B, CSharp, E", module.DebugSolve());

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod2()
        {
            ChordQualities module = new ChordQualities(null, streamWriter, ChordQualities.Note.D, ChordQualities.Note.DSharp, ChordQualities.Note.FSharp, ChordQualities.Note.ASharp);

            Assert.AreEqual("F, GSharp, A, DSharp", module.DebugSolve());

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod3()
        {
            ChordQualities module = new ChordQualities(null, streamWriter, ChordQualities.Note.A, ChordQualities.Note.B, ChordQualities.Note.CSharp, ChordQualities.Note.E);

            Assert.AreEqual("DSharp, FSharp, B, D", module.DebugSolve());

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod4()
        {
            ChordQualities module = new ChordQualities(null, streamWriter, ChordQualities.Note.GSharp, ChordQualities.Note.CSharp, ChordQualities.Note.DSharp, ChordQualities.Note.E);

            Assert.AreEqual("E, FSharp, G, B", module.DebugSolve());

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod5()
        {
            ChordQualities module = new ChordQualities(null, streamWriter, ChordQualities.Note.A, ChordQualities.Note.D, ChordQualities.Note.E, ChordQualities.Note.F);

            Assert.AreEqual("E, GSharp, B, DSharp", module.DebugSolve());

            streamWriter.Close();
        }

        [TestMethod]
        public void TestMethod6()
        {
            ChordQualities module = new ChordQualities(null, streamWriter, ChordQualities.Note.B, ChordQualities.Note.CSharp, ChordQualities.Note.FSharp, ChordQualities.Note.GSharp);

            Assert.AreEqual("D, E, F, A", module.DebugSolve());

            streamWriter.Close();
        }
    }
}
