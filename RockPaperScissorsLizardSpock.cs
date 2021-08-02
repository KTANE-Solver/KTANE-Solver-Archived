using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KTANE_Solver
{
    public class RockPaperScissorsLizardSpock : Module
    {
        Symbol decoy;
        Symbol bombSymbol;

        Dictionary<Symbol, int> counter;
        public enum Symbol
        { 
            Rock,
            Paper,
            Scissors,
            Lizard,
            Spock,
            Null
        }
        public RockPaperScissorsLizardSpock(Symbol decoy, Bomb bomb, StreamWriter logFileWriter) : base(bomb, logFileWriter)
        {
            this.decoy = decoy;
            counter = new Dictionary<Symbol, int> ();
            ResetValues();

            bombSymbol = FindBombSymbol();

            ShowAnswer(string.Join(",", FindAnswer()), "RPSLS Answer");
        }

        private Symbol[] FindAnswer()
        {
            switch (bombSymbol)
            {
                case Symbol.Rock:
                    return new Symbol[] { Symbol.Lizard, Symbol.Scissors };
                
                case Symbol.Paper:
                    return new Symbol[] { Symbol.Rock, Symbol.Spock };
                
                case Symbol.Scissors:
                    return new Symbol[] { Symbol.Paper, Symbol.Lizard };
                
                case Symbol.Lizard:
                    return new Symbol[] { Symbol.Spock, Symbol.Paper };
                
                case Symbol.Spock:
                    return new Symbol[] { Symbol.Scissors, Symbol.Rock};

                default:
                    List<Symbol> list = new List<Symbol>();

                    foreach (Symbol symbol in counter.Keys)
                    {
                        if (symbol != decoy)
                            list.Add(symbol);
                    }

                    return list.ToArray();
            }
        }

        private Symbol FindBombSymbol()
        {
            Symbol highestSymbol = SerialNumberLetter();

            if (highestSymbol == Symbol.Null || highestSymbol == decoy)
            {
                ResetValues();
                highestSymbol = Port();

                if (highestSymbol == Symbol.Null || highestSymbol == decoy)
                {
                    ResetValues();
                    highestSymbol = LitIndicator();

                    if (highestSymbol == Symbol.Null || highestSymbol == decoy)
                    {
                        ResetValues();
                        highestSymbol = UnlitIndicator();

                        if (highestSymbol == Symbol.Null || highestSymbol == decoy)
                        {
                            ResetValues();
                            highestSymbol = SerialNumberDigit();
                        }
                    }
                }
            }

            return highestSymbol;
        }

        private Symbol SerialNumberLetter()
        {
            if (Bomb.SerialNumber.Contains('X') || Bomb.SerialNumber.Contains('Y'))
                return Symbol.Null;

            counter[Symbol.Rock] = CharacterCountInSerialNum('R') + CharacterCountInSerialNum('O');
            counter[Symbol.Paper] = CharacterCountInSerialNum('P') + CharacterCountInSerialNum('A');
            counter[Symbol.Scissors] = CharacterCountInSerialNum('S') + CharacterCountInSerialNum('I');
            counter[Symbol.Lizard] = CharacterCountInSerialNum('L') + CharacterCountInSerialNum('I');
            counter[Symbol.Spock] = CharacterCountInSerialNum('S') + CharacterCountInSerialNum('P');

            return FindHieghestValue();
        }

        private Symbol Port()
        {
            if (Bomb.Ps.Visible)
                return Symbol.Null;

            counter[Symbol.Rock] = Bomb.Rj.Num;
            counter[Symbol.Paper] = Bomb.Parallel.Num;
            counter[Symbol.Scissors] = Bomb.Serial.Num;
            counter[Symbol.Lizard] = Bomb.Dvid.Num;
            counter[Symbol.Spock] = Bomb.Stereo.Num;

            return FindHieghestValue();
        }

        private Symbol LitIndicator()
        {
            if (Bomb.Trn.Lit)
                return Symbol.Null;

            if (Bomb.Frk.Lit)
                counter[Symbol.Rock]++;

            if (Bomb.Frq.Lit)
                counter[Symbol.Rock]++;

            if (Bomb.Bob.Lit)
                counter[Symbol.Paper]++;

            if (Bomb.Ind.Lit)
                counter[Symbol.Paper]++;

            if (Bomb.Car.Lit)
                counter[Symbol.Scissors]++;

            if (Bomb.Sig.Lit)
                counter[Symbol.Scissors]++;

            if (Bomb.Clr.Lit)
                counter[Symbol.Lizard]++;

            if (Bomb.Nsa.Lit)
                counter[Symbol.Lizard]++;

            if (Bomb.Snd.Lit)
                counter[Symbol.Spock]++;

            if (Bomb.Msa.Lit)
                counter[Symbol.Spock]++;

            return FindHieghestValue();
        }

        private Symbol UnlitIndicator()
        {
            if (Bomb.Trn.VisibleNotLit)
                return Symbol.Null;

            if (Bomb.Frk.VisibleNotLit)
                counter[Symbol.Rock]++;

            if (Bomb.Frq.VisibleNotLit)
                counter[Symbol.Rock]++;

            if (Bomb.Bob.VisibleNotLit)
                counter[Symbol.Paper]++;

            if (Bomb.Ind.VisibleNotLit)
                counter[Symbol.Paper]++;

            if (Bomb.Car.VisibleNotLit)
                counter[Symbol.Scissors]++;

            if (Bomb.Sig.VisibleNotLit)
                counter[Symbol.Scissors]++;

            if (Bomb.Clr.VisibleNotLit)
                counter[Symbol.Lizard]++;

            if (Bomb.Nsa.VisibleNotLit)
                counter[Symbol.Lizard]++;

            if (Bomb.Snd.VisibleNotLit)
                counter[Symbol.Spock]++;

            if (Bomb.Msa.VisibleNotLit)
                counter[Symbol.Spock]++;

            return FindHieghestValue();
        }

        private Symbol SerialNumberDigit()

        {
            counter[Symbol.Rock] = CharacterCountInSerialNum('0') + CharacterCountInSerialNum('5');
            counter[Symbol.Paper] = CharacterCountInSerialNum('3') + CharacterCountInSerialNum('6');
            counter[Symbol.Scissors] = CharacterCountInSerialNum('1') + CharacterCountInSerialNum('9');
            counter[Symbol.Lizard] = CharacterCountInSerialNum('2') + CharacterCountInSerialNum('8');
            counter[Symbol.Spock] = CharacterCountInSerialNum('4') + CharacterCountInSerialNum('7');

            return FindHieghestValue();
        }

        private void ResetValues()
        {
            counter[Symbol.Rock] = 0;
            counter[Symbol.Paper] = 0;
            counter[Symbol.Scissors] = 0;
            counter[Symbol.Lizard] = 0;
            counter[Symbol.Spock] = 0;
        }

        private Symbol FindHieghestValue()
        {
            Symbol highestSymbol = Symbol.Null;

            int highest = -1;

            foreach (Symbol symbol in counter.Keys)
            {
                if (counter[symbol] > highest)
                {
                    highestSymbol = symbol;
                    highest = counter[symbol];
                }
            }

            //if highest repeats, then there's a tie

            int numFound = 0;

            foreach (Symbol symbol in counter.Keys)
            {
                if (counter[symbol] == highest)
                {
                    numFound++;
                }
            }

            return numFound == 1 ? highestSymbol : Symbol.Null;
        }

        private int CharacterCountInSerialNum(char target)
        {
            int num = 0;

            foreach (char character in Bomb.SerialNumber)
            {
                if (character == target)
                {
                    num++;
                }
            }

            return num;
        }
    }
}
