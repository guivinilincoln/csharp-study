using System.Globalization;

namespace EntradaDeDados {
    class ValorHora {
        static void Main(string[] args) {
            int numeroFuncionario = int.Parse(Console.ReadLine());
            int horasTrabalhadas = int.Parse(Console.ReadLine());
            double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valorReceber = valorHora * horasTrabalhadas;

            Console.WriteLine("NUMBER = " + numeroFuncionario);
            Console.WriteLine("SALARY = U$ " + valorReceber.ToString("F2", CultureInfo.InvariantCulture));
        }
    }

}
