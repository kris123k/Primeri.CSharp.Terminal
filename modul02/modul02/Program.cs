using System;

namespace modul02
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			//definirane na promenlivi
			int a = 0, b = 0; 
			int sum = 0;	


			//subirane na chisla
			a = 3; b = 7; 
			sum = a + b;

		


			//pisane v konzolata
			Console.Write (a);
			Console.Write ("+");
			Console.Write (b);
			Console.Write ("=");
			Console.WriteLine (sum);

			// dopulnitelni operatori

			Console.WriteLine ("\n izpolzvane na +=");
			a += b; 
			Console.WriteLine (a);

			Console.WriteLine ("\n izpolzvane na -=");
			a -= b; 
			Console.WriteLine (a);

			Console.WriteLine ("\n izpolzvane na *=");
			a *= b; 
			Console.WriteLine (a);

			Console.WriteLine ("\n izpolzvane na ++");
			a ++; 
			Console.WriteLine (a);

			Console.WriteLine ("standartno delene " + (7/3).ToString ()); //otgovor 2 7/3 = 2.3333333
			Console.WriteLine ("ostatuk delene " + (7%3).ToString ()); // orgovor 1 1/3 = 0.3333 

		}
	}
}
