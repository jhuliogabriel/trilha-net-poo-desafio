namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone: Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeAplicativo)
        {
            Console.WriteLine($"Instalando o aplicativo '{nomeAplicativo}' no Iphone.");
        }
    }
}