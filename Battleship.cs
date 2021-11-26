using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTANE_Solver
{
    class Battleship
    {
        //FIELDS
        /*
        -2d array that'll represent board
        -1 sized ship num
        -2 sized ship num
        -3 sized ship num
        -4 sized ship num
        */

        //METHODS

        /*
        Tells if the puzzle is valid

        -The number of 1 sized ships is the same or less than what the bombs offers
        -The number of 2 sized ships is the same or less than what the bombs offers
        -The number of 3 sized ships is the same or less than what the bombs offers
        -The number of 4 sized ships is the same or less than what the bombs offers
        -The number of hits in each row is the same or less than what the bombs offers
        -The number of hits in each column is the same or less than what the bombs offers
        */

        /*
        Find the safe locations
        -Make a list of letters, and rows
        -Mark the safe locations
        -Use these lists until either run out of elements
        -Use port num, indicator num, and battery num to find last safe location


        */

        /*
        */

        /*
        Fill Water Row/Column
        -If there are 0 in a row/column (or all the hits are filled), fill that with water
         */

        /*
        Fill Hit Row/Column
        -If number of emtpy spaces in a row/column match the number hits, fill that with hits
         */

        /*
        Guaruntee n spaces
        -If there is 1 n sized ship, and it can fit in one posible row/colun,
         enter middle spaces as hits where area overlap
         */

        /*
        Eliminating squares
        -If there are no 1 sized ships that haven't been placed yet, and there are single spaces that are surrounded by water is all directions, mark that as water

        -If there are no 2 sized ships that haven't been placed yet, and there are two spaces that are surrounded by water is all directions, mark that as water

        -If there are no 3 sized ships that haven't been placed yet, and there are three spaces that are surrounded by water is all directions, mark that as water

         */

        /*
        Complete ship
        -If it is gauranteed that a ship is built, surround adjacent area with water
         */


    }
}
