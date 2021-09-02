﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KTANE_Solver
{
    public partial class MonsplodeTradingCardOtherStageForm : ModuleForm
    {
        private int stage;
        private MonsplodeTradingCard module;
        private MonsplodeTradingCardForm1 stage1;

        public MonsplodeTradingCardOtherStageForm(int stage, MonsplodeTradingCard module, Bomb bomb, MonsplodeTradingCardForm1 stage1, StreamWriter logFileWriter, ModuleSelectionForm moduleSelectionForm)
        {
            InitializeComponent();
            UpdateForm(stage, module, bomb, stage1, logFileWriter, moduleSelectionForm);
        }

        public void UpdateForm(int stage, MonsplodeTradingCard module, Bomb bomb, MonsplodeTradingCardForm1 stage1, StreamWriter logFileWriter, ModuleSelectionForm moduleSelectionForm)
        {
            String[] names = { "Aluga", "Aluga, The Fighter", "Asteran", "Bob", "Bob, The Ancestor", "Buhar", "Buhar, The Protector", "Caadarim", "Clondar", "Cutie Pie", "Docsplode", "Flaurim", "Gloorim", "Lanaluff", "Lugirit", "Magmy", "Melbor", "Melbor, The Web Bug", "Mountoise", "Myrchat", "Nibs", "Percy", "Pouse", "Ukkens", "Vellarim", "Violan", "Zapra", "Zenlad" };

            offeringCardNameComboBox.Items.Clear();
            offeringCardNameComboBox.Items.AddRange(names);
            offeringCardNameComboBox.Text = names[0];
            offeringCardNameComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            String[] rarity = { "Common", "Uncommon", "Rare", "Ultra" };

            offeringCardRarityComboBox.Items.Clear();
            offeringCardRarityComboBox.Items.AddRange(rarity);
            offeringCardRarityComboBox.Text = rarity[0];
            offeringCardRarityComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            offeringCardPrintVersionTextBox.Text = "";
            offeringCardBentCornerTextBox.Text = "";

            stageLabel.Text = "Stage: " + stage;
            this.stage1 = stage1;
            this.stage = stage;
            this.module = module;

            offeringCardShinyCheckBox.Checked = false;

            UpdateEdgeWork(bomb, logFileWriter, moduleSelectionForm);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (stage == 2)
            {
                this.Hide();
                stage1.UpdateForm(Bomb, LogFileWriter, ModuleSelectionForm);
                stage1.Show();
            }

            else
            {
                this.UpdateForm(2, module, Bomb, stage1, LogFileWriter, ModuleSelectionForm);
            }
        }

        private void strikeButton_Click(object sender, EventArgs e)
        {
            IncrementStrike("Monsplode Trading Card");
        }

        private void submitButton_Click(object sender, EventArgs e)
        { 
            MonsplodeTradingCard.Card offeringCard = GetCard(offeringCardNameComboBox, offeringCardRarityComboBox, offeringCardPrintVersionTextBox, offeringCardBentCornerTextBox, offeringCardShinyCheckBox);

            if (offeringCard == null)
            {
                return;
            }

            module.Solve(offeringCard);

            if (stage == 3)
            {
                this.Hide();
                stage1.UpdateForm(Bomb, LogFileWriter, ModuleSelectionForm);
                stage1.Show();
            }

            else
            {
                UpdateForm(3, module, Bomb, stage1, LogFileWriter, ModuleSelectionForm);
            }
        }

        private MonsplodeTradingCard.Card GetCard(ComboBox name, ComboBox rarityComboBox, TextBox printVersionTextBox, TextBox bentCorners, CheckBox shiny)
        {
            String printVersion = printVersionTextBox.Text.ToUpper();

            if (printVersion.Length != 2)
            {
                ShowErrorMessage("Print Version can only be two charcters", "Monosplode Trading Cards Error");
                return null;
            }

            if (printVersion[0] < 65 || printVersion[0] > 90)
            {
                ShowErrorMessage("First character of Print Version must be a letter", "Monosplode Trading Cards Error");
                return null;
            }

            if (printVersion[1] < 48 || printVersion[1] > 57)
            {
                ShowErrorMessage("Second character of Print Version must be a number", "Monosplode Trading Cards Error");
                return null;
            }

            int bentNumber;
            try
            {
                bentNumber = int.Parse(bentCorners.Text);
            }

            catch
            {
                ShowErrorMessage("Bent Corners must be a number", "Monosplode Trading Cards Error");
                return null;
            }

            if (bentNumber < 0 || bentNumber > 4)
            {
                ShowErrorMessage("Bent corners can only be between 0 - 4", "Monosplode Trading Cards Error");
                return null;
            }

            MonsplodeTradingCard.Card.Rarity rarity = (MonsplodeTradingCard.Card.Rarity)Enum.Parse(typeof(MonsplodeTradingCard.Card.Rarity), rarityComboBox.Text);

            return new MonsplodeTradingCard.Card(name.Text, printVersion, rarity, shiny.Checked, bentNumber, Bomb);
        }
    }
}
