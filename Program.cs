double j, m, c, i,t;

Console.Write("Capital [c] (R$).......:");
c = Convert.ToDouble (Console.ReadLine());

Console.Write("Taxa de juros [i] (%)..:");
i = Convert.ToDouble (Console.ReadLine());

Console.Write("Tempo [t] (meses)......:");
t = Convert.ToDouble (Console.ReadLine());

//Calcula Juros Simples 

j = c * (i / 100) * t;

//Calcula o montante

m = c + j;

Console.WriteLine($"\nJuros (R$).....: {j:N2}");
Console.WriteLine($"Montante (R$)..: {m:N2}");