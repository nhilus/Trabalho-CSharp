using System;
using System.Collections.Generic;

namespace _5412_Ficha4
{
    class Empresa
    {
        static List<Veiculo> pessoas;
        static void Main(string[] args)
        {
            veiculos = new List<Veiculo>();
            veiculos.Add(new Carro("Audi", "A1", "Carro", 1, "Cinza", "Gasóleo", 20, "Disponivel", 5, "Manual"));
            veiculos.Add(new Carro("Audi", "A1", "Carro", 1, "Preto", "Gasóleo", 20, "Disponivel", 5, "Manual"));
            veiculos.Add(new Carro("Audi", "A1", "Carro", 1, "Branco", "Gasóleo", 20, "Disponivel", 5, "Manual"));
            veiculos.Add(new Carro("BMW", "Serie1", "Carro", 1, "Cinza", "Gasóleo", 22, "Disponivel", 5, "Manual"));
            veiculos.Add(new Carro("BMW", "Serie1", "Carro", 1, "Preto", "Gasóleo", 22, "Disponivel", 5, "Manual"));
            veiculos.Add(new Carro("BMW", "Serie2", "Carro", 1, "Cinza", "Gasóleo", 24, "Disponivel", 5, "Manual"));
            veiculos.Add(new Carro("BMW", "Serie1", "Carro", 1, "Preto", "Gasóleo", 24, "Disponivel", 5, "Manual"));
            veiculos.Add(new Carro("Mazda", "CX-3", "Carro", 2, "Vermelho", "Gasóleo", 18, "Disponivel", 5, "Manual"));
            veiculos.Add(new Carro("Mazda", "CX-3", "Carro", 2, "Azul", "Gasóleo", 18, "Disponivel", 5, "Manual"));
            veiculos.Add(new Carro("Mazda", "CX-5", "Carro", 2, "Vermelho", "Gasóleo", 20, "Disponivel", 5, "Manual"));
            veiculos.Add(new Carro("Mazda", "CX-3", "Carro", 1, "Azul", "Gasóleo", 20, "Disponivel", 5, "Manual"));
            veiculos.Add(new Carro("Porche", "911", "Carro", 1, "Cinza", "Gasolina", 40, "Disponivel", 3, "Automática"));
            veiculos.Add(new Carro("Renault", "Clio", "Carro", 2, "Branco", "Gasóleo", 12, "Disponivel", 3, "Manual"));
            veiculos.Add(new Carro("Renault", "Clio", "Carro", 2, "Preto", "Gasolina", 10, "Disponivel", 5, "Manual"));
            veiculos.Add(new Carro("Renault", "Megane", "Carro", 1, "Vermelho", "Gasóleo", 16, "Disponivel", 5, "Manual"));
            veiculos.Add(new Carro("Renault", "Megane", "Carro", 1, "Azul", "Gasóleo", 16, "Disponivel", 5, "Manual"));
            veiculos.Add(new Carro("Renault", "Megane", "Carro", 1, "Preto", "Gasóleo", 16, "Disponivel", 5, "Manual"));
            veiculos.Add(new Carro("Renault", "Megane", "Carro", 1, "Cinza", "Gasóleo", 16, "Disponivel", 5, "Manual"));
            veiculos.Add(new Carro("Renault", "Zoe", "Carro", 3, "Branco", "Elétrico", 25, "Disponivel", 5, "Automática"));
            veiculos.Add(new Carro("Toyota", "CH-R", "Carro", 1, "Preto", "Híbrido", 27, "Disponivel", 5, "Automática"));
            veiculos.Add(new Carro("Toyota", "CH-R", "Carro", 1, "Cinza", "Híbrido", 27, "Disponivel", 5, "Automática"));
            veiculos.Add(new Carro("Toyota", "Prius", "Carro", 2, "Vermelho", "Híbrido", 25, "Disponivel", 5, "Automática"));
            veiculos.Add(new Carro("Toyota", "Prius", "Carro", 1, "Azul", "Híbrido", 25, "Disponivel", 5, "Automática"));
            veiculos.Add(new Carro("Toyota", "Corolla", "Carro", 1, "Preto", "Gasolina", 15, "Disponivel", 5, "Manual"));
            veiculos.Add(new Carro("Seat", "Leon", "Carro", 2, "Preto", "Gasóleo", 17, "Disponivel", 3, "Manual"));
            veiculos.Add(new Mota("Honda", "CBR", "Mota", 2, "Amarelo", "Gasolina", 10, "Disponivel", 125));
            veiculos.Add(new Mota("Kawasaki", "ZXR", "Mota", 2, "Vermelho", "Gasolina", 10, "Disponivel", 300));
            veiculos.Add(new Camioneta("Irizar", "PB", "Camioneta", 1, "Preto", "Gasóleo", 100, "Disponivel", 3, 150));
            veiculos.Add(new Camiao("MAN", null, "Camião", 1, "Preto", "Gasóleo", 120, "Disponivel", 2000));
            veiculos.Add(new Camiao("Mercedes", null, "Camião", 1, "Preto", "Gasóleo", 180, "Disponivel", 2500));
            veiculos.Add(new Camiao("Scania", null, "Camião", 1, "Preto", "Gasóleo", 160, "Disponivel", 1750));


            int op = 1;
            while (op != 0)
            {
                Console.Clear();
                Console.WriteLine("1-Inserir elemento");
                Console.WriteLine("2-Idade média");
                Console.WriteLine("3-Listar alunos");
                Console.WriteLine("4-Alterar Curso");
                Console.WriteLine("5-Listar todos");
                Console.WriteLine("0-Sair");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 0: break;
                    case 1: InsElem(); break;
                    case 2: IdadeMed(); break;
                    case 3: ListarAlunos(); break;
                    case 4: AlterCurso(); break;
                    case 5: ListarTodos(); break;
                    default: Console.WriteLine("Opção inválida"); Console.ReadKey(); break;
                }
            }

        }

