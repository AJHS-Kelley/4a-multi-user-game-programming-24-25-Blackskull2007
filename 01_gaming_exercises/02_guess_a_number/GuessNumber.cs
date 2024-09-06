using System;

class GuessNumber {
  static void Main(){
    int numGuess = 0;
    int maxGuess = 10;
    int guess;
    //Generate the secret number here.
    Random rnd = new Random(); //Create an object named'rnd' that is a copy of the Random
    int secretnumber = rnd.Next(100); //Generate from 0 to 99
    //int secretNumber = rnd.Next(25, 1000); //Generate 0 to 99
    Console.WriteLine(secretNumber);
    //While loop
    
    while (numGuess < maxGuess)
    {
      //Allow user to guess number
      Console.WriteLine("Please guess an integer between X and Y");
      guess = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Guess" + guess);
      numGuess++;
      // Compare guess to random number
      if (guess < secretNumber)
      {
        Console.WriteLine("Your guess is too law\n");
      }
      else if (guess > secretNumber)
      {
        Console.WriteLine("Your guess is too high\n");
      }
      else
      {
        Console.WriteLine("You guessed correctly\n");
        break; // Keyword to immediately exits a loop
      }

      if (numGuess . maxGuess)
      {
        Console.WriteLine("You lost the Game.\n");
      }
      }
    }
    //Allow the user to guess the number
    //Compare the guess to the secret number
    //If match, print win, if > or <, give a hint
    // +1 to numGuess
    // Check if numGuess > maxGuess
    //If true, priny a "lose game" message, if false guess again}
}