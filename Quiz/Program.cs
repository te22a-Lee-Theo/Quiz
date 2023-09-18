// string p = "5";

// string sum = "2" + p;

int sum = 0;

// int p = 5;
// sum = sum + p;

// sum++;
// öka med 1

// sum--;
// minska med 1

Console.WriteLine("Fråga 1 av 3.\nVad är banan klassificerad som? \n1. Grönsak  2. Bär  3. Frukt");
string  number = Console.ReadLine();
int num = int.Parse(number);

if (num == 1)
{
    Console.WriteLine("Fel svar, ingen poäng.\n");
}

else if (num == 2)
{
    Console.WriteLine("Rätt svar, en poäng.\n");
    sum ++;
}

else if (num == 3)
{
    Console.WriteLine("Fel svar, ingen poäng.\n");
}

else
{
    Console.WriteLine("Invalid Response\n");
}


Console.WriteLine("Fråga 2 av 3.\nVad är summan av två motstånde sidor på en vanlig tärning? \n1. Summan är 7  2. Summan är 8  3. Summan är 9");
string wasd = Console.ReadLine();
int was = int.Parse(wasd);

if (was == 1)
{
    Console.WriteLine("Rätt svar, en poäng.\n");
    sum ++;
}
else if (was == 2)
{
    Console.WriteLine("Fel svar, ingen poäng.\n");
}
else if (was == 3)
{
    Console.WriteLine("Fel svar ingen poäng.\n");
}
else
{
    Console.WriteLine("Invalid Response\n");
}


Console.WriteLine("Fråga 3 av 3.\nVilken är den minsta planeten i solsystemet? \n1. Venus  2. Pluto  3. Merkurius");
string qwer = Console.ReadLine();
int qwe = int.Parse(qwer);

if (qwe == 1)
{
    Console.WriteLine("Fel svar, ingen poäng.\n");
}
else if (qwe == 2)
{
    Console.WriteLine("Fel svar, ingen poäng.\n");
}
else if (qwe == 3)
{
    Console.WriteLine("Rätt svar, en poäng.\n");
    sum ++;
}
else
{
    Console.WriteLine("Invalid Response\n");
}



Console.WriteLine($"summan blir {sum}");

if (sum == 3)
{
    Console.WriteLine("yay, full pott!!!");
}
else if (sum == 2)
{
    Console.WriteLine("Bra jobbbat.");
}
else if (sum == 1)
{
    Console.WriteLine("Bra försök, bättre lycka nästa gång.");
}
else if (sum == 0)
{
    Console.WriteLine("Plugga lite och kom tillbaks");
}

Console.WriteLine("Tryck enter för att stänga spelet.");

Console.ReadLine();