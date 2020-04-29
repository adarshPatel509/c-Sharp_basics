using System;

/*
  Reference: https://www.tutorialsteacher.com/csharp/csharp-generics
  Used to define class with placeholder for types 
*/

namespace hello_world {
  public class GenericClass<T> {
    protected T genericVariable;

    public GenericClass(T value) {
      genericVariable = value;
    }

    public T GenericMethod(T genericParam) {
      Console.WriteLine($"{typeof(T).ToString()}, {genericParam}");
      return genericVariable;
    }
  }
}