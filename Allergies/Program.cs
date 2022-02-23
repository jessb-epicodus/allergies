using System;
using System.Collections.Generic;

class Program
{
  public static void main()
  {
    Allergen eggs = new Allergen("eggs", 1);
    Allergen peanuts = new Allergen("peanuts", 2);
    Allergen shellfish = new Allergen("shellfish", 4);
    Allergen strawberries = new Allergen("strawberries", 8);
    Allergen tomatoes = new Allergen("eggs", 16);
    Allergen chocolate = new Allergen("chocolate", 32);
    Allergen pollen = new Allergen("pollen", 64);
    Allergen cats = new Allergen("cats", 128);

    List<Allergen> Allergens = new List<Allergen>() {eggs, peanuts, shellfish, strawberries, tomatoes, chocolate, pollen, cats};

    Console.WriteLine("Enter your allergen score: ");
    string stringAScore = Console.ReadLine();
    int intAScore = int.Parse(stringAScore);

    List<Allergen> AllergensInSearch = new List<Allergen>(0);

    foreach (Allergen element in Allergens)
    {
      if (element.IncludedAllergens(intAScore));
      {
        AllergensInSearch.Add(element);
      }
    }
    foreach(Allergen element in AllergensInSearch)
    {
      Console.WriteLine("Allergens include: " + element.GetAllergenName());
    }
  }
}