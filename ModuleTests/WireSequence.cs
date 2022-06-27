using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using KTANE_Solver;

namespace ModuleTests
{
    [TestClass]
    public class WireSequence
    {
        StreamWriter streamWriter = new StreamWriter("C:\\delete later\\dummy.txt");
        [TestMethod]
        public void Red1A()
        {

            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            
            string answer = "";

            for (int i = 0; i < 1; i++)
            { 
                answer = module.Solve(1, "Red", 'A'); 
            }
             
            streamWriter.Close();
            Assert.AreEqual(answer, "Don't Cut");
            
        }

        [TestMethod]
        public void Red2A()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";

            for (int i = 0; i < 2; i++)
            {
                answer = module.Solve(1, "Red", 'A');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Don't Cut");
        }


        [TestMethod]
        public void Red3A()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";

            for (int i = 0; i < 3; i++)
            {
                answer = module.Solve(1, "Red", 'A');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Cut");
        }

        [TestMethod]
        public void Red4A()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";

            for (int i = 0; i < 4; i++)
            {
                answer = module.Solve(1, "Red", 'A');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Cut");
        }

        [TestMethod]
        public void Red5A()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";

            for (int i = 0; i < 5; i++)
            {
                answer = module.Solve(1, "Red", 'A');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Don't Cut");
        }

        [TestMethod]
        public void Red6A()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";

            for (int i = 0; i < 6; i++)
            {
                answer = module.Solve(1, "Red", 'A');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Cut");
        }

        [TestMethod]
        public void Red7A()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";

            for (int i = 0; i < 7; i++)
            {
                answer = module.Solve(1, "Red", 'A');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Cut");
        }

        [TestMethod]
        public void Red8A()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";

            for (int i = 0; i < 8; i++)
            {
                answer = module.Solve(1, "Red", 'A');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Cut");
        }

        [TestMethod]
        public void Red9A()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";

            for (int i = 0; i < 9; i++)
            {
                answer = module.Solve(1, "Red", 'A');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Don't Cut");
        }

        [TestMethod]
        public void Red1B()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";

            for (int i = 0; i < 1; i++)
            {
                answer = module.Solve(1, "Red", 'B');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Don't Cut");
        }

        [TestMethod]
        public void Red2B()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";

            for (int i = 0; i < 2; i++)
            {
                answer = module.Solve(1, "Red", 'B');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Cut");
        }


        [TestMethod]
        public void Red3B()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";

            for (int i = 0; i < 3; i++)
            {
                answer = module.Solve(1, "Red", 'B');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Don't Cut");
        }

        [TestMethod]
        public void Red4B()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";

            for (int i = 0; i < 4; i++)
            {
                answer = module.Solve(1, "Red", 'B');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Don't Cut");
        }

        [TestMethod]
        public void Red5B()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";

            for (int i = 0; i < 5; i++)
            {
                answer = module.Solve(1, "Red", 'B');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Cut");
        }

        [TestMethod]
        public void Red6B()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";

            for (int i = 0; i < 6; i++)
            {
                answer = module.Solve(1, "Red", 'B');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Don't Cut");
        }

        [TestMethod]
        public void Red7B()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";

            for (int i = 0; i < 7; i++)
            {
                answer = module.Solve(1, "Red", 'B');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Cut");
        }

        [TestMethod]
        public void Red8B()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";

            for (int i = 0; i < 8; i++)
            {
                answer = module.Solve(1, "Red", 'B');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Cut");
        }

        [TestMethod]
        public void Red9B()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";

            for (int i = 0; i < 9; i++)
            {
                answer = module.Solve(1, "Red", 'B');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Cut");
        }

        [TestMethod]
        public void Red1C()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";

            for (int i = 0; i < 1; i++)
            {
                answer = module.Solve(1, "Red", 'C');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Cut");
        }

        [TestMethod]
        public void Red2C()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";

            for (int i = 0; i < 2; i++)
            {
                answer = module.Solve(1, "Red", 'C');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Don't Cut");
        }


        [TestMethod]
        public void Red3C()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";

            for (int i = 0; i < 3; i++)
            {
                answer = module.Solve(1, "Red", 'C');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Don't Cut");
        }

        [TestMethod]
        public void Red4C()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";

            for (int i = 0; i < 4; i++)
            {
                answer = module.Solve(1, "Red", 'C');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Cut");
        }

        [TestMethod]
        public void Red5C()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";

            for (int i = 0; i < 5; i++)
            {
                answer = module.Solve(1, "Red", 'C');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Don't Cut");
        }

        [TestMethod]
        public void Red6C()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";

            for (int i = 0; i < 6; i++)
            {
                answer = module.Solve(1, "Red", 'C');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Cut");
        }

        [TestMethod]
        public void Red7C()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";

            for (int i = 0; i < 7; i++)
            {
                answer = module.Solve(1, "Red", 'C');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Cut");
        }

        [TestMethod]
        public void Red8C()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";

            for (int i = 0; i < 8; i++)
            {
                answer = module.Solve(1, "Red", 'C');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Don't Cut");
        }

        [TestMethod]
        public void Red9C()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";

