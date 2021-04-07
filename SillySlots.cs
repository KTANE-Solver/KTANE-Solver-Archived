using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTANE_Solver
{
    //Author: Nya Bentley
    //Date: 3/23/21
    //Purpose: Solves the silly slot module
    public class SillySlots
    {
        //============FIELDS============

        private String keyword;

        //stage 1 information
        private String stage1Slot1Color;
        private String stage1Slot2Color;
        private String stage1Slot3Color;

        private String stage1Slot1Object;
        private String stage1Slot2Object;
        private String stage1Slot3Object;

        //stage 2 information
        private String stage2Slot1Color;
        private String stage2Slot2Color;
        private String stage2Slot3Color;
                            
        private String stage2Slot1Object;
        private String stage2Slot2Object;
        private String stage2Slot3Object;

        //stage 3 information
        private String stage3Slot1Color;
        private String stage3Slot2Color;
        private String stage3Slot3Color;
                            
        private String stage3Slot1Object;
        private String stage3Slot2Object;
        private String stage3Slot3Object;

        //stage 4 information
        private String stage4Slot1Color;
        private String stage4Slot2Color;
        private String stage4Slot3Color;
                            
        private String stage4Slot1Object;
        private String stage4Slot2Object;
        private String stage4Slot3Object;

        //placeholder information for the currnet slots
        private ConvertedSlot placeholderSlot1;
        private ConvertedSlot placeholderSlot2;
        private ConvertedSlot placeholderSlot3;


        //============PROPERTIES============

        //============CONSTRUCTORS============
        /// <summary>
        /// Used to solve the first stage of the module
        /// </summary>
        /// <param name="keyword">the keyword at the top</param>
        /// <param name="slot1Color">first slot color</param>
        /// <param name="slot1Object">second slot object</param>
        /// <param name="slot2Color">second slot color</param>
        /// <param name="slot2Object">third slot object</param>
        /// <param name="slot3Color">third slot color</param>
        /// <param name="slot3Object">third slot object</param>
        public SillySlots(int stage, String keyword, String slot1Color, String slot1Object, String slot2Color, String slot2Object, String slot3Color, String slot3Object)
        {
            //setting the variables depending on the stage

            this.keyword = keyword;

            if (stage == 1)
            {
                stage1Slot1Color = slot1Color;
                stage1Slot1Object = slot1Object;

                stage1Slot2Color = slot2Color;
                stage1Slot2Object = slot2Object;

                stage1Slot3Color = slot3Color;
                stage1Slot3Object = slot3Object;   
            }

            else if (stage == 2)
            {
                stage2Slot1Color = slot1Color;
                stage2Slot1Object = slot1Object;

                stage2Slot2Color = slot2Color;
                stage2Slot2Object = slot2Object;

                stage2Slot3Color = slot3Color;
                stage2Slot3Object = slot3Object;
            }

            else if (stage == 3)
            {
                stage3Slot1Color = slot1Color;
                stage3Slot1Object = slot1Object;

                stage3Slot2Color = slot2Color;
                stage3Slot2Object = slot2Object;

                stage3Slot3Color = slot3Color;
                stage3Slot3Object = slot3Object;
            }

            else if (stage == 4)
            {
                stage4Slot1Color = slot1Color;
                stage4Slot1Object = slot1Object;
                     
                stage4Slot2Color = slot2Color;
                stage4Slot2Object = slot2Object;
                     
                stage4Slot3Color = slot3Color;
                stage4Slot3Object = slot3Object;
            }

            placeholderSlot1 = new ConvertedSlot(slot1Color, slot1Object, keyword);
            placeholderSlot2 = new ConvertedSlot(slot2Color, slot2Object, keyword);
            placeholderSlot3 = new ConvertedSlot(slot3Color, slot3Object, keyword);
        }

        /// <summary>
        /// Solves each stage
        /// </summary>
        /// <param name="stage">the stage the user is on</param>
        /// <returns>true if the user presses keep</returns>
        public bool Solve(int stage)
        {
            Console.WriteLine("=======================SILLY SLOTS=======================");
            Console.WriteLine($"Stage {stage}\n");

            Console.WriteLine($"Keyword: {keyword}\n");

            //print information to the log
            if (stage == 1)
            {
                Console.Write($"Slot 1: "); placeholderSlot1.PrintConvertedSlot(stage1Slot1Color, stage1Slot1Object);
                Console.Write($"Slot 2: "); placeholderSlot2.PrintConvertedSlot(stage1Slot2Color, stage1Slot2Object);
                Console.Write($"Slot 3: "); placeholderSlot3.PrintConvertedSlot(stage1Slot3Color, stage1Slot3Object);

            }

            else if (stage == 2)
            {
                Console.Write($"Slot 1: "); placeholderSlot1.PrintConvertedSlot(stage2Slot1Color, stage2Slot1Object);
                Console.Write($"Slot 2: "); placeholderSlot2.PrintConvertedSlot(stage2Slot2Color, stage2Slot2Object);
                Console.Write($"Slot 3: "); placeholderSlot3.PrintConvertedSlot(stage2Slot3Color, stage2Slot3Object);
            }

            else if (stage == 3)
            {
                Console.Write($"Slot 1: "); placeholderSlot1.PrintConvertedSlot(stage3Slot1Color, stage3Slot1Object);
                Console.Write($"Slot 2: "); placeholderSlot2.PrintConvertedSlot(stage3Slot2Color, stage3Slot2Object);
                Console.Write($"Slot 3: "); placeholderSlot3.PrintConvertedSlot(stage3Slot3Color, stage3Slot3Object);
            }

            else
            {
                Console.Write($"Slot 1: "); placeholderSlot1.PrintConvertedSlot(stage4Slot1Color, stage4Slot1Object);
                Console.Write($"Slot 2: "); placeholderSlot2.PrintConvertedSlot(stage4Slot2Color, stage4Slot2Object);
                Console.Write($"Slot 3: "); placeholderSlot3.PrintConvertedSlot(stage4Slot3Color, stage4Slot3Object);
            }

            //If any of these are true, then pull the lever

            //There is a single Silly Sausage.
            int sillySausageCount = 0;

            if (isAdjective(placeholderSlot1, ConvertedSlot.Adjective.SILLY) && isNoun(placeholderSlot1, ConvertedSlot.Noun.SAUSAGE))
            {
                sillySausageCount++;
            }

            if (isAdjective(placeholderSlot2, ConvertedSlot.Adjective.SILLY) && isNoun(placeholderSlot2, ConvertedSlot.Noun.SAUSAGE))
            {
                sillySausageCount++;
            }

            if (isAdjective(placeholderSlot3, ConvertedSlot.Adjective.SILLY) && isNoun(placeholderSlot3, ConvertedSlot.Noun.SAUSAGE))
            {
                sillySausageCount++;
            }

            if (sillySausageCount == 1)
            {
                Console.WriteLine("There is a single Silly Sausage. Pulling the lever...\n");
                return false;
            }

            //There is a single Sassy Sally, unless the slot in the same position 2 stages ago was Soggy.

            int sassySallyCount = 0;

            //tells which slot is sassy sally
            bool sassySallySlot1 = false;
            bool sassySallySlot2 = false;

            if (isAdjective(placeholderSlot1, ConvertedSlot.Adjective.SASSY) && isNoun(placeholderSlot1, ConvertedSlot.Noun.SALLY))
            {
                sassySallyCount++;
            }

            if (isAdjective(placeholderSlot2, ConvertedSlot.Adjective.SASSY) && isNoun(placeholderSlot2, ConvertedSlot.Noun.SALLY))
            {
                sassySallyCount++;
            }

            if (isAdjective(placeholderSlot3, ConvertedSlot.Adjective.SASSY) && isNoun(placeholderSlot3, ConvertedSlot.Noun.SALLY))
            {
                sassySallyCount++;
            }

            if (sassySallyCount == 1)
            {
                if (stage == 1 || stage == 2)
                {
                    Console.WriteLine("There is a single Sassy Sally\n");
                    return false;
                }

                else if (stage == 3)
                {
                    ConvertedSlot convertedSlot;

                    //checking which slot needs to be convertd from stage 2
                    if (sassySallySlot1)
                    {
                        convertedSlot = new ConvertedSlot(stage1Slot1Color, stage2Slot1Object, keyword);
                    }

                    else if (sassySallySlot2)
                    {
                        convertedSlot = new ConvertedSlot(stage1Slot2Color, stage2Slot2Object, keyword);
                    }

                    else
                    {
                        convertedSlot = new ConvertedSlot(stage1Slot3Color, stage2Slot3Object, keyword);
                    }

                    //if the converted slot is not soggy, pull the lever
                    if (!isAdjective(convertedSlot, ConvertedSlot.Adjective.SOGGY))
                    {
                        Console.WriteLine("There is a single sassy sally with the slot two stage ago not being Soggy. Pulling the lever...\n");
                        return false;
                    }
                }

                else if (stage == 4)
                {
                    ConvertedSlot convertedSlot;

                    //checking which slot needs to be convertd from stage 2
                    if (sassySallySlot1)
                    {
                        convertedSlot = new ConvertedSlot(stage2Slot1Color, stage2Slot1Object, keyword);
                    }

                    else if (sassySallySlot2)
                    {
                        convertedSlot = new ConvertedSlot(stage2Slot2Color, stage2Slot2Object, keyword);
                    }

                    else
                    {
                        convertedSlot = new ConvertedSlot(stage2Slot3Color, stage2Slot3Object, keyword);
                    }

                    //if the converted slot is not soggy, pull the lever
                    if (!isAdjective(convertedSlot, ConvertedSlot.Adjective.SOGGY))
                    {
                        Console.WriteLine("There is a single sassy sally with the slot two stage ago not being Soggy. Pulling the lever...\n");
                        return false;
                    }
                }

            }

            //There are 2 or more Soggy Stevens.

            int soggyStevenCount = 0;

            if (isAdjective(placeholderSlot1, ConvertedSlot.Adjective.SOGGY) && isNoun(placeholderSlot1, ConvertedSlot.Noun.STEVEN))
            {
                soggyStevenCount++;
            }

            if (isAdjective(placeholderSlot2, ConvertedSlot.Adjective.SOGGY) && isNoun(placeholderSlot2, ConvertedSlot.Noun.STEVEN))
            {
                soggyStevenCount++;
            }

            if (isAdjective(placeholderSlot3, ConvertedSlot.Adjective.SOGGY) && isNoun(placeholderSlot3, ConvertedSlot.Noun.STEVEN))
            {
                soggyStevenCount++;
            }

            if (soggyStevenCount >= 2)
            {
                Console.WriteLine("There are 2 or more Soggy Stevens. Pulling the lever...\n");
                return false;
            }

            //There are 3 Simons, unless any of them are Sassy.

            int simonCount = 0;

            if (isNoun(placeholderSlot1, ConvertedSlot.Noun.SIMON))
            {
                simonCount++;
            }

            if (isNoun(placeholderSlot2, ConvertedSlot.Noun.SIMON))
            {
                simonCount++;
            }

            if (isNoun(placeholderSlot3, ConvertedSlot.Noun.SIMON))
            {
                simonCount++;
            }

            if (simonCount == 3 &&
                !isAdjective(placeholderSlot1, ConvertedSlot.Adjective.SASSY) &&
                !isAdjective(placeholderSlot2, ConvertedSlot.Adjective.SASSY) &&
                !isAdjective(placeholderSlot3, ConvertedSlot.Adjective.SASSY))
            {
                Console.WriteLine("There are 3 Simons with none of them being Sassy. Pulling the lever...\n");
                return false;
            }

            //There is a Sausage adjacent to a Sally, unless every adjacent Sally is Soggy.

            //tells if each slot is sausage
            bool slot1Sausage = isNoun(placeholderSlot1, ConvertedSlot.Noun.SAUSAGE);
            bool slot2Sausage = isNoun(placeholderSlot2, ConvertedSlot.Noun.SAUSAGE);
            bool slot3Sausage = isNoun(placeholderSlot3, ConvertedSlot.Noun.SAUSAGE);


            //tells if each slot is sally
            bool slot1Sally = isNoun(placeholderSlot1, ConvertedSlot.Noun.SALLY);
            bool slot2Sally = isNoun(placeholderSlot2, ConvertedSlot.Noun.SALLY);
            bool slot3Sally = isNoun(placeholderSlot3, ConvertedSlot.Noun.SALLY);


            //check if slot 1 is sausauge and slot 2 is soggy sally
            if (slot1Sausage && slot2Sally)
            {
                if (!isAdjective(placeholderSlot2, ConvertedSlot.Adjective.SOGGY))
                {
                    Console.WriteLine("Slot 1 is sausage. Slot 2 is Sally without being Soggy. Pulling the lever...\n");
                    return false;
                }
            }

            //check if slot 3 is sausauge and slot 2 is soggy sally
            if (slot3Sausage && slot2Sally)
            {
                if (!isAdjective(placeholderSlot2, ConvertedSlot.Adjective.SOGGY))
                {
                    Console.WriteLine("Slot 3 is sausage. Slot 2 is Sally without being Soggy. Pulling the lever...\n");
                    return false;
                }
            }

            //check if slot 2 is sausauge and slot 1 is soggy sally
            if (slot2Sausage && slot1Sally)
            {
                if (!isAdjective(placeholderSlot1, ConvertedSlot.Adjective.SOGGY))
                {
                    Console.WriteLine("Slot 2 is sausage. Slot 1 is Sally without being Soggy. Pulling the lever...\n");
                    return false;
                }
            }

            //check if slot 2 is sausage and slot 3 is soggy sally
            if (slot2Sausage && slot3Sally)
            {
                if (!isAdjective(placeholderSlot3, ConvertedSlot.Adjective.SOGGY))
                {
                    Console.WriteLine("Slot 2 is sausage. Slot 3 is Sally without being Soggy. Pulling the lever...\n");
                    return false;
                }
            }

            //There are exactly 2 Silly slots, unless they are both Steven.
            int sillyCount = 0;

            //check slots are silly
            bool slot1Silly = isAdjective(placeholderSlot1, ConvertedSlot.Adjective.SILLY);
            bool slot2Silly = isAdjective(placeholderSlot2, ConvertedSlot.Adjective.SILLY);
            bool slot3Silly = isAdjective(placeholderSlot3, ConvertedSlot.Adjective.SILLY);


            if (slot1Silly)
            {
                sillyCount++;
            }

            if (slot2Silly)
            {
                sillyCount++;
            }

            if (slot3Silly)
            {
                sillyCount++;
            }

            //checking to see if all sillies are stevenes
            if (sillyCount == 2)
            {
                if (slot1Sally && !isNoun(placeholderSlot1, ConvertedSlot.Noun.STEVEN))
                {
                    Console.WriteLine("There ae two Silly slots but both are not Steven. Pulling the lever...\n");
                    return false;
                }

                if (slot2Sally && !isNoun(placeholderSlot2, ConvertedSlot.Noun.STEVEN))
                {
                    Console.WriteLine("There ae two Silly slots but both are not Steven. Pulling the lever...\n");
                    return false;
                }

                if (slot3Sally && !isNoun(placeholderSlot3, ConvertedSlot.Noun.STEVEN))
                {
                    Console.WriteLine("There ae two Silly slots but both are not Steven. Pulling the lever...\n");
                    return false;
                }
            }


            //There is a single Soggy slot, unless the previous stage had any number of Sausage slots.
            int soggyCount = 0;

            if (isAdjective(placeholderSlot1, ConvertedSlot.Adjective.SOGGY))
            {
                soggyCount++;
            }

            if (isAdjective(placeholderSlot2, ConvertedSlot.Adjective.SOGGY))
            {
                soggyCount++;
            }

            if (isAdjective(placeholderSlot3, ConvertedSlot.Adjective.SOGGY))
            {
                soggyCount++;
            }

            if (soggyCount == 1)
            {

                //if this is stage 1, then return false
                if (stage == 1)
                {
                    Console.WriteLine("There is a single Soggy slot with no previous stage. Pulling the lever...\n");
                    return false;
                }

                else if (stage == 2)
                {
                    ConvertedSlot stage1Slot1 = new ConvertedSlot(stage1Slot1Color, stage1Slot1Object, keyword);
                    ConvertedSlot stage1Slot2 = new ConvertedSlot(stage1Slot2Color, stage1Slot2Object, keyword);
                    ConvertedSlot stage1Slot3 = new ConvertedSlot(stage1Slot3Color, stage1Slot3Object, keyword);

                    bool stage1Slot1Sausge = isNoun(stage1Slot1, ConvertedSlot.Noun.SAUSAGE);
                    bool stage1Slot2Sausge = isNoun(stage1Slot2, ConvertedSlot.Noun.SAUSAGE);
                    bool stage1Slot3Sausge = isNoun(stage1Slot3, ConvertedSlot.Noun.SAUSAGE);

                    if (!stage1Slot1Sausge && !stage1Slot2Sausge && !stage1Slot3Sausge)
                    {
                        Console.WriteLine("There is a single Soggy slot with no previous stage having a Sausage Slot. Pulling the lever...\n");
                        return false;
                    }
                }

                else if (stage == 3)
                {
                    ConvertedSlot stage2Slot1 = new ConvertedSlot(stage2Slot1Color, stage2Slot1Object, keyword);
                    ConvertedSlot stage2Slot2 = new ConvertedSlot(stage2Slot2Color, stage2Slot2Object, keyword);
                    ConvertedSlot stage2Slot3 = new ConvertedSlot(stage2Slot3Color, stage2Slot3Object, keyword);

                    bool stage2Slot1Sausge = isNoun(stage2Slot1, ConvertedSlot.Noun.SAUSAGE);
                    bool stage2Slot2Sausge = isNoun(stage2Slot2, ConvertedSlot.Noun.SAUSAGE);
                    bool stage2Slot3Sausge = isNoun(stage2Slot3, ConvertedSlot.Noun.SAUSAGE);

                    if (!stage2Slot1Sausge && !stage2Slot2Sausge && !stage2Slot3Sausge)
                    {
                        Console.WriteLine("There is a single Soggy slot with no previous stage having a Sausage Slot. Pulling the lever...\n");
                        return false;
                    }
                }

                else
                {
                    ConvertedSlot stage3Slot1 = new ConvertedSlot(stage3Slot1Color, stage3Slot1Object, keyword);
                    ConvertedSlot stage3Slot2 = new ConvertedSlot(stage3Slot2Color, stage3Slot2Object, keyword);
                    ConvertedSlot stage3Slot3 = new ConvertedSlot(stage3Slot3Color, stage3Slot3Object, keyword);

                    bool stage3Slot1Sausge = isNoun(stage3Slot1, ConvertedSlot.Noun.SAUSAGE);
                    bool stage3Slot2Sausge = isNoun(stage3Slot2, ConvertedSlot.Noun.SAUSAGE);
                    bool stage3Slot3Sausge = isNoun(stage3Slot3, ConvertedSlot.Noun.SAUSAGE);

                    if (!stage3Slot1Sausge && !stage3Slot2Sausge && !stage3Slot3Sausge)
                    {
                        Console.WriteLine("There is a single Soggy slot with no previous stage having a Sausage Slot. Pulling the lever...\n");
                        return false;
                    }
                }
            }


            //All 3 slots are the same symbol and colour, unless there has been a Soggy Sausage in any previous stage.
            if (stage1Slot1Color == stage1Slot2Color && stage1Slot1Color == stage1Slot3Color &&
                stage1Slot1Object == stage1Slot2Object && stage1Slot1Object == stage1Slot3Object)
            {
                if (stage == 1)
                {
                    Console.WriteLine("All 3 slots are the same symbol and colour with no previous stage. Pulling the lever...\n");
                    return false;
                }

                else
                {
                    List<ConvertedSlot> convertedSlotList = new List<ConvertedSlot>();

                    convertedSlotList.Add(new ConvertedSlot(stage1Slot1Color, stage1Slot1Object, keyword));
                    convertedSlotList.Add(new ConvertedSlot(stage1Slot2Color, stage1Slot2Object, keyword));
                    convertedSlotList.Add(new ConvertedSlot(stage1Slot3Color, stage1Slot3Object, keyword));

                    if (stage2Slot1Color != null)
                    {
                        convertedSlotList.Add(new ConvertedSlot(stage2Slot1Color, stage2Slot1Object, keyword));
                        convertedSlotList.Add(new ConvertedSlot(stage2Slot2Color, stage2Slot2Object, keyword));
                        convertedSlotList.Add(new ConvertedSlot(stage2Slot3Color, stage2Slot3Object, keyword));

                        if (stage3Slot1Color != null)
                        {
                            convertedSlotList.Add(new ConvertedSlot(stage3Slot1Color, stage3Slot1Object, keyword));
                            convertedSlotList.Add(new ConvertedSlot(stage3Slot2Color, stage3Slot2Object, keyword));
                            convertedSlotList.Add(new ConvertedSlot(stage3Slot3Color, stage3Slot3Object, keyword));
                        }
                    }

                    bool foundSoggySausage = false;


                    foreach (ConvertedSlot slot in convertedSlotList)
                    {
                        if (isAdjective(slot, ConvertedSlot.Adjective.SOGGY) && isNoun(slot, ConvertedSlot.Noun.SAUSAGE))
                        {
                            foundSoggySausage = true;
                            break;
                        }
                    }

                    if (!foundSoggySausage)
                    {
                        Console.WriteLine("All 3 slots are the same symbol and colour with no previous stage having a Soggy Sausage slot. Pulling the lever...\n");
                        return false;
                    }
                }
            }


            //All 3 slots are the same colour, unless any of them are Sally or there was a Silly Steven in the last stage.
            if (placeholderSlot1.AdjectiveProperty == placeholderSlot2.AdjectiveProperty && placeholderSlot1.AdjectiveProperty == placeholderSlot3.AdjectiveProperty &&
                !isNoun(placeholderSlot1, ConvertedSlot.Noun.SALLY) && !isNoun(placeholderSlot2, ConvertedSlot.Noun.SALLY) && 
                !isNoun(placeholderSlot3, ConvertedSlot.Noun.SALLY))
            {
                if (stage == 1)
                {
                    Console.WriteLine("All 3 slots are the same colour with none of them being Sally and no last stage. Pulling the lever...\n");
                    return false;
                }

                else
                {
                    ConvertedSlot slot1;
                    ConvertedSlot slot2;
                    ConvertedSlot slot3;

                    if (stage == 2)
                    {
                        slot1 = new ConvertedSlot(stage1Slot1Color, stage1Slot1Object, keyword);
                        slot2 = new ConvertedSlot(stage1Slot2Color, stage1Slot2Object, keyword);
                        slot3 = new ConvertedSlot(stage1Slot3Color, stage1Slot3Object, keyword);
                    }

                    else if (stage == 3)
                    {
                        slot1 = new ConvertedSlot(stage2Slot1Color, stage2Slot1Object, keyword);
                        slot2 = new ConvertedSlot(stage2Slot2Color, stage2Slot2Object, keyword);
                        slot3 = new ConvertedSlot(stage2Slot3Color, stage2Slot3Object, keyword);
                    }

                    else
                    {
                        slot1 = new ConvertedSlot(stage3Slot1Color, stage3Slot1Object, keyword);
                        slot2 = new ConvertedSlot(stage3Slot2Color, stage3Slot2Object, keyword);
                        slot3 = new ConvertedSlot(stage3Slot3Color, stage3Slot3Object, keyword);
                    }

                    //count of many silly stevens there are
                    int sillyStevenCount = 0;

                    if (isAdjective(slot1, ConvertedSlot.Adjective.SILLY) && isNoun(slot1, ConvertedSlot.Noun.STEVEN))
                    {
                        sillyStevenCount++;
                    }

                    else if (isAdjective(slot2, ConvertedSlot.Adjective.SILLY) && isNoun(slot2, ConvertedSlot.Noun.STEVEN))
                    {
                        sillyStevenCount++;
                    }

                    else if (isAdjective(slot3, ConvertedSlot.Adjective.SILLY) && isNoun(slot3, ConvertedSlot.Noun.STEVEN))
                    {
                        sillyStevenCount++;
                    }

                    if (sillyStevenCount == 0)
                    {
                        Console.WriteLine("All 3 slots are the same colour with none of them being Sally and no last stage having a Silly Steven Slot. Pulling the lever...\n");
                        return false;
                    }
                }

                
            }

            //There are any number of Silly Simons, unless there has been a Sassy Sausage in any previous stage.

            int sillySimonCount = 0;

            if (isAdjective(placeholderSlot1, ConvertedSlot.Adjective.SILLY) && isNoun(placeholderSlot1, ConvertedSlot.Noun.SIMON))
            {
                sillySimonCount++;
            }

            if (isAdjective(placeholderSlot2, ConvertedSlot.Adjective.SILLY) && isNoun(placeholderSlot2, ConvertedSlot.Noun.SIMON))
            {
                sillySimonCount++;
            }

            if (isAdjective(placeholderSlot3, ConvertedSlot.Adjective.SILLY) && isNoun(placeholderSlot3, ConvertedSlot.Noun.SIMON))
            {
                sillySimonCount++;
            }

            if (sillySimonCount > 0)
            {
                if (stage == 1)
                {
                    Console.WriteLine($"There is {sillySimonCount} Silly Simon(S) with no previous stage. Pulling the lever...\n");
                    return false;
                }

                else
                {
                    List<ConvertedSlot> convertedSlotList = new List<ConvertedSlot>();

                    convertedSlotList.Add(new ConvertedSlot(stage1Slot1Color, stage1Slot1Object, keyword));
                    convertedSlotList.Add(new ConvertedSlot(stage1Slot2Color, stage1Slot2Object, keyword));
                    convertedSlotList.Add(new ConvertedSlot(stage1Slot3Color, stage1Slot3Object, keyword));

                    if (stage3Slot1Color != null)
                    {
                        convertedSlotList.Add(new ConvertedSlot(stage2Slot1Color, stage2Slot1Object, keyword));
                        convertedSlotList.Add(new ConvertedSlot(stage2Slot2Color, stage2Slot2Object, keyword));
                        convertedSlotList.Add(new ConvertedSlot(stage2Slot3Color, stage2Slot3Object, keyword));

                        if (stage4Slot1Color != null)
                        {
                            convertedSlotList.Add(new ConvertedSlot(stage3Slot1Color, stage3Slot1Object, keyword));
                            convertedSlotList.Add(new ConvertedSlot(stage3Slot2Color, stage3Slot2Object, keyword));
                            convertedSlotList.Add(new ConvertedSlot(stage3Slot3Color, stage3Slot3Object, keyword));
                        }
                    }

                    bool foundSassySausage = false;


                    foreach (ConvertedSlot slot in convertedSlotList)
                    {
                        if (isAdjective(slot, ConvertedSlot.Adjective.SASSY) && isNoun(slot, ConvertedSlot.Noun.SAUSAGE))
                        {
                            foundSassySausage = true;
                            break;
                        }
                    }

                    if (!foundSassySausage)
                    {
                        Console.WriteLine($"There is {sillySimonCount} Silly Simon(s) with no previous stage having a Sassy Sausage. Pulling the lever...\n");
                        return false;
                    }
                }
            }

            //if this statement is reached, then the user will keep the stage
            Console.WriteLine("No illegal statements found. Pressing keep...\n");
            return true;
        }

        //============METHODS============
        /// <summary>
        /// Giveing more information to the
        /// module
        /// </summary>
        /// <param name="stage">the stage the slots belong to</param>
        /// <param name="slot1Color"></param>
        /// <param name="slot1Object"></param>
        /// <param name="slot2Color"></param>
        /// <param name="slot2Object"></param>
        /// <param name="slot3Color"></param>
        /// <param name="slot3Object"></param>
        public void UpdateModule(int stage, String keyword,
                               String slot1Color, String slot1Object, 
                               String slot2Color, String slot2Object, 
                               String slot3Color, String slot3Object)
        {
            //update the placeholders ahd slots

            this.keyword = keyword;

            placeholderSlot1 = new ConvertedSlot(slot1Color, slot1Object, keyword);
            placeholderSlot2 = new ConvertedSlot(slot2Color, slot2Object, keyword);
            placeholderSlot3 = new ConvertedSlot(slot3Color, slot3Object, keyword);

            if (stage == 1)
            {
                this.stage1Slot1Color = slot1Color;
                this.stage1Slot2Color = slot2Color;
                this.stage1Slot3Color = slot3Color;

                this.stage1Slot1Object = slot1Object;
                this.stage1Slot2Object = slot2Object;
                this.stage1Slot3Object = slot3Object;

                stage2Slot1Color = null;
                stage2Slot1Object = null;
                stage2Slot2Color = null;
                stage2Slot2Object = null;
                stage2Slot3Color = null;
                stage2Slot3Object = null;

                stage3Slot1Color = null;
                stage3Slot1Object = null;
                stage3Slot2Color = null;
                stage3Slot2Object = null;
                stage3Slot3Color = null;
                stage3Slot3Object = null;

                stage4Slot1Color = null;
                stage4Slot1Object = null;
                stage4Slot2Color = null;
                stage4Slot2Object = null;
                stage4Slot3Color = null;
                stage4Slot3Object = null;
            }

            else if (stage == 2)
            {
                this.stage2Slot1Color = slot1Color;
                this.stage2Slot2Color = slot2Color;
                this.stage2Slot3Color = slot3Color;
                          
                this.stage2Slot1Object = slot1Object;
                this.stage2Slot2Object = slot2Object;
                this.stage2Slot3Object = slot3Object;

                stage3Slot1Color = null;
                stage3Slot1Object = null;
                stage3Slot2Color = null;
                stage3Slot2Object = null;
                stage3Slot3Color = null;
                stage3Slot3Object = null;

                stage4Slot1Color = null;
                stage4Slot1Object = null;
                stage4Slot2Color = null;
                stage4Slot2Object = null;
                stage4Slot3Color = null;
                stage4Slot3Object = null;
            }

            if (stage == 3)
            {
                this.stage3Slot1Color = slot1Color;
                this.stage3Slot2Color = slot2Color;
                this.stage3Slot3Color = slot3Color;
                          
                this.stage3Slot1Object = slot1Object;
                this.stage3Slot2Object = slot2Object;
                this.stage3Slot3Object = slot3Object;

                stage4Slot1Color = null;
                stage4Slot1Object = null;
                stage4Slot2Color = null;
                stage4Slot2Object = null;
                stage4Slot3Color = null;
                stage4Slot3Object = null;
            }

            else
            {
                this.stage4Slot1Color = slot1Color;
                this.stage4Slot2Color = slot2Color;
                this.stage4Slot3Color = slot3Color;
                          
                this.stage4Slot1Object = slot1Object;
                this.stage4Slot2Object = slot2Object;
                this.stage4Slot3Object = slot3Object;
            }
          
        }

        /// <summary>
        /// Tells if a slot has a certain adjective
        /// </summary>
        /// <param name="slot"></param>
        /// <param name="adjective">the adjective the program is looking for</param>
        /// <returns>true if the slot has the adjective</returns>
        private bool isAdjective(ConvertedSlot slot, ConvertedSlot.Adjective adjective)
        {
            return slot.AdjectiveProperty == adjective;
        }

        /// <summary>
        /// Tells if a slot has a certain noun
        /// </summary>
        /// <param name="slot"></param>
        /// <param name="noun">the noun the program is looking for</param>
        /// <returns>true if the slot has the noun</returns>
        private bool isNoun(ConvertedSlot slot, ConvertedSlot.Noun noun)
        {
            return slot.NounProperty == noun;
        }

        //============INNER CLASSES============
        /// <summary>
        /// the slot with a converted adjective and noun
        /// </summary>
        public class ConvertedSlot
        {
            
            public enum Adjective
            {
                SASSY,
                SILLY,
                SOGGY,
            }

            public enum Noun
            { 
                SALLY,
                SAUSAGE,
                SIMON,
                STEVEN
            }

            public Noun NounProperty
            {
                get;
            }

            public Adjective AdjectiveProperty
            {
                get;
            }

            /// <summary>
            /// converts a slot into a placeholder
            /// </summary>
            /// <param name="color"></param>
            /// <param name="objectString"></param>
            /// <param name="keyword"></param>
            public ConvertedSlot(String color, String objectString, String keyword)
            {
                AdjectiveProperty = ConvertColorToAdjective(keyword, color);
                NounProperty = ConvertObjectToNoun(keyword, objectString);
            }

            /// <summary>
            /// Converting a color into a placeholder adjective
            /// </summary>
            /// <param name="keyword">used to see what the color gets converted to</param>
            /// <param name="color">the color that will be converted</param>
            /// <returns>the adjective the color converted to</returns>
            public Adjective ConvertColorToAdjective(String keyword, String color)
            {
                if (keyword == "Sassy")
                {
                    switch (color)
                    {
                        //if keyword is sassy and the color is blue, the adjective is sassy
                        case "Blue":
                            return Adjective.SASSY;
                        //if keyword is sassy and the color is red, the adjective is silly
                        case "Red":
                            return Adjective.SILLY;

                        //if keyword is sassy and the color is green, the adjective is soggy
                        case "Green":
                            return Adjective.SOGGY;
                    }


                }

                else if (keyword == "Silly")
                {
                    switch (color)
                    {
                        //if keyword is silly and the color is blue, the adjective is sassy
                        case "Blue":
                            return Adjective.SASSY;

                        //if keyword is silly and the color is red, the adjective is soggy
                        case "Red":
                            return Adjective.SOGGY;

                        //if keyword is silly and the color is green, the adjective is silly
                        case "Green":
                            return Adjective.SILLY;
                    }
                }

                else if (keyword == "Soggy")
                {
                    switch (color)
                    {
                        //if keyword is soggy and the color is blue, the adjective is silly
                        case "Blue":
                            return Adjective.SILLY;

                        //if keyword is soggy and the color is red, the adjective is soggy
                        case "Red":
                            return Adjective.SOGGY;

                        //if keyword is soggy and the color is green, the adjective is sassy
                        case "Green":
                            return Adjective.SASSY;
                    }
                }

                else if (keyword == "Sally")
                {
                    switch (color)
                    {
                        //if keyword is sally and the color is blue, the adjective is silly
                        case "Blue":
                            return Adjective.SILLY;

                        //if keyword is sally and the color is red, the adjective is sassy
                        case "Red":
                            return Adjective.SASSY;

                        //if keyword is sally and the color is green, the adjective is soggy
                        case "Green":
                            return Adjective.SOGGY;
                    }
                }

                else if (keyword == "Simon")
                {
                    switch (color)
                    {
                        //if keyword is simon and the color is blue, the adjective is soggy
                        case "Blue":
                            return Adjective.SOGGY;

                        //if keyword is simon and the color is red, the adjective is sassy
                        case "Red":
                            return Adjective.SASSY;

                        //if keyword is simon and the color is green, the adjective is silly
                        case "Green":
                            return Adjective.SILLY;
                    }
                }

                else if (keyword == "Sausage")
                {
                    switch (color)
                    {
                        //if keyword is sausage and the color is blue, the adjective is silly
                        case "Blue":
                            return Adjective.SILLY;

                        //if keyword is sausage and the color is red, he adjective is sassy
                        case "Red":
                            return Adjective.SASSY;

                        //if keyword is sausage and the color is green, the adjective is soggy
                        case "Green":
                            return Adjective.SOGGY;
                    }
                }

                else if (keyword == "Steven")
                {
                    switch (color)
                    {
                        //if keyword is steven and the color is blue, the adjective is soggy
                        case "Blue":
                            return Adjective.SOGGY;

                        //if keyword is steven and the color is red, the adjective is silly
                        case "Red":
                            return Adjective.SILLY;

                        //if keyword is steven and the color is green, the adjective is sassy
                        case "Green":
                            return Adjective.SASSY;

                    }
                }

                //this should not happen
                Console.WriteLine("Invalid keword. Setting adjective to Sassy\n");
                return Adjective.SASSY;
            }

            /// <summary>
            /// Converting an object into a placeholder noun
            /// </summary>
            /// <param name="keyword">used to see what the color gets converted to</param>
            /// <param name="objectString">the object that will be converted</param>
            /// <returns></returns>
            public Noun ConvertObjectToNoun(String keyword, String objectString)
            {
                if (keyword == "Sassy")
                {
                    switch (objectString)
                    {
                        //if keyword is sassy and the object is cherry, the adjective is sally
                        case "Cherry":
                            return Noun.SALLY;

                        //if keyword is sassy and the object is grape, the adjective is simon
                        case "Grape":
                            return Noun.SIMON;


                        //if keyword is sassy and the object is bomb, the adjective is sausage
                        case "Bomb":
                            return Noun.SAUSAGE;


                        //if keyword is sassy and the object is coin, the adjective is steven
                        case "Coin":
                            return Noun.STEVEN;
                    }
                }

 
                else if (keyword == "Silly")
                {
                    switch (objectString)
                    {
                        //if keyword is silly and the object is cherry, the adjective is steven
                        case "Cherry":
                            return Noun.STEVEN;

                        //if keyword is silly and the object is grape, the adjective is sausage
                        case "Grape":
                            return Noun.SAUSAGE;

                        //if keyword is silly and the object is bomb, the adjective is simon
                        case "Bomb":
                            return Noun.SIMON;


                        //if keyword is silly and the object is coin, the adjective is sally
                        case "Coin":
                            return Noun.SALLY;
                    }
                }

                else if (keyword == "Soggy")
                {
                    switch (objectString)
                    {
                        //if keyword is soggy and the object is cherry, the adjective is simon
                        case "Cherry":
                            return Noun.SIMON;

                        //if keyword is soggy and the object is grape, the adjective is steven
                        case "Grape":
                            return Noun.STEVEN;

                        //if keyword is soggy and the object is bomb, the adjective is sausage
                        case "Bomb":
                            return Noun.SAUSAGE;


                        //if keyword is soggy and the object is coin, the adjective is sally

                        case "Coin":
                            return Noun.SALLY;
                    }
                }

                else if (keyword == "Sally")
                {
                    switch (objectString)
                    {
                        //if keyword is sally and the object is cherry, the adjective is simon
                        case "Cherry":
                            return Noun.SIMON;

                        //if keyword is sally and the object is grape, the adjective is sally
                        case "Grape":
                            return Noun.SALLY;

                        //if keyword is sally and the object is bomb, the adjective is sausage
                        case "Bomb":
                            return Noun.SAUSAGE;

                        //if keyword is sally and the object is coin, the adjective is steven
                        case "Coin":
                            return Noun.STEVEN;
                    }
                }

                else if (keyword == "Simon")
                {
                    switch (objectString)
                    {
                        //if keyword is simon and the object is cherry, the adjective is sausage
                        case "Cherry":
                            return Noun.SAUSAGE;

                        //if keyword is simon and the object is grape, the adjective is simon
                        case "Grape":
                            return Noun.SIMON;
                      
                        //if keyword is simon and the object is bomb, the adjective is sally
                        case "Bomb":
                            return Noun.SALLY;

                        //if keyword is simon and the object is coin, the adjective is steven
                        case "Coin":
                            return Noun.STEVEN;
                    }
                }

                else if (keyword == "Sausage")
                {
                    switch (objectString)
                    {
                        //if keyword is sausage and the object is cherry, the adjective is steven
                        case "Cherry":
                            return Noun.STEVEN;

                        //if keyword is sausage and the object is grape, the adjective is sally
                        case "Grape":
                            return Noun.SALLY;

                        //if keyword is sausage and the object is bomb, the adjective is simon
                        case "Bomb":
                            return Noun.SIMON;

                        //if keyword is sausage and the object is coin, the adjective is sausage
                        case "Coin":
                            return Noun.SAUSAGE;
                    }
                }

                else if (keyword == "Steven")
                {
                    switch (objectString)
                    {
                        //if keyword is steven and the object is cherry, the adjective is sally
                        case "Cherry":
                            return Noun.SALLY;

                        //if keyword is steven and the object is grape, the adjective is steven
                        case "Grape":
                            return Noun.STEVEN;

                        //if keyword is steven and the object is bomb, the adjective is simon
                        case "Bomb":
                            return Noun.SIMON;

                        //if keyword is steven and the object is coin, the adjective is sausage
                        case "Coin":
                            return Noun.SAUSAGE;
                    }
                }

                //this should not happen
                Console.WriteLine("Invalid keword. Setting noun to Sally\n");
                return Noun.SALLY;
            }

            public void PrintConvertedSlot(String color, String objectString)
            { 
                Console.WriteLine($"Converted {color} {objectString} to {AdjectiveProperty} {NounProperty}\n");
            }
        }
    }
}
