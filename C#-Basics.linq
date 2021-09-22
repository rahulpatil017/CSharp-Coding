<Query Kind="Program" />

namespace Foo    // Namespace is optional
{
	class Program
	{
		static void Main()    // Main method can be static or instance
		{
			Console.WriteLine ("Hello, world");
			
			Console.WriteLine(1_000_000_0000); //Representation of the large Numbers
			
			int a = 0;				   //Increament and Decrement Operators
			Console.WriteLine (a++);   // Outputs 0; a is now 1 
			Console.WriteLine (++a);   // Outputs 2; a is now 2
			Console.WriteLine (--a);   // Outputs 1; a is now 1
			
			float b = 1.3F;		//Float has F literal
			decimal c = 1.4M;	//Decimal has M Literal
			double d = 1.4;		//No Literals
			
			checked				// Check Airthmatic Overflow 
			{
				Console.WriteLine(10 * 10);
			}
			
			unchecked		   // Disable Airthmatic Overflow 
			{
				Console.WriteLine(50000000 * 500000000);			
			}
			
			Console.WriteLine( 3 > 5 ? "Ok" : "Not Ok"); 	//Ternary Operators
			
			
			char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' }; //Indices and Ranges
			
			Console.WriteLine("Last Element in vowels " + vowels[^1]);
			
			Console.WriteLine("Second Last Element in vowels " + vowels[^2]);
			
			Console.WriteLine("First Two Element in vowels " + new string(vowels[..2]));
			
			Console.WriteLine("Last Three Element in vowels " + new string(vowels[2..]));
			
			Console.WriteLine("Last Three Element in vowels " + new string(vowels[2..]));
			
			Console.WriteLine("Middle Element in vowels " + new string(vowels[2..]));
			
			int e = 100;  			//Ref Keyword
			PassByRefValue(ref e);
			void PassByRefValue(ref int f)
			{
				f = 200;
			}
			Console.WriteLine("Value of e varaiable changed by ref keyword " + e); 
			
			
			
			string g, h;     		//Out Parameter
			Split("Stevie Ray Vaughn", out g, out h);
			Console.WriteLine(g); // Stevie Ray
			Console.WriteLine(h); // Vaughn
			Split("Stevie Ray Vaughan", out string i, out _); // Discard 2nd param
			Console.WriteLine(i);
			void Split(string name, out string firstNames, out string lastName)
			{
					int i = name.LastIndexOf(' ');
					firstNames = name.Substring(0, i);
					lastName = name.Substring(i + 1);
			}
			
						

			string j = null;  			//Access Null Parameters
			string k = "Hello";
			string l = string.Empty;
			l = j ?? k;     // If j is null, give k
			l = j ??= k;	// If j is null, set j as k
			string ax = null;
			string bx = "Hi";
			string cx = string.Empty;

			cx = ax?.ToString();  // Check if ax is null 
			cx = bx?.ToString();  // Check if bx is null  
		}
	}
}