double comprimentoEscada, Altura;
double anguloGraus, anguloRadianus;

Console.Clear();

Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.BackgroundColor = ConsoleColor.Gray;

Console.WriteLine("<---Escada--->\n\n");

Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkCyan;


Console.WriteLine("Informe o Comprimento da escada: ");
comprimentoEscada = Convert.ToDouble(Console.ReadLine()!);

Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkCyan;

Console.WriteLine("Informe o ângulo (em graus) da posição da escada: ");
anguloGraus = Convert.ToDouble(Console.ReadLine()!);

Console.ResetColor();

anguloRadianus = Math.PI * anguloGraus / 180;
Altura = comprimentoEscada * Math.Sin(anguloRadianus);
Altura = Math.Round(Altura, 2);

Console.ForegroundColor = ConsoleColor.DarkCyan;

Console.WriteLine($"Uma escada de {comprimentoEscada}m e um angulo de {anguloGraus}°, alcança {Altura}m na parede.");

Console.ResetColor();
