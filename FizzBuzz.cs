using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KTANE_Solver
{
    public class FizzBuzz : Module
    {
        public FizzBuzz(string firstColor, string firstNumber, string secondColor, string secondNumber, string thirdColor, string thirdNumber, Bomb bomb, StreamWriter logFileWriter) : base(bomb, logFileWriter)
        {
            PrintDebugLine($"First Number: {firstColor} {firstNumber}");
            PrintDebugLine($"Second Number: {secondColor} {secondNumber}");
            PrintDebugLine($"Third Number: {thirdColor} {thirdNumber}\n");

            //For each number, find the column corresponding to the color of the number in the table below.
            Condition firstCondition = SetCondition(firstColor);
            Condition secondCondition = SetCondition(secondColor);
            Condition thirdCondition = SetCondition(thirdColor);

            //Go through that column and take a note of each integer whose condition applies.

            //Take the sum of these integers to get a number. 

            int firstAdditionNumber = 0;
            int secondAdditionNumber = 0;
            int thirdAdditionNumber = 0;

            //3 or more battery holders are present on the bomb.
            if (Bomb.BatteryHolder >= 3)
            {
                PrintDebugLine("3 or more battery holders are present on the bomb\n");

                firstAdditionNumber += firstCondition.ThreeBatteryHolder;
                secondAdditionNumber += secondCondition.ThreeBatteryHolder;
                thirdAdditionNumber += thirdCondition.ThreeBatteryHolder;
            }

            //At least one Serial and Parallel port are present on the bomb.

            if (Bomb.Serial.Visible && Bomb.Parallel.Visible)
            {
                PrintDebugLine("At least one Serial and Parallel port are present on the bomb\n");

                firstAdditionNumber += firstCondition.SerialParallelPort;
                secondAdditionNumber += secondCondition.SerialParallelPort;
                thirdAdditionNumber += thirdCondition.SerialParallelPort;
            }

            //3 letters and 3 digits are present in the serial number.

            if (Bomb.LetterNum == 3 && Bomb.DigitNum == 3)
            {
                PrintDebugLine("3 letters and 3 digits are present in the serial number\n");

                firstAdditionNumber += firstCondition.ThreeLetterDigit;
                secondAdditionNumber += secondCondition.ThreeLetterDigit;
                thirdAdditionNumber += thirdCondition.ThreeLetterDigit;
            }

            //At least one DVI-D and Stereo RCA port are present on the bomb
            if (Bomb.Dvid.Visible && Bomb.Stereo.Visible)
            {
                PrintDebugLine("At least one DVI-D and Stereo RCA port are present on the bomb\n");

                firstAdditionNumber += firstCondition.DvidStereoPort;
                secondAdditionNumber += secondCondition.DvidStereoPort;
                thirdAdditionNumber += thirdCondition.DvidStereoPort;
            }

            //2 or more strikes are present on the bomb.
            if (Bomb.Strike >= 2)
            {
                PrintDebugLine("2 or more strikes are present on the bomb\n");

                firstAdditionNumber += firstCondition.Strikes;
                secondAdditionNumber += secondCondition.Strikes;
                thirdAdditionNumber += thirdCondition.Strikes;
            }

            //5 or more batteries are present on the bomb.
            if (Bomb.Battery >= 5)
            {
                PrintDebugLine("5 or more batteries are present on the bomb\n");

                firstAdditionNumber += firstCondition.FiveBattery;
                secondAdditionNumber += secondCondition.FiveBattery;
                thirdAdditionNumber += thirdCondition.FiveBattery;
            }

            //None of the above apply.
            if (firstAdditionNumber == 0)
            {
                PrintDebugLine("None of the previous conditions apply\n");

                firstAdditionNumber += firstCondition.None;
                secondAdditionNumber += secondCondition.None;
                thirdAdditionNumber += thirdCondition.None;
            }

            firstAdditionNumber %= 10;
            secondAdditionNumber %= 10;
            thirdAdditionNumber %= 10;

            PrintDebugLine($"First Addition Number: {firstAdditionNumber}");
            PrintDebugLine($"Second Addition Number: {secondAdditionNumber}");
            PrintDebugLine($"Third Addition Number: {thirdAdditionNumber}\n");


            int first = GetNewNumber(firstNumber, firstAdditionNumber);
            int second = GetNewNumber(secondNumber, secondAdditionNumber);
            int third = GetNewNumber(thirdNumber, thirdAdditionNumber);

            PrintDebugLine($"New First Number: {first}");
            PrintDebugLine($"New Second Number:{second}");
            PrintDebugLine($"New Third Number: {third}\n");

            String firstNumAnswer = GetAnswer(first);
            String secondNumAnswer = GetAnswer(second);
            String thirdNumAnswer = GetAnswer(third);

            PrintDebugLine($"1.{firstNumAnswer}\n2.{secondNumAnswer}\n3.{thirdNumAnswer}\n");
            ShowAnswer($"1.{firstNumAnswer}\n2.{secondNumAnswer}\n3.{thirdNumAnswer}", "FizzBuzz Answer");
        }

        private String GetAnswer(int num)
        {
            if (num % 3 == 0 && num % 5 == 0)
                return "FizzBuzz";

            if (num % 3 == 0)
                return "Fizz";

            if (num % 5 == 0)
                return "Buzz";

            return "#";
        }

        private Condition SetCondition(String color)
        {
            switch (color)
            {
                case "Red":
                    return new Condition(7, 3, 4, 2, 6, 1, 3);

                case "Green":
                    return new Condition(3, 4, 5, 3, 6, 2, 1);

                case "Blue":
                    return new Condition(2, 9, 8, 7, 1, 2, 8);

                case "Yellow":
                    return new Condition(4, 2, 8, 9, 2, 5, 3);

                default:
                    return new Condition(5, 8, 2, 1, 8, 3, 4);
            }
        }

        private int GetNewNumber(string n, int addition)
        {
            if (addition == 0)
                return int.Parse(n);
            
            string newNum = "";
            foreach(char c in n)
            {
                newNum += "" + (int.Parse("" + c) + addition) % 10;
            }

            return int.Parse(newNum);
        }

        class Condition
        {
            //3 or more battery holders are present on the bomb.	
            public int ThreeBatteryHolder { get; }

            //3 or more battery holders are present on the bomb.	
            public int SerialParallelPort { get; }

            //3 letters and 3 digits are present in the serial number
            public int ThreeLetterDigit { get; }

            //At least one DVI-D and Stereo RCA port are present on the bomb.
            public int DvidStereoPort { get; }

            //2 or more strikes are present on the bomb
            public int Strikes { get; }

            //5 or more batteries are present on the bomb.
            public int FiveBattery { get; }

            //None of the above apply.
            public int None { get; }

            public Condition(int ThreeBatteryHolder, int SerialParallelPort, int ThreeLetterDigit, int DvidStereoPort, int Strikes, int FiveBattery, int None)
            {
                this.ThreeBatteryHolder = ThreeBatteryHolder;
                this.SerialParallelPort = SerialParallelPort;
                this.ThreeLetterDigit = ThreeLetterDigit;
                this.DvidStereoPort = DvidStereoPort;
                this.Strikes = Strikes;
                this.FiveBattery = FiveBattery;
                this.None = None;
            }
        }
    }
}


