using System;
using trestleBridge.Interfaces;
using trestleBridge.Models.Facilities;

namespace trestleBridge.Actions
{
	public class ChooseChickenHouse
	{
		public ChooseChickenHouse(Farm farm, IFeeding animal)
		{
            // Console.Clear();
            for (int i = 0; i < farm.ChickenHouse.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Chicken House");
            }
            Console.WriteLine();
            // How can I output the type of animal chosen here?
            Console.WriteLine($"Place {animal.Type.ToLower()} where?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());

            farm.ChickenHouse[choice].AddResource(animal);

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);
        }
    }
}

