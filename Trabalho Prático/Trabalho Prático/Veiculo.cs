using System;

namespace Trabalho_Prático
{
    internal class Veiculo
    {
        
        public string MarcaModelo { get; set; }
        public string Tipo { get; set; }
        public int Quantidade { get; set; }
        public string Cor { get; set; }
        public string Combustivel { get; set; }
        public int PrecoDia { get; set; }
        public string Estado { get; set; }


        public Veiculo()
        {
            MarcaModelo = "";
            Tipo = "";
            Quantidade = 0;
            Cor = "";
            Combustivel = "";
            PrecoDia = 0;
            Estado = "";

        }

        public Veiculo(string marcaModelo, string tipo, int quantidade, string cor, string combustivel, int precoDia, string estado)
        {
            MarcaModelo = marcaModelo;
            Tipo=tipo;
            Quantidade = quantidade;
            Cor = cor;
            Combustivel = combustivel;
            PrecoDia = precoDia;
            Estado = estado;
        }

        public Veiculo(Veiculo v)
        {
            MarcaModelo = v.MarcaModelo;
            Tipo = v.Tipo;
            Quantidade = v.Quantidade;
            Cor = v.Cor;
            Combustivel = v.Combustivel;
            PrecoDia = v.PrecoDia;
            Estado=v.Estado;
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override string ToString()
        {
            return $"Marca e modelo: {MarcaModelo}|| Tipo: {Tipo} || Qtd: {Quantidade} || Cor: {Cor} || Combustivel: {Combustivel} || Preco por dia: {PrecoDia} || Estado: {Estado}";
           
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
