using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_Prático;


namespace _5412_Ficha4
{
    class Empresa
    {
        static List<Veiculo> veiculos;
        static void Main(string[] args)
        {
            veiculos = new List<Veiculo>();
            veiculos.Add(new Carro("Audi A1", "Carro", 1, "Cinza", "Gasóleo", 20, "Disponivel", 5, "Manual"));
            veiculos.Add(new Carro("Audi A1", "Carro", 1, "Preto", "Gasóleo", 20, "Disponivel", 5, "Manual"));
            veiculos.Add(new Carro("Audi A1", "Carro", 1, "Branco", "Gasóleo", 20, "Disponivel", 5, "Manual"));
            veiculos.Add(new Carro("BMW Serie1",  "Carro", 1, "Cinza", "Gasóleo", 22, "Disponivel", 5, "Manual"));
            veiculos.Add(new Carro("BMW Serie1",  "Carro", 1, "Preto", "Gasóleo", 22, "Disponivel", 5, "Manual"));
            veiculos.Add(new Carro("BMW Serie2",  "Carro", 1, "Cinza", "Gasóleo", 24, "Disponivel", 5, "Manual"));
            veiculos.Add(new Carro("BMW Serie1",  "Carro", 1, "Preto", "Gasóleo", 24, "Disponivel", 5, "Manual"));
            veiculos.Add(new Carro("Mazda CX-3",  "Carro", 1, "Vermelho", "Gasóleo", 18, "Disponivel", 5, "Manual"));
            veiculos.Add(new Carro("Mazda CX-3",  "Carro", 1, "Azul", "Gasóleo", 18, "Disponivel", 5, "Manual"));
            veiculos.Add(new Carro("Mazda CX-3",  "Carro", 1, "Vermelho", "Gasóleo", 20, "Disponivel", 5, "Manual"));
            veiculos.Add(new Carro("Mazda CX-3",  "Carro", 1, "Azul", "Gasóleo", 20, "Disponivel", 5, "Manual"));
            veiculos.Add(new Carro("Porche 911",  "Carro", 1, "Cinza", "Gasolina", 40, "Disponivel", 3, "Automática"));
            veiculos.Add(new Carro("Renault Clio", "Carro", 1, "Branco", "Gasóleo", 12, "Disponivel", 3, "Manual"));
            veiculos.Add(new Carro("Renault Clio",  "Carro", 1, "Preto", "Gasolina", 10, "Disponivel", 5, "Manual"));
            veiculos.Add(new Carro("Renault Megane",  "Carro", 1, "Vermelho", "Gasóleo", 16, "Disponivel", 5, "Manual"));
            veiculos.Add(new Carro("Renault Megane",  "Carro", 1, "Azul", "Gasóleo", 16, "Disponivel", 5, "Manual"));
            veiculos.Add(new Carro("Renault Megane",  "Carro", 1, "Preto", "Gasóleo", 16, "Disponivel", 5, "Manual"));
            veiculos.Add(new Carro("Renault Megane",  "Carro", 1, "Cinza", "Gasóleo", 16, "Disponivel", 5, "Manual"));
            veiculos.Add(new Carro("Renault Zoe", "Carro", 1, "Branco", "Elétrico", 25, "Disponivel", 5, "Automática"));
            veiculos.Add(new Carro("Toyota CH-R", "Carro", 1, "Preto", "Híbrido", 27, "Disponivel", 5, "Automática"));
            veiculos.Add(new Carro("Toyota CH-R", "Carro", 1, "Cinza", "Híbrido", 27, "Disponivel", 5, "Automática"));
            veiculos.Add(new Carro("Toyota Prius", "Carro", 1, "Vermelho", "Híbrido", 25, "Disponivel", 5, "Automática"));
            veiculos.Add(new Carro("Toyota Prius", "Carro", 1, "Azul", "Híbrido", 25, "Disponivel", 5, "Automática"));
            veiculos.Add(new Carro("Toyota Corolla", "Carro", 1, "Preto", "Gasolina", 15, "Disponivel", 5, "Manual"));
            veiculos.Add(new Carro("Seat Leon", "Carro", 1, "Preto", "Gasóleo", 17, "Disponivel", 3, "Manual"));
            veiculos.Add(new Mota("Honda CBR",  "Mota", 1, "Amarelo", "Gasolina", 10, "Disponivel", 125));
            veiculos.Add(new Mota("Kawasaki ZXR", "Mota", 2, "Vermelho", "Gasolina", 10, "Disponivel", 300));
            veiculos.Add(new Camioneta("Irizar PB", "Camioneta", 1, "Preto", "Gasóleo", 100, "Disponivel", 3, 150));
            veiculos.Add(new Camiao("MAN", "Camião", 1, "Preto", "Gasóleo", 120, "Disponivel", 2000));
            veiculos.Add(new Camiao("Mercedes","Camião", 1, "Preto", "Gasóleo", 180, "Disponivel", 2500));
            veiculos.Add(new Camiao("Scania", "Camião", 1, "Preto", "Gasóleo", 160, "Disponivel", 1750));


            int op = 1;
            while (op != 0)
            {
                Console.Clear();
                Console.WriteLine("1-Inserir novo veiculo");
                Console.WriteLine("2-Alterar estado do veículo");
                Console.WriteLine("3-Lista veiculos disponiveis para aluguer");
                Console.WriteLine("4-Veiculos em manutenção");
                Console.WriteLine("5-Listar todos os veículos");
                Console.WriteLine("6-Calcular preço reserva");
                Console.WriteLine("7-Exportar data");
                Console.WriteLine("0-Sair");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 0: break;
                    case 1: InsVeiculo(); break;
                    case 2: AlterarEstadoVeiculo(); break;
                    case 3: ListaVeiculosAluguer(); break;
                    case 4: VeiculosEmManutencao(); break;
                    case 5: ListaVeiculos(); break;
                    case 6: CalcularPrecoReserva(); break;
                    case 7: ExportarData(); break;
                    default: Console.WriteLine("Opção inválida"); Console.ReadKey(); break;
                }
            }

        }

