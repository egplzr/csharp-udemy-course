using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Section005Codes
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            ContaCorrente cc;

            Cw("Digite o número da conta");
            int nConta = int.Parse(Cr());

            Cw("Digite o titular da conta");
            string titularConta = Cr();

            Cw("Haverá depósito inicial na conta? [s/n]");
            string confirmDepositoInicial = Cr();

            if (confirmDepositoInicial.Equals("s", StringComparison.OrdinalIgnoreCase))
            {
                Cw("Digite o valor do depósito inicial");
                double depositoInicial = double.Parse(Cr());

                cc = new ContaCorrente(nConta, titularConta, depositoInicial);
            }
            else
            {
                cc = new ContaCorrente(nConta, titularConta);
            }

            Cw($"""
                Dados da conta:
                Conta {cc.NumeroDaConta},
                Titular: {cc.Titular},
                Saldo: {cc.Saldo}
            """);

            Cw("Entre um valor para depositar");
            Cw(cc.OperacaoSaldo("deposito", double.Parse(Cr())));

            Cw("Entre um valor para sacar");
            Cw(cc.OperacaoSaldo("saque", double.Parse(Cr())));
        }

        public static void Cw(string mensagem)
        {
            Console.WriteLine(mensagem);
        }

        public static string Cr()
        {
            return Console.ReadLine();
        }
    }
}