Pessoa p = new Pessoa();
p.Nome = "Joaquim";
p.Idade = 18;
p.Apresentar();

public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public void Apresentar()
    {
        Console.WriteLine($"Olá meu nome é {Nome}, e tenho {Idade} anos ");
    }
}


