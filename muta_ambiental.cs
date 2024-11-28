using System;

class Program {
  public static void Main (string[] args) {
    float kg;

    Console.WriteLine ("Informe o valor em kg: ");
    kg = float.Parse(Console.ReadLine());
    
    if (kg > 50){
      Console.WriteLine ("Multado.");
    }
    else {
      Console.WriteLine ("Não há multas.");
    }
  }
}