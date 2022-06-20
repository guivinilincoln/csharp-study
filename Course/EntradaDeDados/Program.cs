using System;

namespace EntradaDeDados {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite uma frase: ");
            string frase = Console.ReadLine();
            Console.WriteLine("Digite uma cor: ");
            string x = Console.ReadLine();
            Console.WriteLine("Digite uma cor: ");
            string y = Console.ReadLine();
            Console.WriteLine("Digite uma cor: ");
            string z = Console.ReadLine();
            Console.WriteLine("Digite 3 cores se paradas por espaço: ");
            string[] vet = Console.ReadLine().Split(' ');
            Console.WriteLine("Digite um numero inteiro: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite uma caractere: ");
            char n2 = char.Parse(Console.ReadLine());
            Console.WriteLine("Digite um numero fracionado: ");
            double n3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite um nome, um char, um numero inteiro e um numero fracionado: ");
            string[] vet2 = Console.ReadLine().Split(' ');


            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(vet[0]);
            Console.WriteLine(vet[1]);
            Console.WriteLine(vet[2]);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(vet2[0]);
            Console.WriteLine(char.Parse(vet2[1]));
            Console.WriteLine(int.Parse(vet2[2]));
            Console.WriteLine(double.Parse(vet2[3]));
        }
    }
}
