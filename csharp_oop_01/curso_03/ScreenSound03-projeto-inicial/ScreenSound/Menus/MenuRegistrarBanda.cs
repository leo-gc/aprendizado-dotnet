using ScreenSound.Modelos;
using OpenAI.Chat;

namespace ScreenSound.Menus;

internal class MenuRegistrarBanda : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Registro das bandas");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        Banda banda = new(nomeDaBanda);
        bandasRegistradas.Add(nomeDaBanda, banda);

        var apiKey = Environment.GetEnvironmentVariable("OPENAI_API_KEY");
        if (string.IsNullOrWhiteSpace(apiKey))
        {
            Console.WriteLine("⚠️ OPENAI_API_KEY não definida. Configure a variável de ambiente.");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
            return;
        }

        var chatClient = new ChatClient("gpt-5-mini", apiKey);

        var messages = new List<ChatMessage>
        {
            new SystemChatMessage("Você é um assistente que responde de forma informal, clara e em PT-BR."),
            new UserChatMessage($"Resuma a banda {nomeDaBanda} em 1 parágrafo. Adote um estilo informal.")
        };

        try
        {
            var result = chatClient.CompleteChatAsync(messages).GetAwaiter().GetResult();

            ChatCompletion completion = result.Value;

            banda.Resumo = completion.Content[0].Text ?? "(sem resposta)";
        }
        catch (Exception ex)
        {
            banda.Resumo = $"(Falha ao gerar resumo: {ex.Message})";
        }

        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }

}
