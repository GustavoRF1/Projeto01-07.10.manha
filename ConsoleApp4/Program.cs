int N1, N2;

Console.WriteLine("Digite o primeiro número: ");
N1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo número: ");
N2 = int.Parse(Console.ReadLine());

if (N1 > N2)
{
    Console.WriteLine($"O primeiro número({N1}) é maior que o segundo número ({N2}).");
}else if(N2 > N1)
{
    Console.WriteLine($"O segundo número({N2}) é maior que o primeiro número ({N1}).");
}
else
{
    Console.WriteLine("Os dois números são iguais.");
}