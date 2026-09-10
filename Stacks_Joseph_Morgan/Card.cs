using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_Joseph_Morgan
{
     class Card
    {


        public string Number { get; } //making a number string to represent the number of the card

        public string Suit { get; } //making a suit string to represent the suit of the card

        public Card(string numParam, string suitParam) //constructor for the card class that takes in a number and suit parameter
        {
            Number = numParam; //assigning the number parameter to the number property of the card class
            Suit = suitParam; //assigning the suit parameter to the suit property of the card class
        }
    }
}
