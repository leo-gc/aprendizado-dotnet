using AtividadesExtras;
using System.Threading.Channels;

public class Program
{
    public static void Main(string[] args)
    {
        // Dada uma lista de números, criar uma consulta LINQ para retornar apenas os elementos únicos da lista.

        List<int> listaDeNumeros = [5, 3, 7, 1, 5, 2, 9, 8, 0, 1, 4];
        List<int> listaDeNumerosUnicos = listaDeNumeros.Distinct().ToList();
        Console.WriteLine($"Lista de números únicos: {String.Join(", ", listaDeNumerosUnicos)}\n");

        // Dada uma lista de livros com título, autor e ano de publicação, criar uma consulta LINQ para retornar uma lista com os títulos dos livros publicados após o ano 2000, ordenados alfabeticamente.

        List<Livro> livros = new List<Livro>
        {
            new Livro { Titulo = "Aprendendo LINQ", Autor = "João Silva", AnoPublicacao = 2005 },
            new Livro { Titulo = "Programação em C#", Autor = "Ana Oliveira", AnoPublicacao = 2010 },
            new Livro { Titulo = "Algoritmos e Estruturas de Dados", Autor = "Carlos Santos", AnoPublicacao = 1998 },
            new Livro { Titulo = "Introdução à Inteligência Artificial", Autor = "Mariana Costa", AnoPublicacao = 2021 },
            new Livro { Titulo = "Design Patterns", Autor = "Paulo Rocha", AnoPublicacao = 2002 }
        };

        List<string> titulosLivrosApos2000 = livros
            .Where(livro => livro.AnoPublicacao > 2000)
            .Select(livro => livro.Titulo)
            .Order()
            .ToList();

        Console.WriteLine($"Títulos de livros após o ano 2000, ordenados alfabeticamente:\n{String.Join("\n", titulosLivrosApos2000)}\n");

        // Dada uma lista de produtos com nome e preço, criar uma consulta LINQ para calcular o preço médio dos produtos.
        List<Produto> produtos = new List<Produto>
        {
            new Produto { Nome = "Laptop", Preco = 1200 },
            new Produto { Nome = "Smartphone", Preco = 800 },
            new Produto { Nome = "Tablet", Preco = 500 },
            new Produto { Nome = "Câmera", Preco = 300 }
        };

        var precoMedio = produtos.Average(p => p.Preco);

        Console.WriteLine($"Preço médio dos produtos: {precoMedio}\n");

        // Dada uma lista de inteiros, criar uma consulta LINQ para retornar apenas os números pares.
        List<int> inteiros = [1, 8, 3, 6, 4, 5, 7, 2, 9, 2];
        List<int> inteirosPares = inteiros.Where(n => n % 2 == 0).ToList();

        Console.WriteLine($"Inteiros pares: {String.Join(", ", inteirosPares)}");
    }
}