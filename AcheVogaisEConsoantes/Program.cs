char[] characters = new char[10];

for (int i = 0; i < 10; i++)
{
    Console.Write($"Caractere {i + 1}: ");
    characters[i] = char.Parse(Console.ReadLine());
}

Console.WriteLine("\nVogais: ");
for (int i = 0; i < 10; i++)
{
    if (characters[i] == 'a' ||
        characters[i] == 'e' ||
        characters[i] == 'i' ||
        characters[i] == 'o' ||
        characters[i] == 'u' ||
        characters[i] == 'A' ||
        characters[i] == 'E' ||
        characters[i] == 'I' ||
        characters[i] == 'O' ||
        characters[i] == 'U'
       )
    {
        Console.WriteLine(characters[i]);
    }
}

Console.WriteLine("\nConsoantes: ");
for (int i = 0; i < 10; i++)
{
    if (characters[i] != 'a' &&
        characters[i] != 'e' &&
        characters[i] != 'i' &&
        characters[i] != 'o' &&
        characters[i] != 'u' &&
        characters[i] != 'A' &&
        characters[i] != 'E' &&
        characters[i] != 'I' &&
        characters[i] != 'O' &&
        characters[i] != 'U'
       )
    {
        Console.WriteLine(characters[i]);
    }
}