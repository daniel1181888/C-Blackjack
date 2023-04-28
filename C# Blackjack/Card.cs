using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Blackjack
{



    public enum Rank
    {
        Ace,
        Two,               //enum gebruikt als een array om de verschillende waardes op te slaan.
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
    }

    public enum Suit
    {
        Hearts,
        Diamonds,
        Spades,             // enum voor de verschillende suits van een kaart
        Clubs
    }

    

    public class Card 
    {
        static string[] color = { "Hearts", "Diamonds", "Clubs", "Spades" };     //array voor color van de kaart
        static string[] value = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" }; //array value om verschillende waardes op te slaan 
        public Rank Rank { get; private set; }  // getters en setters voor het opahlen en zetten van verschillende gegevens
        public Suit Suit { get;  private set; }

        public Card(Rank rank, Suit suit)
        {
            this.Rank = rank;
            this.Suit = suit;
        }

        public int GetValue(int totalpoints = 0)
        {

            switch (Rank)
            {
                case Rank.Ace:
                    return totalpoints > 10 ? 1 :11 ;
                case Rank.Two:
                    return 2;
                case Rank.Three: 
                    return 3;
                case Rank.Four:
                    return 4;
                case Rank.Five: 
                    return 5;
                case Rank.Six:
                    return 6;
                case Rank.Seven:
                    return 7;               // alle kaarten een waarden geven met een switchcase
                case Rank.Nine:
                    return 8;
                case Rank.Ten:
                case Rank.Jack:
                case Rank.Queen:
                case Rank.King:                                     
                    return 10;
                default:
                    return (int)Rank;
            }

        }
          

        public override string ToString()
        {
            return $"{value[(int)Rank]} of {color[(int)Suit]}";     // overide to string 
        }
    }
    
}
