using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBookstore
{
    internal class book
    {
        private Dictionary<string, string> booksfree = new Dictionary<string, string>
        {
            { "dom casmurro", "sei la" },
            { "a que pena sereia", "Disney" },
            { "harry potter e a pedra", "lord voldermot" }

        };

        private Dictionary<string, string> booksrented = new Dictionary<string, string>
        {

        };

        public void Newbook() {
            Console.WriteLine("Digite o nome do livro");
            string book = Console.ReadLine();
            Console.WriteLine("\nDigite o nome do autor");
            string autor = Console.ReadLine();
            booksfree.Add(book.ToLower(), autor.ToLower());

            Console.WriteLine("Livro adicionado, aperte qualquer coisa pra sair");
            Console.ReadKey();
        }

        public void SearchBooks() {
            Console.WriteLine("Livros disponiveis :\n");

            foreach (var booklist in booksfree) {
                Console.WriteLine($" O livro {booklist.Key} do autor {booklist.Value}.\n");
            }

            Console.WriteLine("\nLista de livros emprestado :\n");

            foreach (var book in booksrented) {
                Console.WriteLine($" o livro {book.Key} esta emprestado para {book.Value} \n");
            }
            Console.WriteLine("Aperte qualquer coisa para sair");
            Console.ReadKey();
        }

        public void RedoBooks()
        {
            Console.WriteLine("Qual o nome do livro que deseja editar");
            string bookname = Console.ReadLine();
            if (booksfree.ContainsKey(bookname))
            {
                booksfree.Remove(bookname);
                Console.WriteLine("Digite o nome correto do livro");
                string newbook = Console.ReadLine();
                Console.WriteLine("Digite o nome correto do autor");
                string newautor = Console.ReadLine();

                booksfree.Add(newbook.ToLower(), newautor.ToLower());
            } else
            {
                Console.WriteLine("Livro nao existe pressione algo para voltar ao menu");
                Console.ReadKey();
            }
        }

        public void DeleteBooks() {
            Console.WriteLine("Digite o nome do livro que deseja excluir");
            string book = Console.ReadLine();
            booksfree.Remove(book.ToLower());
        }

        public void RentBook() {
        
           string bookname = Console.ReadLine();
            if (booksfree.ContainsKey(bookname))
            {
                Console.WriteLine("Qual o nome da pessoa que deseja emprestar o livro");
                string username = Console.ReadLine();

                booksfree.Remove(bookname.ToLower());
                booksrented.Add(bookname.ToLower(), username.ToLower());
            }
            else
            {
                Console.WriteLine("O livro nao existe ou nao esta disponivel");
                Console.ReadKey();
            }
        }

        public void returnBook()
        {
            Console.WriteLine("Digite o nome do livro que deseja devolver");
            string bookname = Console.ReadLine();
            if (booksrented.ContainsKey(bookname))
            {
                Console.WriteLine("Digite o nome do autor desse livro");
                string autor = Console.ReadLine();
                booksrented.Remove(bookname);
                booksfree.Add(bookname.ToLower(), autor.ToLower());
            }
            else
            {
                Console.WriteLine("O livro nao existe ou nao esta emprestado");
                Console.ReadKey();
            }

        }


       
    }
}
