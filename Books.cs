using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBookstore
{
    internal class Books
    {
        static void Main(string[] args)
        {
            string userInput;
            int choice = - 1;

            while (choice != 0)
            {
                Console.WriteLine("Digite a opçao que deseja fazer\n");
                Console.WriteLine("Opçao 1 - Gerenciar livros");
                Console.WriteLine("Opçao 2 - Gerenciar usuarios");
                Console.WriteLine("Opçao 3 - Emprestimos");
                Console.WriteLine("Opçao 4 - relatorios");

                choice = Functions.verifyIfIsNumber();

                switch (choice)
                {
                    case 0:
                        break;

                    case 1:
                        Console.Clear();
                        int choicetemp = -1; 

                        while (choicetemp != 0)
                        {
                            Console.WriteLine("1 - Cadastrar novo livro");
                            Console.WriteLine("2 - Listar livros");
                            Console.WriteLine("3 - Atualizar livro");
                            Console.WriteLine("4 - Excluir livro");
                            Console.WriteLine("0 - sair");

                            choicetemp = Functions.verifyIfIsNumber();

                            if (choicetemp == 2) {

                            }
                        }


                        break;


                }
            }
        }
    }
}
