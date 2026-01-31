
//CarroClasse carroClasse = new CarroClasse();
//carroClasse.Marca = "VW";
//carroClasse.Ano = 2027;
//carroClasse.Denominacao();

//CarroClasse carro2 = carroClasse;
//carro2.Marca = "GM";
//carro2.Ano = 2028;
//carro2.Denominacao();

//carroClasse.Denominacao();

//------------------------------------------

CarroEstrutura carroEstrutura = new CarroEstrutura();
carroEstrutura.Marca = "VW";
carroEstrutura.Ano = 2029;
carroEstrutura.Denominacao();

CarroEstrutura carroEstrutura2 = carroEstrutura;
carroEstrutura2.Marca = "Peugeot";
carroEstrutura2.Ano = 2030;

carroEstrutura2.Denominacao();
carroEstrutura.Denominacao();

Console.ReadKey();


public class CarroClasse()
{
    public string Marca { get; set; }
    public int Ano { get; set; }

    public void Denominacao()
    {
        Console.WriteLine($"Classe - Carro da marca {Marca} e ano {Ano}");
    }
}

public struct CarroEstrutura()
{
    public string Marca { get; set; }
    public int Ano { get; set; }
    public void Denominacao()
    {
        Console.WriteLine($"Estrutura - Carro da marca {Marca} e ano {Ano}");
    }
}