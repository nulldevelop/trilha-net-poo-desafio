namespace DesafioPOO.Models
{
  public class Iphone(string numero, string imei, string modelo, int memoria) : Smartphone(numero, imei, modelo, memoria)
  {
    public override void InstalarAplicativo(string nomeApp)
    {
      Console.WriteLine($"Instalando o aplicativo {nomeApp} no Iphone...");
    }

    public override void Ligar()
    {
      Console.WriteLine("Ligando o Iphone...");
    }

    public override void ReceberLigacao()
    {
      Console.WriteLine("Recebendo ligação no Iphone...");
    }
  }
}
