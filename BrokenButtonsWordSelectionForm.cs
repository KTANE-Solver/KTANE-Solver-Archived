using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTANE_Solver
{
    public partial class BrokenButtonsWordSelectionForm : Form
    {
        private BrokenButtons module;

        public BrokenButtonsWordSelectionForm(string type, BrokenButtons module)
        {
            InitializeComponent();
            UpdateForm(type);
        }

        private void UpdateForm(string type)
        {
            List<string> words = new List<string>();

            words.AddRange(new string[]
            {
                // Explosion Related
                "bomb", "blast", "boom", "burst",

                // Bomb Components
                "wire", "button", "module", "light", "led", "switch",
                "RJ-45", "DVI-D", "RCA", "PS/2", "serial", "port",

                // Descriptions
                "row", "column", "one", "two", "three", "four", "five",
                "six", "seven", "eight", "size",

                // Misc
                "this", "that", "other", "submit", "abort", "drop",
                "thing", "blank", "", "broken", "too", "to", "yes",
                "see", "sea", "c", "wait", "word", "bob", "no",
                "not", "first", "hold", "late", "fail" 
            });

            for (int i = 0; i < words.Count; i++)
            {
                words[i] = words[i].ToUpper();
            }

            switch (type)
            {
                case "T":
                    foreach (string word in words)
                    {
                        if (!word.Contains('T'))
                        {
                            words.Remove(word);
                        }
                    }
                    break;

                case "Port":
                    words = new string[]
                    {
                        // Explosion Related
                        "bomb", "blast", "boom", "burst",

                        // Bomb Components
                        "wire", "button", "module", "light", "led", "switch",
                        "RJ-45", "DVI-D", "RCA", "PS/2", "serial", "port",

                        // Descriptions
                        "row", "column", "one", "two", "three", "four", "five",
                        "six", "seven", "eight", "size",

                        // Misc
                        "this", "that", "other", "submit", "abort", "drop",
                        "thing", "blank", "", "broken", "too", "to", "yes",
                        "see", "sea", "c", "wait", "word", "bob", "no",
                        "not", "first", "hold", "late", "fail"
                    }.ToList<string>();
                    break;

                case "threeLess":
                    foreach (string word in words)
                    {
                        if (word.Length >= 3)
                        {
                            words.Remove(word);
                        }
                    }
                    break;
            }

            comboBox.Items.Clear();
            comboBox.Items.AddRange(words.ToArray());
            comboBox.Text = words[0];
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            module.tempAnswer = comboBox.Text;

        }
    }
}
