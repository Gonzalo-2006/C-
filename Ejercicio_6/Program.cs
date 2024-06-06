int numero=0; 

Console.WriteLine("Proporcionar el 30% 60% 90% de un numero"); 

Console.WriteLine("Ingrese el numero:"); 
numero = int.Parse(Console.ReadLine()); 

int porcentaje1 = (numero * 30)/100; 
int porcentaje2 = (numero * 60)/100;
int porcentaje3 = (numero * 90)/100; 

Console.WriteLine("El 30% es: "+porcentaje1);
Console.WriteLine("El 60% es: "+porcentaje2);
Console.WriteLine("el 90% es: "+porcentaje3);