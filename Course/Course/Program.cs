using System;
using System.Globalization;

namespace Course {
    class tiposBasicos {
        static void Main(string[] args) {
            Console.WriteLine("Tipos básicos: ");

            bool completo = false;
            char genero = 'f';



            sbyte x = 100; //Tipo pre definido
            SByte y = 100; //Tipo System

            byte n0 = 255; //Não aceita negativo e nem acima de 256

            int n1 = 2147483647;
            long n2 = 2147483648L;
            float n3 = 5.3f;
            double n4 = 5.3;
            string nome = "Guilherne Lincoln";
            object obj = "Vinicius Martins";
            object obj1 = 25;

            //Valores minimos e maximos
            int n5 = int.MaxValue;
            int n6 = int.MinValue;
            sbyte n7 = sbyte.MinValue;
            decimal n8 = decimal.MaxValue;

            Console.WriteLine(x + " -> sbyte pre definido");
            Console.WriteLine(y + " -> SByte Tipo System");
            Console.WriteLine(n0 + " -> byte ate 255");
            Console.WriteLine(n1 + " -> Tipo inteiro valor maximo 2147483647");
            Console.WriteLine(n2 + " -> Tipo long, lmebrar de colocar L no final para mostrar que se trada de um Longs");
            Console.WriteLine(completo + " -> Tipo bool, armazenar verdadeiro ou falso");
            Console.WriteLine(genero + " -> Tipo char, sempre entre aspas simpless, ´podemos utilizar o codigo unicode desse caracter");
            Console.WriteLine(n3 + " -> Tipo float, lembrar sempre de colocar f no final");
            Console.WriteLine(n4 + " -> Tipo double");
            Console.WriteLine(nome + " -> Tipo String ele não é um tipo basico, pois ele é IMTÁVEL, sendo assim não pode ser alterado");
            Console.WriteLine(obj = " -> Tipo Object, ele é um tipo generico, onde pode receber um 'dos outros tipos' Exemplo: " + obj + " " + obj1);
            Console.WriteLine("Valores Minimos e Maximos: ");
            Console.WriteLine(n5 + "- > Valor Max de Int");
            Console.WriteLine(n6 + "- > Valor Min de Int");
            Console.WriteLine(n7 + "- > Valor Min de sbyte");
            Console.WriteLine(n8 + "- > Valor Max de decimal");

            //saida de dados
            char generoDois = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nomeDois = "Luiz";

            Console.Write("Bom dia!");
            Console.WriteLine("Boa noite !");
            Console.WriteLine("----------------------------");
            Console.WriteLine(generoDois);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nomeDois);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F4",CultureInfo.InvariantCulture));

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reaiss");

        }
    }
}
