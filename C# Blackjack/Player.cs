using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Blackjack
{
    internal class Player {

        public string Name { get; set; }    //getters en setters voor eigenschappen van player

        public List<Card> Cards { get; }
        public bool HasLostRound { get; private set; }
        public bool HasWonRound { get; private set; }

        public Player(string name) { 
            this.Cards = new List<Card>();
            this.Name = name;
            this.HasLostRound = false;  
            this.HasWonRound = false;     
        }



        public void ComparePointsToDealer(Dealer dealer)  //Logica voor het vergelijken van de punten met de dealer
        {
            int playerPoints = GetPoints();
            int dealerPoints = dealer.GetPoints();
            int playerCardCount = this.Cards.Count;
            int dealerCardCount = dealer.Cards.Count;

            if (playerPoints > 21)
            {
                this.HasWonRound = false;
                this.HasLostRound = true;
            }
            else if (playerPoints <= 21 && playerPoints == dealerPoints)
            {
                if (playerPoints < 21 || playerCardCount == dealerCardCount || (playerCardCount > 2 && dealerCardCount > 2))
                {
                    this.HasWonRound = false;
                    this.HasLostRound = false;
                }
                else
                {
                    if (playerCardCount < dealerCardCount)
                    {
                        this.HasWonRound = true;
                        this.HasLostRound = false;
                    }
                    else
                    {
                        this.HasWonRound = false;
                        this.HasLostRound = true;
                    }
                }
            }
            else if (playerPoints <= 21 && playerPoints > dealerPoints)
            {
                this.HasWonRound = true;
                this.HasLostRound = false;
            }
            else if (playerPoints <= 21 && dealerPoints > 21)
            {
                this.HasWonRound = true;
                this.HasLostRound = false;
            }
            else
            {
                this.HasWonRound = false;
                this.HasLostRound = true;
            }
        }

        public int GetPoints() {
            int totalPoints = 0;
            foreach (Card card in this.Cards) {
                totalPoints += card.GetValue(totalPoints);    // berekening Punten voor Get Points
            }
            return totalPoints;
        
        }

  
    }

}
