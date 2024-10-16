// See https://aka.ms/new-console-template for more information
List<int> numbers = new List<int>(); // Creates an empty List
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Please enter a number: ");
    numbers.Add(Convert.ToInt32(Console.ReadLine()));
}
Console.ReadLine(); // Keeps the program from ending
Console.WriteLine(string.Join(" ", numbers));
Console.WriteLine("The largest number is " + numbers.Max());
Console.WriteLine("The smallest number is " + numbers.Min());
Console.WriteLine("The sum is " + numbers.Sum());
Console.WriteLine("The average of the numbers is " + numbers.Average());
Console.WriteLine();

Random generator = new Random();
List<int> randomNumbers = new List<int>();
int zeroCount = 0;

for (int i = 0; i < 20; i++)
    randomNumbers.Add(generator.Next(41));
Console.WriteLine(string.Join(", ", randomNumbers));
Console.WriteLine("The average is " + randomNumbers.Average());
Console.WriteLine("The largest number is " + randomNumbers.Max());
Console.WriteLine("The smallest number is " + randomNumbers.Min());
Console.WriteLine();

for (int i = 0; i < randomNumbers.Count; i++)
{
    if (randomNumbers[i] == 10)
        Console.Write("Ten ");
    else if (randomNumbers[i] == 20)
        Console.Write("Twenty ");
    else if (randomNumbers[i] == 30)
        Console.Write("Thirty ");
    else if (randomNumbers[i] == 40)
        Console.Write("Fourty ");
    else
        Console.Write(randomNumbers[i] + " ");
}
Console.WriteLine();

Console.WriteLine("Double List");
for (int i = 0; i < randomNumbers.Count; i++)
{
    randomNumbers[i] = randomNumbers[i] * 2;
    Console.Write(randomNumbers[i] + " ");
}
Console.WriteLine();

Console.WriteLine("Set values < 50 to zero");
for (int i = 0; i < randomNumbers.Count; i++)
    if (randomNumbers[i] < 50)
        randomNumbers[i] = 0;
Console.WriteLine(string.Join(", ", randomNumbers));

Console.WriteLine("Challenge - Count Zeroes");
for (int i = 0; i < randomNumbers.Count; i++)
    if (randomNumbers[i] == 0)
        zeroCount += 1;
Console.WriteLine("There are " + zeroCount + " zeroes");