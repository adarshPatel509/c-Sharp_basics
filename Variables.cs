using System;

namespace hello_world {
  class Variables {
    string name = "Adarsh Patel";
    int age = 20;
    double weight = 60.35;
    public void details() {
        Console.WriteLine($"name: {name}, age: {age}, weight: {weight}");
    }
  }

  class Constants {
    enum Ages {
      child = 5,
      young = 21,
      old = 60
    };
    public void actions(int age) {
      if(age < (int)Ages.child) {
          Console.WriteLine("Too young too play!");
      } else if(age >= (int)Ages.child && age < (int)Ages.young) {
          Console.WriteLine("U can play but can't drink!");
      } else if(age >= (int)Ages.young && age < (int)Ages.old) {
          Console.WriteLine("Have some drink!");
      } else if(age >= (int)Ages.old) {
          Console.WriteLine("Enjoy rest of your life!");
      }
    }
  }
}