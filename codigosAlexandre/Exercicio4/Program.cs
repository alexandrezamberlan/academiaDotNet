Console.WriteLine("Faça um programa em C# e no Visual Studio que receba\n" +
    "a data na forma DD/MM/AAAA e imprima na forma AAAA/MM/DD e AA/MM/DD.\n" +
    "Note que o dia, o mês e o ano devem ser lidos em variáveis diferentes.");

////solução clássica e básica -> int
//int dia;
//int mes;
//int ano;

//Console.Write("Informe o dia: ");
//dia = int.Parse(Console.ReadLine());

//Console.Write("Informe o mês: ");
//mes = int.Parse(Console.ReadLine());

//Console.Write("Informe o ano: ");
//ano = int.Parse(Console.ReadLine());

//Console.WriteLine("DD/MM/AAAA: " + dia + "/" + mes + "/" + ano);
//Console.WriteLine("AAAA/MM/DD: " + ano + "/" + mes + "/" + dia);

//Console.WriteLine("AA/MM/DD: " + (ano % 100) + "/" + mes + "/" + dia);

//solução não clássica -> string
string dia;
string mes;
string ano;

Console.Write("Informe o dia: ");
dia = Console.ReadLine();

Console.Write("Informe o mês: ");
mes = Console.ReadLine();

Console.Write("Informe o ano: ");
ano = Console.ReadLine();

Console.WriteLine("DD/MM/AAAA: " + dia + "/" + mes + "/" + ano);
Console.WriteLine("AAAA/MM/DD: " + ano + "/" + mes + "/" + dia);

Console.WriteLine("AA/MM/DD: " + ano[2] + ano[3] + "/" + mes + "/" + dia);









































