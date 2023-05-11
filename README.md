# Casser un mot de passe alphabétique par force brute

- Prenez connaissance de cet extrait de la table ASCII
![1922d5a6715214bff59e42902a568d91.png](:/cd22ce35dfe34dd88b81fa478e8dbd25)

- A quoi correspond le caractère ASCII **97**?

- Ouvrez Visual Studio
- Créez une nouvelle **application console** nommée
- Testez le code suivant:
```csharp
namespace CasserMotDePasseAlphaForceBrute
{
    class Program
    {
        public static void Main(string[] args)
        {
            // caractère de code ASCII 97        
            char lettre = (char)97;
            System.Console.WriteLine(lettre);

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
```

- Qu'est ce qui s'affiche?
- Observez cet extrait plus long:
![4159ab55e76ecd9228e1db7c26a464d9.png](:/842fa590609f406798c7efb311b8937b)

- Tester maintenant le code :
```csharp
char lettre = (char)97;                  // code ASCII 97
System.Console.WriteLine(lettre); 

lettre = (char)98;                       // code ASCII 98
System.Console.WriteLine(lettre);

lettre = (char)99;				// etc.
System.Console.WriteLine(lettre); 

lettre = (char)100;
System.Console.WriteLine(lettre);

Console.Write("Press any key to continue . . . ");
Console.ReadKey(true);
```

- Qu’est-ce qui s’affiche ?

- Travail à faire :
- En vous inspirant du code précédent, **affichez toutes les lettres minuscules de l’alphabet (de a à z) grâce à une boucle for**.

- Travail à faire :
	- Générer un mot de passe constitué de une lettre minuscule aléatoire ( ! ) avec les instructions :
```csharp
Random rnd = new Random();
// génère un code ASCII entre 97 et 122
int codeASCIIHasard = rnd.Next(97,122);
// obtient la lettre aléatoire à partir du code ASCII
char lettreHasard = (char)codeASCIIHasard;
```

	- et essayer de le trouver par force brute avec une boucle **for** (ou **while**). 
	- Lorsque la lettre est trouvée, un message doit s’afficher et vous pouvez interrompre la boucle for avec l’instruction :   ` break ; ``

- Travail à faire : 
	- Générer un mot de passe aléatoire de deux lettres.

> Indication :
> pour cela, générez deux lettres au hasard lettreHasard1 et lettreHasard2 et puis écrivez :
`String motDePasse = "" + lettreHasard1 + lettreHasard2;`

	- et essayer de le trouver par force brute avec deux boucles for imbriquées. 
	Rappel : deux boucles imbriquées for s’écrivent :
```csharp
for (int i = ??? ; i < ??? ; i++)
{
	// instructions
	for (int j = ??? ; j < ??? ; j++)
	{
		// instructions 
	}
}
```

- Facultatif : faire la même chose avec un mot de passe de trois lettres.
 


