using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using KTANE_Solver;

namespace ModuleTests
{
    [TestClass]
    public class WireSequenceTest
    {
        StreamWriter streamWriter = new StreamWriter("dummy.txt");

        [TestMethod]
        public void Red1A()
        {

            WireSequence module = new WireSequence(null, streamWriter);
            
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
            WireSequence module = new WireSequence(null, streamWriter);
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
