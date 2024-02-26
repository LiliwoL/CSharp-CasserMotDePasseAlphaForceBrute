using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasserMotDePasseAlphaForceBrute
{
    internal class Activite4
    {
        /**
         * ACTIVITE 4
         * 
         * Générer un mot de passe constitué de **une** lettre minuscule aléatoire 
         * 
         * et essayer de le trouver par force brute avec une boucle **for** (ou **while**). 
         * */
        public static void init()
        {
            Random rnd = new Random();
            // génère un code ASCII entre 97 et 122
            int codeASCIIHasard = rnd.Next(97, 122);
            // obtient la lettre aléatoire à partir du code ASCII
            char lettreHasard = (char)codeASCIIHasard;

            //Console.WriteLine(lettreHasard);

            for (int i = 97; i < 123; i++)
            {
                char lettre = (char)i;
                if (lettre == lettreHasard)
                {
                    Console.WriteLine("lettre trouvée : " + lettre);
                    break;
                }
            }

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
