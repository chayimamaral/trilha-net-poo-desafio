namespace DesafioPOO.Models
{
    // DONE: Herdar da classe "Smartphone"
    // Implementado...
    public class Nokia : Smartphone
    {
        // DONE: Sobrescrever o método "InstalarAplicativo"
        // Implementado...
        public Nokia(string numero, string modelo, string imei, int memoria)
    : base(numero, modelo, imei, memoria) { }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} via Loja da Nokia no modelo {GetModelo()}.");
        }
    }
}