using System;

namespace hello_world {
  public class ExceptionDemo {
    public ExceptionDemo() {
      this.OpenFile();
    }
    public void OpenFile() {
      try {
        Console.WriteLine("opening file....");
        throw new System.Exception("Error in reading file!");
      } catch {
        Console.WriteLine("Handeling exception!");
      } finally {
        Console.WriteLine("closing file....");
      }
    }
  }
}