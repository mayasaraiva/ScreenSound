class Musica
{
    public string Nome {  get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; } //propriedade pascal case

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
        Console.WriteLine($"Artista: {Artista}");
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