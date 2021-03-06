﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Abertura_de_Conta
{
    class ContaBancaria
    {
        public int Numero { get; private set; }
        //public int Numero;

        public string Titular { get; set; }
        //public string Titular;

        public double Saldo { get; private set; }
        //public double Saldo;

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double saldo) : this(numero, titular)
        {
            Saldo = saldo;
        }


        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            double taxa = 5;
            Saldo = Saldo - quantia - taxa;
        }

        public override string ToString()
        {
            return "Conta " + Numero + ", Titular: " + Titular + ", Saldo: R$" + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
