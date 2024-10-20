
using System.Globalization;
using VerificaçãoEmEstoque;

Produtos p = new Produtos();

Console.WriteLine("Entre os dados do produto:");
Console.Write("Nome: ");
p.Nome = Console.ReadLine();

Console.Write("Preço: ");
p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Quantidade: ");
p.Quantidade = int.Parse(Console.ReadLine());
Console.WriteLine("Dados do produto: " + p);


Console.WriteLine();
Console.Write("Digite o número de produtos a ser adicionado no estoque: ");
int qte = int.Parse(Console.ReadLine());
p.AdiocionarProdutos(qte);
Console.WriteLine();
Console.WriteLine("Dados Atulizados: " + p);


Console.WriteLine();
Console.Write("Digite o número de produtos a ser Removido do estoque: ");
qte = int.Parse(Console.ReadLine());
p.RemoverProdutos(qte);
Console.WriteLine();
Console.WriteLine("Dados Atulizados: " + p);
