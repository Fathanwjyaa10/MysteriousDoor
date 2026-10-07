string secretCode = "1992";
string attemp = "";

int tries = 3;

while (attemp != secretCode && tries > 0)
{
    tries--;

    Console.Write("Enter the secret code to open the mysterious door:");
    attemp = Console.ReadLine();

    if (attemp != secretCode)
    {
        Console.WriteLine("Wrong code. Try again...");
    }
    else
    {
        Console.WriteLine("Incorrect code. The door remains firmly shut.");
    }
}