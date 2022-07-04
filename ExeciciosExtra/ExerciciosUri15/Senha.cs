using System.Globalization;

namespace ExerciciosUri15 {
    class Senha {
        static void Main(string[] args) {
            int senha = 2002;
            int senhaDigitada = int.Parse(Console.ReadLine());

            while (senhaDigitada != senha) {
                Console.WriteLine("Senha Invalida");
                senhaDigitada = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido");

        }
    }
}
