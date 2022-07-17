using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace KTANE_Solver
{
    class ChordQualities : Module
    {
        Note note1;
        Note note2;
        Note note3;
        Note note4;

        Note currentRoot;
        string currentQuality;

        List<string> qualities;
        
        Note newRoot;
        string newQuality;

        public ChordQualities(Bomb bomb, StreamWriter logFileWriter, Note note1, Note note2, Note note3, Note note4) : base(bomb, logFileWriter, "Chord Qualities")
        {
            this.note1 = note1;
            this.note2 = note1;
            this.note3 = note1;
            this.note4 = note1;

            RefactorNotes();

            qualities = new List<string>
            {
                "X...X..X..X.",
                "X..X...X..X.",
                "X...X..X...X",
                "X..X...X...X",
                "X..XX.....X.",
                "X..X..X...X.",
                "X.X.X..X....",
                "X.XX...X....",
                "X...X...X.X.",
                "X...X...X..X",
                "X....X.X..X.",
                "X..X....X..X"
            };

        }

        public enum Note
        { 
            A,
            ASharp,
            B,
            C,
            CSharp,
            D,
            DSharp,
            E,
            F,
            FSharp,
            G,
            GSharp
        }

        public void Solve()
        {
            FindQualityAndRoot();
            FindNewRoot();
            FindNewQuality();
            List<Note> answerList = FindAnswer();

            ShowAnswer(string.Join(", ", answerList), true);
        }

        private void RefactorNotes()
        {
            Note[] notes = new Note[] { note1, note2, note3, note4 };

            if (note1 != notes.Min())
            {
                int minIndex = Array.IndexOf(notes, notes.Min());

                Note minNote = notes[minIndex];
                Note firstNote = notes[0];

                notes[0] = minNote;
                notes[minIndex] = firstNote;
            }

            if (note4 != notes.Max())
            {
                int maxIndex = Array.IndexOf(notes, notes.Max());

                Note minNote = notes[maxIndex];
                Note lastNote = notes[3];

                notes[3] = minNote;
                notes[maxIndex] = lastNote;
            }

            if (note2 > note3)
            {
                Note thirdNote = notes[1];
                Note secondNote = notes[2];

                notes[1] = secondNote;
                notes[2] = thirdNote;
            }
        }

        private void FindQualityAndRoot()
        {
            string quality = "";
            bool correctQuality = false;
            int startingNote = -1;
            for(int i = 0; i < 12; i++)
            {
                quality = qualities[i];

                for (int j = 1; j > 5; j++)
                {
                    startingNote = j;
                    correctQuality = CoorectQuality(quality, j);

                    if (correctQuality)
                    {
                        break;
                    }
                }

                if (correctQuality)
                {
                    break;
                }
            }

            switch (startingNote)
            {
                case 1:
                    currentRoot = note1;
                    break;

                case 2:
                    currentRoot = note2;
                    break;

                case 3:
                    currentRoot = note3;
                    break;

                default:
                    currentRoot = note4;
                    break;
            }

            this.currentQuality = quality;

        }

        private int[] FindGaps(int startingNote)
        {
            int[] gaps;

            switch (startingNote)
            {
                case 1:
                    gaps = new int[] { note2 - note1, note3 - note2, note4 - note3, note4 - note1};
                    break;

                case 2:
                    gaps = new int[] {note3 - note2, note4 - note3, note4 - note1, note2 - note1};
                    break;

                case 3:
                    gaps = new int[] {  note4 - note3, note4 - note1, note2 - note1, note3 - note2 };
                    break;

                default:
                    gaps = new int[] {  note4 - note1, note2 - note1, note3 - note2, note4 - note3 };
                    break;
            }

            for (int i = 0; i < 4; i++)
            {
                gaps[i] = Math.Abs(gaps[i]) % 12;
            }

            return gaps;
        }

        private int[] FindGaps(string quality)
        {
            List<int> gaps = new List<int>();

            List<char> qualityList = quality.ToCharArray().ToList();


            while (qualityList.Count != 0)
            {
                int counter = 0;
                char c = qualityList[0];

                if (c != '.')
                {
                    qualityList.RemoveAt(0);
                    continue;
                }

                while (qualityList.Count != 0 && c == qualityList[0])
                {
                    counter++;
                    qualityList.RemoveAt(0);
                }

                gaps.Add(counter + 1);
            }

            return gaps.ToArray();
        }

        private bool CoorectQuality(string quality, int startingNote)
        {
            int[] gaps = FindGaps(startingNote);

            int previousIndex = 0;

            for (int i = 0; i < gaps.Length; i++)
            {
                if (i != 3)
                {
                    string qualityGaps = quality.Substring(previousIndex, gaps[i]);

                    int dotCount = qualityGaps.Where(x => x == '.').Count();

                    if (qualityGaps[0] != 'X' || quality[qualityGaps.Length - 1] != 'X' || dotCount != qualityGaps.Length - 2)
                    {
                        return false;
                    }

                    previousIndex += gaps[i];
                }

                else
                {
                    string qualityGaps = quality.Substring(previousIndex);

                    if (qualityGaps.Length != gaps[3])
                    {
                        return false;
                    }
                }

            }

            return true;
        }

        private void FindNewRoot()
        {
            switch (currentQuality)
            {
                case "X...X..X..X.":
                    newRoot = Note.G;
                    break;

                case "X..X...X..X.":
                    newRoot = Note.GSharp;
                    break;

                case "X...X..X...X":
                    newRoot = Note.ASharp;
                    break;

                case "X..X...X...X":
                    newRoot = Note.F;
                    break;

                case "X..XX.....X.":
                    newRoot = Note.A;
                    break;

                case "X..X..X...X.":
                    newRoot = Note.CSharp;
                    break;

                case "X.X.X..X....":
                    newRoot = Note.DSharp;
                    break;

                case "X.XX...X....":
                    newRoot = Note.E;
                    break;

                case "X...X...X.X.":
                    newRoot = Note.FSharp;
                    break;

                case "X...X...X..X":
                    newRoot = Note.C;
                    break;

                case "X....X.X..X.":
                    newRoot = Note.D;
                    break;

                case "X..X....X..X":
                    newRoot = Note.B;
                    break;
            }
        }

        private void FindNewQuality()
        {
            switch (currentRoot)
            {
                case Note.A:
                    newQuality = qualities[11];
                    break;
                case Note.ASharp:
                    newQuality = qualities[9];
                    break;
                case Note.B:
                    newQuality = qualities[1];
                    break;
                case Note.C:
                    newQuality = qualities[5];
                    break;
                case Note.CSharp:
                    newQuality = qualities[7];
                    break;
                case Note.D:
                    newQuality = qualities[2];
                    break;
                case Note.DSharp:
                    newQuality = qualities[4];
                    break;
                case Note.E:
                    newQuality = qualities[10];
                    break;
                case Note.F:
                    newQuality = qualities[6];
                    break;
                case Note.FSharp:
                    newQuality = qualities[0];
                    break;
                case Note.G:
                    newQuality = qualities[3];
                    break;
                case Note.GSharp:
                    newQuality = qualities[8];
                    break;
            }
        }

        private List<Note> FindAnswer()
        {
            int [] gaps = FindGaps(newQuality);

            List<Note> answer = new List<Note>();

            answer.Add(newRoot);


            Note currentNote = newRoot;

            for (int i = 0; i < gaps.Length; i++)
            {
                Note newNote = (Note)((int)(currentNote + gaps[i]) % 12);

                currentNote = newNote;

                answer.Add(currentNote);
            }

            return answer;
        }

    }
}
