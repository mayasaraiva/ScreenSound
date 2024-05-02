class Album
{
    //campo privado que funciona apenas dentro desta classe
    private List<Musica> musicas = new List<Musica>();

    public Album(string nome)
    {
        Nome = nome;
    }
    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao); 
    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum {this.Nome}\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}\n");
        }

        Console.WriteLine($"Para ouvir esse álbum inteiro você precisa de {DuracaoTotal} segundos.");
    }
}