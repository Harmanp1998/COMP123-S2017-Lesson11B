using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Harmanpreet Singh
 * Date: July 27, 2017
 * Description: This is the Hand class
 * It inherits from the CardList Abstract class
 * Version: 0.2 - Added HisghestCards method
 */

namespace COMP123_S2017_Lesson11B
{
    public class Hand : CardList
    {
        // PRIVATE INSTANCE VARIABLES

        // PUBLIC PROPERTIES

        // CONSTRUCTORS

        // PRIVATE METHODS
        protected override void _initialize()
        {
            // STUB
            // this method is empty
        }

        // PUBLIC METHODS

        /// <summary>
        /// This method overrides the built-in ToString method.
        /// </summary>
        /// <returns>
        /// This method returns the current cards in the deck
        /// </returns>
        public override string ToString()
        {
            string outputString = "";

            outputString += "Hand Contains  Number of Cards: " + this.Count + "\n";
            outputString += "==================================\n";

            foreach (Card card in this)
            {
                outputString += "The " + card.Face + " of " + card.Suit + "\n";
            }

            return outputString;
        }
        /// <summary>
        /// This method identifies most valuable cards in the Hand Object
        /// </summary>
        /// <param name="hand"></param>
        public void HighestCards(Hand hand)
        {
            var GFaceValue = from cards in hand
                             orderby cards.Face descending
                             select cards.Face;
            Console.WriteLine("All Highest cards are :  ");
            foreach (var valuable in GFaceValue)
            {
                {
                    Console.WriteLine(valuable);
                }


            }
        }
    }
}