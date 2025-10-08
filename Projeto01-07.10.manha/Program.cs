//Faça um programa que leia 2 números e execute as 4 operações matemáticas exibindo o seu resultado

float Numero1, Numero2;

Console.Write("Informe o primeiro numero: ");
Numero1 = float.Parse(Console.ReadLine());

Console.Write("Informe o segundo numero: ");
Numero2 = float.Parse(Console.ReadLine());

Console.WriteLine("Soma: " + (Numero1+Numero2));
Console.WriteLine("Subtração: " + (Numero1 - Numero2));
Console.WriteLine("Soma: " + (Numero1*Numero2));
if (Numero2 != 0)
{
    Console.WriteLine("Soma: " + (Numero1 / Numero2));
}else
{
    Console.WriteLine("Erro: Divisão por 0.");    
}
    Console.ReadKey();