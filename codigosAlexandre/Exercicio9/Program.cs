Console.WriteLine("Faça um programa no VS que receba do usuário 3 valores de glicemia em jejum, " +
    "representando a medição diária de um paciente diabético.\n" +
    "Para cada valor recebido analisar e informar ao paciente o seguinte:" +
"Se o valor diário for menor que 65, avisá-lo que corre risco de hipoglicemia" +
"Se o valor diário for maior que 250, avisá-lo que corre risco de hiperglicemia.");

//Além disso, o programa deve fazer a média dos 3 valores de glicemia coletados. E se a média for 
//menor que 80, avisá-lo que é preciso diminuir 2 unidades de insulina. Se a média for maior que
//150, avisá-lo que será necessário adicionar 2 unidades de insulina.

/// <summary>
/// armazena a medida glicemia de um dia em jejum
/// </summary>
int medicao1;

/// <summary>
/// armazena a medida glicemia do segundo dia em jejum
/// </summary>
int medicao2;

/// <summary>
/// armazena a medida glicemia do terceiro dia em jejum
/// </summary>
int medicao3;

/// <summary>
/// armazena a média glicêmica e informa se haverá aumento ou diminuição de insulina
/// </summary>
float mediaMedicao;


Console.Write("Digite sua glicemia em Jejum do Primeiro Dia: ");
medicao1 = int.Parse(Console.ReadLine());

if (medicao1 < 65)
{
    Console.WriteLine("Atenção! Cuidado você está entrando em hipoglicemia!!");
} 
if (medicao1 > 250)
{
    Console.WriteLine("Atenção! Cuidado você está entrando em hiperglicemia!!");
}

Console.Write("Digite sua glicemia em Jejum do Segundo Dia: ");
medicao2 = int.Parse(Console.ReadLine());

if (medicao2 < 65)
{
    Console.WriteLine("Atenção! Cuidado você está entrando em hipoglicemia!!");
}
if (medicao2 > 250)
{
    Console.WriteLine("Atenção! Cuidado você está entrando em hiperglicemia!!");
}

Console.Write("Digite sua glicemia em Jejum do Terceiro Dia: ");
medicao3 = int.Parse(Console.ReadLine());

//ifs concatenados
if (medicao3 < 65)
{
    Console.WriteLine("Atenção! Cuidado você está entrando em hipoglicemia!!");
}
if (medicao3 > 250)
{
    Console.WriteLine("Atenção! Cuidado você está entrando em hiperglicemia!!");
}

mediaMedicao = (medicao1 + medicao2 + medicao3) / 3;

Console.WriteLine($"Sua média glicêmica foi de {mediaMedicao} mg/ml");


//ifs aninhados
if (mediaMedicao < 80)
{
    Console.WriteLine("Parabéns! Você pode diminuir 2 unidades de insulina");
} else if (mediaMedicao > 150)
{
    Console.WriteLine("Cuidado com a alimentação ou falta de exercícios. Você precisa aumentar 2 unidades de insulina");
}