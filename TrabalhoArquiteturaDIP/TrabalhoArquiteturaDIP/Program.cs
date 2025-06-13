namespace Trabalho_Arquitetura_DIP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDevice device = new Lamp();

            Console.WriteLine("Pressione ENTER para ligar/desligar a lâmpada ou Q para sair.");

            while (true)
            {
                var key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.Q)
                {
                    Console.WriteLine("Saindo...");
                    break;
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    device.Operate();
                }
            }
        }
    }
}   
