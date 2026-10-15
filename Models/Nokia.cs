namespace DesafioPOO.Models
{
  // TODO: Herdar da classe "Smartphone"
  public class Nokia(string numero, string imei, string modelo, int memoria) : Smartphone(numero, imei, modelo, memoria)
  {
    public override void InstalarAplicativo(string nomeApp)
    {
      Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia...");
    }

    public override void Ligar()
    {
      Console.WriteLine("Ligando o Nokia...");
    }

    public override void ReceberLigacao()
    {
      Console.WriteLine("Recebendo ligação no Nokia...");
    }
  }
}
