float Peso, Altura, IMC;

Console.WriteLine("Digite o peso (Kg): ");
Peso = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a altura (m): ");
Altura = float.Parse(Console.ReadLine());

IMC = (Peso/(Altura*Altura));

if (IMC < 18.5)
{
    Console.WriteLine($"IMC: {IMC}. Abaixo do peso");
} else if(IMC >= 18.5 &&  Peso <= 24.9)
{
    Console.WriteLine($"IMC: {IMC}. Peso normal");
} else if(IMC >= 25 && Peso <= 29.9)
{
    Console.WriteLine($"IMC: {IMC}. Sobrepeso");
}
else if(IMC >= 30)
{
    Console.WriteLine($"IMC: {IMC}. Obesidade");
}