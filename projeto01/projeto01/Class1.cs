using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto01
{
	internal class contaBancaria
	{
		private int numero_da_conta;
		private string Titular_da_conta;
		private double saldo_da_conta;

        public double Saldo
        {
            get { return saldo_da_conta; }
            set {  saldo_da_conta = value;}
        }

        public string titular_da_conta
        {
			get { return Titular_da_conta; }
			set { Titular_da_conta = value; }
		}
      

        public int Numero_da_conta
        {
            get { return numero_da_conta; }
            set { numero_da_conta = value; }
        }


        //construtures
        public contaBancaria(int numero_da_conta, string titular_da_conta)
        {
            this.numero_da_conta = numero_da_conta;
            Titular_da_conta = titular_da_conta;
        }

        public contaBancaria(int numero_da_conta, string titular_da_conta, double saldo_da_conta) : this(numero_da_conta, titular_da_conta)
        {
            this.saldo_da_conta = saldo_da_conta;
        }

        //metodos 
         public void Deposito (double quantia)
        {
            saldo_da_conta += quantia;
        }

        public void Saque (double quantia)
        {
            saldo_da_conta -= quantia +5;
        }
    }
}
