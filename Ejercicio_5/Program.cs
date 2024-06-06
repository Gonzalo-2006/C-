int numeroInicial=0, porcentajes=20,resultado; 

Console.WriteLine("Ingrese el numero para hallar el 20%"); 
numeroInicial = int.Parse(Console.ReadLine());

resultado = (numeroInicial*porcentajes)/100; 
Console.WriteLine ("El 20% de " +numeroInicial +" Es: "+resultado);
