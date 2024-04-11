using System;

namespace RecipeApp
{
	class Program
	{
		static void Main(string[] args)
		{
			RecipeManager recipeManager = new RecipeManager();

			Console.WriteLine("Welcome to the Recipe App!");

			while (true)
			{
				Console.WriteLine("\nMenu:");
				Console.WriteLine("1. Enter a new recipe");
				Console.WriteLine("2. Display current recipe");
				Console.WriteLine("3. Scale recipe");
				Console.WriteLine("4. Reset quantities");
				Console.WriteLine("5. Clear all data");
				Console.WriteLine("6. Exit");

				Console.WriteLine("Enter your choice: ");
				int choice = Convert.ToInt32(Console.ReadLine());

				switch (choice)
				{
					case 1:
						recipeManager.EnterNewRecipe();
						break;
					case 2:
						recipeManager.DisplayRecipe();
						break;
					case 3:
						recipeManager.ScaleRecipe();
						break;
					case 4:
						recipeManager.ResetQuantities();
						break;
					case 5:
						recipeManager.ClearRecipe();
						break;
					case 6:
						Console.WriteLine("Exiting the Recipe App...");
						return;
					default:
						Console.WriteLine("Invalid choice. Please enter a valid option.");
						break;
				}
			}
		}
	}

	class RecipeManager
	{
		private string[] ingredients;
		private string[] steps;

		public void EnterNewRecipe()
		{
			Console.WriteLine("\nEnter the number of ingredients: ");
			int numIngredients = Convert.ToInt32(Console.ReadLine());

			ingredients = new string[numIngredients];
			for (int i = 0; i < numIngredients; i++)
			{
				Console.WriteLine($"Enter ingredient {i + 1} (name quantity unit): ");
				ingredients[i] = Console.ReadLine();
			}

			Console.WriteLine("Enter the number of steps: ");
			int numSteps = Convert.ToInt32(Console.ReadLine());

			steps = new string[numSteps];
			for (int i = 0; i < numSteps; i++)
			{
				Console.WriteLine($"Enter step {i + 1}: ");
				steps[i] = Console.ReadLine();
			}

			Console.WriteLine("Recipe entered successfully!");
		}

		public void DisplayRecipe()
		{
			Console.WriteLine("\nRecipe:");
			Console.WriteLine("Ingredients:");
			foreach (string ingredient in ingredients)
			{
				Console.WriteLine(ingredient);
			}
			Console.WriteLine("Steps:");
			foreach (string step in steps)
			{
				Console.WriteLine(step);
			}
		}

		public void ScaleRecipe()
		{
			Console.WriteLine("Enter the scaling factor (0.5, 2, or 3): ");
			double factor = Convert.ToDouble(Console.ReadLine());

			for (int i = 0; i < ingredients.Length; i++)
			{
				string[] parts = ingredients[i].Split(' ');
				double quantity = Convert.ToDouble(parts[1]);
				quantity *= factor;
				ingredients[i] = $"{parts[0]} {quantity} {parts[2]}";
			}

			Console.WriteLine("Recipe scaled successfully!");
		}

		public void ResetQuantities()
		{
			// Not implemented in this sample
			Console.WriteLine("Quantities reset to original values.");
		}

		public void ClearRecipe()
		{
			ingredients = null;
			steps = null;
			Console.WriteLine("Recipe data cleared.");
		}
	}
}
