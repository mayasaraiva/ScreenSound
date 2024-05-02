Banda banda1 = new Banda("Queen");


Album albumDoQueen = new Album("A night at the opera");


Musica musica1 = new Musica(banda1, "Love of my life")
{
    Duracao = 213,
    Disponivel = true,
};

Musica musica2 = new Musica(banda1, "Bohemian Rhapsody")
{
    Duracao = 354,
    Disponivel = true,
};


albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);
banda1.AdicionarAlbum(albumDoQueen);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();

albumDoQueen.ExibirMusicasAlbum();
banda1.ExibirDiscografia();

Episodio ep1 = new(1, "Técnicas de Autoconhecimento", 45);
ep1.AdicionarConvidados("Maria");
ep1.AdicionarConvidados("João");

Episodio ep2 = new(2, "Técnicas de Aprendizado", 30);
ep2.AdicionarConvidados("Leandro");
ep2.AdicionarConvidados("Rafaela");

Episodio ep3 = new(3, "Técnicas de Performance", 37);
ep3.AdicionarConvidados("Eduardo");
ep3.AdicionarConvidados("Daniela");

Podcast podcast = new("Mayara", "100% Presente");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.AdicionarEpisodio(ep3);
podcast.ExibirDetalhes();