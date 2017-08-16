using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleicaoUrnaBasica
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalEleitores, votosBrancos, votosNulos, votosValidos;
            double porcBrancos, porcNulos, porcValidos;
            Console.WriteLine("Digite a quantidade de eleitores, votos brancos e nulos e válidos:");
            totalEleitores = Convert.ToInt32(Console.ReadLine());
            votosBrancos = Convert.ToInt32(Console.ReadLine());
            votosNulos = Convert.ToInt32(Console.ReadLine());
            votosValidos = Convert.ToInt32(Console.ReadLine());
            porcBrancos = (votosBrancos * 100) / totalEleitores;
            porcNulos = (votosNulos * 100) / totalEleitores;
            porcValidos = (votosValidos * 100) / totalEleitores;
            Console.WriteLine("Porcentagem de votos brancos: " + porcBrancos + " %");
            Console.WriteLine("Porcentagem de votos nulos: " + porcNulos + " %");
            Console.WriteLine("Porcentagem de votos válidos: " + porcValidos + " %");
            Console.ReadLine();
        }
    }
}
