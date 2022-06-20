using System;

namespace EntradaDeDados {
    class Raio {
        static void Main(string[] args) {
            double pi = 3.14159;
            double raio = double.Parse(Console.ReadLine());
            double area = pi * raio * raio;
            Console.WriteLine("A= " + area.ToString("F4"));
        }
    }

}
