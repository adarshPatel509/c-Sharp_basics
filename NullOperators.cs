using System;
using System.Collections.Generic;

namespace hello_world {
  public class NullOperators {
    public NullOperators() {
      this.Demo();
    }

    public void Demo() {
      int? age = null;
      string message = (age == null) ? "Enter valid age" : "Weclome";
      Console.WriteLine(message);

      List<int> marks = null;
      int? count = marks?.Count; // "?" returns null if value is null(not error) else returns count
      int howMany = marks?.Count ?? 0; // "??" returns first_value in not null else second_value
      Console.WriteLine($"{howMany} {count}");

      marks = new List<int>() {1,2,3,4};
      howMany = marks?.Count ?? 0;   
      Console.WriteLine($"{howMany}");
    }
  }
}