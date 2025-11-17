//Pessoa p = new Pessoa();
//p.Nome = "Joaquim";
//p.Idade = 18;

//Pessoa p = new Pessoa("José", 20);
Pessoa p = new Pessoa();
p.Apresentar();

Pessoa p2 = new Pessoa("José");
p2.Apresentar();

Pessoa p3 = new Pessoa(30);
p3.Apresentar();

public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public static string Versao;

    // Padrão
    //public Pessoa()
    //{
    //    Nome = "Desconhecido";
    //}

    //// Parametrizado
    //public Pessoa(string nome, int idade)
    //{
    //    Nome = nome;
    //    Idade = idade;
    //}

    //// Estático
    //public Pessoa()
    //{
    //    Versao = "1.0.1";
    //}

    // Encadeamento de construtores    

    public Pessoa() : this("Sem nome", 10) { }
    public Pessoa(string nome) : this(nome, 20) { }
    public Pessoa(int idade) : this("Estranho", idade) { }
    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public void Apresentar()
    {
        Console.WriteLine($"Olá meu nome é {Nome}, e tenho {Idade} anos ");
        //Console.WriteLine($"Olá, a versão do sistema é {Versao}");
    }
}


