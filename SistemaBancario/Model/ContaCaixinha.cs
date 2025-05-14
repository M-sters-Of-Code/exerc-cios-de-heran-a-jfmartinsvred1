using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.Model
{
    public class ContaCaixinha : Conta
    {
        public override void Depositar(decimal valor)
        {

            if (valor <= 1)
                throw new ArgumentOutOfRangeException("O valor do depósito deve ser maior ou igual a 1.");
            var valorComLucro = valor * 1.01m;
            this.Saldo += valorComLucro;
        }

        public override void Sacar(decimal valor)
        {
            base.Sacar(valor);
        }
        public ContaCaixinha(decimal saldo) : base(saldo)
        {
        }

        public ContaCaixinha(Cliente cliente) : base(cliente)
        {
        }
    }
}
