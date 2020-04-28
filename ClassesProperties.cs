using System;

namespace hello_world {
  public class Employee {
    public string Name {get; set;}
    protected double vacationDays = 0;
    public virtual void TakeVacation() {

    }
    public Employee(string name) {
      Name = name;
    }
    public override string ToString() {
      return $"[Employee: Name = {Name}]";
    }
  }

  public class Worker : Employee {
    public double HourlyWage {get; set;}
    public Worker(string name, double wage) : base(name) {
      HourlyWage = wage;
    }
    public override void TakeVacation() {
      vacationDays += 10;
    }
    public override string ToString() {
      return $"[Employee: Name = {Name}, VacationDays = {vacationDays}]";
    }
  }

  public class Manager : Employee {
    public bool CompanyCar {get; set;}
    public Manager(string name, bool hascar) : base(name) {
      CompanyCar = hascar;
    }
    public override void TakeVacation() {
      vacationDays += 15;
    }
    public override string ToString() {
      return $"[Employee: Name = {Name}, VacationDays = {vacationDays}, HasCar = {CompanyCar}]";
    }
  }
}