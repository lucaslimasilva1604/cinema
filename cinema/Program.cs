using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinema
{
    internal class Program
    {
        public static void RevervasDeCadeira(string[] cadeiras)
        {
            for (int i = 0; i < 10; i++)
            {
                if (cadeiras[i] == "X")
                {
                    Console.Write("[ --- ] ");
                }
                else
                {
                    Console.Write($"[ {cadeiras[i]} ] ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------");
        }
        public static void OcupadoOuNao(string[] cadeiras, string cadeiraReservada)
        {
            for (int i = 0; i < 10; i++)
            {
                if (cadeiraReservada == cadeiras[i])
                {
                    cadeiras[i] = "X";
                    Console.WriteLine($"Cadeira {cadeiraReservada} RESERVADA!");
                    break;
                }
                if (i == 9)
                {
                    Console.WriteLine("ERRO: Lugar Ocupado!");
                }
            }
        }
        static void Main(string[] args)
        {
            string[] cadeiras = new string[10];

            for (int i = 0; i < 10; i++)
            {
                int lugar = i + 1;
                cadeiras[i] = "B" + lugar.ToString();
            }

            char escolha;

            do
            {
                RevervasDeCadeira(cadeiras);

                Console.Write("Reservar a cadeira: ");
                string cadeiraReservada = Console.ReadLine();

                OcupadoOuNao(cadeiras, cadeiraReservada);

                Console.Write("Quer reservar outro? [S/N] ");
                escolha = char.Parse(Console.ReadLine());

                Console.Clear();
            } while (escolha == 'S' || escolha == 's');

            Console.ReadKey();
        }
    }
}
