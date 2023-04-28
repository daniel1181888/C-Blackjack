using C__Blackjack;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;


namespace C__Blackjack
{
    public class PlayCards
    {
        public List<Card> Cards;

        public PlayCards() // Define a constructor om een deck van kaarten te maken
        {
            Cards = new List<Card>(); // Initialize de lijst
            

            // Loop door alle combinaties van suits en ranks
            foreach (Rank r in Enum.GetValues(typeof(Rank)))
            {
                foreach (Suit s in Enum.GetValues(typeof(Suit)))
                {
                    Card newCard = new Card(r, s);
                    Cards.Add(newCard); // voeg kaart toe aan lijst
                }
            }
        }


           
        public Card NextCard()
        {
            // methode NextCard om de volgende kaart uit te stappel te pakken en bij te houden
            var temp = this.Cards[0];
            Cards.RemoveAt(0);
            return temp;
        }

        public void ShuffleDeck()
        {
            // nieuwe list shuffleCaeds
            List<Card> shuffledCards = new List<Card>();

            // genereer een random nummer
            Random random = new Random();

            // blijf loopen totdat alle kaarten zijn geschud
            while (Cards.Count > 0)
            {
                // Krijg een willekeurige index in het bereik van de resterende kaarten
                int randomIndex = random.Next(Cards.Count);

                //Voeg de kaart bij de willekeurige index toe aan de geschudde lijst
                shuffledCards.Add(Cards[randomIndex]);

                //Verwijder de kaart bij de willekeurige index uit de originele lijst
                Cards.RemoveAt(randomIndex);
            }

            //Vervang het originele kaartspel door het geschudde kaartspel
            Cards = shuffledCards;
        }
    }
}









    

 
   









