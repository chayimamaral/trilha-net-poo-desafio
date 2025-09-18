using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
// Implmentado...
class Program
{
  static void Main(string[] args)
  {
    Smartphone nokia = new Nokia("11987654321", "Nokia 3310", "123456789", 64);
    Smartphone iphone = new Iphone("11912345678", "iPhone 14", "987654321", 128);

    Console.WriteLine("=== Testando Nokia ===");
    nokia.Ligar();
    nokia.ReceberLigacao();
    nokia.InstalarAplicativo("WhatsApp");

    Console.WriteLine("\n=== Testando iPhone ===");
    iphone.Ligar();
    iphone.ReceberLigacao();
    iphone.InstalarAplicativo("Instagram");
  }
}