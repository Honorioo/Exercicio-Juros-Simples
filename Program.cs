using System;

namespace Exercicio_Juros_Simples
{
    class Program
    {
        static void Main(string[] args)
        {
            double capital, TaxaJros, Tempo, resultadoJ, resultadoM; 

            Console.WriteLine("-------Juros Simples-------");


            Console.Write("Capital [c] (R$).......: ");
            capital = Convert.ToDouble(Console.ReadLine());

            Console.Write("Taxa de Juros (i).......: ");
            TaxaJros = Convert.ToDouble(Console.ReadLine());

            Console.Write("Tempo (t) meses.......: ");
            Tempo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();


            resultadoJ = capital * TaxaJros * Tempo;
            resultadoM = capital + TaxaJros;

                    Console.WriteLine();
                    Console.WriteLine($"Juros (R$).....: {resultadoJ}");
                    Console.WriteLine($"Montante (R$).....: {resultadoM}");












        }
    }
}
