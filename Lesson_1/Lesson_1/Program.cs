using System;

namespace Lesson_1 {
	class Program {
		static void Main(string[] args) {

			// Declare variables
			int num_1 = 5;
			int num_2 = 2;
			int result = num_1 + num_2;

			bool resultGreaterThan = false;
			string greaterThan = "No";

			float pi = 3.14159f;
			float radius = 5.5f;
			float area = 0.0f;
								       //1st2nd3rd4th5th
			int[] array_1 = new int[5] { 0, 1, 2, 3, 4 };

			// Perform logical operations

			if (result > array_1[2]) {
				Console.WriteLine("Result is greater than array index 3.");
				resultGreaterThan = true;
			} else {
				Console.WriteLine("Result is less then than array index 3.");
				resultGreaterThan = false;
			}

			Console.WriteLine(resultGreaterThan);

			if (resultGreaterThan == true) {
				greaterThan = "Yes";
			} else {
				greaterThan = "No";
			}

			if (resultGreaterThan != false) {
				//Console.WriteLine("The result of the two numbers summed is not greater than array index 3.");
			}

			area = pi * (radius * radius);

			// Output results
			
			Console.WriteLine(greaterThan);

			// Output a string
			Console.WriteLine("Our numbers are: ");
			// Concatenate string and int
			Console.WriteLine("Number 1: " + num_1);

			Console.WriteLine("Number 2: " + num_2);

			Console.WriteLine("Result of number 1 + number 2: " + result);

			//Console.WriteLine(array_1[3]);

			//Console.WriteLine("Is the result greater than array[3]? " + greaterThan);
			// Print pi
			Console.WriteLine(pi);
			// Print the radius of our circle			
			Console.WriteLine("The radius of our circle is: " + radius);
			// Print the area of our circle
			Console.WriteLine("The area of our circle is: " + area);
		}
	}
}
