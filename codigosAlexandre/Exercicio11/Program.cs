Console.WriteLine("Escreva um algoritmo para ler o número de eleitores " +
    "\nde um município, o número de votos brancos, " +
    "\nnulos e válidos. Calcule e escreva o percentual que cada um " +
    "\nrepresenta em relação ao total de eleitores.");

/// <summary>
/// armazena a quantidade de eleitores digitada pelo usuário
/// </summary>
int numeroEleitores;

/// <summary>
/// armazena a quantidade de votos em branco digitada pelo usuário
/// </summary>
int numeroVotosBrancos;

/// <summary>
/// armazena a quantidade de votos nulos digitada pelo usuário
/// </summary>
int numeroVotosNulos;

/// <summary>
/// armazena o número de votos válidos, calculados no sistema
/// </summary>
int numeroValidos;

/// <summary>
/// armazena a porcentagem de votos em branco
/// </summary>
float porcentagemVotosBrancos;

/// <summary>
/// armazena a porcentagem votos nulos
/// </summary>
float porcentagemVotosNulos;

/// <summary>
/// armazena a porcentagem votos válidos: numero de eleitores menos a
/// soma dos votos nulos e em branco
/// </summary>
float porcentagemVotosValidos;

Console.Write("Informe a quantidade de eleitores: ");
numeroEleitores = int.Parse(Console.ReadLine());

Console.Write("Informe a quantidade de votos brancos: ");
numeroVotosBrancos = int.Parse(Console.ReadLine());

/// <summary>
/// PARA EXEMPLIFICAR NO GITHUB
/// </summary>

Console.Write("Informe a quantidade de votos nulos: ");
numeroVotosNulos = int.Parse(Console.ReadLine());

//lembre que há abstenções... CUIDADO....
numeroValidos = numeroEleitores - (numeroVotosBrancos + numeroVotosNulos);

//numeroEleitores -> 100%
//numeroVotosBrancos -> porcentagemVotosBrancos
porcentagemVotosBrancos = numeroVotosBrancos * 100 / numeroEleitores;

//numeroEleitores -> 100%
//numeroVotosNulos -> porcentagemVotosNulos
porcentagemVotosNulos = numeroVotosNulos * 100 / numeroEleitores;

porcentagemVotosValidos = 100 - (porcentagemVotosBrancos + porcentagemVotosNulos);

Console.WriteLine("Votos nulos (%): " + porcentagemVotosNulos);
Console.WriteLine("Votos em branco (%): " + porcentagemVotosBrancos);
Console.WriteLine("Votos válidos (%): " + porcentagemVotosValidos);