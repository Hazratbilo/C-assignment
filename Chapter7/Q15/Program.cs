char [] lattinLetters = new char [26];

for (int i = 0;i  < lattinLetters.Length;i++)
{
    lattinLetters[i] = (char)('a' + i);
}

Console.WriteLine ("Enter words to check:");
string input= Console.ReadLine ().ToLower ();

int index=0;

foreach (var items in input)
{
    if(!char.IsLetter (items))
    {
        index=Array.IndexOf(lattinLetters, input);
        Console.WriteLine ($"{items}=> {index}");
    }
    else if (char.IsWhiteSpace (items)) continue;
    else if (char.IsDigit (items)) continue;
    
    else
    {
        Console.WriteLine ($"{items}=> Not found");

    }
    index++ ;
}
