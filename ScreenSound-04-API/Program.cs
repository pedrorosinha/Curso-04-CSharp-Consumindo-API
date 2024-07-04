using ScreenSound_04_API.Filtros;
using ScreenSound_04_API.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        musicas[1].ExibirDetalhesDaMusica();
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "rock");
        ////LinqFilter.FiltrarMusicasDeUmArtista(musicas, "U2");

        //var musicasPreferidas = new MusicasPreferidas("Playlist");
        //musicasPreferidas.AdicionarMusicasFavoritas(musicas[75]);
        //musicasPreferidas.AdicionarMusicasFavoritas(musicas[247]);
        //musicasPreferidas.AdicionarMusicasFavoritas(musicas[1005]);
        //musicasPreferidas.AdicionarMusicasFavoritas(musicas[510]);
        //musicasPreferidas.ExibirMusicasFavoritas();

        //musicasPreferidas.GerarArquivoJson();

    } catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}