using System;
using System.Globalization;

namespace EntradaDeDados {
    class ValorProduto {
        static void Main(string[] args) {

            string[] vet1 = Console.ReadLine().Split(" ");
            string[] vet2 = Console.ReadLine().Split(" ");

            double valorProduto1 = int.Parse(vet1[1]) * double.Parse(vet1[2]);
            double valorProduto2 = int.Parse(vet2[1]) * double.Parse(vet2[2]);
            double total = valorProduto1 + valorProduto2;

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }

}