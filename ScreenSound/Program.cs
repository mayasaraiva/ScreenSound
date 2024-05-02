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