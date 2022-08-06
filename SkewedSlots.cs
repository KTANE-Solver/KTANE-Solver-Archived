using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KTANE_Solver
{
    class SkewedSlots : Module
    {
        private int[] originalNumbers;
        private int[] currentNumbers;

        private int[] fibonacciSequence;
        private int[] primeValues;
        private int[] binaryValueSum;
        public SkewedSlots(Bomb bomb, StreamWriter logFileWriter, int [] originalNumbers) : base(bomb, logFileWriter, "Skewed Slots")
        {
            this.originalNumbers = originalNumbers;

            for (int i = 0; i < 3; i++)
            {
                currentNumbers[i] = originalNumbers[i];
            }

            fibonacciSequence = new int[]{ 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144 };
            primeValues = new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };
            binaryValueSum = new int[] { 0, 1, 1, 2, 1, 2, 2, 3, 1, 2, 2 }; 
        }


        public void Solve()
        {
            for (int i = 0; i < currentNumbers.Length; i++)
            {
                currentNumbers[i] = AllSlots(currentNumbers[i], originalNumbers[i]);
            }

            currentNumbers[0] = Slot1();
            currentNumbers[1] = Slot2();
            currentNumbers[2] = Slot3();

            for (int i = 0; i < currentNumbers.Length; i++)
            {
                currentNumbers[i] = ModifyNumber(currentNumbers[i]);
            }

            ShowAnswer(string.Join("", currentNumbers), true);

        }

        private int AllSlots(int currentNumber, int orignalNumber)
        {
            if (currentNumber == 2)
            {
                currentNumber = 5;
            }

            else if (currentNumber == 7)
            {
                currentNumber = 0;
            }

            currentNumber += Bomb.LitIndicatorsList.Count - Bomb.UnlitIndicatorsList.Count;

            if (currentNumber % 3 == 0)
            {
                return currentNumber + 4;
            }

            else if (currentNumber > 7)
            {
                return currentNumber * 2;
            }

            else if (currentNumber < 3 && currentNumber % 2 == 0)
            {
                return currentNumber / 2;
            }

            else if (Bomb.Stereo.Visible || Bomb.Ps.Visible)
            {
                return currentNumber;
            }

            return orignalNumber + Bomb.Battery;
        }

        private int Slot1()
        {
            int num = currentNumbers[0];

            if (num % 2 == 0 && num > 5)
            {
                return num / 2;
            }

            if (primeValues.Contains(num))
            {
                return num + Bomb.LastDigit;
            }

            if (Bomb.Parallel.Visible)
            {
                return num * -1;
            }

            if (originalNumbers[1] % 2 == 1)
            {
                return num;
            }

            return num - 2;
        }

        private int Slot2()
        {
            int num = currentNumbers[1];

            if (!Bomb.Bob.Lit)
            {
                return num;
            }

            if (num == 0)
            {
                return originalNumbers[0];
            }

            int fibIndex = Array.IndexOf(fibonacciSequence, num);

            if (fibIndex != -1)
            {
                return num + fibonacciSequence[fibIndex + 1];
            }

            if (num >= 7)
            {
                return num + 4;
            }

            return num * 3;
        }

        private int Slot3()
        {
            int num = currentNumbers[2];

            if (Bomb.Serial.Visible)
            {
                return num + Bomb.LargestDigit;
            }

            if (originalNumbers.Where(x => x == originalNumbers[2]).Count() > 1)
            {
                return num;
            }

            if (num >= 5)
            {
                return binaryValueSum[originalNumbers[2]];
            }

            return num + 1;
        }

        private int ModifyNumber(int num)
        {
            while (num < 0)
            {
                num += 10;
            }

            while (num > 9)
            {
                num -= 10;
            }

            return num;
        }
    }
}
