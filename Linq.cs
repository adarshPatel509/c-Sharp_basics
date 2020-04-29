using System;
using System.Collections.Generic;
using System.Linq;

/*
LINQ: Language Integrated Queries (Query syntax & Method syntax)
  ex: orderby
      group
      any 
      contains
      take
      zip
*/

namespace hello_world {
  public class Linq {
    public Linq() {
      this.Demo();
    }

    public void Demo() {
      List<int> numbers = new List<int>() {1,2,3,4,5,6,7,8,9,10};
      var odds = from val in numbers  //query syntax of LINQ
                 where (val % 2) != 0
                 select val;
      var evens = numbers.Where(num => num % 2 == 0);  //method syntax of LINQ

      Console.Write(" odds: ");
      foreach(int val in odds) {
        Console.Write($"{val},");
      }

      Console.Write(" evens: ");
      foreach(int val in evens) {
        Console.Write($"{val},");
      }

      this.OrderAndGroup();
      this.AnyAndContains();
      this.TakeAndZip();
      this.FilterAndSort();
    }

    //LINQ orederby & group operations
    public void OrderAndGroup() {
      var query = from methods in typeof(double).GetMethods()
                  orderby methods.Name
                  group methods by methods.Name into groups
                  select new {MathodName = groups.Key, NumOfOverLoads = groups.Count()};

      foreach(var item in query) {
        Console.WriteLine(item);
      }
    }

    //LINQ any and contains operations
    public void AnyAndContains() {
      var listOne = Enumerable.Empty<int>();
      var listTwo = Enumerable.Range(1, 10);
      
      Console.WriteLine($"listOne has any members? {listOne.Any()}. listTwo has any members? {listTwo.Any()}.");
      Console.WriteLine($"listTwo contains 5? {listTwo.Contains(5)}. listTwo contains 15? {listTwo.Contains(15)}.");
    }

    //LINQ take and zip
    public void TakeAndZip() {
      var numbers = Enumerable.Range(1, 20);
      var shortList = numbers.Take(5).Select(x => x*10);
      foreach (var item in shortList) {
        Console.Write($"{item},");
      }

      var list1 = new List<string>() {"Adarsh", "Arpit", "Ankur"};
      var list2 = new List<int>() {20, 12, 25};
      var nameAge = list1.Zip(list2, (name, age) => (name + ": " + age));
      foreach (var item in nameAge) {
        Console.WriteLine(item);
      }
    }

    //LINQ filter and sorts
    public void FilterAndSort() {
      var list1 = Enumerable.Range(1, 20);
      var list2 = from val in list1
                  orderby val descending
                  where val % 2 == 0
                  select val;
      foreach (var item in list2) {
        Console.Write($"{item},");
      }
    }
  }
}