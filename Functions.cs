using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBookstore
{
    internal class Functions
    {
        public static int verifyIfIsNumber()
        {
            int choice;

            while (!int.TryParse(Console.ReadLine(),out choice))
            {
                Console.WriteLine("Digite apenas numeros validos");
            }
            Console.Clear();
            return choice ;
        }
    }
}
