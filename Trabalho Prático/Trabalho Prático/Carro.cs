using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Prático
{
    internal class Carro : Veiculo
    {

        public int NumeroPortas { get; set; }
        public string TipoCaixa { get; set; }

        public Carro() : base()
        {
            NumeroPortas = 0;
            TipoCaixa = "";

        }

        public Carro(string marcaModelo, string tipo, int quantidade, string cor, string combustivel, int precoDia,string estado,  int numeroPortas, string tipoCaixa) : base ( marcaModelo,  tipo,  quantidade,  cor,  combustivel, precoDia, estado)
        {
            NumeroPortas = numeroPortas;
            TipoCaixa = tipoCaixa;
        }

        public Carro(Carro c) : base(c.MarcaModelo, c.Tipo, c.Quantidade, c.Cor, c.Combustivel, c.PrecoDia, c.Estado)
        {
            NumeroPortas = c.NumeroPortas;
            TipoCaixa = c.TipoCaixa;

        }


        public Carro(Veiculo veiculo): base(veiculo.MarcaModelo, veiculo.Tipo, veiculo.Quantidade, veiculo.Cor, veiculo.Combustivel, veiculo.PrecoDia, veiculo.Estado)
        {
            

        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
