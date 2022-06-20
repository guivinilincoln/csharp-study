using System;
using System.Globalization;

namespace Execicio1 {
    class EntradaDeDados{
        static void Main(string[] args) {
            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem sua casa ?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto: ");
            double preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com seu útlimo nome, idade e altura (mesma linha): ");
            string[] vet = Console.ReadLine().Split(' ');

            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Quartos em casa: :" + quartos);
            Console.WriteLine("Preço do protudo: " + preco);
            Console.WriteLine("Ultimo nome: " + vet[0]);
            Console.WriteLine("Sua idade: " + int.Parse(vet[1]));
            double altura = double.Parse(vet[2]);
            Console.WriteLine("Sua altura: " + altura.ToString("F2"));
        }
    }
}

