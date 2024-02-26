# Casser un mot de passe alphabétique par force brute

![6117a9d7d787bcfc2fe97d3854e0df9e.png](:/02f9f47952464a98a3c21757121ce8ae)

[toc]


v0.2

---
# Compétence

B3.3. Sécurisation des équipements et des usages des utilisateurs

---
# Source

Mathieu Frétière
www.lookuptables.com

---
# GitHub

https://github.com/LiliwoL/CSharp-CasserMotDePasseAlphaForceBrute
# 
***

# Casser un mot de passe alphabétique par force brute

> Pré requis : Visual Studio code doit être installé sur la machine.

# 
# Travail à faire

- Rapport de TP en répondant aux questions posées.
- Dépôt GitHub contenant les sources de votre programme.

---
# Activité 0: Création du programme

- Ouvrez Visual Studio
- Créez une nouvelle **application console** nommée **CasserMotDePasseAlphaForceBrute**

---
# Activité 1: Table ASCII

- Prenez connaissance de cet extrait de la table ASCII
![1922d5a6715214bff59e42902a568d91.png](:/cd22ce35dfe34dd88b81fa478e8dbd25)

> A quoi correspond le caractère ASCII **97**?

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

> Qu'est ce qui s'affiche?

---

# Activité 2: Création d'un mot de passe

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

> Qu’est-ce qui s’affiche ?

---
# Activité 3: Afficher toutes les lettres minuscules

> En vous inspirant du code précédent, **affichez toutes les lettres minuscules de l’alphabet (de a à z) grâce à une boucle for**.

---
# Activité 4: Générer un mot de passe d'une lettre et la retrouver

Générer un mot de passe constitué de **une** lettre minuscule aléatoire avec les instructions :
```csharp
Random rnd = new Random();
// génère un code ASCII entre 97 et 122
int codeASCIIHasard = rnd.Next(97,122);
// obtient la lettre aléatoire à partir du code ASCII
char lettreHasard = (char)codeASCIIHasard;
```
et essayer de le trouver par force brute avec une boucle **for** (ou **while**). 


> Lorsque la lettre est trouvée, un message doit s’afficher et vous pouvez interrompre la boucle for avec l’instruction :   ` break ; `

---

# Activité 5: Idem que précédemment mais avec 2 lettres

A partir du code précédent, générer un mot de passe aléatoire de 2 lettres.

> **Indication :**
> pour cela, générez deux lettres au hasard lettreHasard1 et lettreHasard2 et puis écrivez :
`String motDePasse = "" + lettreHasard1 + lettreHasard2;`

et essayer de le trouver par **force brute** avec deux boucles for imbriquées. 
	
> Rappel : deux boucles imbriquées for s’écrivent :
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

---
# Activité facultative

- Faire la même chose avec un mot de passe de trois lettres.
- Afficher le temps passé pour trouver les bonnes lettres.
