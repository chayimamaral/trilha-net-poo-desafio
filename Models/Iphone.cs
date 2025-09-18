namespace DesafioPOO.Models
{
    // DONE: Herdar da classe "Smartphone"
    // Implementado...

    public class Iphone : Smartphone
    {
        // DONE: Sobrescrever o método "InstalarAplicativo"
        // Implementado...
        public Iphone(string numero, string modelo, string imei, int memoria)
    : base(numero, modelo, imei, memoria) { }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} via App Store no modelo {GetModelo()}.");
        }
    }
}