using System;
using System.Collections.Generic;

namespace CSHARP_Listes_Exo3
{
    class Program
    {
        static void Main(string[] args)
        {
            //création de la variable pour stocker le résultat sous la forme d'un entier
            int result = 0;
            
            //création de la liste "numbers"
            List<int> numbers = new List<int>();
            numbers.Add(42);
            numbers.Add(69);
            numbers.Add(118);
            numbers.Add(666);
            numbers.Add(1789);

            //pour chaque valeur du tableau, faire le cumul 
            foreach(int value in numbers)
            {
                Console.WriteLine($"\n{result} + {value} =");
                result += value;
                Console.WriteLine(result);
            }

            //afficher le résultat du cumul de tous les nombres de la liste
            Console.WriteLine("\nle résultat final est : " + result);

        }
    }
}
/*
Créer une liste numbers et la remplir de nombres au choix.
À l’aide d’une boucle, calculer la somme de tous les nombres de la liste.
Afficher le résultat dans une phrase.
Bonus : rappelez tous les nombres dans le calcul.*/