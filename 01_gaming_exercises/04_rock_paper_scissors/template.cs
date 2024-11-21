using System;

class Template {

  static void Main() {
    //PLAYER VARIABLE
    string PlayerName = "Test Player";
    int PlayerScore;
    string PlayerChoice;

    //CPU VARIABLES
    int CPUScore
    string CPUChoice;

    Console.Writeline("Welcome to the Rock Paper Scissors Tournament"\n)
    Console.Writeline("Please enter you combatant name"\n)
    playerName = Console.Readline();
    Console.Writeline("${playerName} Is your combatant name?\n");
    String isCorrect = Console.Readline().ToLower();

    if (isCorrect ="yes")
    {
      console.writeline ($"Welcome {PlayerName}. Your challenger awaits"\n);
    }
    else if(isCorrect = "no")
    {
      Console.Writeline("Please enter your combatant name"\n);
      PlayerName = Console.Readline();
    }
    else
    {
      Console.Writeline("Unable to use answer, please try again"\n)
    }

    Console.Writeline("""
    Is is a fierce foe to fight
    it is well skilled in the battle of Rock
    Paper
    and Scissors
    But I believe you have the power to defeat it
    =============================================
    Rules of the Tournament
    Choose Rock, Parper, or Scissors as the only skills
    Any and every other style will lead to disqualification
    =============================================""");

    while (PlayerScore < 5 && CPUChoice <5)
    {
      //Print scores
      Console.Writeline($"Your score: {PlayerScore}\n Opponents: {CPUScore}")
      //Let the player selecty R, P, S
      Console.Writeline("Choose your technique"\n)
    }
  }
}