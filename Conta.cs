using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeFinal {
    internal class Conta {

        //ATRIBUTOS 
        private string _nome;
        private double _saldo;

        //AUTO PROPERTIES
        public int Numero { get; private set; }


        //CONSTRUTORES
        public Conta(int numeroConta, string nomeConta) {
            Numero = numeroConta;
            _nome = nomeConta;
            _saldo = 0;
        }

        //PROPERTIES
        public string Nome {
            get { return _nome; }
            set { if (value != null && value.Length > 4) {
                    _nome = value;
                } }
        }

        public double Saldo {
            get { return _saldo; }
            set { _saldo = value; }
        }


        //MÉTODOS

        //Adicionar saldo a conta
        public void Deposito(double valorDeposito) {
            Saldo = Saldo + valorDeposito;
        }

        //Remover saldo da conta
        public void Saque(double valorSaque) {
            Saldo = Saldo - (valorSaque + 5.00);
        }




    }
}
