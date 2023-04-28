using C__Blackjack;

internal class main 
{
    static void Main(string[] args){
        Console.WriteLine("hoeveel spelers?");          // vraag hoeveel spelers
        int aantalspelers = Convert.ToInt32(Console.ReadLine()); // sla het antwoord op in de int aantalspelers
        BlackjackGame game = new BlackjackGame(aantalspelers);     // start een nieuwe blackjack game met new blackjackgame             
        game.start();   //start op het spel te laten beginnen
    }
}