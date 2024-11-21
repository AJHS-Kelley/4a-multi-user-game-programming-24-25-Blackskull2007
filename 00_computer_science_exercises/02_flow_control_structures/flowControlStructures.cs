using System;
class HelloWorld {
  static void Main() {
   







































   int day = 1;
   switch(day)
   {
    case 1:
    Console.WriteLine("It's Monday.\n");
    break;
    case 2:
    Console.WriteLine("It's Tuesday.\n");
    break;
    case 3:
    Console.WriteLine("It's Wednesday.\n");
    break;
    //case 4-6
    case 7: 
    Console.WriteLine("It's Sunday, go rest.\n");
    break;
   }
   //REPEATIG STEPS OVER, AND OVER, AND OVER AGAIN
   //LOOPS are used to repeat instructions multiple times.

   //while Loops are "musical chairs" in computer science.
   //use while loops if you DO NOT know how many loops you need
   //the code will run as long as the condition is true
   //while loop syntax:
   /*

   while (CONDITIONAL _EXPRESSION)
  {
    code to loop goes here
  }
  */

  int z =0;
  while(z<=100) //What do I replace CONDITIONAL_EXPRESSION with?
  {
    Console.WriteLine*(z);
    z==;
  }

 int y =100;
  while(y>=100) //What do I replace CONDITIONAL_EXPRESSION with?
  {
    Console.WriteLine(y);
    y--;
  }

  //for loops are like playing go fish
  //you know how many cards are in your hand
  //used when you know how many loops you need ahead of time

  /*
  for (statement1; statement2; statement3;)
  {
    Code to run each time through loop
  }

  statement1 = code to run ONE TIME before the loops starts
  statement2 = CONDITIONAL EXPRESSION to check EACH TIME before loop runs
  statement3 = code to run AFTER each loop

  Each 'trip' through the loop is called an ITERATION
  */

  //Counting to 10 with loops.
  for (int i =0; i < 10; i++)
  {
    Console.WriteLine(i);
  }
}