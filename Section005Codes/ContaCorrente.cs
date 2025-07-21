using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section005Codes
{
    public class ContaCorrente
    {
        private double _saldo;
        public int NumeroDaConta { get; private set; }
        public string Titular { get; private set; }

        public ContaCorrente(int numeroDaConta, string titular)
        {
            NumeroDaConta = numeroDaConta;
            Titular = titular;
        }

        public ContaCorrente(int numeroDaConta, string titular, double depositoInicial) : this(numeroDaConta, titular)
        {
            OperacaoSaldo("deposito", depositoInicial);
        }

        public double Saldo
        {
            get { return _saldo; }
            set { _saldo = Saldo; }
        }

        public string OperacaoSaldo(string operacao, double valor)
        {
            if (operacao.Equals("deposito", StringComparison.OrdinalIgnoreCase))
            {
                _saldo += valor;
                return $"Depósito concluído! Saldo Atual: {Saldo}";
            }
            else if (operacao.Equals("saque", StringComparison.OrdinalIgnoreCase))
            {
                _saldo = _saldo - valor - 5;
                return $"Saque concluído! Taxa de R$5 cobrada. Saldo Atual: {Saldo}";
            }
            else
            {
                return "Operação inválida!";
            }
        }
    }
}