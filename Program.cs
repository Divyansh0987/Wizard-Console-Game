using System.IO;

Console.WriteLine("Hello! Welcome to the wizard game!");
Console.WriteLine("Checking save file...");

Console.WriteLine("No save file found.");

Console.WriteLine("Would you like to create a new wizard?");
string userInput = Console.ReadLine().ToLower();

#region checkUserInputValidity
if (userInput == "no") return;
while (userInput != "yes")
{
    Console.WriteLine("Please input yes or no.");
    userInput = Console.ReadLine().ToLower();

    if (userInput == "yes") break;
}
#endregion

Console.WriteLine("You will now customize your wizard.");
Wizard wizard = new Wizard();
wizard.Hp = wizard.maxHp;

Console.WriteLine("What would you like to name your wizard?");
wizard.Name = Console.ReadLine();
Console.WriteLine($"Hello {wizard.Name}! Welcome to wizard land! You will start at level 1 with {wizard.Hp} Hp.");
Spell basicSpell = new("Basic Spell", 1, "Normal");
// Console.WriteLine("Your goal is to become the best wizard of wizard land!");
Console.WriteLine($"You recieved a {basicSpell.Type} {basicSpell.Name}.");
Console.WriteLine("You are now ready to epxlore the wizard world.");

// if (wizard.currentHp is  0.) * wizard.maxHp)
// 