            for (int i = 0; i < 9; i++)
            {
                answer = module.Solve(1, "Red", 'C');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Don't Cut");
        }

        public void Blue1A()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";

            for (int i = 0; i < 1; i++)
            {
                answer = module.Solve(1, "Blue", 'A');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Don't Cut");
        }

        [TestMethod]
        public void Blue2A()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";
            for (int i = 0; i < 2; i++)
            {
                answer = module.Solve(1, "Blue", 'A');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Cut");
        }


        [TestMethod]
        public void Blue3A()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";
            for (int i = 0; i < 3; i++)
            {
                answer = module.Solve(1, "Blue", 'A');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Don't Cut");
        }

        [TestMethod]
        public void Blue4A()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";
            for (int i = 0; i < 4; i++)
            {
                answer = module.Solve(1, "Blue", 'A');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Cut");
        }

        [TestMethod]
        public void Blue5A()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";
            for (int i = 0; i < 5; i++)
            {
                answer = module.Solve(1, "Blue", 'A');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Don't Cut");
        }

        [TestMethod]
        public void Blue6A()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";
            for (int i = 0; i < 6; i++)
            {
                answer = module.Solve(1, "Blue", 'A');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Don't Cut");
        }

        [TestMethod]
        public void Blue7A()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";
            for (int i = 0; i < 7; i++)
            {
                answer = module.Solve(1, "Blue", 'A');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Don't Cut");
        }

        [TestMethod]
        public void Blue8A()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";
            for (int i = 0; i < 8; i++)
            {
                answer = module.Solve(1, "Blue", 'A');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Cut");
        }

        [TestMethod]
        public void Blue9A()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";
            for (int i = 0; i < 9; i++)
            {
                answer = module.Solve(1, "Blue", 'A');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Cut");
        }

        [TestMethod]
        public void Blue1B()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";
            for (int i = 0; i < 1; i++)
            {
                answer = module.Solve(1, "Blue", 'B');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Cut");
        }

        [TestMethod]
        public void Blue2B()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";
            for (int i = 0; i < 2; i++)
            {
                answer = module.Solve(1, "Blue", 'B');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Don't Cut");
        }


        [TestMethod]
        public void Blue3B()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";
            for (int i = 0; i < 3; i++)
            {
                answer = module.Solve(1, "Blue", 'B');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Cut");
        }

        [TestMethod]
        public void Blue4B()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";
            for (int i = 0; i < 4; i++)
            {
                answer = module.Solve(1, "Blue", 'B');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Don't Cut");
        }

        [TestMethod]
        public void Blue5B()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";
            for (int i = 0; i < 5; i++)
            {
                answer = module.Solve(1, "Blue", 'B');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Cut");
        }

        [TestMethod]
        public void Blue6B()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";
            for (int i = 0; i < 6; i++)
            {
                answer = module.Solve(1, "Blue", 'B');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Cut");
        }

        [TestMethod]
        public void Blue7B()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";
            for (int i = 0; i < 7; i++)
            {
                answer = module.Solve(1, "Blue", 'B');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Don't Cut");
        }

        [TestMethod]
        public void Blue8B()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";
            for (int i = 0; i < 8; i++)
            {
                answer = module.Solve(1, "Blue", 'B');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Don't Cut");
        }

        [TestMethod]
        public void Blue9B()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";
            for (int i = 0; i < 9; i++)
            {
                answer = module.Solve(1, "Blue", 'B');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Don't Cut");
        }

        [TestMethod]
        public void Blue1C()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";
            for (int i = 0; i < 1; i++)
            {
                answer = module.Solve(1, "Blue", 'C');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Don't Cut");
        }

        [TestMethod]
        public void Blue2C()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";
            for (int i = 0; i < 2; i++)
            {
                answer = module.Solve(1, "Blue", 'C');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Cut");
        }


        [TestMethod]
        public void Blue3C()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";
            for (int i = 0; i < 3; i++)
            {
                answer = module.Solve(1, "Blue", 'C');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Don't Cut");
        }

        [TestMethod]
        public void Blue4C()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";
            for (int i = 0; i < 4; i++)
            {
                answer = module.Solve(1, "Blue", 'C');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Don't Cut");
        }

        [TestMethod]
        public void Blue5C()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";
            for (int i = 0; i < 5; i++)
            {
                answer = module.Solve(1, "Blue", 'C');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Don't Cut");
        }

        [TestMethod]
        public void Blue6C()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";
            for (int i = 0; i < 6; i++)
            {
                answer = module.Solve(1, "Blue", 'C');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Cut");
        }

        [TestMethod]
        public void Blue7C()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";
            for (int i = 0; i < 7; i++)
            {
                answer = module.Solve(1, "Blue", 'C');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Cut");
        }

        [TestMethod]
        public void Blue8C()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";
            for (int i = 0; i < 8; i++)
            {
                answer = module.Solve(1, "Blue", 'C');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Cut");
        }

        [TestMethod]
        public void Blue9C()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";
            for (int i = 0; i < 9; i++)
            {
                answer = module.Solve(1, "Blue", 'C');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Don't Cut");
        }

