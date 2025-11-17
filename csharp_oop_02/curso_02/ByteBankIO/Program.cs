using ByteBankIO;
using System.Text;

partial class Program
{
    static void Main(string[] args)
    {
        //UsarStreamDeEntrada();

        var linhas = File.ReadAllLines("contas.txt");
        //foreach (var linha in linhas)
        //{
        //    Console.WriteLine(linha);
        //}

        var bytesArquivo = File.ReadAllBytes("contas.txt");
        Console.WriteLine($"O arquivo contas.txt possui {bytesArquivo.Length} bytes");

        File.WriteAllText("escrevendoComAClasseFile.txt", "Testando o File.WriteAllText");

        Console.WriteLine("Aplicação Finalizada...");

        Console.ReadLine();
    }
}