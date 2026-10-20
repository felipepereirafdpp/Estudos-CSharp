using Aula_06;

Produto p = new Produto("TV", 10);

Console.WriteLine(p.GetNome());

p.Nome = "TV 4K";

Console.WriteLine(p.GetNome());