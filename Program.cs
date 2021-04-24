using System;

namespace AnaliseCredito
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal valor, renda, PorcenDeRenda;
            int resul1, parcelas;
            DateTime agora = DateTime.Now;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Olá!                       {agora}");
            Console.WriteLine("      Análise de Crédito.");
            Console.WriteLine("- Recebimento do valor solicitado de empréstimo, a quantidade de parcelas necessária e a renda mensal comprovada.");
            Console.WriteLine();

            Console.Write("Insira o valor solicitado de empréstimo (até R$ 5.000,00): R$ ");
            valor = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine();

            if (valor > 5000)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Atenção!! Valor de empréstimo excedido.");
                Console.ResetColor();
                Environment.Exit(0);
            }

            else if (valor <= 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Atenção!! Valor de empréstimo inválido.");
                Console.ResetColor();
                Environment.Exit(0);
            }

            Console.Write("Insira a quantidade de parcelas solicitado (até 12x): ");
            parcelas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (parcelas > 12)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Atenção!! Quantidade de parcela(s) excedida(s).");
                Console.ResetColor();
                Environment.Exit(0);
            }

            else if (parcelas < 2)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Atenção!! Quantidade de parcela(s) inválida(s).");
                Console.ResetColor();
                Environment.Exit(0);
                Console.WriteLine();

            }

            resul1 = (int)Convert.ToDecimal(valor / parcelas);

            Console.WriteLine($"- As parcelas serão pagas em {parcelas}x de {resul1:C2}.");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("- Pressione 'Enter' para prosseguir...");
            Console.ResetColor();
            Console.ReadLine();

            Console.Write("Insira o valor de renda mensal comprovada: R$ ");
            renda = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine();

            PorcenDeRenda = (renda * 30) / 100;

            if (parcelas > PorcenDeRenda)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Atenção!! O valor da parcela não pode exceder no máximo 30% do valor da renda.");
                Console.ResetColor();
                Environment.Exit(0);
                Console.WriteLine();
            }

            Console.Write("|");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("- Solicitação de empréstimo confirmada.");
            Console.ResetColor();
            Console.WriteLine("|");
            Console.WriteLine($"|Valor de empréstimo: {valor:C2}");
            Console.WriteLine($"|Quantidade de parcelas: {parcelas}x.");
            Console.WriteLine($"|Valor da(s) parcela(s): {resul1:C2}");
            Console.WriteLine($"|Renda do solicitante: {renda:c2}");





        }
    }
}
