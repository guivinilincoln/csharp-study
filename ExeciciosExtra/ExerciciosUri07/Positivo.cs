using System.Globalization;

namespace ExerciciosUri07 {
    class Positivo {
        static void Main(string[] args) {
            int numero = int.Parse(Console.ReadLine());
            if (numero < 0) {
                Console.WriteLine("NEGATIVO");
            }
            else {
                Console.WriteLine("NAO NEGATIVO");
            }
        }
    }
}


