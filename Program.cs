Console.WriteLine("Whats your weight?");
int weight = int.Parse(Console.ReadLine());

Console.WriteLine("Whats your height(meter)?");
float height = float.Parse(Console.ReadLine().ToString());

float bodyMassIndex = weight / height * height;
Console.WriteLine($"Weight index: {bodyMassIndex}");
if (bodyMassIndex > 18 && bodyMassIndex < 23)
{
    Console.WriteLine("Your body massindex control");
}
Console.ReadKey();