int Opcao;
float Valor;

Console.WriteLine("Digite o valor do produto: ");
Valor = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a forma de pagamento (1 - á vista, 2 - parcelado): ");
Opcao = int.Parse(Console.ReadLine());

if (Opcao == 1)
{
    Console.WriteLine($"O valor á ser pago é: {Valor * 0.9} reais.");
}
else
{
    Console.WriteLine($"O valor á ser pago é: {Valor} reais.");
}