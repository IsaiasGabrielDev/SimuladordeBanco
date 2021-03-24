using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace SimuladorBanco_aplicandoconhecimento
{
    class ContaBancaria
    {
        public int Numero { get; private set; }
        public String Titular { get; set; }
        public Double Saldo { get; private set; }

        
        //Construtores
        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double saldo) :this(numero,titular)
        {
            
            Saldo = saldo;
        }

        //Meus métodos

        public void AdicionarFundos(double quantidade)
        {
            Saldo += quantidade;
        }

        public void RemoverFundos(double quantidade)
        {
            Saldo -= quantidade;
            Saldo -= 5.0;
        }

        public override string ToString()
        {
            return "Conta "
                + Numero
                + ", Titular: "
                + Titular
                + " Saldo: R$ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);


        }

    }
}
