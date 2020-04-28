using System;

namespace hello_world {
  //abstract class
  public abstract class Control {
    protected int xPos, yPos;
    public Control(int xPos, int yPos) {
      this.xPos = xPos;
      this.yPos = yPos;
    }

    public virtual void Clear() {

    }
    public abstract void Draw();
  }

  //derived class
  class Button : Control {
    private string text;
    public Button(int xpos, int ypos, string text) : base(xpos, ypos) {
      this.text = text;
    }
    public override void Clear() {
      xPos = 0;
      yPos = 0;
      Console.WriteLine($"xpos: {xPos}, ypos: {yPos}");
    }

    public override void Draw() {
      Console.WriteLine($"Drawing the button at position... xpos: {xPos}, ypos: {yPos}");
    }
  }

  class AbsDemo {
    public AbsDemo() {
      this.Demo();
    }

    public void Demo() {
      Button loadingButton = new Button(500, 500, "Loading...");
      loadingButton.Draw();
      loadingButton.Clear();
    }
  }
}