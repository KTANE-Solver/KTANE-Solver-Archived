using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KTANE_Solver
{
    public class RoundKeypad : Module
    {
        

        Symbol northSymbol;
        Symbol northEastSymbol;
        Symbol eastSymbol;
        Symbol southEastSymbol;
        Symbol southSymbol;
        Symbol southWestSymbol;
        Symbol westSymbol;
        Symbol northWestSymbol;

        List<Symbol> symbolList;

        List<SymbolRow> symbolRowList;

        public enum Symbol
        {
            Three,
            Six,
            A,
            Ae,
            B,
            BackwardsC,
            BlackStar,
            Butt,
            C,
            Copyright,
            E,
            H,
            Hashtag,
            Lambda,
            Lightning,
            N,
            O,
            Omega,
            Paragraph,
            QuestionMark,
            SmilyFace,
            Squid,
            Swirl,
            Trident,
            UfinishedR,
            WhiteStar,
            X,
            Null
        }

        public RoundKeypad(Bomb bomb, StreamWriter logFileWriter, string north, string northEast, string east, string southEast, string south, string southWest, string west, string northWest) : base(bomb, logFileWriter, "Round Keypad")
        {
            symbolRowList = new List<SymbolRow>
            {
                new SymbolRow(new Symbol[] { Symbol.O, Symbol.A, Symbol.Lambda, Symbol.Lightning, Symbol.Squid, Symbol.H, Symbol.BackwardsC }),
                new SymbolRow(new Symbol[] { Symbol.E, Symbol.O, Symbol.BackwardsC, Symbol.Swirl, Symbol.WhiteStar, Symbol.H, Symbol.QuestionMark }),
                new SymbolRow(new Symbol[] { Symbol.Copyright, Symbol.Butt, Symbol.Swirl, Symbol.X, Symbol.UfinishedR, Symbol.Lambda, Symbol.WhiteStar }),
                new SymbolRow(new Symbol[] { Symbol.Six, Symbol.Paragraph, Symbol.B, Symbol.Squid, Symbol.Squid, Symbol.X, Symbol.QuestionMark, Symbol.SmilyFace }),
                new SymbolRow(new Symbol[] { Symbol.Trident, Symbol.SmilyFace, Symbol.B, Symbol.C, Symbol.Paragraph, Symbol.Three, Symbol.BlackStar }),
                new SymbolRow(new Symbol[] { Symbol.Six, Symbol.E, Symbol.Hashtag, Symbol.Ae, Symbol.Trident, Symbol.N, Symbol.Omega })
            };

            symbolList = new List<Symbol>();
            symbolList.AddRange(new Symbol[] { SetUpSymbol(north), SetUpSymbol(northEast), SetUpSymbol(east), SetUpSymbol(southEast), SetUpSymbol(south), SetUpSymbol(southWest), SetUpSymbol(west), SetUpSymbol(northWest) });
        }



        private Symbol SetUpSymbol(String imageName)
        {
            switch (imageName)
            {
                case "3":
                    return Symbol.Three;

                case "6":
                    return Symbol.Six;

                case "A":
                    return Symbol.A;

                case "AE":
                    return Symbol.Ae;

                case "B":
                    return Symbol.B;

                case "Backwards C":
                    return Symbol.BackwardsC;

                case "Black Star":
                    return Symbol.BlackStar;

                case "Butt":
                    return Symbol.Butt;

                case "C":
                    return Symbol.C;

                case "Copyright":
                    return Symbol.Copyright;

                case "E":
                    return Symbol.E;

                case "H":
                    return Symbol.H;

                case "Hashtag":
                    return Symbol.Hashtag;

                case "Lambda":
                    return Symbol.Lambda;

                case "Lightning":
                    return Symbol.Lightning;

                case "N":
                    return Symbol.N;

                case "O":
                    return Symbol.O;

                case "Omega":
                    return Symbol.Omega;

                case "Paragraph":
                    return Symbol.Paragraph;

                case "Question Mark":
                    return Symbol.QuestionMark;

                case "Smily Face":
                    return Symbol.SmilyFace;

                case "Squid":
                    return Symbol.Squid;

                case "Swirl":
                    return Symbol.Swirl;

                case "Trident":
                    return Symbol.Trident;

                case "Unfinished R":
                    return Symbol.UfinishedR;

                case "White Star":
                    return Symbol.WhiteStar;

                case "X":
                    return Symbol.X;

                //should never happen
                default:
                    return Symbol.Null;

            }
        }

        public void Solve()
        {
            List<int> symbolNumList = new List<int>();

            foreach (SymbolRow symbolRow in symbolRowList)
            {
                symbolRow.SetSymbolNum(symbolList);
                symbolNumList.Add(symbolRow.foundSymbolNum);
            }

            int maxValue = symbolNumList.Max();

            for (int i = symbolRowList.Count - 1; i > -1; i--)
            {
                if (symbolRowList[i].foundSymbolNum != maxValue)
                {
                    symbolRowList.RemoveAt(i);
                }
            }

            SymbolRow answerRow = symbolRowList.Last();

            List<Symbol> answers = new List<Symbol>();


            foreach (Symbol symbol in symbolList)
            {
                if (!answerRow.row.Contains(symbol))
                {
                    answers.Add(symbol);
                }
            }

            ShowAnswer(string.Join(", ", answers), true);
        }



        public class SymbolRow
        {
            public Symbol[] row;
            public  int foundSymbolNum;

            public SymbolRow(Symbol [] row)
            {
                this.row = row;
                foundSymbolNum = 0;
            }

            public void SetSymbolNum(List<Symbol> symbolList)
            {
                foundSymbolNum = row.Where(x => symbolList.Contains(x)).Count();
            }
        }
    }
}
