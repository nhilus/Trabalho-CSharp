using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Prático
{
    internal class Camiao : Veiculo
    {

        public int PesoMaximo { get; set; }


        public Camiao() : base()
        {
            PesoMaximo = 0;
        }

        public Camiao(string marcaModelo, string tipo, int quantidade, string cor, string combustivel, int precoDia, string estado, int pesoMaximo) : base(marcaModelo, tipo, quantidade, cor, combustivel, precoDia, estado)
        {
            PesoMaximo = pesoMaximo;
        }

        public Camiao(Camiao cPesado) : base(cPesado.MarcaModelo, cPesado.Tipo, cPesado.Quantidade, cPesado.Cor, cPesado.Combustivel, cPesado.PrecoDia, cPesado.Estado)
        {
            PesoMaximo = cPesado.PesoMaximo;
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
            return base.ToString() + $"|| Peso Máximo: {PesoMaximo}"; 
        }
    }
}
