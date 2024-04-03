namespace TorneioDeTenis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 0, aux = 0;
            while (aux < 6)
            {
                aux++;
                string vitoria = Console.ReadLine();
                if (vitoria != "V" && vitoria != "v" && vitoria != "p" && vitoria != "P")
                {
                    Console.WriteLine("Comando invalido. Tente novamente. Precione qualquer tecla para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }
                if (vitoria == "v" || vitoria == "V")
                {
                    cont++;
                }
            }
            int resultado = 0;
            if (cont == 1 || cont == 2)
            {
                resultado = 3;
            }
            if (cont == 3 || cont == 4)
            {
                resultado = 2;
            }
            if (cont == 5 || cont == 6)
            {
                resultado = 1;
            }
            if (cont < 1)
            {
                resultado = -1;
            }
            Console.Clear();
            Console.Write(resultado);
            Console.ReadLine();
        }
    }
}
