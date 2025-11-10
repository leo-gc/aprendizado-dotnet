using ScreenSound_04.Modelos;
using ScreenSound_04.Filtros;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
	try
	{
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        //Console.WriteLine(resposta);
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        LinqFilter.FiltrarMusicasEmCSharp(musicas);
        //musicas[1].ExibirDetalhesDaMusica();
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusicasl(musicas, "rock");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Michael Jackson");

        //MusicasFavoritas musicasFavoritasDoLeo = new("Leo");
        //musicasFavoritasDoLeo.AdicionarMusicaFavorita(musicas[58]);
        //musicasFavoritasDoLeo.AdicionarMusicaFavorita(musicas[209]);
        //musicasFavoritasDoLeo.AdicionarMusicaFavorita(musicas[12]);
        //musicasFavoritasDoLeo.AdicionarMusicaFavorita(musicas[84]);
        //musicasFavoritasDoLeo.AdicionarMusicaFavorita(musicas[134]);
        //musicasFavoritasDoLeo.AdicionarMusicaFavorita(musicas[211]);
        //musicasFavoritasDoLeo.AdicionarMusicaFavorita(musicas[390]);

        //musicasFavoritasDoLeo.ExibirMusicasFavoritas();

        //MusicasFavoritas musicasFavoritasDoDaniel = new("Daniel");
        //musicasFavoritasDoDaniel.AdicionarMusicaFavorita(musicas[53]);
        //musicasFavoritasDoDaniel.AdicionarMusicaFavorita(musicas[208]);
        //musicasFavoritasDoDaniel.AdicionarMusicaFavorita(musicas[13]);
        //musicasFavoritasDoDaniel.AdicionarMusicaFavorita(musicas[85]);
        //musicasFavoritasDoDaniel.AdicionarMusicaFavorita(musicas[135]);
        //musicasFavoritasDoDaniel.AdicionarMusicaFavorita(musicas[212]);
        //musicasFavoritasDoDaniel.AdicionarMusicaFavorita(musicas[391]);

        //musicasFavoritasDoDaniel.ExibirMusicasFavoritas();

        //musicasFavoritasDoDaniel.GerarArquivoJson();
    }
	catch (Exception ex)
	{
        Console.WriteLine($"Temos um problema: {ex.Message}");
	}
}