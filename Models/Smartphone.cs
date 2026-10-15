namespace DesafioPOO.Models
{
  public abstract class Smartphone(string numero, string imei, string modelo, int memoria)
  {
    public string Numero { get; set; } = numero;
    public string Imei { get; set; } = imei;
    public string Modelo { get; set; } = modelo;
    public int Memoria { get; set; } = memoria;

    public abstract void Ligar();

    public abstract void ReceberLigacao();

    public abstract void InstalarAplicativo(string nomeApp);
  }
}
