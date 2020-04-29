using System;

/*
  Reference: https://www.c-sharpcorner.com/UploadFile/3d39b4/extension-method-in-C-Sharp/
  Adding new methods to existing type
  properties
        - Must be declared in a non-generic static class
        - As an static method
        - this keyword as first param
*/

namespace hello_world {
  public static class ExtensionMethod {
    //adding a new method to string type
    public static int WorldCount(this string str) {
      string[] userString = str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries);  
      int wordCount = userString.Length;  
      return wordCount;  
    } 
  }
}