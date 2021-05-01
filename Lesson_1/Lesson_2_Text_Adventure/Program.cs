using System;

namespace Lesson_2_Text_Adventure {
	class Program {
		static void Main(string[] args) {

			// Declare / initialise varibles, (some are not initialised here)
			// User name and age
			string userName;
			string userAge;

			// User skill
			bool noSkill = true;
			bool strong = false;
			bool smart = false;
			bool magic = false;
			bool fast = false;
			string skillChoice;

			// User items
			bool noItem = true;
			bool weapon = false;
			bool book = false;
			bool spell = false;
			bool runningShoes = false;

			// User afflictions
			bool noAffliction = true;
			bool poisoned = false;
			bool brokenBone = false;
			bool insane = false;
			bool bleeding = false;

			// Greating
			Console.WriteLine("Hello and welcome to the Castle Keep Dungeons.\n" +
				"My name is Granthor, Dungeon Keeper to the Red Queen\n" +
				"and I will be your guide as you descend into the darkness.\n" +
				"What is your name?\n\n" +
				"Please input your name and press ENTER");
			// Get the users name
			userName = Console.ReadLine();
			// Output a personalised greating to the user using their name
			Console.WriteLine("Welcome " + userName + ". It is a pleasure to meet you.");
			// Get the users age
			Console.WriteLine("How old are you " + userName + "?");
			userAge = Console.ReadLine();
			// Output a personalised greating to the user using their name
			Console.WriteLine("You are " + userAge + "? That is a fine age to attempt to descend the Castle Keep Dungeons! Please do step inside.");
			// Choose a skill
			Console.WriteLine("Would you like to have a weapon, be strong, smart, magic or fast?" );
			skillChoice = Console.ReadLine();
			// Use if statements to make decisions by checking user input against different options
			if (skillChoice == "weapon" || skillChoice == "Weapon") {
				weapon = true;
			} else if (skillChoice == "strong") {
				strong = true;
			} else if (skillChoice == "smart") {
				smart = true;
			} else if (skillChoice == "magic") {
				magic = true;
			} else if (skillChoice == "fast") {
				fast = true;
			}  else {
				Console.WriteLine("Invalid choice. Your mistake cost you your life.");
				Environment.Exit(0);
			}
			Console.WriteLine(userName + " has chosen to be " + skillChoice + ".");

			Console.WriteLine("That was a wise choice. The " + skillChoice + " have often faired well here.");
			
		}
	}
}
