float Nota1, Nota2, Nota3, Peso1, Peso2, Peso3, Media;

Console.WriteLine("Digite a primeira nota: ");
Nota1 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite o peso da nota 1: ");
Peso1 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a segunda nota: ");
Nota2 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite o peso da nota 2: ");
Peso2 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a terceira nota: ");
Nota3 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite o peso da nota 3: ");
Peso3 = float.Parse(Console.ReadLine());

Media = ((Nota1*Peso1) + (Nota2*Peso2) + (Nota3*Peso3))/(Peso1+Peso2 + Peso3);

if (Media >= 9)
{
    Console.WriteLine($"A média é: A com {Media}");
}else if (Media >= 7 && Media < 9)
{
    Console.WriteLine($"A média é: B com {Media}");
}else if (Media >= 5 && Media < 7)
{
    Console.WriteLine($"A média é: C com {Media}");
}
else
{
    Console.WriteLine($"A média é: D com {Media}");
}