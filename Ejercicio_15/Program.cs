int numero1; 
Console.WriteLine("Ingrese su numero"); 
numero1 = int.Parse(Console.ReadLine()); 

int division = numero1 / 2; 
if(division < 100){
    Console.WriteLine("Su numero es menor a 100");
}else if(division > 100){
    Console.WriteLine("Su numero es mayor a 100");
}else{
    Console.WriteLine("Su nuemro es igual a 100");
}
