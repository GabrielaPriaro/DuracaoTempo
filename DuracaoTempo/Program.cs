//Problema "duracao"
//Fazer um programa para ler uma duração de tempo em segundos, daí imprimir na tela esta duração no
//formato horas:minutos:segundos.

namespace DuracaoTempo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalSegundos, duracaoHoras, duracaoMinutos, duracaoSegundos ;

            Console.Write("Digite a duracao em segundos: ");
            totalSegundos = int.Parse(Console.ReadLine());

            duracaoHoras = totalSegundos / 3600;
            duracaoMinutos = (totalSegundos % 3600) / 60;
            duracaoSegundos = totalSegundos % 60;

            Console.WriteLine($"{duracaoHoras}:{duracaoMinutos}:{duracaoSegundos}");
        }
    }
}