        private static void ListarTodos()
        {
            Console.Clear();
            Console.WriteLine("------------ Listagem de pessoas  ------------ ");
            for (int i = 0; i < pessoas.Count; i++)
            {
                Console.WriteLine(pessoas[i].ToString());
            }
            Console.ReadKey();
        }

        private static void AlterCurso()
        {
            Console.Clear();

            Console.WriteLine("Qual o número mínimo do aluno a modificar");
            int min = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o número máximo do aluno a modificar");
            int max = int.Parse(Console.ReadLine());

            for (int i = 0; i < pessoas.Count; i++)
            {
                if (typeof(Aluno) == pessoas[i].GetType())
                {
                    if (((Aluno)pessoas[i]).Numero >= min && ((Aluno)pessoas[i]).Numero <= max)
                    {
                        Console.WriteLine("O curso atual do aluno é: " + ((Aluno)pessoas[i]).Curso + "\nQual o novo curso?");
                        ((Aluno)pessoas[i]).Curso = Console.ReadLine();
                        Console.WriteLine("Curso alterado com sucesso");
                    }
                }
            }
            Console.ReadKey();
        }

        private static void ListarAlunos()
        {
            Console.Clear();
            Console.WriteLine("------------ Listagem de alunos  ------------ ");
            for (int i = 0; i < pessoas.Count; i++)
            {
                if (typeof(Aluno) == pessoas[i].GetType())
                    Console.WriteLine(pessoas[i].ToString());
            }
            Console.ReadKey();
        }

        private static void IdadeMed()
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
        }

        private static void InsElem()
        {
            Console.Clear();

            Console.WriteLine("Pretende inserir um \n1-Professor\n2-Aluno");
            int op = int.Parse(Console.ReadLine());

            if (op < 1 || op > 2)
            {
                Console.WriteLine("Opção inválida");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Qual o nome");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual a data de nascimento (aaaa/mm/dd)");
            DateTime dn = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Qual a altura?");
            double altura = double.Parse(Console.ReadLine());

            if (op == 1)
            {
                Console.WriteLine("Qual a área");
                string area = Console.ReadLine();

                pessoas.Add(new Professor(nome, dn, altura, area));
                Console.WriteLine("Professor adicionado com sucesso");
            }
            else
            {
                Console.WriteLine("Qual o número");
                int numero = int.Parse(Console.ReadLine());

                Console.WriteLine("Qual o curso");
                string curso = Console.ReadLine();

                pessoas.Add(new Aluno(nome, dn, altura, numero, curso));
                Console.WriteLine("Aluno adicionado com sucesso");
            }

            Console.ReadKey();
        }
    }
}
