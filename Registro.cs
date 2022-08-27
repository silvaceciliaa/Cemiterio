using System;
namespace Cemiterio
{
    public class Registro
    {
        public string Nome { get; set; }

        public int AnoMorte { get; set; }

        public int Cova { get; set; }

        public void Enterro(int cova)
        {
            Console.WriteLine("Digite o nome do morto");
            Nome = Console.ReadLine();
            Console.WriteLine("Digite o ano de sua morte");
            AnoMorte = Convert.ToInt32(Console.ReadLine());
            Cova = cova + 1;
            Console.WriteLine($"Morto enterrado com sucesso na cova {Cova}");
        }
    }
}

