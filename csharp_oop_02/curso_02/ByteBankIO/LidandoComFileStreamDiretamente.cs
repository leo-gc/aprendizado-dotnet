using ByteBankIO;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

partial class Program
{
    static void LidandoComFileStreamDiretamente(string[] args)
    {
        string enderecoDoArquivo = "contas.txt";

        using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {
            int numeroDeBytesLidos = -1;

            byte[] buffer = new byte[1024]; //1KB

            while (numeroDeBytesLidos != 0)
            {
                numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);

                EscreverBuffer(buffer, numeroDeBytesLidos);
            }

            // public override int Read(byte[] array, int offset, int count);

            fluxoDoArquivo.Close();

            Console.ReadLine();
        }
    }

    static void EscreverBuffer(byte[] buffer, int bytesLidos)
    {
        var utf8 = new UTF8Encoding();

        var texto = utf8.GetString(buffer, 0, bytesLidos);

        //public virtual string GetString(byte[] bytes, int index, int count);
        Console.Write(texto);

        //foreach (byte meuByte in buffer)
        //{
        //    Console.Write(meuByte);
        //    Console.Write(" ");
        //}
    }
}