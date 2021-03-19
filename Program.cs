using System;

namespace VelocMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada1,entrada2;
            double distância,tempo,VelocMedia;
            
            Console.Beep();
            Console.WriteLine("---------");
            Console.ForegroundColor=ConsoleColor.DarkRed;
            Console.WriteLine("Cálculo da Velocidade Média");
            Console.ResetColor();
            Console.Write("Digite o valor da distância percorrida (em metros): ");
            entrada1 = Console.ReadLine();
            Console.Write("Digite o valor do tempo gasto (em segundos): ");
            entrada2 = Console.ReadLine();

            distância = Convert.ToDouble(entrada1);
            tempo = Convert.ToDouble(entrada2);

            VelocMedia= distância/tempo;

            Console.Beep();
            Console.WriteLine("----------");
            Console.ForegroundColor=ConsoleColor.DarkRed;
            Console.WriteLine("\n---Resultado---");
            Console . ResetColor ();
            Console.WriteLine($"{VelocMedia:N2} m/s");
            Console.WriteLine("----------");
        }
    }
}
