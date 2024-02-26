using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasserMotDePasseAlphaForceBrute
{
    internal class Activite5
    {
        /**
         * ACTIVITE 5
         * 
         * Générer un mot de passe constitué de **deux** lettres minuscules aléatoires
         * 
         * et essayer de le trouver par force brute avec une boucle **for** (ou **while**). 
         * */
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            // génère un code ASCII entre 97 et 122
            int codeASCIIHasard1 = rnd.Next(97, 122);
            int codeASCIIHasard2 = rnd.Next(97, 122);

            // obtient la lettre aléatoire à partir du code ASCII
            char lettreHasard1 = (char)codeASCIIHasard1;
            char lettreHasard2 = (char)codeASCIIHasard2;

            String motDePasse = "" + lettreHasard1 + lettreHasard2;

            Console.WriteLine(motDePasse);

            for (int i = 97; i < 123; i++)
            {

                char lettre1 = (char)i;
                for (int j = 97; j < 123; j++)
                {
                    char lettre2 = (char)j;
                    String mdp = "" + lettre1 + lettre2;
                    if (mdp == motDePasse)
                    {
                        Console.WriteLine("motDePasse trouvé : " + mdp);
                        break;
                    }
                }
            }

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
