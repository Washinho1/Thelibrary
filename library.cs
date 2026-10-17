using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBookstore
{
    internal class library
    {
        static void Main(string[] args)
        {
            int choice = - 1;
            book mylibrary = new book();

            while (choice != 0)
            {
                Console.WriteLine("Digite a opçao que deseja fazer\n");
                Console.WriteLine("Opçao 1 - Gerenciar livros");
                Console.WriteLine("Opçao 2 - Gerenciar usuarios");
                Console.WriteLine("Opçao 3 - Emprestimos");
                Console.WriteLine("Opçao 4 - relatorios");
                Console.WriteLine("Opçao 0 - Sair do app");

                choice = Functions.verifyIfIsNumber();

                switch (choice)
                {
                    case 0:
                        break;

                    case 1:
                        int choicetemp = -1;

                        while (choicetemp != 0)
                        {
                            Console.Clear();
                            Console.WriteLine("1 - Cadastrar novo livro");
                            Console.WriteLine("2 - Listar livros");
                            Console.WriteLine("3 - Atualizar livro");
                            Console.WriteLine("4 - Excluir livro");
                            Console.WriteLine("0 - sair");

                            choicetemp = Functions.verifyIfIsNumber();

                            switch (choicetemp)
                            {
                                case 1:
                                    mylibrary.Newbook();
                                    break;
                                case 2:
                                    mylibrary.SearchBooks();
                                    break;
                                case 3:
                                    mylibrary.RedoBooks();
                                    break;
                                case 4:
                                    mylibrary.DeleteBooks();
                                    break;
                            }  
                        }
                        break;
                    
                    case 2:

                        break;

                }
            }
        }
    }
}
