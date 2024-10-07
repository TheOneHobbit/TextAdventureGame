using System;

namespace ChooseYourOwnAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Noise In The Nighttime */ 

            // Start by asking for the user's name:
            Console.Write("What is your name?: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}! Welcome to our story."); 

            // Set the scene for the story to the user:
            Console.WriteLine("It begins on a night like any other in late Fall, rain was pattering heavily on windows and roof tiles alike. You're in the living room sitting in front of the fire, wrapped in your quilted blanket and drinking a hot cocoa, made the way you like with cinnamon and a pinch of chili. You hear a shattering of a window from the other side of the house. Do you go and investigate?");

            // Give the user instructions to make the decision:
            Console.Write("Type YES or NO: ");
            string noiseChoice = Console.ReadLine();

            // Modify user input to ensure value is uppercase:
            noiseChoice = noiseChoice.ToUpper();
            /* Console.WriteLine(noiseChoice); Original test to ensure input worked */

            // Add conditional statements to check user's decision: 
            if (noiseChoice == "NO") 
            {
                Console.WriteLine($"Not much of an adventurer {name}, are we?");
                Console.WriteLine("THE END.");
            }
            else if (noiseChoice == "YES")
            {
                Console.WriteLine("You gather your blanket around you and walk out into the hallway, following the now whistling wind and falling water sounds coming from an upstairs room. As you approach the door to your bedroom you see a light on and a shadow move from under the door. Walking towards it, do you call out or silently go to open it?");
            
            // Give the user second set of instructions if they input "YES": 
            Console.Write("Type HELLO? or OPEN: ");
            string doorChoice = Console.ReadLine();

            // Modify user input to ensure value is uppercase:
            doorChoice = doorChoice.ToUpper();
            /* Console.WriteLine(doorChoice); Original test to ensure input worked */ 

            // Add conditional statements to check user's decision: 
            if (doorChoice == "HELLO?") 
            {
                Console.WriteLine("A voice behind the door speaks. It says \"Answer me this: \"");
                Console.WriteLine("\"I am always here, but have no body of my own. I am mighty yet cower in the light, and hide in plain sight at night. What am I?\"");
                // Ask the user to answer the riddle:
                Console.Write("Type your answer: ");
                string riddleAnswer = Console.ReadLine();
                // Modify user input to ensure value is uppercase:
                riddleAnswer = riddleAnswer.ToUpper();
                /* Console.WriteLine(riddleAnswer); Original test to ensure input worked */

                // Correct answer is "SHADOW". If user types "SHADOW", "MY SHADOW" or "A SHADOW":- program will print following: 
                if (riddleAnswer == "SHADOW" || riddleAnswer == "MY SHADOW" || riddleAnswer == "A SHADOW") 
                {
                    Console.WriteLine("The door opens and nothing is there except your own shadow illuminated by the lamp light. You rush in and look for something to cover the broken window temporarily, you turn sharply after hearing the crunch of glass behind you, the lamp light turns off...");
                    Console.WriteLine("THE END.");
                }
                // If any answer other than the correct is given:
                else 
                {
                    Console.WriteLine("You hear the voice call out again.");
                    Console.WriteLine("\"You have answered incorrectly. You get no more chances\" With this response the door flies open, lamp light no longer visible as the room is filled with darkness, as you stumble backwards hitting your head on the floor, you start seeing the faint outline of something standing above you. The lamp light flickers back on, and the darkness retreats, you scramble to your feet and rub your eyes, but nothing is around you... you take a hurried breath, and suddenly are awake, back in the living room.");
                    Console.WriteLine("THE END.");
                }
            }
            // Second conditional statement relating to user decision:
            else if (doorChoice == "OPEN")
            {
                Console.WriteLine("You gingerly open the door, hand trembling over the handle, peering into the room trying to work out shapes through the lamp light. You see the broken window, shattered glass spread on the floor and water pooling up from the constant rainfall.");
                Console.WriteLine("There are a number of things you could use to mop up the water and temporarily close the window breach.");
                Console.Write("Enter a number (1-3): ");
                string bedroomChoice = Console.ReadLine();
                
                // Add switch cases for the choices after opening the door:
                switch (bedroomChoice)
                {
                    case "1": 
                      Console.WriteLine("You choose to use a clean towel and tape from your bedside dresser. The room now seems bright and calm again.");
                      Console.WriteLine("THE END.");
                      break;
                    case "2":
                      Console.WriteLine("You choose to use dirty laundry for both the water and the window breach... You slip on a wet sock and hit your head whilst trying to clear up, waking up in your bed, you realise somebody has tucked you in and cleaned up, you live alone...");
                      Console.WriteLine("THE END.");
                      break;
                    case "3":
                      Console.WriteLine("You ignore the water and try to find out what broke the window in the first place, propping an old book against the hole for the time being. As you turn to walk away, the book flies across the room as if pushed from the other side.");
                      Console.WriteLine("THE END.");
                      break;
                    default:
                      Console.WriteLine("You have chosen to do nothing about the mess and walk away.");
                      Console.WriteLine("THE END.");
                      break;
                }
              }
            } 
        }
    }
}