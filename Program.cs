int age;
Console.WriteLine("Veuillez indiquer votre âge.");
while (!int.TryParse(Console.ReadLine(), out age))
{
    Console.WriteLine("Veuillez entrer uniquement un nombre.");
}
if (age >= 18)
{
    Console.WriteLine($"Vous avez {age} ans, vous êtes donc majeur.e.");
}
else
{
    Console.WriteLine($"Vous avez {age} ans, vous êtes donc mineur.e.");
}