        private static void CalcularPrecoReserva()
        {
            throw new NotImplementedException();

            //validações: if date.now>reservationEndDate: veiculo.estado= Disponivel
            //variaveis: date.now, reservationDate, reservationEndDate, precoDia, precoFinal, 
            //
















        }

        private static void ExportarData()
        {
            throw new NotImplementedException();
        }


        private  static void LerLista()
        {

        }

        private static void ListaVeiculos()
        {
            Console.Clear();
            Console.WriteLine("------------ Listagem de Veículos  ------------ ");
            for (int i = 0; i < veiculos.Count; i++)
            {
                Console.WriteLine((i+1) + veiculos[i].ToString());
            }
            Console.ReadKey();
        }

        private static void AlterarEstadoVeiculo()
        {
            Console.Clear();

            ListaVeiculos();

            Console.WriteLine("Qual o veículo a modificar?");
            int selecao = int.Parse(Console.ReadLine());


            Console.WriteLine($"O estado atual do veículo é: {veiculos[i].Estado}\nQual o novo estado?");
            veiculos[selecao-1].Estado = Console.ReadLine();
            Console.WriteLine("Estado do veículo alterado com sucesso");
           
            Console.ReadKey();
        }

        private static void ListarCarros()
        {
            Console.Clear();
            Console.WriteLine("------------ Listagem de carros  ------------ ");
            for (int i = 0; i < veiculos.Count; i++)
            {
                if (typeof(Carro) == veiculos[i].GetType())
                    Console.WriteLine(veiculos[i].ToString());
            }
            Console.ReadKey();
        }

        private static void ListarMotas()
        {
            Console.Clear();
            Console.WriteLine("------------ Listagem de motas  ------------ ");
            for (int i = 0; i < veiculos.Count; i++)
            {
                if (typeof(Mota) == veiculos[i].GetType())
                    Console.WriteLine(veiculos[i].ToString());
            }
            Console.ReadKey();
        }

        private static void ListarCamioes()
        {
            Console.Clear();
            Console.WriteLine("------------ Listagem de camiões  ------------ ");
            for (int i = 0; i < veiculos.Count; i++)
            {
                if (typeof(Camiao) == veiculos[i].GetType())
                    Console.WriteLine(veiculos[i].ToString());
            }
            Console.ReadKey();
        }

        private static void ListarCamionetas()
        {
            Console.Clear();
            Console.WriteLine("------------ Listagem de camionetas  ------------ ");
            for (int i = 0; i < veiculos.Count; i++)
            {
                if (typeof(Camioneta) == veiculos[i].GetType())
                    Console.WriteLine(veiculos[i].ToString());
            }
            Console.ReadKey();
        }

