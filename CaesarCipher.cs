using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace KTANE_Solver
{
    class CaesarCipher : Module
    {
        string display;
        int offset;

        public CaesarCipher(string display, Bomb bomb, StreamWriter logFileWriter) : base(bomb, logFileWriter, "Caesar Cipher")
        {
            this.display = display;
            offset = 0;
        }

        public void Solve()
        {
            FindOffset();

            string newDisplay = "";
            for (int i = 0; i < display.Length; i++)
            {
                newDisplay +=  "" + (display[i] + offset);
            }

            ShowAnswer(newDisplay, true);
        }

        private void FindOffset()
        {
            if (Bomb.Parallel.Visible && Bomb.Nsa.Lit)
            {
                return;
            }

            if (Bomb.HasVowel)
            {
                offset -= -1;
            }

            offset += Bomb.Battery;

            if (Bomb.LastDigit % 2 == 0)
            {
                offset += 1;
            }

            if (Bomb.Car.Visible)
            {
                offset += 1;
            }
        }
    }
}
