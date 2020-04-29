using System;

/*
Reference: http://zetcode.com/csharp/datetime/
*/

namespace hello_world {
  public class DateAndTime {
    public DateAndTime() {
      this.Demo();
    }

    public void Demo() {
      DateTime now = DateTime.Now;
      DateTime utcNow = DateTime.UtcNow;
      Console.WriteLine($"localTime: {now.ToString("F")}, utcTime: {utcNow.ToString("F")}");
      
      //properties
      Console.WriteLine($"\nday: {now.Day}, month: {now.Month}, year: {now.Year}, dayOfYear: {now.DayOfYear}, timeOfDay: {now.TimeOfDay}");
      Console.WriteLine($"H: {now.Hour}, M: {now.Minute}, S: {now.Second}, Kind: {now.Kind}");
    }
  }
}