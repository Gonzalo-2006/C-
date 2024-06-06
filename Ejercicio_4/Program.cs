int AñoActual = 2024, FechaDeNacimineto = 0; 
Console.WriteLine("Proporcionar la fecha de nacimiento de una persona"); 

Console.WriteLine("Ingrese su año de nacimineto: "); 
FechaDeNacimineto = int.Parse(Console.ReadLine()); 

int edad = AñoActual - FechaDeNacimineto; 

Console.WriteLine("Su edad es: "+edad);