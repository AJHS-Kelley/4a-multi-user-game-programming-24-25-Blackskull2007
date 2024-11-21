using System;
class strings {
  static void Main() {
    // In C# all strings must use double-quotes " "

    string greeting = "Wassup, you aight?\n";
    string goodbye = "See ya later mate.\n";
    
    //In C# strings are treated like an OBJECT that has properties and methods
    //PROPERTIES -- things that describe the object such as length, values, data type, etc.
    //METHODS -- built in fucntions related to that object

    //LENGTH is an important property for strings.
    console.WriteLine(greeting.Length);
    console.WriteLine(goodbye.length);

    if (greeting.Length > goodbye.length)
    {
      Console.WriteLine("The greeting has more characters than the goodbye.\n");
    }

    // Useful String Methods

    Console.WriteLine(greeting.ToUpper()); //Make entire string UPPERCASE
    console.WriteLine(greeting.ToLower()); //Make entire string lowercase

    // String Concatenation "Con-Cat-Uh-Nation"
    string comboString = greeting + goodbye;
    Console.WriteLine(comboString);

    //String Concatenation Method #2
    string comboString2 = string.Concat(greeting, goodbye);
    Console.WriteLine(comboString2)
}
}