class Musica
{
    //Criando um construtor, aonde não será possível criar uma música sem criar e passar o nome do artista e banda primeiro
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }
    public string Nome {  get; }
    public Banda Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; } //propriedade pascal case

    public Genero Genero { get; set; }
    public string DescricaoResumida => $"A música {Nome} pertence à banda {Artista}";//chamado lambda

    //Maneira Resumida de ter uma propriedade apenas com o get, igual a de baixo
    //public string DescricaoResumida 
    //{
    //    get
    //    {
    //        return $"A música {Nome} pertence à banda {Artista}";
    //    } 
    //} //sem o set significa que não pode ter a opção de escrita nesta propriedade 


    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano.");
        } else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }
}