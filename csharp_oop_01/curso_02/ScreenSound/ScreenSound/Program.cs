//Banda queen = new Banda("Queen");

//Album albumDoQueen = new Album("A night at the opera");

//Musica musica1 = new Musica(queen, "Love of my life")
//{
//    Duracao = 213,
//    Disponivel = true,
//};

//Musica musica2 = new Musica(queen, "Bohemian Rapsody")
//{
//    Duracao = 354,
//    Disponivel = false,
//};

//albumDoQueen.AdicionarMusica(musica1);
//albumDoQueen.AdicionarMusica(musica2);
//queen.AdicionarAlbum(albumDoQueen);

//musica1.ExibirFichaTecnica();
//musica2.ExibirFichaTecnica();
//albumDoQueen.ExibirMusicasDoAlbum();
//queen.ExibirDiscografia();

Episodio ep1 = new(2, "Técnicas de facilitação", 45);
ep1.AdicionarConvidado("Maria");
ep1.AdicionarConvidado("Marcelo");

Episodio ep2 = new(1, "Técnicas de aprendizado", 67);
ep2.AdicionarConvidado("Fernando");
ep2.AdicionarConvidado("Marcos");
ep2.AdicionarConvidado("Flavia");

Podcast podcast = new("Podcast especial", "Daniel");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();