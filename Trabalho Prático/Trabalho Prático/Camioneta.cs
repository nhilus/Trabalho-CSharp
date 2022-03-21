using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Prático
{
    internal class Camioneta : Veiculo
    {


        public int NumeroEixos { get; set; }
        public int NumeroMaximoPassageiros { get; set; }


        public Camioneta() : base()
        {
            NumeroEixos = 0;
            NumeroMaximoPassageiros = 0;

        }

        public Camioneta(string marcaModelo, string tipo, int quantidade, string cor, string combustivel, int precoDia, string estado, int numeroEixos, int numeroMaximoPassageiros) : base(marcaModelo, tipo, quantidade, cor, combustivel, precoDia, estado)
        {

            NumeroEixos=numeroEixos;
            NumeroMaximoPassageiros=numeroMaximoPassageiros;

        }

        public Camioneta(Camioneta cPassageiros) : base (cPassageiros.MarcaModelo, cPassageiros.Tipo,cPassageiros.Quantidade,cPassageiros.Cor,cPassageiros.Combustivel,cPassageiros.PrecoDia, cPassageiros.Estado)
        {
            NumeroEixos = cPassageiros.NumeroEixos;
            NumeroMaximoPassageiros = cPassageiros.NumeroMaximoPassageiros;
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
            return base.ToString() + $"|| Numero de eixos: {NumeroEixos} || Numero máximo de passageiros: {NumeroMaximoPassageiros}";
        }
    }

    

    
}
