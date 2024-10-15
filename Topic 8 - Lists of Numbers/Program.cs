// See https://aka.ms/new-console-template for more information
List<int> numbers = new List<int>(); // Creates an empty List
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Please enter a number: ");
    numbers.Add(Convert.ToInt32(Console.ReadLine()));
}
Console.ReadLine(); // Keeps the program from ending
Console.WriteLine("The largest number is " + numbers.Max());
Console.WriteLine("The smallest number is " + numbers.Min());
Console.WriteLine("The sum is " + numbers.Sum());