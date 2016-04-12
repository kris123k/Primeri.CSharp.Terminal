using System;

namespace readfromcommandline
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// definirane na promenlivi
			int a = 5, b = 0;

			// vuvejdane na parametri
			Console.Write ("vuvedete b: ");
			b = Convert.ToInt32 (Console.ReadLine ());

			// pechat na rezultat
			Console.WriteLine ("rezultata a+b e: " + (a + b).ToString () + "\n\n\n");


		}
	}
}
