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
            int choicetemp = -1;
            book mylibrary = new book();
            usuario user = new usuario();

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
                        choicetemp = - 1 ;
                        break;
                    
                    case 2:
                        while (choicetemp != 0)
                        {
                            Console.Clear();
                            Console.WriteLine("1 - Cadastrar novo usuaruio");
                            Console.WriteLine("2 - Listar usuarios");
                            Console.WriteLine("3 - Atualizar usuario");
                            Console.WriteLine("4 - Excluir usuario");
                            Console.WriteLine("0 - sair");

                            choicetemp = Functions.verifyIfIsNumber();

                            switch (choicetemp)
                            {
                                case 1:
                                    user.addUser();
                                    break;
                                case 2:
                                    user.searchUser();
                                    break;
                                case 3:
                                    user.redoUser();
                                    break;
                                case 4:
                                    user.deleteUser();
                                    break;
                            }
                        }
                        choicetemp = -1;
                        break;
                        case 3:
                        while (choicetemp != 0)
                        {
                            Console.Clear();
                            Console.WriteLine("1 - Empresta livro");
                            Console.WriteLine("2 - Devolver livro");
                            Console.WriteLine("3 - Listar livros");
                            Console.WriteLine("0 - sair");

                            choicetemp = Functions.verifyIfIsNumber();

                            switch (choicetemp)
                            {
                                case 1:
                                    Console.WriteLine("Qual livro deseja emprestar");

                                    mylibrary.RentBook();
                                    break;
                                case 2:
                                    mylibrary.returnBook();
                                    break;
                                case 3:
                                    mylibrary.SearchBooks();
                                    break;
                            }
                        }
                        choicetemp = -1 ;
                        break;
                }
            }
        }
    }
}
