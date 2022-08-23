using System;

namespace CalculoCombustivel {
    class Program {
        
        static void Main(string[] args) {
            int escolha = Console.WriteLine("Escolha uma Ação: 1-Fazer o cálculo / 2-Encerrar");

            while escolha == 1 {
                int alcool = Console.WriteLine("Qual o valor do Álcool: ");
                int gasolina = Console.WriteLine("Qual o valor da Gasolina: ");

                if ((alcool / gasolina) > 0.7) {
                    console.WriteLine("Vale a pena Gasolina")
                } else if ((alcool / gasolina) < 0.7) {
                    console.WriteLine("Vale a pena Gasolina")
                } else if ((alcool / gasolina) == 0.7) {
                    console.WriteLine("Tanto faz")
                }
                int escolha = Console.WriteLine("Escolha uma Ação: 1-Fazer o cálculo / 2-Encerrar");
            }
            console.WriteLine("App encerrado! Obrigado por utilizar nossos serviços.")
            console.WriteLine("Dirija com Cuidado.")
        }
    }
}