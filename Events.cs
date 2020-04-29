using System;
using System.Threading;

namespace hello_world {
  public class TimeInfoEventArg {
    public int Hour {get; set;}
    public int Minute {get; set;}
    public int Second {get; set;}

    public TimeInfoEventArg(int h, int m, int s) {
      this.Hour = h;
      this.Minute = m;
      this.Second = s;
    }
  }

  public class Clock {
    private int second = 0;
    public delegate void SecondChangeHandler(object Clock, TimeInfoEventArg timeInfo);
    public event SecondChangeHandler SecondChanged;
    public void Run() {
      while(true) {
        Thread.Sleep(1000);
        DateTime now = DateTime.Now;
        if(now.Second != second) {
          TimeInfoEventArg timeInfoEventArg = 
          new TimeInfoEventArg(
            now.Hour, now.Minute, now.Second
          );
          if(SecondChanged != null) {
            SecondChanged(this, timeInfoEventArg);
          }
        }
      }
    }
  }

  public class DigitalClock {
    public void Subscribe(Clock theClock) {
      theClock.SecondChanged += NewTime;
    }

    public void NewTime(object o, TimeInfoEventArg e) {
      Console.WriteLine($"Current Time: {e.Hour.ToString()}:{e.Minute.ToString()}:{e.Second.ToString()}");
    }
  }

  public class Log {
    public void Subscribe(Clock theClock) {
      theClock.SecondChanged += LogTime;
    }

    public void LogTime(object o, TimeInfoEventArg e) {
      Console.WriteLine($"Logging... {e.Hour.ToString()}:{e.Minute.ToString()}:{e.Second.ToString()}");
    }
  }

  public class EventDemo {
    public EventDemo() {
      this.Demo();
    }

    public void Demo() {
      Clock myClock = new Clock();

      DigitalClock digiClock = new DigitalClock();
      digiClock.Subscribe(myClock);

      Log log = new Log();
      log.Subscribe(myClock);

      myClock.Run();
    }
  }
}