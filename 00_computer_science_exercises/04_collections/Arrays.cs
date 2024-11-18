//Collections Example, Malachi DeBose v0.0
using System;
using System.Linq;
using System.Collections;


class Collections {
  static void Main() {//DO NOT DELETE!

/*
In C# a collection is known as an ARRAY
-- EACH ITEM IN THE ARRAY IS AN ELEMENT
-- NUMBER OF ELEMENTS IN THE ARRAY CANNOT BE CHANGED
-- CONTENTS OF EACH ELEMENT CAN CHANGE
-- ARRAYS ARE ORDERED, MEANING EACH ITEM HAS A FIXED POSITION
-- POSITION OF THE ELEMENT IS THE INDEX\
-- FIRST ELEMENT INDEX IS 0
*/

//DECLARING AND DEFINING AN ARRAY
string[] breakfastFoods = {"Eggs", "Bacon", "Grits", "Sausage", "Pancakes"};
int[] testScore = {0, 20, 40, 60, 80};
double[] GPA = {0.90D, 4.02D, 0.07D, 4.00, 3.75D};

//Print Array Contents -- All Elements on Single Line
Console.WriteLine("The elements of each array are:\n");
Console.WriteLine("breakFastFoods: \n" + String.Join(", ", breakfastFoods));
Console.WriteLine(); //Print an empty line to the screen.

//Print An Array on Separate Lines
Console.WriteLine("The elements of each array are:\n");
Console.WriteLine("testScore: \n" + String.Join("\n", testScore));
Console.WriteLine(); //Print an empty line to the screen.

//How long is my array? DETERMING ARRAY LENGTH
Console.WriteLine("The length of the breafast array is: " + breakFastFoods.Length);
//.Length is known as a PROPERTY of the array.
Console.WriteLine("The length of the test score array is: " + testScore.Length);

// Acessing Elements in the array with the index.
Console.WriteLine("The first element in breakFastFoods is: " + breakFastFoods[0]);
//PRINT THE 2ND ELEMENT OF THE testScores Array
//Print THE 3RD ELEMENT OF THE GPA Array

  }//DO NOT DELETE EVER, 3 SPACES INDENTED FROM THE LEFT
}//DO NOT DELETE EVER, ALWAYS TOUCHING THE LEFT MARGIN