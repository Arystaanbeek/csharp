using System;
using System.Collections.Generic;
using System.Linq;

enum CardSuit
{
    Hearts,
    Diamonds,
    Clubs,
    Spades
}

class Card
{
    public CardSuit Suit { get; }
    public int Value { get; }

    public Card(CardSuit suit, int value)
    {
        Suit = suit;
        Value = value;
    }
}

class Player
{
    private List<Card> hand = new List<Card>();

    public void AddCards(List<Card> cards)
    {
        hand.AddRange(cards);
    }

    public void DisplayCards()
    {
        foreach (var card in hand)
        {
            Console.WriteLine($"{card.Value} of {card.Suit}");
        }
    }
}

class Game
{
    private List<Player> players = new List<Player>();
    private List<Card> deck = new List<Card>();

    public void AddPlayer(Player player)
    {
        players.Add(player);
    }

    public void CreateDeck()
    {
        foreach (CardSuit suit in Enum.GetValues(typeof(CardSuit)))
        {
            for (int value = 6; value <= 14; value++)
            {
                deck.Add(new Card(suit, value));
            }
        }
    }

    public void ShuffleDeck()
    {
        var random = new Random();
        deck = deck.OrderBy(card => random.Next()).ToList();
    }

    public void DealCards()
    {
        int cardsPerPlayer = deck.Count / players.Count;
        int index = 0;

        foreach (Player player in players)
        {
            player.AddCards(deck.GetRange(index, cardsPerPlayer));
            index += cardsPerPlayer;
        }
    }

    public void PlayGame()
    {
        // Реализация игрового процесса
        // ...
    }
}

class Statistics
{
    public Dictionary<string, int> GetWordFrequency(string text)
    {
        string[] words = text.Split(new char[] { ' ', ',', '.', '!', '?', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, int> wordFrequency = new Dictionary<string, int>();

        foreach (string word in words)
        {
            string cleanedWord = word.Trim().ToLower();

            if (wordFrequency.ContainsKey(cleanedWord))
            {
                wordFrequency[cleanedWord]++;
            }
            else
            {
                wordFrequency[cleanedWord] = 1;
            }
        }

        return wordFrequency;
    }
}

class Program
{
    static void Main()
    {
        Game game = new Game();
        Player player1 = new Player();
        Player player2 = new Player();

        game.AddPlayer(player1);
        game.AddPlayer(player2);

        game.CreateDeck();
        game.ShuffleDeck();
        game.DealCards();

        player1.DisplayCards();
        player2.DisplayCards();

        game.PlayGame();

        string sampleText = @"
            Here is the house that Jack built.
            This is the malt that lay in the house that Jack built.
            This is the rat that ate the malt that lay in the house that Jack built.
            This is the cat that killed the rat that ate the malt that lay in the house that Jack built.
            This is the dog that worried the cat that killed the rat that ate the malt that lay in the house that Jack built.
            ";

        Statistics stats = new Statistics();
        var wordFrequency = stats.GetWordFrequency(sampleText);

        Console.WriteLine("Word\tFrequency");
        Console.WriteLine("----------------");

        foreach (var pair in wordFrequency)
        {
            Console.WriteLine($"{pair.Key}\t{pair.Value}");
        }
    }
}
