int AñoActual, AñoDeNacimiento, edad; 

AñoActual = 2024; 
Console.WriteLine("Ingrese su fecha de nacimiento: "); 
AñoDeNacimiento = int.Parse(Console.ReadLine()); 

edad = AñoActual - AñoDeNacimiento; 
edad--; 

if(edad >= 18){
    Console.WriteLine("Su edad es: "+edad);
    Console.WriteLine("Es mayor de edad"); 
}else{
    Console.WriteLine("Su edad es: "+edad);
    Console.WriteLine("No es mayor de edad"); 
}




