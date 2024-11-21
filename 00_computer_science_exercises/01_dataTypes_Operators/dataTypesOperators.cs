//Data Types and Operators, Malachi DeBose, v0.0
using System;
class DataTypesOperators
static void Main() {
    //This is a comment, it gets ignored.
    /*
    This is still a comment
    */
    /*
    DATA Types
    C# is STATICALLY TYPED-- once a variable has a data type it cannot change
    float- float--decimal numbers +/- including 0.v0
    Double- double-- decimal numbers +/- including 0.v0<--MOST COMMONLY USED DECIMAL
    Intergers-int-- whole numbers +/- including v0
    VARIABLES ARE 'BUCKETS' WITH A NAME TO STORE DATA INSIDE
    */
    //DECLARING(NAMING VARIABLES)
    //Method #1--Declared But not Assigned
    //dataType variableName
    int myInteger;
    double myDouble

    //Method #2--Declare AND Assigned
    int myInteger2=1;
    double myDouble2=2.050

    //Strings--Collections of letters, numbers, and special characters
    string myString= "this is my string"

    //Boolean--bool-Trues or False values
    bool myBool=true
    bool fireResistance=false
    bool hasPurpleKey=true
    //Character--char--a single character
    char myChar='A'
    //ASSIGNING VALUES AFTER DECLARATION
    myInteger=5;
    myDouble=1.0;

    //PRINTING VARIABLES TO THE CONSOLE TERMINAL
    Console.WriteLine(myInteger)
    Console.WriteLine(myDouble)
    Console.WriteLine(myIntgeer-.25)
    Console.WriteLine(myDouble+2.5)

    //PRINYERS VARIABLES TO THE CONSOLE TERMINAL
    Console.WriteLine(myInteger)
    Console.WriteLine(myDouble)

    //OPERATORS--ARITHMETIC
    int myNewInt=myInteger+myInteger2;
    double myNewDouble = myDouble = myDouble + myDouble2;
    //ADDITION
    double MyNewNumber = myInteger + myDouble

    //SUBTRACTION
    MyNewNumber= myDouble - myInteger

    //DIVISION
    myNewNumber = myDouble / myInteger

    //MULTIPLICATION
    myNewNumber = myDouble * myInteger
}