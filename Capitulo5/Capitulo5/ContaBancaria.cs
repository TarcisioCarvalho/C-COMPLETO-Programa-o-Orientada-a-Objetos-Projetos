using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo5
{
    class ContaBancaria
    {
        private double _saldo;
        public String NumeroConta { get; set; }
        public String Nome { get; set; }

        public ContaBancaria(string numeroConta, string nome)
        {
            NumeroConta = numeroConta;
            Nome = nome;
        }


        public ContaBancaria(string numeroConta, string nome, Double saldo):this(numeroConta, nome)
        {
            deposito(saldo);
        }

        public Double Saldo
        {
            get { return _saldo; }
        }

        public void deposito(Double deposito)
        {
            _saldo += deposito;
           
        }

        public void saque(Double saque)
        {
            _saldo -= (5 + saque);
            Console.WriteLine("Dados Atualizados :");
        }

        public override string ToString()
        {
            return $"Conta {NumeroConta}, Titular: {Nome}, Saldo: {_saldo}";
        }
    }
}
