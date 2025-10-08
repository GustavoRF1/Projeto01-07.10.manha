float L1, L2, L3;

Console.WriteLine("Digite a medida do primeiro lado: ");
L1 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a medida do segundo lado: ");
L2 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a medida do terceiro lado: ");
L3 = float.Parse(Console.ReadLine());

if (L1 > (L2 + L3) || L2 > (L1 + L3) || L3 > (L1 + L2))
{
    Console.WriteLine("Não é um triângulo.");
}
else
{
    if (L1 == L2 && L2 == L3)
    {
        Console.WriteLine("O triângulo é equilátero");
    }
    else if ((L1 == L2) || (L2 == L3) || (L1 == L3))
    {
        Console.WriteLine("O triângulo é isósceles");
    }
    else
    {
        Console.WriteLine("O triângulo é escaleno");
    }
}

Console.WriteLine("Pressione qualuqer tecla para sair...");
Console.ReadLine();