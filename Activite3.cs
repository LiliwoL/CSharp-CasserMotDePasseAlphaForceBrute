using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasserMotDePasseAlphaForceBrute
{
    internal class Activite3
    {
        /**
         * ACTIVITE 3
         * 
         * affichez toutes les lettres minuscules de l’alphabet (de a à z) grâce à une boucle for
         * */
        public static void Main(string[] args)
        {
            for (int i = 97; i < 123; i++)
            {
                char lettre = (char)i;
                Console.WriteLine(lettre);
            }

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
