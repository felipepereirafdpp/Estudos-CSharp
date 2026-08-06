
using Aula_02;
using System.Globalization;
double precoEstouqe;

Produto produto = new Produto();
Console.WriteLine("Entre os Dados do produto: ");
Console.Write("Nome: ");
produto.Nome = Console.ReadLine();
Console.Write("Preço: ");
produto.Preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
Console.Write("Quantidade no Estoque: ");
produto.Quantidade = int.Parse(Console.ReadLine());

precoEstouqe = produto.ValorTotalEmEstoque();
Console.WriteLine("Dados do Produto: " + produto.Nome + " , " + "R$" + produto.Preco.ToString("F2") + " , " + produto.Quantidade + " Unidades " + " , "+ "Total Estoque: " + "R$"+precoEstouqe);

Console.Write("Digite o numero de produtos a ser adicionado ao estoque: ");
int valorAdicionado = int.Parse(Console.ReadLine());

produto.AdicionarProdutos(valorAdicionado);
precoEstouqe = produto.ValorTotalEmEstoque();

Console.WriteLine("Dados Atualizados: " + produto.Nome + " , " + "R$" + produto.Preco.ToString("F2") + " , " + produto.Quantidade + " Unidades " + " , " + "Total Estoque: " + "R$" + precoEstouqe);

Console.Write("Digite o numero de produtos a ser removido ao estoque: ");
int valorRemovido = int.Parse(Console.ReadLine());

produto.RemoveProdutos(valorRemovido);
precoEstouqe = produto.ValorTotalEmEstoque();

Console.WriteLine("Dados Atualizados: " + produto.Nome + " , " + "R$" + produto.Preco.ToString("F2") + " , " + produto.Quantidade + " Unidades " + " , " + "Total Estoque: " + "R$" + precoEstouqe);

