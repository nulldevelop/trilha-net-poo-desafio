using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia Iniciando");
Nokia nokia = new("123456789", "987654321", "3310", 128);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("----------------------------");

Console.WriteLine("Smartphone Iphone Iniciando");
Iphone iphone = new("987654321", "123456789", "iPhone 12", 256);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");
