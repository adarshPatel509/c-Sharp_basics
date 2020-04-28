using System;
using System.Collections.Generic;

namespace hello_world {
  public class Arrays {
    public Arrays() {
      this.MakeArray();
    }
    public void MakeArray() {
      int[] marks = new int[10];
      for(int i=0; i<marks.Length; i++) {
        marks[i] = i*i + i;
      }
      foreach(int mark in marks) {
        Console.WriteLine($"Mark: {mark}");
      }
    }
  }
  
  public class Lists {
    public Lists() {
      this.MakeList();
    }

    public void MakeList() {
      List<string> members = new List<string>();
      members.Add("Adarsh");
      members.Add("Arpit");
      members.Add("Reshu");
      foreach(string member in members) {
        Console.WriteLine($"Name: {member}");
      }
    }
  }

  public class Dict {
    public Dict() {
      this.MakeDict();
    }

    public void MakeDict() {
      Dictionary<string, int> grades = new Dictionary<string, int>();
      grades.Add("Adarsh", 92);
      grades.Add("Arpit", 98);
      grades.Add("Ankur", 75);

      foreach(KeyValuePair<string,int> person in grades) {
        Console.WriteLine(person);
      }
    }
  }
}