namespace AbstraindoCelular.Models;

public class Nokia : Smartphone
{
    public override void InstalarAplicativo(string nomeApp)
    {
        Console.WriteLine($"Instalando App {nomeApp}");
    }

    public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
    {
    }

    
}