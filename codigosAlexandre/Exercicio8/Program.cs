
Console.WriteLine("Ler uma temperatura em graus Celsius e" +
    "\napresentá-la convertida em graus Fahrenheit." +
    "\nA fórmula da conversão é F = (9 * C + 160) / 5.");

/// <summary>
/// valor de temperatura em celsius
/// </summary>
float temperaturaCelsius;

/// <summary>
/// temperatura em fahrenheit convertida de celsius
/// </summary>
float temperaturaFahrenheit;


Console.Write("Digite a temperatura em graus Celsius: ");
temperaturaCelsius = float.Parse( Console.ReadLine() );

temperaturaFahrenheit = (9 * temperaturaCelsius + 160) / 5;

Console.WriteLine("O valor " + temperaturaCelsius + " em graus Celsius é " +
    "em Fahrenheit: " + temperaturaFahrenheit);






















