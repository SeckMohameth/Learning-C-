using System;

class Program {
  public static void Main (string[] args) {

    // comment

    /*  
      multiline comment
    */

    int mo = 27;
    if (mo > 26) {
      Console.WriteLine("is 27");
    } else {
      Console.WriteLine("Younger than 27");
    }

    int i = 44;
    
    Console.WriteLine ("Hello World" + i);

    testfunction();
    secondFunction(23);
    
  }

  static void testfunction() {
    Console.WriteLine("I'm another function");
  }

  static bool secondFunction(int i) {
    return  i < 100;
  }

  
  
}



