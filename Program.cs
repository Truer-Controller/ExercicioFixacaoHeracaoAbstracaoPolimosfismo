using System;
using System.Collections.Generic;
using System.Globalization;
using ExercicioFixacaoHeracaoAbstracaoPolimosfismo.Entities;

namespace ExercicioFixacaoHeracaoAbstracaoPolimosfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> list = new List<Pessoa>();

            Console.WriteLine("Numero de contribuentes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualincome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'i')
                {
                    Console.Write("Healt expenditures: ");
                    double medico = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new PessoaFisica(medico, name, anualincome));
                }
                else
                {
                    Console.Write("Number Employ: ");
                    int trabalhadores = int.Parse(Console.ReadLine());
                    list.Add(new PessoaJuridica(trabalhadores, name, anualincome));
                }
            }

            double soma = 0.0;
            Console.WriteLine("");
            Console.WriteLine("Taxes Paid: ");
            foreach(Pessoa acc in list)
            {
                double taxa = acc.Taxa();
                Console.WriteLine(acc.NamePessoa + ": $ " + taxa.ToString("F2", CultureInfo.InvariantCulture));
                soma += taxa;
            }
            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + soma.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
