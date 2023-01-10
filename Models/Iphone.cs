namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo \"{nomeApp}\" no seu {this.GetType().Name}, aguarde...");
            //Console.WriteLine("");
            for (int i = 0; i < 100; i++ )
            {
                Console.Write(".");
                System.Threading.Thread.Sleep(100);
            }

            Console.WriteLine($"\n Aplicativo \"{nomeApp}\" instalado com sucesso!");
        }
    }
}