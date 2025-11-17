using ByteBankIO;

partial class Program
{
    static ContaCorrente ConverterStringParaContaCorrente(string linha)
    {
        // 375 4644 2483.13 Jonatan
        string[] campos = linha.Split(',');

        string agencia = campos[0];
        string numero = campos[1];
        string saldo = campos[2].Replace('.', ',');
        string nomeTitular = campos[3];

        int agenciaComInt = int.Parse(agencia);
        int numeroComInt = int.Parse(numero);
        double saldoComDouble = double.Parse(saldo);

        Cliente titular = new Cliente();
        titular.Nome = nomeTitular;

        var resultado = new ContaCorrente(agenciaComInt, numeroComInt);
        resultado.Depositar(saldoComDouble);
        resultado.Titular = titular;

        return resultado;
    }
}