namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"(feito)
    public class Nokia : Smartphone
    {

         public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
             Console.WriteLine($"Intalando o aplicativo'{nomeApp}' no Nokia");
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"(feito)
    }
}