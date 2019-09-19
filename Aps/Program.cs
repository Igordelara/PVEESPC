using System;

namespace Pvespc
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Control.ControleGeral c = new Control.ControleGeral();
            do
            {
                Console.WriteLine("Temos cadastros = : {0}", Model.Listas.pessoaLista.Count);

                Console.WriteLine("1 - Incluir \n" +
                    "2 - Pesquisar por cpf\n" +
                    "3 - Editar por id\n" +
                    "4 - Excluir\n" +
                    "5 - Listar todos\n" +
                    "0 - Sair\n");
                a = Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        c.adicionarPessoa();
                        break;
                    case 2:
                        c.pesquisarPorCpf();
                        break;
                    case 3:
                        c.alterarPorCpf();
                        break;
                    case 4:
                        c.excluirPorCpf();
                        break;
                    case 5:
                        c.listarTodos();
                        break;


                    default:
                        Console.WriteLine($" Deseja Realmente Sair  -  S  ({a})");

                       
                        
                        break;
                }


            } while (a != 0);

        }
    }
}
