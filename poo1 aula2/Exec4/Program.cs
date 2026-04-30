// See https://aka.ms/new-console-template for more information
Console.Write("Informe o raio do circulo: ");
double raio = double.Parse(Console.ReadLine());

// 2. Calculando a área (A = π * r²)
// Usamos Math.PI para pegar o valor exato de Pi (3.14159...)
// Usamos Math.Pow(raio, 2) para elevar o raio ao quadrado (potência de 2)

double area = Math.PI * Math.Pow(raio, 2);

Console.WriteLine($"area calculada:{area:F2}");
Console.WriteLine("fim da execução do programa");
