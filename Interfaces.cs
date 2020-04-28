using System;

namespace hello_world {
  //interfaces
  public interface IDetails {
    public int Age {get; set;}
    public string Name {get; set;}

    public int myAge();
    public string myName();
  }
  public interface IHola {
    public string Message {get; set;}
    public void Hola();
  }
   
  //implementer class
  public class Person : IDetails, IHola {
    public int Age {get; set;}
    public string Name {get; set;}
    public string Message {get; set;}
    //new property
    public bool OnlyMe {get; set;}

    public Person(int age, string name , string message) {
      this.Age = age;
      this.Name = name;
      this.Message = message;
    }

    public int myAge() {
      return Age;
    }

    public string myName() {
      return Name;
    }

    public void Hola() {
      Console.WriteLine($"{Message}");
    }
    
    //new method
    public void NewMethod() {
      Console.WriteLine("Only i can do this!");
    }
  }

  //client class
  public class DemoInterfaces {

    public DemoInterfaces() {
      this.demo();
    }

    public void demo() {
      Person adarsh = new Person(20, "Adarsh", "Welcome to C# world!");
      IDetails arpit = new Person(10, "Arpit", "Grow up kido!");
      IHola ankur = new Person(25, "Ankur", "Hmm :/");

      adarsh.Hola();
      Console.WriteLine($"{adarsh.myAge()}, {adarsh.myName()}");
      adarsh.NewMethod();

      Console.WriteLine($"{arpit.myAge()}, {arpit.myName()}");
      //arpit.Hola(); error
      //arpit.NewMethod(); error

      //Console.WriteLine($"{ankur.myAge()}, {ankur.myName()}") error
      ankur.Hola();
      // ankur.NewMethod();
    }
  }
}