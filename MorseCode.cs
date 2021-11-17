using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace KTANE_Solver
{
    public class MorseCode : Module
    {
        public MorseCode(Bomb bomb, StreamWriter logFileWriter) : base(bomb, logFileWriter)
        { 
        
        }
        public void Solve(String word)
        {
            double answer;
            switch (word.ToLower())
            {
                case "shell":
                    answer = 3.505;
                    break;

                case "halls":
                    answer = 3.515;
                    break;

                case "slick":
                    answer = 3.522;
                    break;

                case "vector":
                    answer = 3.595;
                    break;


                case "strobe":
                    answer = 3.545;
                    break;

                case "flick":
                    answer = 3.555;
                    break;

                case "leaks":
                    answer = 3.542;
                    break;

                case "bistro":
                    answer = 3.552;
                    break;

                case "beats":
                    answer = 3.600;
                    break;

                case "brick":
                    answer = 3.575;
                    break;

                case "break":
                    answer = 3.572;
                    break;

                case "bombs":
                    answer = 3.565;
                    break;

                case "trick":
                    answer = 3.532;
                    break;

                case "steak":
                    answer = 3.582;
                    break;

                default:
                    answer = 3.535;
                    break;

            }

            PrintDebugLine($"Word: {word}\nAnswer: {answer}\n");

            ShowAnswer("" + answer, "Morse Code Answer");
        }
    }
}
