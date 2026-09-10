using System;

namespace Stacks_Joseph_Morgan
{
    class Program
    {
        static void Main(string[] args) 
        {
            Card[] myCardsArray = new Card[] // Array of cards to be used in the stack
            {

                new Card("Ace", "Spades"), //naming some cards
                new Card("Jack", "Clubs"),
                new Card("Queen", "Diamonds"),
                new Card("Queen", "Hearts"),
                new Card("10", "Hearts"),
                new Card("2", "Diamonds"),
                new Card("6", "Spades"),
                new Card("9", "Clubs"),
                new Card("Ace", "Diamonds")
            };

            Stack<Card> startingDeck = new Stack<Card>(myCardsArray);  //creating a stack of cards using the array of cards

            Console.WriteLine("Cards in Deck:"); 
            foreach(Card card in startingDeck)  //looping through the stack of cards and writing them to the console
            {
                Console.WriteLine($"{card.Number} of {card.Suit}!"); 
            }

            Console.WriteLine($"Cards in the deck: {startingDeck.Count}"); //writes the number of cards in the deck to the console

            List<Card> myHand = new List<Card>(); //creating a list of cards to represent the player's hand
            myHand.Add(new Card("Jack", "Diamonds")); //adding cards to the player's hand
            myHand.Add(new Card("8", "Hearts")); //adding cards to the player's hand
            myHand.Add(new Card("3", "Diamonds")); //adding cards to the player's hand

            Console.WriteLine("Got any 8's?"); 
            if(startingDeck.Count > 0) 
            {
                myHand.Add(startingDeck.Pop()); //removing the top card from the stack and adding it to the player's hand
            }

            Console.WriteLine($"Cards in the stack: {startingDeck.Count}"); //new deck count after popping a card from the stack

            startingDeck.Push(myHand[0] ); //adding the first card in the player's hand to the top of the stack
            myHand.RemoveAt(0); //removing the first card in the player's hand

            Console.WriteLine("Cards in Deck:"); 
            foreach (Card card in startingDeck) //looping through the stack of cards and writing them to the console
            {
                Console.WriteLine($"{card.Number} of {card.Suit}!"); //writing the cards in the stack to the console
            } 
        }
    }
}