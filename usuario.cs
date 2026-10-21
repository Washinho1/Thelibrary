using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBookstore
{
    internal class usuario
    {
        private Dictionary<string, string> usuarios = new Dictionary<string, string>()
        {
            { "joao carlos" , "00011122298" }
        };

        public void addUser()
        {
            Console.WriteLine("fale o nome da pessoa que deseja adicionar :");
            string name = Console.ReadLine();

            Console.WriteLine("agora digite o cpf :");
            string cpf = Console.ReadLine();

            usuarios.Add(name.ToLower(), cpf.ToLower());
        }

        public void redoUser()
        {
            Console.WriteLine("Qual o nome do livro que deseja editar");
            string bookname = Console.ReadLine();
            if (usuarios.ContainsKey(bookname))
            {
                usuarios.Remove(bookname);
                Console.WriteLine("Digite o nome correto");
                string newbook = Console.ReadLine();
                Console.WriteLine("Digite o cpf correto do usuario");
                string newautor = Console.ReadLine();

                usuarios.Add(newbook.ToLower(), newautor.ToLower());
            }
            else
            {
                Console.WriteLine("usuario nao existe pressione algo para voltar ao menu");
                Console.ReadKey();
            }
        }

        public void searchUser()
        {
            foreach (var item in usuarios)
            {
                Console.WriteLine($"Usuario {item.Key} com o cpf de {item.Value}\n");
            }

            Console.WriteLine("Aperte qualquer coisa para sair");
            Console.ReadKey();
        }

        public void deleteUser()
        {
            {
                Console.WriteLine("Digite o nome do usuario que deseja deletar");
                string userName = Console.ReadLine();
                
                usuarios.Remove(userName);
            }
        }
    }
}
