int age;
Console.WriteLine("Veuillez indiquer votre âge.");
age = int.Parse(Console.ReadLine());
if (age >= 18)
{
    Console.WriteLine($"Vous avez {age} ans, vous êtes donc majeur.e.");
}
else
{
    Console.WriteLine($"Vous avez {age} ans, vous êtes donc mineur.e.");
}