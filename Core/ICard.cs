namespace CardGame
{
    public interface ICard
    {
        int Rank { get; set; }
        Suit.SuitType Suit { get; set; }
        string Value { get; set; }
        IPlayer PlayedBy { get; set; }
        int OrderPlayed { get; set; }
    }
}