namespace DesafioPOO.Models
{
    // Herdando da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // Construtor passando todos os parâmetros para a classe base
        public Nokia(string numero, string modelo, string imei, int memoria) 
            : base(numero, modelo, imei, memoria)
        {
        }

        // Sobrescrevendo o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia.");
        }
    }
}
