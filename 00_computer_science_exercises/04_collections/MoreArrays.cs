using System;
using System.Linq;
class MoreArrays {
  static void Main() { //DO NOT DELETE

  string[] colors = {"Black", "Purple", "Red", "White", "Silver"};
  //LOOPING THROUGH ARRAYS-- The old way
  for (int i = 0; i < colors.Length; i++)
  {
    Console.WriteLine(colors[i]);
  }

  //LOOPING THROUGH ARRAYS -- THE NEW WAY
  foreach (string i in colors)
  {
    Console.WriteLine(i);
  }

  //LOOPING THROUGH ARRAY PRACTICE
  int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
  //Your loop should iterate through the entire array.
  //Print the vbalue on the screen
  //If the number is even, print that to the screen
  //If the number is odd, priny that to the screen
  foreach (int i in numbers)
  {
    Console.WriteLine(i);
    if (i % 2 == 0)//mODULUS DIVIDES AND RETURNS THE REMAINDER
    {
      Console.WriteLine("This number is even.\n");
    }
  }
  //MULTIDIMENSIONAL ARRAYS
  //tHIS CLASS WILL ONLY USE 2 DIMENSIONAL ARRAYS
  int[,] nums = {{2, 4, 6}, {-1, 0, 1}};

  //ACCESSING ELEMENTS IN 2D ARRAYS
  Console.WriteLine(nums[0, 1]);
  Console.WriteLine(nums[1, 1]);

  //CHANGING ELEMENTS IN 2D ARRAYS
  nums[1, 2] = 9001;
  //CHANGE ANY ELEMENT FROM THE FIRST ARRAY
  nums[0, 2] = 502;
  
  //LOOPING THROUGH 2D ARRAYS -- EASY MODE
  foreach (int i in nums)
  {
    Console.WriteLine(i);
  }

  //LOOPING THROUGH 2D ARRAYS-- HARD MODE
  for (int i = 0; i < nums.GetLength(0); i++)
  {
    for (int j = 0; j < nums.GetLength(1); j++)
    {
      Console.WriteLine(nums[i, j]);
    }
  }
  }
}