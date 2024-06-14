
static void MadLib()
{
    Console.WriteLine("What is your name?");
    string userName = Console.ReadLine();
    Console.WriteLine($"Hello, {userName}! What is your fav wing flavor?");
    string favWing = Console.ReadLine();
    Console.WriteLine("Fav down & distance?");
    string favDown = Console.ReadLine();
    Console.WriteLine("Fav coverage?");
    string favCoverage = Console.ReadLine();

    string value = $"One day, {userName} was munching on some {favWing} wings when all of a sudden, the ghost of John Madden asked him what he would run on {favDown}. Then he asked why does he run so much {favCoverage}.";
    Console.WriteLine(value);
}
MadLib();