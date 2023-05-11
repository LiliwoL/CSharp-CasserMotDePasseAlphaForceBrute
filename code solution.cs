// Exo 2 Casser MDP
// 1
public static void Main(string[] args)
{
    char lettre = (char)97;
    System.Console.WriteLine(lettre);


    Console.Write("Press any key to continue . . . ");
    Console.ReadKey(true);
}

//2
public static void Main(string[] args)
{
    char lettre = (char)97;
    System.Console.WriteLine(lettre);

    lettre = (char)98;
    System.Console.WriteLine(lettre);

    lettre = (char)99;
    System.Console.WriteLine(lettre);

    lettre = (char)100;
    System.Console.WriteLine(lettre);

    Console.Write("Press any key to continue . . . ");
    Console.ReadKey(true);
}

// 3
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

// 4 
public static void Main(string[] args)
{
    Random rnd = new Random();
    // g�n�re un code ASCII entre 97 et 122
    int codeASCIIHasard = rnd.Next(97, 122);
    // obtient la lettre al�atoire � partir du code ASCII
    char lettreHasard = (char)codeASCIIHasard;

    //Console.WriteLine(lettreHasard);

    for (int i = 97; i < 123; i++)
    {
        char lettre = (char)i;
        if (lettre == lettreHasard)
        {
            Console.WriteLine("lettre trouv�e : " + lettre);
            break;
        }
    }

    Console.Write("Press any key to continue . . . ");
    Console.ReadKey(true);
}

// mdp de 2 lettres
public static void Main(string[] args)
{
    Random rnd = new Random();
    // g�n�re un code ASCII entre 97 et 122
    int codeASCIIHasard1 = rnd.Next(97, 122);
    int codeASCIIHasard2 = rnd.Next(97, 122);
    // obtient la lettre al�atoire � partir du code ASCII
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
                Console.WriteLine("motDePasse trouv� : " + mdp);
                break;
            }
        }


    }

    Console.Write("Press any key to continue . . . ");
    Console.ReadKey(true);
}