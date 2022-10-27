using System;

namespace BancoAlura
{
    public class Conta
    {
      
        public int Numero { get; set; }
        public double Saldo { get; private set; }
        public Cliente Titular { get; set; }

        internal void Deposita(double valorOperacao)
        {
            this.Saldo += valorOperacao;
        }
       
    }
}