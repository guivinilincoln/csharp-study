namespace ExerciciosUri11 {
    class Caixa {
        static void Main(string[] args) {
            string[] valores = Console.ReadLine().Split(' ');
            int codigo = int.Parse(valores[0]);
            int qtd = int.Parse(valores[1]);

            double valorTotal;

            if (codigo == 1) {
                valorTotal = qtd * 4.00;
            }
            else if (codigo == 2) {
                valorTotal = qtd * 4.50;
            }
            else if (codigo == 3) {
                valorTotal = qtd * 5.00;
            }
            else if (codigo == 4) {
                valorTotal = qtd * 2.00;
            }
            else {
                valorTotal = qtd * 1.50;
            }

            Console.WriteLine("Total: R$ " + valorTotal.ToString("F2"));
        }
    }
}
