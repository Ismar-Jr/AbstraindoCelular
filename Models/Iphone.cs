namespace AbstraindoCelular.Models;

public class Iphone : Smartphone
{
    
    public override void InstalarAplicativo(string nomeApp)
    {
        Console.WriteLine($"Instalando App {nomeApp}");
    }

    public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
    {
    }
    
}