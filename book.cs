using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBookstore
{
    internal class book
    {
        private Dictionary<string, string> books = new Dictionary<string, string>
        {
            { "dom casmurro", "sei la" },
            { "a que pena sereia", "Disney" },
            { "harry potter e a pedra", "lord voldermot" }

        };

        public void Newbook() {
            Console.WriteLine("Digite o nome do livro");
            string book = Console.ReadLine();
            Console.WriteLine("\nDigite o nome do autor");
            string autor = Console.ReadLine();
            books.Add(book.ToLower(), autor.ToLower());

            Console.WriteLine("Livro adicionado, aperte qualquer coisa pra sair");
            Console.ReadKey();
        }

        public void SearchBooks (){
            foreach (var booklist in books) {
                Console.WriteLine($" O livro {booklist.Key} do autor {booklist.Value}.\n");
            }
            Console.WriteLine("Aperte qualquer coisa para sair");
            Console.ReadKey();
        }

        public void RedoBooks()
        {
            Console.WriteLine("Qual o nome do livro que deseja editar");
            string bookname = Console.ReadLine();
            if (books.ContainsKey(bookname))
            {
                books.Remove(bookname);
                Console.WriteLine("Digite o nome correto do livro");
                string newbook = Console.ReadLine();
                Console.WriteLine("Digite o nome correto do autor");
                string newautor = Console.ReadLine();

                books.Add(newbook.ToLower(), newautor.ToLower());
            }else
            {
                Console.WriteLine("Livro nao existe pressione algo para voltar ao menu");
                Console.ReadKey();
            }
        }

        public void DeleteBooks() {
            Console.WriteLine("Digite o nome do livro que deseja excluir");
            string book = Console.ReadLine();
            books.Remove(book.ToLower());
        }



       
    }
}
