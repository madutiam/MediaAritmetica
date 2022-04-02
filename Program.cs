Double n1, n2, n3, média;


Console.WriteLine("Média Aritmétrica de 3 números\n");

Console.Write("Digite o primeiro número: ");
n1 = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Digite o segundo número: ");
n2 = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Digite o terceiro número: ");
n3 = Convert.ToDouble(Console.ReadLine()!);

média = (n1 + n2 + n3) /3;

Console.WriteLine($"Média: {média:N1} ");

