//Enter quote

using OOPfun;

WordTools wt = new WordTools();

    string quote = "";

    Console.WriteLine("Please enter the quote to analyze: ");
    quote = Console.ReadLine();
    Console.WriteLine("Quote: " + quote);

    Console.WriteLine("Number of Words: " + wt.WordCounter(quote));
    Console.WriteLine("Number of Characters: " + wt.CharacterCounter(quote));
    Console.WriteLine("Alphabet ");
    wt.AplphabetCounter(quote);
