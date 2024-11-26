Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Roll I: {roll1}, Roll II: {roll2}, Roll III: {roll3}. Total: {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("Rolled triples. +6 bonus points added!!!");
        total += 6;
    }
    else
    {
        Console.WriteLine("Rolled doubles. +2 bonus points added!");
        total += 2;
    }
}

if (total >= 15)
{
    Console.WriteLine($"You have rolled {total}, you win!");
}
else
{
    Console.WriteLine($"You have rolled {total}, you lose.");
}