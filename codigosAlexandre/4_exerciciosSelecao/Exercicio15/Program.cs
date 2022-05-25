Console.WriteLine("Faça um programa para uma loja de tintas. O programa deverá pedir o tamanho em metros quadrados da área a ser pintada."+
    "\nConsidere que a cobertura da tinta é de 1 litro para cada 3 metros quadrados e que a tinta é vendida em latas de 18 litros, que custam R$ 80,00."+
    "\nInforme ao usuário a quantidades de latas de tinta a serem compradas e o preço total.");


float tamanhoArea;      //variavel de entrada
float quantidadeTinta;  //variaveis de saida
int quantidadeLatas;
float valorCompra;

Console.Write("Informe a área a ser pintada (metros quadrados): ");
tamanhoArea = float.Parse( Console.ReadLine() );

quantidadeTinta = tamanhoArea / 3; //cobertura da tinta é de 1 litro por 3 metros quadrados
quantidadeLatas =  (int) Math.Ceiling( quantidadeTinta / 18 ); // tinta é vendida em latas de 18 litros
valorCompra = quantidadeLatas * 80; //a lata custa R$ 80,00

Console.WriteLine("A quantidade de tinta para cobrir a área é de: " + quantidadeTinta + " litros");
Console.WriteLine("A quantidade de latas de 18 litros para cobrir a área é de: " + quantidadeLatas);
Console.WriteLine("O valor total a ser gasto é de: R$ " + valorCompra);