        public void Black1A()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";
            for (int i = 0; i < 1; i++)
            {
                answer = module.Solve(1, "Black", 'A');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Cut");
        }

        [TestMethod]
        public void Black2A()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";
            for (int i = 0; i < 2; i++)
            {
                answer = module.Solve(1, "Black", 'A');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Cut");
        }


        [TestMethod]
        public void Black3A()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";
            for (int i = 0; i < 3; i++)
            {
                answer = module.Solve(1, "Black", 'A');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Don't Cut");
        }

        [TestMethod]
        public void Black4A()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";
            for (int i = 0; i < 4; i++)
            {
                answer = module.Solve(1, "Black", 'A');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Cut");
        }

        [TestMethod]
        public void Black5A()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";
            for (int i = 0; i < 5; i++)
            {
                answer = module.Solve(1, "Black", 'A');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Don't Cut");
        }

        [TestMethod]
        public void Black6A()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";
            for (int i = 0; i < 6; i++)
            {
                answer = module.Solve(1, "Black", 'A');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Don't Cut");
        }

        [TestMethod]
        public void Black7A()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";
            for (int i = 0; i < 7; i++)
            {
                answer = module.Solve(1, "Black", 'A');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Cut");
        }

        [TestMethod]
        public void Black8A()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";
            for (int i = 0; i < 8; i++)
            {
                answer = module.Solve(1, "Black", 'A');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Don't Cut");
        }

        [TestMethod]
        public void Black9A()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";
            for (int i = 0; i < 9; i++)
            {
                answer = module.Solve(1, "Black", 'A');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Don't Cut");
        }

        [TestMethod]
        public void Black1B()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";
            for (int i = 0; i < 1; i++)
            {
                answer = module.Solve(1, "Black", 'B');
            }
            streamWriter.Close();
        }

        [TestMethod]
        public void Black2B()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";
            for (int i = 0; i < 2; i++)
            {
                answer = module.Solve(1, "Black", 'B');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Don't Cut");
        }


        [TestMethod]
        public void Black3B()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";
            for (int i = 0; i < 3; i++)
            {
                answer = module.Solve(1, "Black", 'B');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Cut");
        }

        [TestMethod]
        public void Black4B()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";
            for (int i = 0; i < 4; i++)
            {
                answer = module.Solve(1, "Black", 'B');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Don't Cut");
        }

        [TestMethod]
        public void Black5B()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";
            for (int i = 0; i < 5; i++)
            {
                answer = module.Solve(1, "Black", 'B');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Cut");
        }

        [TestMethod]
        public void Black6B()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";
            for (int i = 0; i < 6; i++)
            {
                answer = module.Solve(1, "Black", 'B');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Cut");
        }

        [TestMethod]
        public void Black7B()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";
            for (int i = 0; i < 7; i++)
            {
                answer = module.Solve(1, "Black", 'B');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Cut");
        }

        [TestMethod]
        public void Black8B()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";
            for (int i = 0; i < 8; i++)
            {
                answer = module.Solve(1, "Black", 'B');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Don't Cut");
        }

        [TestMethod]
        public void Black9B()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";
            for (int i = 0; i < 9; i++)
            {
                answer = module.Solve(1, "Black", 'B');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Don't Cut");
        }

        [TestMethod]
        public void Black1C()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";
            for (int i = 0; i < 1; i++)
            {
                answer = module.Solve(1, "Black", 'C');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Cut");
        }

        [TestMethod]
        public void Black2C()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";
            for (int i = 0; i < 2; i++)
            {
                answer = module.Solve(1, "Black", 'C');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Cut");
        }


        [TestMethod]
        public void Black3C()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";
            for (int i = 0; i < 3; i++)
            {
                answer = module.Solve(1, "Black", 'C');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Don't Cut");
        }

        [TestMethod]
        public void Black4C()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";
            for (int i = 0; i < 4; i++)
            {
                answer = module.Solve(1, "Black", 'C');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Cut");
        }

        [TestMethod]
        public void Black5C()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";
            for (int i = 0; i < 5; i++)
            {
                answer = module.Solve(1, "Black", 'C');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Don't Cut");
        }

        [TestMethod]
        public void Black6C()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";
            for (int i = 0; i < 6; i++)
            {
                answer = module.Solve(1, "Black", 'C');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Cut");
        }

        [TestMethod]
        public void Black7C()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";
            for (int i = 0; i < 7; i++)
            {
                answer = module.Solve(1, "Black", 'C');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Don't Cut");
        }

        [TestMethod]
        public void Black8C()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";
            for (int i = 0; i < 8; i++)
            {
                answer = module.Solve(1, "Black", 'C');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Cut");
        }

        [TestMethod]
        public void Black9C()
        {
            KTANE_Solver.WireSequence module = new KTANE_Solver.WireSequence(null, streamWriter);
            string answer = "";
            for (int i = 0; i < 1; i++)
            {
                answer = module.Solve(1, "Black", '9');
            }
            streamWriter.Close();
            Assert.AreEqual(answer, "Cut");
        }
    }
}
