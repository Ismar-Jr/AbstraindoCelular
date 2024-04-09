namespace AbstraindoCelular.Models;

public abstract class Smartphone
{
    public string Numero { get; set; }
    private string Modelo { get; set; }
    private string IMEI { get; set; }
    private int Memoria { get; set; }
    
    protected Smartphone(string numero, string modelo, string imei, int memoria)
    {
        Numero = numero;
        Modelo = modelo;
        IMEI = imei;
        Memoria = memoria;
    }

    public void ligar()
    {
        Console.WriteLine("Ligando...");
    }

    public void ReceberLigacao()
    {
        Console.WriteLine("Recebendo ligação...");
    }

    public abstract void InstalarAplicativo(string nomeApp);

    public void DescricaoTelefone(string telefone)
    {
        Console.WriteLine("\n______________________");
        Console.WriteLine($"Usando o {telefone}:");
        Console.WriteLine($"Número: {Numero}");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"IMEI: {IMEI}");
        Console.WriteLine($"Memória {Memoria}GB");
    }
    
    
}