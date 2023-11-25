namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia: Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeAplicativo)
        {
            Console.WriteLine($"Instalando o aplicativo '{nomeAplicativo}' no Nokia.");
        }
    }
}