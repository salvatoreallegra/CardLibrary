namespace CardClassLibrary
{
    public class Card
    {
        private string Suit { get; }

        private string Rank { get; }

        public Card(string suit,string rank){
            this.Suit = suit;
            this.Rank = rank;
        }

        public override string ToString() => $"{Rank} of {Suit}";
    }
}