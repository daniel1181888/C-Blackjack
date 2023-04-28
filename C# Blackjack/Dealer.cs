using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Blackjack      // dealer class kan kaarten ui delen aan de spelers
{
    internal class Dealer : Player  //class dealer
    {
        private PlayCards deck;

        public Dealer() : base("Dealer") { // deck = new dack maak een niet deck aan
            deck = new PlayCards();
            deck.ShuffleDeck(); //gebruik de shuffledeck funtie om het deck te schudden
        }

        public Card getCard() {
            return this.deck.NextCard();   //pak een kaart uit het deck met deck.nextcard
        }
    }
}
