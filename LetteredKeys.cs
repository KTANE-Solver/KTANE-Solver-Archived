using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KTANE_Solver
{
    public class LetteredKeys : Module
    {
        int number;
        public LetteredKeys(Bomb bomb, StreamWriter logFileWriter, int number) : base(bomb, logFileWriter, "Lettered Keys")
        {
            this.number = number;
        }

        public string SolveDebug()
        {
            if (number == 69)
                return "D";

            if (number % 6 == 0)
                return "A";

            if (Bomb.Battery >= 2 && number % 3 == 0)
                return "B";

            bool containsCE3 = Bomb.SerialNumber.Contains('C') || Bomb.SerialNumber.Contains('E') || Bomb.SerialNumber.Contains('3');

            if (containsCE3 && number >= 22 && number <= 79)
                return "B";

            if (containsCE3)
                return "C";

            if (number < 46)
                return "D";

            return "A";
        }

        public void Solve()
        {
            ShowAnswer(SolveDebug(), true);
        }
    }
}