        private static void ListaVeiculosAluguer()
        {
            Console.Clear();
            Console.WriteLine("------------ Listagem de Veiculos para Aluguer  ------------ ");

            ListaVeiculos();

            int op = 1;
            while (op != 0)
            {
                Console.WriteLine("Selecione o tipo de viatura:");
                Console.WriteLine("1-Carros");
                Console.WriteLine("2-Motas");
                Console.WriteLine("3-Camiões");
                Console.WriteLine("4-Camionetas");
                Console.WriteLine("0-Sair");

                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 0: break;
                    case 1: ListarCarros(); break;
                    case 2: ListarMotas(); break;
                    case 3: ListarCamioes(); break;
                    case 4: ListarCamionetas(); break;
                    default: Console.WriteLine("Opção inválida"); Console.ReadKey(); break;
                }


                for (int i = 0; i < veiculos.Count; i++)
                {
                    if (veiculos[i].Estado == "Disponivel")
                        Console.WriteLine(veiculos[i].ToString());
                }
                Console.ReadKey();
            }
        }

        private static void VeiculosEmManutencao()
        {
            Console.Clear();
            Console.WriteLine("------------ Listagem de Veiculos em Manutenção  ------------ ");
            for (int i = 0; i < veiculos.Count; i++)
            {
                if (veiculos[i].Estado == "Manutenção")
                    Console.WriteLine(veiculos[i].ToString());
            }
            Console.ReadKey();
        }

        private static void VeiculosAlugados()
        {
            Console.Clear();
            Console.WriteLine("------------ Listagem de Veiculos Alugados  ------------ ");
            for (int i = 0; i < veiculos.Count; i++)
            {
                if (veiculos[i].Estado == "Alugado")
                    Console.WriteLine(veiculos[i].ToString());
            }
            Console.ReadKey();
        }

        private static void VeiculosReservados()
        {
            Console.Clear();
            Console.WriteLine("------------ Listagem de Veiculos Reservados  ------------ ");
            for (int i = 0; i < veiculos.Count; i++)
            {
                if (veiculos[i].Estado == "Reservado")
                    Console.WriteLine(veiculos[i].ToString());
            }
            Console.ReadKey();
        }





        /* private static void IdadeMed()
         {
             Console.Clear();
             double somaAlunos = 0, somaProfessores = 0, contAlunos = 0, contProfessores = 0;

             for (int i = 0; i < pessoas.Count; i++)
             {
                 if (typeof(Aluno) == pessoas[i].GetType())
                 {
                     somaAlunos += DateTime.Now.Year - pessoas[i].DN.Year;
                     contAlunos++;
                 }
                 else if (typeof(Professor) == pessoas[i].GetType())
                 {
                     somaProfessores += DateTime.Now.Year - pessoas[i].DN.Year;
                     contProfessores++;
                 }
             }

             if (contAlunos > 0)
                 Console.WriteLine("A média de idade dos alunos é: " + (somaAlunos / contAlunos));
             else
                 Console.WriteLine("Não existem alunos para a média");


             if (contProfessores > 0)
                 Console.WriteLine("A média de idade dos professores é: " + (somaProfessores / contProfessores));
             else
                 Console.WriteLine("Não existem professores para a média");


             Console.ReadKey();
         }*/

        private static void InsVeiculo()
        {
            Console.Clear();

            Console.WriteLine("Pretende inserir que tipo de veículo?\n 1-Carro\n2-Mota\n3-Camião\n4-Camioneta ");
            int op = int.Parse(Console.ReadLine());

            if (op < 1 || op > 4)
            {
                Console.WriteLine("Opção inválida");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Qual a marca e modelo:");
            string marcaModelo = Console.ReadLine();

            Console.WriteLine("Tipo de viatura:");
            string tipo = Console.ReadLine();

            Console.WriteLine("Quantidade:");
            int quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual a cor?");
            string cor = Console.ReadLine();

            Console.WriteLine("Qual o tipo de combustivel:");
            string combustivel = Console.ReadLine();

            Console.WriteLine("Preço por dia:");
            int precoDia = int.Parse(Console.ReadLine());

            Console.WriteLine("O carro encontra-se disponivel ou em manutenção?");
            string estado = Console.ReadLine();


            if (op == 1)
            {
                Console.WriteLine("Numero de portas do carro: ");
                int numeroPortas = int.Parse(Console.ReadLine());

                Console.WriteLine("Tipo de caixa que o carro tem: ");
                string tipoCaixa = Console.ReadLine();

                veiculos.Add(new Carro(marcaModelo, tipo, quantidade, cor, combustivel, precoDia, estado, numeroPortas, tipoCaixa));
                Console.WriteLine("Carro adicionado com sucesso");


            }
            else if (op == 2)
            {
                Console.WriteLine("Cilindrada: ");
                int cilindrada = int.Parse(Console.ReadLine());

                veiculos.Add(new Mota(marcaModelo, tipo, quantidade, cor, combustivel, precoDia, estado, cilindrada));
                Console.WriteLine("Mota adicionada com sucesso");
            }else if (op == 3)
            {
                Console.WriteLine("Numero de eixos da camioneta : ");
                int numeroEixos = int.Parse(Console.ReadLine());

                Console.WriteLine("Numero máximo de passageiros: ");
                int numeroPassageiros = int.Parse(Console.ReadLine());

                veiculos.Add(new Camioneta(marcaModelo, tipo, quantidade, cor, combustivel, precoDia, estado, numeroEixos, numeroPassageiros));
                Console.WriteLine("Camioneta adicionada com sucesso");
            }else
            {
                Console.WriteLine("Peso máximo suportado:");
                int pesoMaximo = int.Parse(Console.ReadLine());

                veiculos.Add(new Camiao(marcaModelo, tipo, quantidade, cor, combustivel, precoDia, estado, pesoMaximo));
                Console.WriteLine("Camião adicionado com sucesso");
            }

            Console.ReadKey();
        }
    }
}
