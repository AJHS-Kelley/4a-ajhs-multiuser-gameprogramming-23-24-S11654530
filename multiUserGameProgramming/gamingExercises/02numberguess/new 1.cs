//02_Colletions, Ronald Durham, 10-3-2023 v0.0
using Systems;

namespace _02_Collections 
{
    class Program 
	(
	        static void Main(string[] orgs)
			(
			   // Collections are variables that can store multiple values Inone variables
			   
			   /* Arrays 
			   -- Number of elements in an array CANNOT change.
			   -- Contents of elements In an array CAN change.
			   -- Items In the array are called ELEMENTS 
			   -- Arrays are ordered, meaning each items has a fixed position 
			   -- The position is known as the INDEX 
			   -- First element in array is index 0.
			   */
			   
			   // Declaring and Defining an Array 
			   string [] breakfastfoods - {"Bacon", "waffels", "Pancakes", "cereal" , "purfait"};
			   int[] testScores - {95, 100, 25, 15, 27, 35};
			   float[] GPA = (3.14f, 2.25f, 1.74f, 099f, 4.25f);
			   
			   // Print Array Contents -- All Elements on Single Line 
			   Console.Writeline(" The elements for each array are:\n")
			   Console.Writeline("breakfastfoods: \n" + String.Join(",", breakfastfoods));
			   Console.Writeline();
			   Console.Writeline("testScores: \n" + String.Join(",",testScores));
			   Console.Writeline();
			   console.Writeline("GPA: \n" + string.Join(",",GPA)):
			   Console.Writeline();
			   
			   /* Print Array Contents -- Each Element on Separate Line
			   Console.Writeline("The elements for each array are:\n");
			   Console.Writeline("breakfastfoods: \n" + String.join("\n", breakfastfoods));
			   Console.Writeline();
			   Console.Writeline("testScores: \n + String.Join("n",testScores));
			   Console.Writeline();
			   Console.writeline("GPA: \n + String,Join("\n, GPA)); 
			   Console.Writeline();
			   */
			   
			   // Determining Array ELEMENTS
			   Console.Writeline("The length of each array is:\n");
			   Console.Writeline(breakfastFoods: " + breakfastFoods,Length);
			   Console.Writeline("testScores; " + testScores.Length);
			   Console.Writeline("GPA": " + GPA.Length);
			   
			   // Accessing Array Elements -- use the index!
			   Console.Writeline("The first element in each array is:\n");
			   Console.Writeline("breakfastfood: " + breakfastfoods{0});
			   Console.Writeline("testScores: " + testScores[0]);
			   Console,Writeline("GPA: " +
			   
			   )
	)		   