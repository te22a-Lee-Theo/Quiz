// string p = "5";

// string sum = "2" + p;

int sum = 0;

// int p = 5;
// sum = sum + p;

// sum++;
// öka med 1

// sum--;
// minska med 1

Console.WriteLine("Fråga 1 av 3.\nVad är banan klassificerad som? 1. Grönsak  2. Bär  3. Frukt");
string  number = Console.ReadLine();
int num = int.Parse(number);

if (num == 1)
{
    Console.WriteLine("Fel svar, ingen poäng.");
}

else if (num == 2)
{
    Console.WriteLine("Rätt svar, en poäng.");
    sum ++;
}

else if (num == 3)
{
    Console.WriteLine("Fel svar, ingen poäng.");
}

else
{
    Console.WriteLine("Invalid Response");
}




Console.WriteLine($"summan blir {sum}");

if (sum > 3)
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

Console.ReadLine();