﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace KTANE_Solver
{
    public class SimonSays : Module
    {
        //a "list" of all the lights that lit up
        String lights;

        public SimonSays(String lights, Bomb bomb, StreamWriter logFileWriter) : base(bomb, logFileWriter)
        {
            this.lights = lights;
        }

        public void Solve()
        {
            List<String> answerList = new List<string>();

            switch (Bomb.Strike)
            {
                case 0:

                    if (Bomb.HasVowel)
                    {
                        foreach (char character in lights)
                        {
                            if (character == 'B')
                                answerList.Add("Red");

                            else if (character == 'G')
                                answerList.Add("Yellow");

                            else if (character == 'R')
                                answerList.Add("Blue");

                            else
                                answerList.Add("Green");
                        }
                    }

                    else
                    {
                        foreach (char character in lights)
                        {
                            if (character == 'B')
                                answerList.Add("Yellow");

                            else if (character == 'G')
                                answerList.Add("Green");

                            else if (character == 'R')
                                answerList.Add("Blue");

                            else
                                answerList.Add("Red");
                        }
                    }
                    break;

                case 1:
                    if (Bomb.HasVowel)
                    {
                        foreach (char character in lights)
                        {
                            if (character == 'B')
                                answerList.Add("Green");

                            else if (character == 'G')
                                answerList.Add("Blue");

                            else if (character == 'R')
                                answerList.Add("Yellow");

                            else
                                answerList.Add("Red");
                        }
                    }

                    else
                    {
                        foreach (char character in lights)
                        {
                            if (character == 'B')
                                answerList.Add("Blue");

                            else if (character == 'G')
                                answerList.Add("Yellow");

                            else if (character == 'R')
                                answerList.Add("Red");

                            else
                                answerList.Add("Green");
                        }
                    }
                    break;

                default:

                    if (Bomb.HasVowel)
                    {
                        foreach (char character in lights)
                        {
                            if (character == 'B')
                                answerList.Add("Red");

                            else if (character == 'G')
                                answerList.Add("Yellow");

                            else if (character == 'R')
                                answerList.Add("Green");

                            else
                                answerList.Add("Blue");
                        }
                    }

                    else
                    {
                        foreach (char character in lights)
                        {
                            if (character == 'B')
                                answerList.Add("Green");

                            else if (character == 'G')
                                answerList.Add("Blue");

                            else if (character == 'R')
                                answerList.Add("Yellow");

                            else
                                answerList.Add("Red");
                        }
                    }
                    break;
            }

            String answer = "";

            foreach (String str in answerList)
            {
                answer += str + ", ";
            }

            answer = answer.Remove(answer.Length - 2, 2);

            MessageBox.Show(answer, "Simon Says Answer", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}