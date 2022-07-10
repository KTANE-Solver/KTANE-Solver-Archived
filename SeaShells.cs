using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KTANE_Solver
{
    public class SeaShells : Module
    {
        private string phrase1;
        private string phrase2;
        private string bigButton;

        private string lettters;

        private List<string> answerList;

        public SeaShells(Bomb bomb, StreamWriter logFileWriter, string phrase1, string phrase2, string bigButton) : base(bomb, logFileWriter, "Sea Shells")
        {
            this.phrase1 = phrase1;
            this.phrase2 = phrase2;
            this.bigButton = bigButton;

            answerList = new List<string>();
        }

        public void Solve()
        {
            string aWord;
            string bWord;
            string cWord;
            string dWord;
            string eWord;

            switch (bigButton)
            {
                case "SHIH TZU":
                    aWord = "SHOE";
                    bWord = "SHIH TZU";
                    cWord = "SHE";
                    dWord = "SIT";
                    eWord = "SUSHI";
                    break;

                case "TOUCAN":
                    aWord = "CAN";
                    bWord = "TOUCAN";
                    cWord = "TUTU";
                    dWord = "2";
                    eWord = "CANCAN";
                    break;

                case "SWITCH":
                    aWord = "WITCH";
                    bWord = "SWITCH";
                    cWord = "ITCH";
                    dWord = "TWITCH";
                    eWord = "STITCH";
                    break;

                default:
                    aWord = "BURGLAR ALARM";
                    bWord = "BULGARIA";
                    cWord = "ARMOUR";
                    dWord = "BURGER";
                    eWord = "LLAMA";
                    break;
            }

            foreach (char c in lettters)
            {
                switch (c)
                {
                    case 'A':
                        answerList.Add(aWord);
                        break;

                    case 'B':
                        answerList.Add(bWord);
                        break;

                    case 'C':
                        answerList.Add(cWord);
                        break;

                    case 'D':
                        answerList.Add(dWord);
                        break;

                    default:
                        answerList.Add(eWord);
                        break;
                }
            }

            string answer = string.Join(", ", answerList);

            ShowAnswer(answer, true);
        }

        private void FindLetters()
        {
            switch (phrase1)
            {
                case "SHE SELLS":
            
                if (phrase2 == "SEA SHELLS")
                {
                    lettters = "BDABDAB";
                }

                else if(phrase2 == "SHE SHELLS")
                { 
                    lettters = "ACEEAC";
                }

                else if (phrase2 == "SEA SELLS")
                {
                    lettters = "EACEACE";
                }

                else
                {
                    lettters = "DAABDAB";
                }

                break;

                case "SHE SHELLS":

                    if (phrase2 == "SEA SHELLS")
                    {
                        lettters = "BEEBBE";
                    }

                    else if (phrase2 == "SHE SHELLS")
                    {
                        lettters = "CDCCDB";
                    }

                    else if (phrase2 == "SEA SELLS")
                    {
                        lettters = "EAEAEA";
                    }

                    else
                    {
                        lettters = "BEEDA";
                    }

                    break;

                default:

                    if (phrase2 == "SEA SHELLS")
                    {
                        lettters = "ABABA";
                    }

                    else if (phrase2 == "SHE SHELLS")
                    {
                        lettters = "DBAEC";
                    }

                    else if (phrase2 == "SEA SELLS")
                    {
                        lettters = "EBDADAB";
                    }

                    else
                    {
                        lettters = "CECEC";
                    }

                    break;
            }
        }
    }
}
