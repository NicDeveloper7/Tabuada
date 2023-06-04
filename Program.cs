    //By NicholasDev
    
    //Declaração das variáveis
    int multiplier, result, multiplying;

    Console.WriteLine("--- Tabuada do 1 ao 10 ---");

    Console.WriteLine();

    Console.WriteLine("Digite um número: ");
    multiplier = int.Parse(Console.ReadLine()!);

    //Início do laço de repetição
    for (multiplying = 0; multiplying <= 10; multiplying++) {

        //Calcula o resultado da multiplicação
        result = multiplier * multiplying;

        //Exibe o resultado da multiplicação
        Console.WriteLine($"{multiplier} x {multiplying} = {result}");

    }