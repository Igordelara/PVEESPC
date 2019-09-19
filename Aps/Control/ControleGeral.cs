using System;
using System.Collections.Generic;
using System.Text;

namespace Pvespc.Control
{

      
    class ControleGeral
    {
   
        public void adicionarPessoa()
        {

            Pessoa a = new Pessoa();
            Console.WriteLine("ID");
            a.Cpf = Console.ReadLine();
            Pessoa p = new Pessoa();
            Console.WriteLine("Informe cpf");
            a.Cpf = Console.ReadLine();
            Console.WriteLine("informe nome: ");
            a.Nome = Console.ReadLine();
            Console.WriteLine("Informe sua idade: ");
            a.Idade = Convert.ToInt32(Console.ReadLine());
            Model.Listas.pessoaLista.Add(a);
            Console.WriteLine("Digite sua Data de Nascimento");
            a.Data = Console.ReadLine();
            Console.Write("Peso: ");
            a.Peso = float.Parse(Console.ReadLine());

        }

        public void pesquisarPorCpf()
        {
            Console.WriteLine("informe o cpf");
            string cpf = Console.ReadLine();
            Pessoa p = Model.Listas.pessoaLista.Find(x => x.Cpf.Equals(cpf));
            if (p != null)
            {
                Console.WriteLine(p.Id);
                Console.WriteLine(p.Nome);
                Console.WriteLine(p.Idade);
                Console.WriteLine(p.Cpf);
                Console.WriteLine(p.Data);
                Console.WriteLine(p.Peso);
            }
            else
            {
                Console.WriteLine("cpf nao encontrado!");
            }

        }

        public void excluirPorCpf()
        {

            Boolean r = true;
            do
            {
                Console.WriteLine("Informe o CPF que deseja realmente Excluir:");
                string cpf = Console.ReadLine();
                Pessoa p = Model.Listas.pessoaLista.Find(x => x.Cpf.Equals(cpf));

                if (p != null)
                {
                    Console.WriteLine("Deseja  realmente excluir?");
                    Console.WriteLine("1 - Sim");
                    Console.WriteLine("2 - Não");
                    string sn = Console.ReadLine();

                    switch (sn)
                    {
                        case "1":
                            Model.Listas.pessoaLista.Remove(p);
                            Console.WriteLine("Excluido com sucesso!");
                            Console.WriteLine("Voltando ao inicio");
                            r = false;
                            break;
                        case "2":
                            Console.WriteLine("Voltando ao inicio");
                            r = false;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("CPF não encontrado! Por favor, digite um CPF válido...");
                }
            } while (r);

        }
        public void alterarPorCpf()
        {
            Console.WriteLine("informe o cpf para alterar");
            string cpf = Console.ReadLine();
            Pessoa p = Model.Listas.pessoaLista.Find(x => x.Cpf.Equals(cpf));
            if (p != null)
            {
                Console.WriteLine("Digite o Novo Nome");
                p.Nome = Console.ReadLine();
                Console.WriteLine("Digite a nova Idade");
                p.Idade = Convert.ToInt32(Console.ReadLine());
                Console.Write("Peso: ");
                             
                p.Peso = float.Parse(Console.ReadLine());
               Console.WriteLine("alterado com sucesso!");

            }
            else
            {
                Console.WriteLine("cpf nao encontrado!");
            }
        }

        public void listarTodos()
        {
            foreach (Pessoa p in Model.Listas.pessoaLista)
            {
                Console.WriteLine("\n");
                Console.WriteLine(p.Id);
                Console.WriteLine(p.Cpf);
                Console.WriteLine(p.Nome);
                Console.WriteLine(p.Idade);
                Console.WriteLine(p.Data);
                Console.WriteLine(p.Peso);

            }
        }


    }
}
