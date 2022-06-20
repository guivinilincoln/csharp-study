using System;
using System.Globalization;

namespace Execicio1 {
    class TiposBasicos {
        static void Main(string[] args) {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char generio = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double media = 53.234567;

            Console.WriteLine("Produtos: ");
            Console.WriteLine("{0}, cuso preço é $ {1:F2}", produto1, preco1);
            Console.WriteLine($"{preco2}, cujo o valor é $ {preco2:F2}");

            Console.WriteLine("Registro: " + idade + ", código " + codigo + " é gênero: " + generio);

            Console.WriteLine("Media com oito casas decimais: " + media.ToString("F8"));
            Console.WriteLine("Arredondando (Três casas decimais): " + media.ToString("F3"));
            Console.WriteLine("Separador decimal invariant culture: " + media.ToString("F3", CultureInfo.InvariantCulture));
            
        }

    }
}