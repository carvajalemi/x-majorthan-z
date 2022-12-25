using System;

class Program {
  public static void Main (string[] args) {
   //Leer dos numeros enteros
    Console.WriteLine("Ingrese el valor de x:");
    string xString= Console.ReadLine();
    int x = Int32.Parse (xString);
    Console.WriteLine("Ingrese el valor de z:");
    string zString= Console.ReadLine();
    int z = Int32.Parse (zString);
    //Si x es mayor a z imprimir verdadero
    if (x>z)
      Console.WriteLine("Verdadero");
    
  }
}