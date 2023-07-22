using System;
namespace HelloWorld
{
  class Person {
    public string name;
    public int age;

    public Person() {
      name = "Hello World";
      age = 18;
    }

    public Person(string _name, int _age) {
      name = _name;
      age = _age;
    }

    public void GetDetails() {
      Console.WriteLine("Name: " + name);
      Console.WriteLine("Age: " + age);
    }
  }

  class Program {        
     public static void Main(string[] args) {
       Person P = new Person("Jake", 24);
       P.GetDetails();
     }
   }
}

// to run: dotnet build && dotnet run
