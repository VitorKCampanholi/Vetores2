using System.Globalization;
using Vetores2;


int n = int.Parse(Console.ReadLine());

Product[] vect = new Product[n];


for (int i = 0; i < n; i++)
{
    string nome = Console.ReadLine();
    double preço = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    vect[i] = new Product { Nome = nome, Preço = preço };
}

double soma = 0.0;
for (int i = 0; i < n; i++)
{
    soma += vect[i].Preço;

}


double avg = soma / n;
Console.WriteLine("AVERAGE PRICE = R$ " + avg.ToString("F2"), CultureInfo.InvariantCulture);