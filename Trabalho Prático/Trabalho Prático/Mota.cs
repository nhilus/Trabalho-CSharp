using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Prático
{
    internal class Mota : Veiculo
    {

        public int Cilindrada { get; set; }



        public Mota() : base()
        {
            Cilindrada=0;
        }

        public Mota(string marcaModelo, string tipo, int quantidade, string cor, string combustivel, int precoDia, string estado, int cilindrada): base(marcaModelo, tipo, quantidade, cor, combustivel, precoDia, estado)
        {
            Cilindrada = cilindrada;
        }

        public Mota(Mota m) : base(m.MarcaModelo, m.Tipo, m.Quantidade, m.Cor, m.Combustivel, m.PrecoDia, m.Estado)
        {
            Cilindrada = m.Cilindrada;

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
