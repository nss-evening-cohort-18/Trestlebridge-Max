using System;
using trestleBridge.Interfaces;
using trestleBridge.Models.Facilities;

namespace trestleBridge.Actions
{
	public class ChooseDuckHouse
	{
		public static void CollectInput(Farm farm, IResource animal)
        {
                Console.Clear();
                for (int i = 0; i < farm.DuckHouses.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. Duck House");
                }
                Console.WriteLine();
                
                Console.WriteLine($"Place {animal.Type.ToLower()} where?");

                Console.Write("> ");
                int choice = Int32.Parse(Console.ReadLine());

                farm.DuckHouses[choice - 1].AddResource(animal);
            
        }  
    }
}

